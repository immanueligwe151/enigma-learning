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
    public partial class Moodlet : Form
    {
        public Moodlet()
        {
            InitializeComponent();
        }

        public static int goBack;

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Enigma_Startup startPage = new Enigma_Startup();
            Startup_Page Home = new Startup_Page();
            if (goBack == 1)
            {
                this.Close();
                startPage.Show();
            }
            else
            {
                this.Close();
                Home.Show();
            }
        }

        private void btn_DayRate_Click(object sender, EventArgs e)
        {
            RateYourDay dayRate = new RateYourDay();
            dayRate.ShowDialog();
        }

        private void btn_Diary_Click(object sender, EventArgs e)
        {
            Diary yourDiary = new Diary();
            this.Close();
            yourDiary.Show();
        }
    }
}
