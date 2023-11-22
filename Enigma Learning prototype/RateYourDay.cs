using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace Enigma_Learning_prototype
{
    public partial class RateYourDay : Form
    {
        public RateYourDay()
        {
            InitializeComponent();
        }

        private void btn_Rate_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Aww, that's not great! What seems to be the matter? Would you like to " +
                    "talk to someone, or would you like to use The Diary? It probably would be better to talk " +
                    "to someone though, because then they would be more understanding than a program would be.", "Bad");
                Thread.Sleep(750);
                DialogResult message = MessageBox.Show("Would you like to talk with one of us via our live chat on our website? " +
                    "Perhaps someone will be able to help you with whatever's wrong.", "Talk With Us", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    Process.Start("https://www.enigmalearning.uk/");
                }
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("Well, that's not a good sign. What could be possibly wrong? Maybe you want to " +
                    "talk to someone about it? Perhaps you can use The Diary to explain what's wrong? Always " +
                    "try not to focus on the negative because it's not very healthy for you. Whatever is wrong," +
                    " let go of it and focus on the good parts of life", "Not too good");
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("Guess you're just feeling more or less neutral. Whatever the case is, try not to " +
                    "feel too bad with whatever's wrong, because looking towards the positive always helps.", "Okay");
            }
            else if (radioButton4.Checked == true)
            {
                MessageBox.Show("That's alright! Not too bad! Still tho, wouldn't it be nice" +
                    " to perhaps feel at your best? Always try to keep yourself at your best mood" +
                    " because it pays to always feel great!", "Nice!");
            }
            else if (radioButton5.Checked == true)
            {
                MessageBox.Show("That's great! It's so nice that you're feeling wonderful! Always " +
                    "try to keep yourself at your best mood, no matter what brings you down!", "Wonderful");
            }
        }

        private void RateYourDay_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }
    }
}
