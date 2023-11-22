using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Learning
{
    public partial class EnterCode : Form
    {
        public EnterCode()
        {
            InitializeComponent();
        }

        public static bool scannerReopened = false;
        public static int windowReopened1 = 0;
        public static bool windowReopened = false;

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            scannerReopened = true;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            Codes workCodes = new Codes();
            workCodes.CheckCode(codeEntry.Text);
            if (workCodes.found == true)
            {
                //string entry = codeEntry.Text;
                ScanQRCode.codeAccepted = true;
                //SaveToFile(entry);
                MessageBox.Show("This code has been accepted. Click OK to continue.");
                this.Close();
                Enigma_Learning_prototype.Startup_Page startUp = new Enigma_Learning_prototype.Startup_Page();
                startUp.Show();
            }
            else
            {
                ScanQRCode.codeAccepted = false;
                MessageBox.Show("Code NOT accepted. Please try again.");
                codeEntry.Text = "";
            }
        }

        private void EnterCode_Load(object sender, EventArgs e)
        {
            windowReopened1++;
            Enigma_Learning.ScanQRCode.formClosed = false;
            Enigma_Learning.ScanQRCode.codeAccepted = false;
            Enigma_Learning.ScanQRCode.enterCodeOpened = false;
            Enigma_Learning.ScanQRCode.stopCamera = false;
            Enigma_Learning.ScanQRCode.startCamera = false;
        }
        //public void SaveToFile(string entry)
        //{
        //    Properties.Resources.contains_code_entered;
        //}
    }
}
