using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Learning_prototype
{
    public partial class ReviewContent : Form
    {
        public ReviewContent()
        {
            InitializeComponent();
        }

        public int subjectNumber { get; set; }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Do you really want to leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (message == DialogResult.Yes)
            {
                this.Close();
                RevisionStyle revisionStyle = new RevisionStyle();
                revisionStyle.Show();
            }
        }
    }
}