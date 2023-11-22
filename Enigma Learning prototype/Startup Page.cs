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
    public partial class Startup_Page : Form
    {
        public Startup_Page()
        {
            InitializeComponent();
        }

        private void btn_Biology_Click(object sender, EventArgs e)
        {
            Topics topicPage = new Topics();
            Topics.subjectLabels = "Biology";
            this.Close();
            topicPage.Show();
        }

        private void btn_Chemistry_Click(object sender, EventArgs e)
        {
            Topics topicPage = new Topics();
            Topics.subjectLabels = "Chemistry";
            this.Close();
            topicPage.Show();
        }

        private void btn_Physics_Click(object sender, EventArgs e)
        {
            Topics topicPage = new Topics();
            Topics.subjectLabels = "Physics";
            this.Close();
            topicPage.Show();
        }

        private void btn_GoToMoodlet_Click(object sender, EventArgs e)
        {
            Moodlet gotoMoodlet = new Moodlet();
            Moodlet.goBack = 2;
            this.Close();
            gotoMoodlet.Show();
        }

        private void Startup_Page_Load(object sender, EventArgs e)
        {
            ExamQuestions1.chemistryQuestionNo = 0;//setting this variable back to default
            ExamQuestions1.biologyQuestionNo = 0;//setting this back to default as well
            ExamQuestions1.physicsQuestionNo = 0;//setting this back to default too
            ExamQuestions1.biologyCountdown = 10;//setting this back to default
            ExamQuestions1.chemistryCountdown = 10;//this too
            ExamQuestions1.physicsCountdown = 10;//this t00
            ExamQuestions1.biologyQuestions = new List<int> { 1, 2, 3, 4, 5 };//this too
            //dont forget to change it once you've changed it in the form it's in
            ExamQuestions1.chemistryQuestions = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };//this too
            //dont forget to change it once you've changed it in the form it's in
            ExamQuestions1.physicsQuestions = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//this too
            //dont forget to change it once you've changed it in the form it's in
            ExamQuestions1.questionsAnswered = 0;//this too. doesn;t need changing
            ExamQuestions1.marksAttained = 0;//this too
            ExamQuestions1.totalMarks = 0;//this too, will change by itself in its form as a number is assigned to it once its loaded
            ExamQuestions1.allQuestions = 0;//this too, will change by itself for same reason as above

        }
    }
}

