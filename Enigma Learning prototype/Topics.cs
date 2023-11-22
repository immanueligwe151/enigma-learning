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
    public partial class Topics : Form
    {
        public Topics()
        {
            InitializeComponent();
            
        }

        public static string subjectLabels;

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Startup_Page Home = new Startup_Page();
            Home.Show();
        }

        private void Topics_Load(object sender, EventArgs e)
        {
            switch (subjectLabels)
            {
                case "Biology":
                    Biology_Load();
                    break;
                case "Chemistry":
                    Chemistry_Load();
                    break;
                case "Physics":
                    Physics_Note();
                    break;
            }
        }
        private void Biology_Load()
        {
            this.Text = "Biology";
            btn_Topic1.Text = "Cells";
            btn_Topic2.Text = "Organisation";
            btn_Topic3.Text = "Infectious Diseases";
            btn_Topic4.Text = "Bioenergetics";
            btn_Topic5.Text = "Inheritance";
            btn_Topic6.Text = "Variation and Evolution";
            btn_Topic7.Text = "Homeostasis";
            btn_Topic8.Text = "Ecology";
        }
        private void Chemistry_Load()
        {
            this.Text = "Chemistry";
            btn_Topic1.Text = "Atomic Structure\nand the Periodic Table";
            btn_Topic2.Text = "Chemical Reactions";
            btn_Topic3.Text = "Chemical Measurements";
            btn_Topic4.Text = "Chemical Changes";
            btn_Topic5.Text = "Chemical Analysis";
            btn_Topic6.Text = "Organic Chemistry";
            btn_Topic7.Text = "Rates of Reaction";
            btn_Topic8.Text = "Resources";
        }
        private void Physics_Note()
        {
            this.Text = "Physics";
            btn_Topic1.Text = "Energy";
            btn_Topic2.Text = "Electricity";
            btn_Topic3.Text = "Particle Model of Matter";
            btn_Topic4.Text = "Atomic Structure and\nRadioactivity";
            btn_Topic5.Text = "Waves";
            btn_Topic6.Text = "Forces";
            btn_Topic7.Text = "Magnetism";
            btn_Topic8.Text = "Space Physics";
        }

        private void btn_Topic1_Click(object sender, EventArgs e)
        {
            RevisionStyle revisionStyle = new RevisionStyle();
            switch (subjectLabels)
            {
                case "Biology":
                    Notes.realSubjectNo = 1;
                    break;
                case "Chemistry":
                    Notes.realSubjectNo = 9;
                    break;
                case "Physics":
                    Notes.realSubjectNo = 17;
                    break;
            }
            this.Close();
            revisionStyle.Show();
        }

        private void btn_Topic2_Click(object sender, EventArgs e)
        {
            RevisionStyle revisionStyle = new RevisionStyle();
            switch (subjectLabels)
            {
                case "Biology":
                    Notes.realSubjectNo = 2;
                    break;
                case "Chemistry":
                    Notes.realSubjectNo = 10;
                    break;
                case "Physics":
                    Notes.realSubjectNo = 18;
                    break;
            }
            this.Close();
            revisionStyle.Show();
        }

        private void btn_Topic3_Click(object sender, EventArgs e)
        {
            RevisionStyle revisionStyle = new RevisionStyle();
            switch (subjectLabels)
            {
                case "Biology":
                    Notes.realSubjectNo = 3;
                    break;
                case "Chemistry":
                    Notes.realSubjectNo = 11;
                    break;
                case "Physics":
                    Notes.realSubjectNo = 19;
                    break;
            }
            this.Close();
            revisionStyle.Show();
        }

        private void btn_Topic4_Click(object sender, EventArgs e)
        {
            RevisionStyle revisionStyle = new RevisionStyle();
            switch (subjectLabels)
            {
                case "Biology":
                    Notes.realSubjectNo = 4;
                    break;
                case "Chemistry":
                    Notes.realSubjectNo = 12;
                    break;
                case "Physics":
                    Notes.realSubjectNo = 20;
                    break;
            }
            this.Close();
            revisionStyle.Show();
        }

        private void btn_Topic5_Click(object sender, EventArgs e)
        {
            RevisionStyle revisionStyle = new RevisionStyle();
            switch (subjectLabels)
            {
                case "Biology":
                    Notes.realSubjectNo = 5;
                    break;
                case "Chemistry":
                    Notes.realSubjectNo = 13;
                    break;
                case "Physics":
                    Notes.realSubjectNo = 21;
                    break;
            }
            this.Close();
            revisionStyle.Show();
        }

        private void btn_Topic6_Click(object sender, EventArgs e)
        {
            RevisionStyle revisionStyle = new RevisionStyle();
            switch (subjectLabels)
            {
                case "Biology":
                    Notes.realSubjectNo = 6;
                    break;
                case "Chemistry":
                    Notes.realSubjectNo = 14;
                    break;
                case "Physics":
                    Notes.realSubjectNo = 22;
                    break;
            }
            this.Close();
            revisionStyle.Show();
        }

        private void btn_Topic7_Click(object sender, EventArgs e)
        {
            RevisionStyle revisionStyle = new RevisionStyle();
            switch (subjectLabels)
            {
                case "Biology":
                    Notes.realSubjectNo = 7;
                    break;
                case "Chemistry":
                    Notes.realSubjectNo = 15;
                    break;
                case "Physics":
                    Notes.realSubjectNo = 23;
                    break;
            }
            this.Close();
            revisionStyle.Show();
        }

        private void btn_Topic8_Click(object sender, EventArgs e)
        {
            RevisionStyle revisionStyle = new RevisionStyle();
            switch (subjectLabels)
            {
                case "Biology":
                    Notes.realSubjectNo = 8;
                    break;
                case "Chemistry":
                    Notes.realSubjectNo = 16;
                    break;
                case "Physics":
                    Notes.realSubjectNo = 24;
                    break;
            }
            this.Close();
            revisionStyle.Show();
        }
    }
}
