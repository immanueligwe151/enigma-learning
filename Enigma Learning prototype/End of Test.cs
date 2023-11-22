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
    public partial class EndofTest : Form
    {
        public EndofTest()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EndofTest_Load(object sender, EventArgs e)
        {
            string printedScore;
            double percentageScore = ((double)Enigma_Learning_prototype.ExamQuestions1.marksAttained / (double)Enigma_Learning_prototype.ExamQuestions1.totalMarks) * 100;
            if (percentageScore.ToString().Length <= 4)
            {
                printedScore = percentageScore.ToString();
            }
            else
            {
                printedScore = percentageScore.ToString().Remove(4);
            }
            lbl_percentageScore.Text = "Your performance: " + printedScore + "%";
            if (percentageScore > 60 && percentageScore <= 100)
            {
                pictureBox1.Image = Properties.Resources.great_work_image;
                lbl_Description.Text = "You attempted " + Enigma_Learning_prototype.ExamQuestions1.questionsAnswered.ToString() + " out of " + Enigma_Learning_prototype.ExamQuestions1.questionsforScoring.ToString() +
                    " questions\nand got " + Enigma_Learning_prototype.ExamQuestions1.marksAttained.ToString() + " marks out of " +Enigma_Learning_prototype.ExamQuestions1.totalMarks.ToString() + " marks.\n\n" +
                    "This is a great performance! With a score like this you'll\n" +
                    "thrash the exams and show them who's boss: you!" +
                    "\nKeep on practicing and building up your confidence, cos\n" +
                    "it all counts! At the same time also work on your mental\n" +
                    "wellbeing and make use of our Moodlet tool, because it\n" +
                    "helps immensely to be mentally okay before writing any\n" +
                    "exam. Once again, well done and good luck in your\n" +
                    "preparations and your exams! We believe in you!";
            }
            else if (percentageScore > 30 && percentageScore <= 60)
            {
                pictureBox1.Image = Properties.Resources.alright_image;
                lbl_Description.Text = "You attempted " + Enigma_Learning_prototype.ExamQuestions1.questionsAnswered.ToString() + " out of " + Enigma_Learning_prototype.ExamQuestions1.questionsforScoring.ToString() +
                    " questions\nand got " + Enigma_Learning_prototype.ExamQuestions1.marksAttained.ToString() + " marks out of " + Enigma_Learning_prototype.ExamQuestions1.totalMarks.ToString() + " marks.\n\n" +
                    "That's a good performance, though it could be\n" +
                    "a bit better. But don't worry; no one's perfect. It always\n" +
                    "takes some bit of extra work to be good at something. With\n" +
                    "constant practice and determination, you will get there. As\n" +
                    "you are working on your performance, don't forget to also work\n" +
                    "on your mental health using our Moodlet tool, as it helps immensly\n" +
                    "to be mentally okay before any exam.\n" +
                    "We believe in you!";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.not_great_image;
                lbl_Description.Text = "You attempted " + Enigma_Learning_prototype.ExamQuestions1.questionsAnswered.ToString() + " out of " + Enigma_Learning_prototype.ExamQuestions1.questionsforScoring.ToString() +
                    " questions and\ngot " + Enigma_Learning_prototype.ExamQuestions1.marksAttained.ToString() + " marks out of " + Enigma_Learning_prototype.ExamQuestions1.totalMarks.ToString() + " marks.\n" +
                    "\nAww, you could've done better than that! But not to worry;\n" +
                    "you probably did your best 😊. But don't let your not-so-great\n" +
                    "score at a test bring you down. A score is nothing in comparison\n" +
                    "to what you can do, to your full potential. So don't fret, but\n" +
                    "push through the negative and see light in the positive. Try\n" +
                    "and try and try again until you've finally gotten it right!\n" +
                    "Then you know that you've achieved your full potential. And at\n" +
                    "the same time, also work on your mental health using our Moodlet\n" +
                    "tool, as it helps immensely to be okay before any exam.\n" +
                    "We believe in you!";
            }
        }
    }
}
