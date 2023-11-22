using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Learning_prototype
{
    public partial class RevisionStyle : Form
    {
        public RevisionStyle()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Startup_Page homePage = new Startup_Page();
            this.Close();
            homePage.Show();
        }

        private void btn_ReviewContent_Click(object sender, EventArgs e)
        {
            NotAvailable();
            /*ReviewContent reviewContent = new ReviewContent();
            this.Close();
            reviewContent.Show();*/
        }

        private void btn_RevisionNotes_Click(object sender, EventArgs e)
        {
            switch (Notes.realSubjectNo)
            {
                case 1:
                    LoadNotes();
                    break;
                case 2:
                    LoadNotes();
                    break;
                case 3:
                    NotAvailable();
                    break;
                case 4:
                    NotAvailable();
                    break;
                case 5:
                    NotAvailable();
                    break;
                case 6:
                    NotAvailable();
                    break;
                case 7:
                    NotAvailable();
                    break;
                case 8:
                    NotAvailable();
                    break;
                case 9:
                    NotAvailable();
                    break;
                case 10:
                    NotAvailable();
                    break;
                case 11:
                    LoadNotes();
                    break;
                case 12:
                    LoadNotes();
                    break;
                case 13:
                    NotAvailable();
                    break;
                case 14:
                    NotAvailable();
                    break;
                case 15:
                    NotAvailable();
                    break;
                case 16:
                    NotAvailable();
                    break;
                case 17:
                    NotAvailable();
                    break;
                case 18:
                    NotAvailable();
                    break;
                case 19:
                    NotAvailable();
                    break;
                case 20:
                    NotAvailable();
                    break;
                case 21:
                    LoadNotes();
                    break;
                case 22:
                    NotAvailable();
                    break;
                case 23:
                    NotAvailable();
                    break;
                case 24:
                    NotAvailable();
                    break;
            }
        }

        private void btn_ExamQuestions_Click(object sender, EventArgs e)
        {
            if (Topics.subjectLabels == "Biology")
            {
                LoadQuestions();
            }
            if (Topics.subjectLabels == "Chemistry")
            {
                LoadQuestions();
            }
            if (Topics.subjectLabels == "Physics")
            {
                NotAvailable();
            }
        }
        private void LoadNotes()
        {
            Notes notes = new Notes();
            this.Close();
            notes.Show();
        }
        private void LoadQuestions()
        {
            ExamQuestions1 form1 = new ExamQuestions1();
            this.Close();
            form1.Show();
        }
        private void NotAvailable()
        {
            MessageBox.Show("Sorry, this content is not available at the moment! Keep a " +
                "lookout at our website at https://www.enigmalearning.uk/ for information on when an update is available", "Content not available :(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_ExamQuestions_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_ExamQuestions, "Use this to answer exam-styled questions\nbased on the subject you have picked. This is a very good\ntool in preparing for your exams.");
        }

        private void btn_RevisionNotes_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_RevisionNotes, "Use this to revise quickly using clear, easy-to-understand\nnotes prepared by our science team based on the\ntopic you have picked.");
        }

        private void btn_ReviewContent_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_ReviewContent, "Use this to quickly look through the topic\ncontent of your selected topic.");
        }
    }
}
