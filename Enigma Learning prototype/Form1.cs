using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Enigma_Learning_prototype
{
    public partial class Enigma_Startup : Form
    {
        public Enigma_Startup()
        {
            InitializeComponent();
        }

        public int moodletStart { get; set; }

        private void btn_StartEnigma_Click(object sender, EventArgs e)
        {
            Enigma_Learning.ScanQRCode scanCode = new Enigma_Learning.ScanQRCode();
            scanCode.ShowDialog();
            if (Enigma_Learning.EnterCode.windowReopened1 >= 2)
            {
                Enigma_Learning.EnterCode enterCode = new Enigma_Learning.EnterCode();
                enterCode.ShowDialog();
            }
            if (Enigma_Learning.ScanQRCode.enterCodeOpened == true)
            {
                Enigma_Learning.EnterCode enterCode = new Enigma_Learning.EnterCode();
                enterCode.ShowDialog();
            }
            if (Enigma_Learning.EnterCode.scannerReopened == true)
            {
                Enigma_Learning.ScanQRCode openedAgain = new Enigma_Learning.ScanQRCode();
                openedAgain.ShowDialog();
            }
            if (Enigma_Learning.ScanQRCode.codeAccepted == true)
            {
                this.Hide();
            }
            else
            {

            }
        }

        private void btn_GoToMoodlet_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("This is an aspect of our revision app that helps to deal with your mental health.\n" +
                "Would you like to go here?", "The Moodlet", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (message == DialogResult.Yes)
            {
                Moodlet gotoMoodlet = new Moodlet();
                Moodlet.goBack = 1;
                this.Hide();
                Thread.Sleep(500);
                gotoMoodlet.Show();
            }
        }

        private void Enigma_Startup_Load(object sender, EventArgs e)
        {
            Enigma_Learning.ScanQRCode.formClosed = false;
            Enigma_Learning.ScanQRCode.codeAccepted = false;
            Enigma_Learning.ScanQRCode.enterCodeOpened = false;
            Enigma_Learning.ScanQRCode.stopCamera = false;
            Enigma_Learning.ScanQRCode.startCamera = false;
        }

        private void btn_GoToMoodlet_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_GoToMoodlet, "Click this button to access our Moodlet tool, a very useful\ntool to help with your mental health");
        }

        private void btn_StartEnigma_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(btn_StartEnigma, "Have your daily planner with QR code handy? Acess the app\nusing the QR code and start revising now!");
        }
    }
}


