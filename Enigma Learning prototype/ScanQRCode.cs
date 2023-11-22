using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Enigma_Learning
{
    public partial class ScanQRCode : Form
    {
        public ScanQRCode()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        public static bool formClosed = false;
        public static bool codeAccepted = false;
        public static bool enterCodeOpened = false;
        public static bool stopCamera = false;
        public static bool startCamera = false;

        private void ScanQRCode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboDevice.Items.Add(filterInfo.Name);
            }
            cboDevice.SelectedIndex = 0;
        }

        private void btn_ScanCode_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            startCamera = true;
            timer1.Start();
            btn_ScanCode.Enabled = false;
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ScanQRCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            formClosed = true;
            if (startCamera == true)
            {
                if (timer1.Enabled == true)
                {
                    captureDevice.Stop();
                }
            }
            startCamera = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                try
                {
                    Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                    if (result != null)
                    {
                        if (formClosed == true)
                        {
                            captureDevice.Stop();
                        }
                        Codes workCodes = new Codes();
                        workCodes.CheckCode(result.ToString());
                        if (workCodes.found == true)
                        {
                            captureDevice.Stop();
                            timer1.Stop();
                            int count = 0;
                            codeAccepted = true;
                            count++;
                            if (count == 1)
                            {
                                MessageBox.Show("This code has been accepted. Click OK to continue.");
                                this.Close();
                                timer1.Stop();
                                Enigma_Learning_prototype.Startup_Page startup = new Enigma_Learning_prototype.Startup_Page();
                                startup.Show();
                            }
                        }
                        else
                        {
                            timer1.Stop();
                            captureDevice.Stop();
                            btn_ScanCode.Enabled = true;
                            codeAccepted = false;
                            MessageBox.Show("Code NOT accepted. Please try again.");
                            MessageBox.Show(result.ToString());
                            pictureBox1.Image = null;
                            
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private void btn_EnterCode_Click(object sender, EventArgs e)
        {
            this.Close();
            enterCodeOpened = true;
            stopCamera = true;
            if (startCamera == true)
            {
                captureDevice.Stop();
                timer1.Stop();
            }
            EnterCode.windowReopened = true;
        }
    }
}
