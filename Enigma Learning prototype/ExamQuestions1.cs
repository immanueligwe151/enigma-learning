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
    public partial class ExamQuestions1 : Form
    {
        public ExamQuestions1()
        {
            InitializeComponent();
        }

        public static int chemistryQuestionNo;
        //the variable i'll use to contain the question number for chemistry which will be randomly generated
        public static int biologyQuestionNo;
        //the variable i'll use to contain the question number for biology which will be randomly generated
        public static int physicsQuestionNo;
        //the variable i'll use to contain the question number for physics which will be randomly generated
        public static int biologyCountdown = 10;//this is the total number of questions for biology which i'll be
        //subtracting 1 from every single time a question is loaded, and once it's 0, the "next" button will be disabled.
        //this value is only temporary. i'll change it as the questions making goes on.
        public static int chemistryCountdown = 8;//this is the total number of questions for chemistry which i'll be
        //subtracting 1 from every single time a question is loaded, and once it's 0, the "next" button will be disabled.
        //this value is only temporary. i'll change it as the questions making goes on.
        public static int physicsCountdown = 10;//this is the total number of questions for physics which i'll be
        //subtracting 1 from every single time a question is loaded, and once it's 0, the "next" button will be disabled.
        //this value is only temporary. i'll change it as the questions making goes on.
        public static List<int> biologyQuestions = new List<int> { 1, 2, 3, 4, 5 };
        //the list I'll be using to contain the question number identifiers for biology so that each time a question is answered i can remove
        //the value from the list, to avoid repitition of questions when a random number is generated
        public static List<int> chemistryQuestions = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        //the list I'll be using to contain the question number identifiers for chemistry so that each time a question is answered i can remove
        //the value from the list, to avoid repitition of questions when a random number is generated
        public static List<int> physicsQuestions = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //the list I'll be using to contain the question number identifiers for physics so that each time a question is answered i can remove
        //the value from the list, to avoid repitition of questions when a random number is generated
        public static int questionsAnswered = 0;
        //this keeps track of all the questions answered by the user
        public static int marksAttained = 0;
        //this keeps track of all the marks attained by the user
        public static int totalMarks;
        //this is all the marks that can be gained and will be initialised at the start of each subject test
        public static int allQuestions;
        //this is all the questions for each subject, and will be initalised at the start of each subject test
        public static int questionsforScoring;
        public static bool questionCorrect = false;//this is there just to ensure that the user gets the marks they deserve
        public static int spareMarks;//this is the marks that aren't added on when the test is ended and will be added
        public static bool buttonClicked = false;
        public static string questionIdentifier;

        private void btn_Back_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are you sure you want to quit? You will lose all your progress!", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (message == DialogResult.Yes)
            {
                Startup_Page Home = new Startup_Page();
                this.Close();
                Home.Show();
            }
        }

        private void ExamQuestions1_Load(object sender, EventArgs e)
        {
            //Biology_Question_5();
            switch (Topics.subjectLabels)
            {
                case "Biology":
                    allQuestions = 5;
                    questionsforScoring = 5;
                    break;
                case "Chemistry":
                    allQuestions = 16;
                    questionsforScoring = 16;
                    break;
                case "Physics":

                    break;
            }
            allQuestions--;
            ChoosingQuestion();//asking the void to randomly select a question
        }
        private void Biology_Question_1()
        //5 marks, question 1 for biology
        {
            AddingMarks();
            questionIdentifier = "Bio1";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Cells";
            marksForQuestion.Text = "(5 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "(1) Suggest why epithelial cells have many mitochondria. (2 marks)";
            mainQuestion.Location = new Point(50, 68);
            richTextBox1.Visible = true;
            richTextBox1.Size = new Size(300, 80);
            richTextBox1.Location = new Point(50, 100);
            richTextBox1.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = true;
            questionLabel1.Text = "(2) What is osmosis? (3 marks)";
            questionLabel1.Location = new Point(50, 200);
            richTextBox2.Visible = true;
            richTextBox2.Size = new Size(320, 100);
            richTextBox2.Location = new Point(50, 230);
            richTextBox2.Text = "";
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Biology_Question_2()
        //3 marks, question 2 for biology
        {
            AddingMarks();
            questionIdentifier = "Bio2";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Organisation";
            marksForQuestion.Text = "(3 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "(1) A and B are two enzymes that digest carbohydrates.\n     What general name do scientists give to enzymes like A and B? (1 mark)";
            mainQuestion.Location = new Point(50, 68);
            textBox1.Visible = true;
            textBox1.Text = "";
            textBox1.Size = new Size(180, 26);
            textBox1.Location = new Point(50, 120);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = true;
            questionLabel1.Text = "(2) The tissue in the wall of the heart contracts.\n     What type of tissue is this and what does the heart do when this tissue contracts? (2 marks)";
            questionLabel1.Location = new Point(50, 200);
            richTextBox1.Visible = true;
            richTextBox1.Size = new Size(320, 100);
            richTextBox1.Location = new Point(50, 260);
            richTextBox1.Text = "";
            richTextBox2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Biology_Question_3()
        //4 marks, question 3 for biology
        {
            AddingMarks();
            questionIdentifier = "Bio3";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Cells";
            marksForQuestion.Text = "(4 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "(1) Explain what happens to the heart in coronary heart disease. (3 marks)";
            mainQuestion.Location = new Point(50, 68);
            richTextBox1.Visible = true;
            richTextBox1.Size = new Size(380, 120);
            richTextBox1.Location = new Point(50, 100);
            richTextBox1.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = true;
            questionLabel1.Text = "(2) The stomach makes hydrochloric acid. How does the acid help digestion? (1 mark)";
            questionLabel1.Location = new Point(50, 250);
            richTextBox2.Visible = true;
            richTextBox2.Size = new Size(320, 100);
            richTextBox2.Location = new Point(50, 280);
            richTextBox2.Text = "";
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Biology_Question_4()
        //3 marks, question 4 for biology
        {
            AddingMarks();
            questionIdentifier = "Bio4";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Infectious Diseases";
            marksForQuestion.Text = "(3 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "(1) Painkillers do not cure infectious diseases. Why? (1 mark)";
            mainQuestion.Location = new Point(50, 68);
            richTextBox1.Visible = true;
            richTextBox1.Size = new Size(380, 120);
            richTextBox1.Location = new Point(50, 100);
            richTextBox1.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = true;
            questionLabel1.Text = "(2) Hand-gel dispensers are now placed at the entrance of most hospital wards. Explain why. (2 marks)";
            questionLabel1.Location = new Point(50, 250);
            richTextBox2.Visible = true;
            richTextBox2.Size = new Size(320, 100);
            richTextBox2.Location = new Point(50, 280);
            richTextBox2.Text = "";
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Biology_Question_5()
        //3 marks, question 5 for biology
        {
            AddingMarks();
            questionIdentifier = "Bio5";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Infectious Diseases";
            marksForQuestion.Text = "(3 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "To immunise someone against measles, a small quantity of the inactive measles pathogen is injected into the body.\n" +
                "Describe what happens in the body after immunisation to stop a person catching measles in the future. (3 marks)";
            mainQuestion.Location = new Point(50, 68);
            richTextBox1.Visible = true;
            richTextBox1.Size = new Size(700, 300);
            richTextBox1.Location = new Point(50, 130);
            richTextBox1.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = false;
            richTextBox2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        


        private void Chemistry_Question_1()
        //1 mark, question 1 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem1";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Atomic Structure and the Periodic Table";
            marksForQuestion.Text = "(1 mark)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "The electronic structure of five elements are shown in the image below.\n\nThe letters are NOT the symbols of the elements";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic1;
            pictureBox1.Size = new Size(320, 280);
            pictureBox1.Location = new Point(50, 145);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = true;
            questionLabel1.Text = "Choose the element to answer the question. Each element can\nbe used once, more than once or not at all." +
                "\n\nUse the periodic table to help you.\nWhich element is Hydrogen?";
            questionLabel1.Location = new Point(380, 150);
            radioButton1.Visible = true;
            radioButton1.Checked = true;
            radioButton1.Text = "A";
            radioButton1.Location = new Point(380, 260);
            radioButton2.Visible = true;
            radioButton2.Text = "B";
            radioButton2.Location = new Point(430, 260);
            radioButton3.Visible = true;
            radioButton3.Text = "C";
            radioButton3.Location = new Point(480, 260);
            radioButton4.Visible = true;
            radioButton4.Text = "D";
            radioButton4.Location = new Point(530, 260);
            radioButton5.Visible = true;
            radioButton5.Text = "E";
            radioButton5.Location = new Point(580, 260);
            radioButton6.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_2()
        //1 mark, question 2 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem2";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Atomic Structure and the Periodic Table";
            marksForQuestion.Text = "(1 mark)";
            radioButton1.Visible = true;
            radioButton1.Checked = true;
            mainQuestion.Visible = true;
            mainQuestion.Text = "The electronic structure of five elements are shown in the image below.\n\nThe letters are NOT the symbols of the elements";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic1;
            pictureBox1.Size = new Size(320, 280);
            pictureBox1.Location = new Point(50, 145);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = true;
            questionLabel1.Text = "Choose the element to answer the question. Each element can\nbe used once, more than once or not at all." +
                "\n\nUse the periodic table to help you.\nWhich element is a halogen?";
            questionLabel1.Location = new Point(380, 150);
            radioButton1.Visible = true;
            radioButton1.Text = "A";
            radioButton1.Location = new Point(380, 260);
            radioButton2.Visible = true;
            radioButton2.Text = "B";
            radioButton2.Location = new Point(430, 260);
            radioButton3.Visible = true;
            radioButton3.Text = "C";
            radioButton3.Location = new Point(480, 260);
            radioButton4.Visible = true;
            radioButton4.Text = "D";
            radioButton4.Location = new Point(530, 260);
            radioButton5.Visible = true;
            radioButton5.Text = "E";
            radioButton5.Location = new Point(580, 260);
            radioButton6.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_3()
        //1 mark, question 3 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem3";
            questionsAnswered++;
            radioButton1.Visible = true;
            radioButton1.Checked = true;
            lbl_topicReference.Text = "Topic Reference: Atomic Structure and the Periodic Table";
            marksForQuestion.Text = "(1 mark)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "The electronic structure of five elements are shown in the image below.\n\nThe letters are NOT the symbols of the elements";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic1;
            pictureBox1.Size = new Size(320, 280);
            pictureBox1.Location = new Point(50, 145);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = true;
            questionLabel1.Text = "Choose the element to answer the question. Each element can\nbe used once, more than once or not at all." +
                "\n\nUse the periodic table to help you.\nWhich element is a metal in the same group as element A?";
            questionLabel1.Location = new Point(380, 150);
            radioButton1.Visible = true;
            radioButton1.Text = "A";
            radioButton1.Location = new Point(380, 260);
            radioButton2.Visible = true;
            radioButton2.Text = "B";
            radioButton2.Location = new Point(430, 260);
            radioButton3.Visible = true;
            radioButton3.Text = "C";
            radioButton3.Location = new Point(480, 260);
            radioButton4.Visible = true;
            radioButton4.Text = "D";
            radioButton4.Location = new Point(530, 260);
            radioButton5.Visible = true;
            radioButton5.Text = "E";
            radioButton5.Location = new Point(580, 260);
            radioButton6.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_4()
        //1 mark, question 4 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem4";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Atomic Structure and the Periodic Table";
            marksForQuestion.Text = "(1 mark)";
            radioButton1.Visible = true;
            radioButton1.Checked = true;
            mainQuestion.Visible = true;
            mainQuestion.Text = "The electronic structure of five elements are shown in the image below.\n\nThe letters are NOT the symbols of the elements";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic1;
            pictureBox1.Size = new Size(320, 280);
            pictureBox1.Location = new Point(50, 145);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = true;
            questionLabel1.Text = "Choose the element to answer the question. Each element can\nbe used once, more than once or not at all." +
                "\n\nUse the periodic table to help you.\nWhich element exists as single atoms?";
            questionLabel1.Location = new Point(380, 150);
            radioButton1.Visible = true;
            radioButton1.Text = "A";
            radioButton1.Location = new Point(380, 260);
            radioButton2.Visible = true;
            radioButton2.Text = "B";
            radioButton2.Location = new Point(430, 260);
            radioButton3.Visible = true;
            radioButton3.Text = "C";
            radioButton3.Location = new Point(480, 260);
            radioButton4.Visible = true;
            radioButton4.Text = "D";
            radioButton4.Location = new Point(530, 260);
            radioButton5.Visible = true;
            radioButton5.Text = "E";
            radioButton5.Location = new Point(580, 260);
            radioButton6.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_5()
        //2 marks, question 5 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem5";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Atomic Structure and the Periodic Table";
            marksForQuestion.Text = "(2 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "This questions is about carbon and gases in the air.\n\n" +
                "Carbon atoms have protons, neutrons and electrons.\n\n" +
                "Complete the table below by writing the relative mass of a neutron and electron.";
            mainQuestion.Location = new Point(50, 68);
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic2;
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(58, 200);
            pictureBox1.Size = new Size(480, 280);
            textBox1.Visible = true;
            textBox1.BringToFront();
            textBox1.Location = new Point(380, 360);
            textBox1.Size = new Size(100, 26);
            textBox2.Visible = true;
            textBox2.BringToFront();
            textBox2.Location = new Point(380, 420);
            textBox2.Size = new Size(100, 26);
            textBox1.Visible = true;
            textBox1.Text = "";
            textBox2.Visible = true;
            textBox2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel1.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_6()
        //1 mark, question 6 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem6";
            questionsAnswered++;
            radioButton1.Visible = true;
            radioButton1.Checked = true;
            lbl_topicReference.Text = "Topic Reference: Atomic Structure and the Periodic Table";
            marksForQuestion.Text = "(1 mark)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "This questions is about carbon and gases in the air.\n\n" +
                "Carbon atoms have protons, neutrons and electrons.\n\n" +
                "What is the total number of protons and neutrons in an atom called?";
            mainQuestion.Location = new Point(50, 68);
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton1.Text = "The atomic number";
            radioButton2.Text = "The mass number";
            radioButton3.Text = "One mole of the atom";
            radioButton1.Location = new Point(58, 200);
            radioButton2.Location = new Point(58, 250);
            radioButton3.Location = new Point(58, 300);
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel1.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_7()
        //3 marks, question 7 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem7";
            questionsAnswered++;
            radioButton1.Checked = true;
            radioButton1.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "";
            textBox2.Visible = true;
            textBox2.Text = "";
            lbl_topicReference.Text = "Topic Reference: Atomic Structure and the Periodic Table";
            marksForQuestion.Text = "(3 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "The diagram shows a carbon atom";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic3;
            pictureBox1.Location = new Point(50, 100);
            pictureBox1.Size = new Size(320, 240);
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox1.BringToFront();
            textBox2.BringToFront();
            textBox1.Location = new Point(310, 260);
            textBox1.Size = new Size(100, 26);
            textBox2.Location = new Point(310, 320);
            textBox2.Size = new Size(100, 26);
            questionLabel1.Visible = true;
            questionLabel1.Text = "A proton is labelled.\nUse the correct answer from the box to label each of the other subatomic particles.";
            questionLabel1.Location = new Point(400, 100);
            pictureBox2.Visible = true;
            pictureBox2.Image = Enigma_Learning.Properties.Resources.pic4;
            pictureBox2.Size = new Size(383, 39);
            pictureBox2.Location = new Point(400, 150);
            questionLabel2.Visible = true;
            questionLabel2.Text = "The atom of carbon is represented as:\n\n\nWhat is the mass number of this carbon atom?";
            questionLabel2.Location = new Point(50, 350);
            pictureBox3.Visible = true;
            pictureBox3.BringToFront();
            pictureBox3.Image = Enigma_Learning.Properties.Resources.pic5;
            pictureBox3.Location = new Point(50, 370);
            pictureBox3.Size = new Size(40, 48);
            radioButton1.Visible = true;
            radioButton1.Text = "6";
            radioButton1.Location = new Point(50, 440);
            radioButton1.BringToFront();
            radioButton2.Visible = true;
            radioButton2.Text = "13";
            radioButton2.Location = new Point(110, 440);
            radioButton2.BringToFront();
            radioButton3.Visible = true;
            radioButton3.Text = "19";
            radioButton3.Location = new Point(170, 440);
            radioButton3.BringToFront();
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            pictureBox4.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_8()
        //4 marks, question 8 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem8";
            questionsAnswered++;
            radioButton1.Checked = true;
            radioButton1.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "";
            textBox2.Visible = true;
            textBox2.Text = "";
            textBox3.Visible = true;
            textBox3.Text = "";
            textBox4.Visible = true;
            textBox4.Text = "";
            lbl_topicReference.Text = "Topic Reference: Chemical Reactions";
            marksForQuestion.Text = "(4 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "The structures of four substances A, B, C and D are shown in the figure below.";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic6;
            pictureBox1.Location = new Point(50, 100);
            pictureBox1.Size = new Size(518,131);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.BringToFront();
            textBox2.BringToFront();
            textBox3.BringToFront();
            textBox4.BringToFront();
            textBox1.Size = new Size(70, 26);
            textBox2.Size = new Size(70, 26);
            textBox3.Size = new Size(70, 26);
            textBox4.Size = new Size(70, 26);
            textBox1.Location = new Point(80, 285);
            textBox2.Location = new Point(80, 330);
            textBox3.Location = new Point(80, 375);
            textBox4.Location = new Point(80, 420);
            questionLabel1.Visible = true;
            questionLabel1.Text = "Use the correct letter, A, B, C or D to answer each question:\na) Which substance is a gas?\n\nb) Which substance is a liquid?\n\nc) Which substance is an element?\n\nd) Which substance is made of ions?";
            questionLabel1.Location = new Point(50, 240);
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
        }
        private void Chemistry_Question_9()
        //3 marks, question 9 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem9";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Chemical Reactions";
            marksForQuestion.Text = "(3 marks)";
            mainQuestion.Visible = false;
            //mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic8;
            pictureBox1.Size = new Size(336, 142);
            pictureBox1.Location = new Point(50, 68);
            questionLabel1.Visible = true;
            questionLabel1.Text = "What is the formula of the substance in the image?\nSelect the correct answer:";
            questionLabel1.Location = new Point(400, 100);
            pictureBox2.Visible = true;
            pictureBox2.Image = Enigma_Learning.Properties.Resources.pic9;
            pictureBox2.Size = new Size(254, 37);
            pictureBox2.Location = new Point(420, 150); 
            radioButton1.Visible = true;
            radioButton1.Checked = true;
            radioButton1.Text = "";
            radioButton1.BringToFront();
            radioButton1.Location = new Point(420, 163);
            radioButton2.Visible = true;
            radioButton2.Text = "";
            radioButton2.BringToFront();
            radioButton2.Location = new Point(510, 163);
            radioButton3.Visible = true;
            radioButton3.Text = "";
            radioButton3.BringToFront();
            radioButton3.Location = new Point(600, 163);
            pictureBox4.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            questionLabel2.Visible = true;
            questionLabel2.Text = "Use the correct answer from the box below to complete the sentence.\n\n\n\n" +
                "When a sulfur atom and an oxygen atom bond to produce the substance above,\nelectrons are ";
            questionLabel2.Location = new Point(50, 220);
            pictureBox3.Visible = true;
            pictureBox3.Image = Enigma_Learning.Properties.Resources.pic10;
            pictureBox3.BringToFront();
            pictureBox3.Size = new Size(393, 39);
            pictureBox3.Location = new Point(50, 260);
            textBox1.Visible = true;
            textBox1.BringToFront();
            textBox1.Text = "";
            textBox1.Location = new Point(190, 334);
            textBox1.Size = new Size(70, 26);
            questionLabel3.Visible = true;
            questionLabel3.Text = "What is the type of bonding shown in the diagram above?\nWrite down the correct answer in the textbox below.";
            questionLabel3.Location = new Point(50, 390);
            pictureBox4.Visible = true;
            pictureBox4.Image = Enigma_Learning.Properties.Resources.pic11;
            pictureBox4.BringToFront();
            pictureBox4.Size = new Size(360, 28);
            pictureBox4.Location = new Point(50, 440);
            textBox2.Visible = true;
            textBox2.Text = "";
            textBox2.Location = new Point(50, 480);
            textBox2.Size = new Size(70, 26);
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_10()
        //3 marks, question 10 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem10";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Chemical Reactions";
            marksForQuestion.Text = "(3 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "This question is about salts." +
                "\n\nSodium chloride is produced by reacting sodium with chlorine." +
                "\nsodium + chlorine → sodium chloride" +
                "\nThe diagram shows what happens to atoms of sodium and chlorine in this reaction." +
                "\nThe dots (•) and crosses (X) represent electrons." +
                "\nOnly the outer electrons are shown.\n\n\n\n\n\nDescribe, in terms of electrons, what happens when a sodium atom reacts with" +
                "\na chlorine atom to produce sodium chloride";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic12;
            pictureBox1.Size = new Size(468,89);
            pictureBox1.Location = new Point(50, 230);
            richTextBox1.Visible = true;
            richTextBox1.Text = "";
            richTextBox1.Location = new Point(50, 380);
            richTextBox1.Size = new Size(400,150);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_11()
        //3 marks, question 11 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem11";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Chemical Reactions";
            marksForQuestion.Text = "(3 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "This question is about diamonds.\nPick an option from the boxes below and fill in the textboxes:";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic29;
            pictureBox1.Size = new Size(405, 488);
            pictureBox1.Location = new Point(150, 120);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            questionLabel1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = true;
            textBox1.Text = "";
            textBox1.BringToFront();
            textBox1.Size = new Size(100, 26);
            textBox1.Location = new Point(180, 250);
            textBox2.Visible = true;
            textBox2.Text = "";
            textBox2.BringToFront();
            textBox2.Size = new Size(100, 26);
            textBox2.Location = new Point(180, 430);
            textBox3.Visible = true;
            textBox3.Text = "";
            textBox3.BringToFront();
            textBox3.Size = new Size(100, 26);
            textBox3.Location = new Point(270, 580);
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_12()
        //2 marks, question 12 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem12";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Chemical Changes";
            marksForQuestion.Text = "(2 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "This question is about electrolysis.\nMetal spoons can be coated with silver. This is called electroplating.\nSuggest one reason why spoons are electroplated.";
            mainQuestion.Location = new Point(50, 68);
            richTextBox1.Visible = true;
            richTextBox1.Text = "";
            richTextBox1.BringToFront();
            richTextBox1.Location = new Point(50, 150);
            richTextBox1.Size = new Size(300, 60);
            questionLabel1.Visible = true;
            questionLabel1.BringToFront();
            questionLabel1.Text = "When sodium chloride solution is electrolysed the products are hydrogen and chlorine.\nWhat is made from chlorine?";
            questionLabel1.Location = new Point(50, 220);
            radioButton1.Visible = true;
            radioButton1.Checked = true;
            radioButton1.Text = "Bleach";
            radioButton1.Location = new Point(50, 270);
            radioButton2.Visible = true;
            radioButton2.Text = "Fertilizers";
            radioButton2.Location = new Point(50, 310);
            radioButton3.Visible = true;
            radioButton3.Text = "Soap";
            radioButton3.Location = new Point(50, 350);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel2.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_13()
        //1 mark, question 13 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem13";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Chemical Changes";
            marksForQuestion.Text = "(1 mark)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "The diagram represents the electrolysis cell for extracting aluminium.\nThe current will only flow when the electrolyte is molten.";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic30;
            pictureBox1.Size = new Size(577, 192);
            pictureBox1.Location = new Point(50, 130);
            questionLabel1.Visible = true;
            questionLabel1.Text = "The electrolyte is aluminium oxide mixed with another substance.\nWhat is the name of the other substance in the electrolyte?";
            questionLabel1.BringToFront();
            questionLabel1.Location = new Point(50, 330);
            radioButton1.Visible = true;
            radioButton1.Text = "cryolite";
            radioButton1.BringToFront();
            radioButton1.Checked = true;
            radioButton1.Location = new Point(50, 370);
            radioButton2.Visible = true;
            radioButton2.Text = "rock salt";
            radioButton2.Location = new Point(150, 370);
            radioButton3.Visible = true;
            radioButton3.Text = "limestone";
            radioButton3.Location = new Point(270, 370);
            questionLabel2.Visible = false;            
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_14()
        //1 mark, question 14 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem14";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Chemical Changes";
            marksForQuestion.Text = "(1 mark)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "The diagram represents the electrolysis cell for extracting aluminium.\nThe current will only flow when the electrolyte is molten.";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic30;
            pictureBox1.Size = new Size(577, 192);
            pictureBox1.Location = new Point(50, 130);
            questionLabel1.Visible = true;
            questionLabel1.Text = "The electrolyte is aluminium oxide mixed with another substance.\nSelect the correct option below to complete the sentence:\nThis other substance is added to ____________";
            questionLabel1.BringToFront();
            questionLabel1.Location = new Point(50, 330);
            radioButton1.Visible = true;
            radioButton1.Text = "condense the aluminium oxide";
            radioButton1.BringToFront();
            radioButton1.Checked = true;
            radioButton1.Location = new Point(50, 400);
            radioButton2.Visible = true;
            radioButton2.Text = "lower the melting point of the aluminium oxide";
            radioButton2.Location = new Point(50, 430);
            radioButton3.Visible = true;
            radioButton3.Text = "raise the boiling point of the aluminium oxide";
            radioButton3.Location = new Point(50, 460);
            questionLabel2.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_15()
        //2 marks, question 15 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem15";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Chemical Changes";
            marksForQuestion.Text = "(2 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "The figure below shows magnessium burning in air.";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic31;
            pictureBox1.Size = new Size(180, 289);
            pictureBox1.Location = new Point(50, 90);
            questionLabel1.Visible = true;
            questionLabel1.Text = "a) Look at the figure.\nHow can you tell a reaction is taking place?";
            questionLabel1.BringToFront();
            questionLabel1.Location = new Point(240, 100);
            richTextBox1.Visible = true;
            richTextBox1.Text = "";
            richTextBox1.Location = new Point(240, 150);
            richTextBox1.Size = new Size(260, 80);
            questionLabel2.Visible = true;
            questionLabel2.Text = "b) Name the product from the reaction in the figure.";
            questionLabel2.Location = new Point(240, 240);
            textBox1.Visible = true;
            textBox1.Text = "";
            textBox1.Size = new Size(175, 26);
            textBox1.Location = new Point(240, 270);
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }
        private void Chemistry_Question_16()
        //3 marks, question 16 for chemistry
        {
            AddingMarks();
            questionIdentifier = "Chem16";
            questionsAnswered++;
            lbl_topicReference.Text = "Topic Reference: Chemical Changes";
            marksForQuestion.Text = "(3 marks)";
            mainQuestion.Visible = true;
            mainQuestion.Text = "A student investigated the reaction of copper carbonate with dilute sulfuric acid.\nThe student used the apparatus shown in the figure below.";
            mainQuestion.Location = new Point(50, 68);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic53;
            pictureBox1.Size = new Size(315,130);
            pictureBox1.Location = new Point(50, 120);
            questionLabel1.Visible = true;
            questionLabel1.Text = "a) Complete the state symbols in the equation";
            questionLabel1.BringToFront();
            questionLabel1.Location = new Point(50, 260);
            pictureBox2.Visible = true;
            pictureBox2.Image = Enigma_Learning.Properties.Resources.pic54;
            pictureBox2.Size = new Size(527, 35);
            pictureBox2.Location = new Point(50, 290);
            textBox1.Visible = true;
            textBox1.BringToFront();
            textBox1.Text = "";
            textBox1.Size = new Size(30, 26);
            textBox1.Location = new Point(120, 295);
            textBox2.Visible = true;
            textBox2.BringToFront();
            textBox2.Text = "";
            textBox2.Size = new Size(30, 26);
            textBox2.Location = new Point(456, 295);
            questionLabel2.Visible = true;
            questionLabel2.Text = "b) Why did the balance reading decrease during the reaction?";
            questionLabel2.Location = new Point(50, 330);
            radioButton1.Visible = true;
            radioButton1.Checked = true;
            radioButton1.Text = "The copper carbonate broke down";
            radioButton1.Location = new Point(50, 360);
            radioButton2.Visible = true;
            radioButton2.Location = new Point(50, 390);
            radioButton2.Text = "A salt was produced in the reaction";
            radioButton3.Visible = true;
            radioButton3.Text = "A gas was lost from the flask";
            radioButton3.Location = new Point(50, 420);
            radioButton4.Visible = true;
            radioButton4.Text = "Water was produced in the reaction";
            radioButton4.Location = new Point(50, 450);
            richTextBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            questionLabel3.Visible = false;
            questionLabel4.Visible = false;
            questionLabel5.Visible = false;
            questionLabel6.Visible = false;
        }


        private void Physics_Question_1()
        //question 1 for physics
        {
            
        }
        private void Physics_Question_2()
        //question 2 for physics
        {
            
        }
        private void Physics_Question_3()
        //question 3 for physics
        {
            
        }
        private void Physics_Question_4()
        //question 4 for physics
        {
            
        }
        private void Physics_Question_5()
        //question 5 for physics
        {
            
        }
        private void Physics_Question_6()
        //question 6 for physics
        {
            
        }
        private void Physics_Question_7()
        //question 7 for physics
        {
            
        }
        private void Physics_Question_8()
        //question 8 for physics
        {
            
        }
        private void Physics_Question_9()
        //question 9 for physics
        {
            
        }
        private void Physics_Question_10()
        //question 10 for physics
        {
            
        }


        private void btn_EndTest_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            AddFinalMarks();
            Enigma_Learning.EndofTest endofTest = new Enigma_Learning.EndofTest();
            endofTest.ShowDialog();
            //MessageBox.Show(marksAttained.ToString() + " /  " + totalMarks.ToString());
            Thread.Sleep(750);
            DialogResult message = MessageBox.Show("Would you like to rate your revision and how you feel this test went?", "Rate Your Revision", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Enigma_Learning.Review review = new Enigma_Learning.Review();
                review.ShowDialog();
            }
            Thread.Sleep(500);
            this.Close();
            Startup_Page startUp = new Startup_Page();
            startUp.Show();
        }
        private void AddingMarks()
        {
            switch (Topics.subjectLabels)
            {
                case "Biology":
                    switch (questionIdentifier)
                    {
                        case "Bio1":

                            if (richTextBox1.Text.ToLower().Contains("active transport") == true && richTextBox1.Text.ToLower().Contains("requires energy") == true)
                            {
                                marksAttained++;
                            }
                            if (richTextBox1.Text.ToLower().Contains("from") == true && richTextBox1.Text.ToLower().Contains("respiration") == true)
                            {
                                marksAttained++;
                            }
                            if (richTextBox2.Text.ToLower().Contains("partially permeable") == true || richTextBox2.Text.ToLower().Contains("semi permeable") == true || richTextBox2.Text.ToLower().Contains("selectively permeable") == true)
                            {
                                marksAttained++;
                            }
                            if (richTextBox2.Text.ToLower().Contains("membrane") == true)
                            {
                                marksAttained++;
                            }
                            if (richTextBox2.Text.ToLower().Contains("dilute") == true || richTextBox2.Text.ToLower().Contains("concentrated solution") == true || richTextBox2.Text.ToLower().Contains("from a high concentration of water to a lower concentration") == true || richTextBox2.Text.ToLower().Contains("from high water potential to low water potential") == true || richTextBox2.Text.ToLower().Contains("down a concentration gradient of water") == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Bio2":

                            if (textBox1.Text.ToLower().Contains("carbohydrases") == true)
                            {
                                marksAttained++;
                            }
                            if (richTextBox1.Text.ToLower().Contains("muscular") == true)
                            {
                                marksAttained++;
                            }
                            if ((richTextBox1.Text.ToLower().Contains("push") == true || richTextBox1.Text.ToLower().Contains("pump") == true || richTextBox1.Text.ToLower().Contains("force") == true) && richTextBox1.Text.ToLower().Contains("blood") == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Bio3":
                            if (richTextBox1.Text.ToLower().Contains("fatty deposits") == true || richTextBox1.Text.ToLower().Contains("material in arteries") == true || richTextBox1.Text.ToLower().Contains("material in coronary arteries") == true)
                            {
                                marksAttained++;
                            }
                            if (richTextBox1.Text.ToLower().Contains("narrows") == true || richTextBox1.Text.ToLower().Contains("blocks") == true || richTextBox1.Text.ToLower().Contains("reduces flow") == true)
                            {
                                marksAttained++;
                            }
                            if (richTextBox1.Text.ToLower().Contains("decreases") == true && richTextBox1.Text.ToLower().Contains("oxygen") == true && richTextBox1.Text.ToLower().Contains("supply") == true)
                            {
                                marksAttained++;
                            }
                            if (richTextBox2.Text.ToLower().Contains("enzyme") == true || richTextBox2.Text.ToLower().Contains("protease") == true || richTextBox2.Text.ToLower().Contains("pepsin most effective in acid conditions") == true || richTextBox2.Text.ToLower().Contains("low pH") == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Bio4":
                            if ((richTextBox1.Text.ToLower().Contains("don’t") == true || richTextBox1.Text.ToLower().Contains("do not")) && richTextBox1.Text.ToLower().Contains("kill") == true && (richTextBox1.Text.ToLower().Contains("pathogens") == true || richTextBox1.Text.ToLower().Contains("bacteria") == true || richTextBox1.Text.ToLower().Contains("viruses") == true || richTextBox1.Text.ToLower().Contains("microbes") == true || richTextBox1.Text.ToLower().Contains("microorganisms") == true))
                            {
                                marksAttained++;
                            }
                            if (richTextBox2.Text.ToLower().Contains("kills bacteria") == true || richTextBox2.Text.ToLower().Contains("destroys bacteria") == true)
                            {
                                marksAttained++;
                            }
                            if ((richTextBox2.Text.ToLower().Contains("reduce") == true || richTextBox2.Text.ToLower().Contains("prevent") == true) && richTextBox2.Text.ToLower().Contains("transfer") == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Bio5":
                            if (richTextBox1.Text.ToLower().Contains("white") == true && richTextBox1.Text.ToLower().Contains("blood") == true && richTextBox1.Text.ToLower().Contains("cells") == true && richTextBox1.Text.ToLower().Contains("allow") == true && (richTextBox1.Text.ToLower().Contains("lymphocytes") == true || richTextBox1.Text.ToLower().Contains("leucocytes") == true))
                            {
                                marksAttained += 2;
                            }
                            if (richTextBox1.Text.ToLower().Contains("in future") == true || (richTextBox1.Text.ToLower().Contains("re") == true && richTextBox1.Text.ToLower().Contains("infected") == true && richTextBox1.Text.ToLower().Contains("anti") == true && (richTextBox1.Text.ToLower().Contains("body") == true || richTextBox1.Text.ToLower().Contains("bodies") == true) && (richTextBox1.Text.ToLower().Contains("rapid") == true || richTextBox1.Text.ToLower().Contains("quick") == true || richTextBox1.Text.ToLower().Contains("fast") == true)))
                            {
                                marksAttained++;
                            }
                            break;
                    }
                    break;
                case "Chemistry":
                    switch (questionIdentifier)
                    {
                        case "Chem1":
                            if (radioButton2.Checked == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem2":
                            if (radioButton4.Checked == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem3":
                            if (radioButton5.Checked == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem4":
                            if (radioButton3.Checked == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem5":
                            if (textBox1.Text == "1")
                            {
                                marksAttained++;
                            }
                            if (textBox2.Text == "1/2000" || textBox2.Text == "0")
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem6":
                            if (radioButton2.Checked == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem7":
                            if (textBox1.Text.ToLower() == "neutron")
                            {
                                marksAttained++;
                            }
                            if (textBox2.Text.ToLower() == "electron")
                            {
                                marksAttained++;
                            }
                            if (radioButton2.Checked == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem8":
                            if (textBox1.Text.ToUpper() == "C")
                            {
                                marksAttained++;
                            }
                            if (textBox2.Text.ToUpper() == "B")
                            {
                                marksAttained++;
                            }
                            if (textBox3.Text.ToUpper() == "A")
                            {
                                marksAttained++;
                            }
                            if (textBox4.Text.ToUpper() == "D")
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem9":
                            if (radioButton1.Checked == true)
                            {
                                marksAttained++;
                            }
                            if (textBox1.Text.ToLower() == "shared")
                            {
                                marksAttained++;
                            }
                            if (textBox2.Text.ToLower() == "covalent")
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem10":
                            if (richTextBox1.Text.ToLower().Contains("sodium loses an electron") == true || richTextBox1.Text.ToLower().Contains("loses electron") == true || richTextBox1.Text.ToLower().Contains("loses") == true && richTextBox1.Text.ToLower().Contains("sodium") == true)
                            {
                                marksAttained++;
                            }
                            if (richTextBox1.Text.ToLower().Contains("chlorine gains an electron") == true || richTextBox1.Text.ToLower().Contains("gains electron") == true || richTextBox1.Text.ToLower().Contains("gains") == true && richTextBox1.Text.ToLower().Contains("chlorine") == true)
                            {
                                marksAttained++;
                            }
                            if (richTextBox1.Text.ToLower().Contains("1 electron") == true || richTextBox1.Text.ToLower().Contains("one electron") == true || richTextBox1.Text.ToLower().Contains("an electron") == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem11":
                            if (textBox1.Text.ToLower() == "high")
                            {
                                marksAttained++;
                            }
                            if (textBox2.Text.ToLower() == "hundred")
                            {
                                marksAttained++;
                            }
                            if (textBox3.Text.ToLower() == "hard")
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem12":
                            if (richTextBox1.Text.ToLower().Contains("protection") == true || richTextBox1.Text.ToLower().Contains("improve") == true || richTextBox1.Text.ToLower().Contains("lifespan") == true || richTextBox1.Text.ToLower().Contains("appearance") == true)
                            {
                                marksAttained++;
                            }
                            if (radioButton1.Checked == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem13":
                            if (radioButton1.Checked == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem14":
                            if (radioButton2.Checked == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem15":
                            if (richTextBox1.Text.ToLower().Contains("flame") == true || richTextBox1.Text.ToLower().Contains("energy was given out") == true || richTextBox1.Text.ToLower().Contains("a new substance was formed") == true || richTextBox1.Text.ToLower().Contains("magnessium turned into a white powder") == true || richTextBox1.Text.ToLower().Contains("magnessium turned into a powder") == true)
                            {
                                marksAttained++;
                            }
                            if (textBox1.Text.ToLower().Contains("magnessium oxide") == true)
                            {
                                marksAttained++;
                            }
                            break;
                        case "Chem16":
                            if (textBox1.Text == "s")
                            {
                                marksAttained++;
                            }
                            if (textBox2.Text == "l")
                            {
                                marksAttained++;
                            }
                            if (radioButton3.Checked == true)
                            {
                                marksAttained++;
                            }
                            break;
                    }
                    break;
                case "Physics":

                    break;
            }
        }
        private void AddFinalMarks()
        {
            if (buttonClicked == true)
            {
                switch (Topics.subjectLabels)
                {
                    case "Biology":
                        switch (questionIdentifier)
                        {
                            case "Bio1":

                                if (richTextBox1.Text.ToLower().Contains("active transport") == true && richTextBox1.Text.ToLower().Contains("requires energy") == true)
                                {
                                    marksAttained++;
                                }
                                if (richTextBox1.Text.ToLower().Contains("from") == true && richTextBox1.Text.ToLower().Contains("respiration") == true)
                                {
                                    marksAttained++;
                                }
                                if (richTextBox2.Text.ToLower().Contains("partially permeable") == true || richTextBox2.Text.ToLower().Contains("semi permeable") == true || richTextBox2.Text.ToLower().Contains("selectively permeable") == true)
                                {
                                    marksAttained++;
                                }
                                if (richTextBox2.Text.ToLower().Contains("membrane") == true)
                                {
                                    marksAttained++;
                                }
                                if (richTextBox2.Text.ToLower().Contains("dilute") == true || richTextBox2.Text.ToLower().Contains("concentrated solution") == true || richTextBox2.Text.ToLower().Contains("from a high concentration of water to a lower concentration") == true || richTextBox2.Text.ToLower().Contains("from high water potential to low water potential") == true || richTextBox2.Text.ToLower().Contains("down a concentration gradient of water") == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Bio2":

                                if (textBox1.Text.ToLower().Contains("carbohydrases") == true)
                                {
                                    marksAttained++;
                                }
                                if (richTextBox1.Text.ToLower().Contains("muscular") == true)
                                {
                                    marksAttained++;
                                }
                                if ((richTextBox1.Text.ToLower().Contains("push") == true || richTextBox1.Text.ToLower().Contains("pump") == true || richTextBox1.Text.ToLower().Contains("force") == true) && richTextBox1.Text.ToLower().Contains("blood") == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Bio3":
                                if (richTextBox1.Text.ToLower().Contains("fatty deposits") == true || richTextBox1.Text.ToLower().Contains("material in arteries") == true || richTextBox1.Text.ToLower().Contains("material in coronary arteries") == true)
                                {
                                    marksAttained++;
                                }
                                if (richTextBox1.Text.ToLower().Contains("narrows") == true || richTextBox1.Text.ToLower().Contains("blocks") == true || richTextBox1.Text.ToLower().Contains("reduces flow") == true)
                                {
                                    marksAttained++;
                                }
                                if (richTextBox1.Text.ToLower().Contains("decreases") == true && richTextBox1.Text.ToLower().Contains("oxygen") == true && richTextBox1.Text.ToLower().Contains("supply") == true)
                                {
                                    marksAttained++;
                                }
                                if (richTextBox2.Text.ToLower().Contains("enzyme") == true || richTextBox2.Text.ToLower().Contains("protease") == true || richTextBox2.Text.ToLower().Contains("pepsin most effective in acid conditions") == true || richTextBox2.Text.ToLower().Contains("low pH") == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Bio4":
                                if ((richTextBox1.Text.ToLower().Contains("don’t") == true || richTextBox1.Text.ToLower().Contains("do not")) && richTextBox1.Text.ToLower().Contains("kill") == true && (richTextBox1.Text.ToLower().Contains("pathogens") == true || richTextBox1.Text.ToLower().Contains("bacteria") == true || richTextBox1.Text.ToLower().Contains("viruses") == true || richTextBox1.Text.ToLower().Contains("microbes") == true || richTextBox1.Text.ToLower().Contains("microorganisms") == true))
                                {
                                    marksAttained++;
                                }
                                if (richTextBox2.Text.ToLower().Contains("kills bacteria") == true || richTextBox2.Text.ToLower().Contains("destroys bacteria") == true)
                                {
                                    marksAttained++;
                                }
                                if ((richTextBox2.Text.ToLower().Contains("reduce") == true || richTextBox2.Text.ToLower().Contains("prevent") == true) && richTextBox2.Text.ToLower().Contains("transfer") == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Bio5":
                                if (richTextBox1.Text.ToLower().Contains("white") == true && richTextBox1.Text.ToLower().Contains("blood") == true && richTextBox1.Text.ToLower().Contains("cells") == true && richTextBox1.Text.ToLower().Contains("allow") == true && (richTextBox1.Text.ToLower().Contains("lymphocytes") == true || richTextBox1.Text.ToLower().Contains("leucocytes") == true))
                                {
                                    marksAttained += 2;
                                }
                                if (richTextBox1.Text.ToLower().Contains("in future") == true || (richTextBox1.Text.ToLower().Contains("re") == true && richTextBox1.Text.ToLower().Contains("infected") == true && richTextBox1.Text.ToLower().Contains("anti") == true && (richTextBox1.Text.ToLower().Contains("body") == true || richTextBox1.Text.ToLower().Contains("bodies") == true) && (richTextBox1.Text.ToLower().Contains("rapid") == true || richTextBox1.Text.ToLower().Contains("quick") == true || richTextBox1.Text.ToLower().Contains("fast") == true)))
                                {
                                    marksAttained++;
                                }
                                break;
                        }
                        break;
                    case "Chemistry":
                        switch (questionIdentifier)
                        {
                            case "Chem1":
                                if (radioButton2.Checked == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem2":
                                if (radioButton4.Checked == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem3":
                                if (radioButton5.Checked == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem4":
                                if (radioButton3.Checked == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem5":
                                if (textBox1.Text == "1")
                                {
                                    marksAttained++;
                                }
                                if (textBox2.Text == "1/2000" || textBox2.Text == "0")
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem6":
                                if (radioButton2.Checked == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem7":
                                if (textBox1.Text.ToLower() == "neutron")
                                {
                                    marksAttained++;
                                }
                                if (textBox2.Text.ToLower() == "electron")
                                {
                                    marksAttained++;
                                }
                                if (radioButton2.Checked == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem8":
                                if (textBox1.Text.ToUpper() == "C")
                                {
                                    marksAttained++;
                                }
                                if (textBox2.Text.ToUpper() == "B")
                                {
                                    marksAttained++;
                                }
                                if (textBox3.Text.ToUpper() == "A")
                                {
                                    marksAttained++;
                                }
                                if (textBox4.Text.ToUpper() == "D")
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem9":
                                if (radioButton1.Checked == true)
                                {
                                    marksAttained++;
                                }
                                if (textBox1.Text.ToLower() == "shared")
                                {
                                    marksAttained++;
                                }
                                if (textBox2.Text.ToLower() == "covalent")
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem10":
                                if (richTextBox1.Text.ToLower().Contains("sodium loses an electron") == true || richTextBox1.Text.ToLower().Contains("loses electron") == true || richTextBox1.Text.ToLower().Contains("loses") == true && richTextBox1.Text.ToLower().Contains("sodium") == true)
                                {
                                    marksAttained++;
                                }
                                if (richTextBox1.Text.ToLower().Contains("chlorine gains an electron") == true || richTextBox1.Text.ToLower().Contains("gains electron") == true || richTextBox1.Text.ToLower().Contains("gains") == true && richTextBox1.Text.ToLower().Contains("chlorine") == true)
                                {
                                    marksAttained++;
                                }
                                if (richTextBox1.Text.ToLower().Contains("1 electron") == true || richTextBox1.Text.ToLower().Contains("one electron") == true || richTextBox1.Text.ToLower().Contains("an electron") == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem11":
                                if (textBox1.Text.ToLower() == "high")
                                {
                                    marksAttained++;
                                }
                                if (textBox2.Text.ToLower() == "hundred")
                                {
                                    marksAttained++;
                                }
                                if (textBox3.Text.ToLower() == "hard")
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem12":
                                if (richTextBox1.Text.ToLower().Contains("protection") == true || richTextBox1.Text.ToLower().Contains("improve") == true || richTextBox1.Text.ToLower().Contains("lifespan") == true || richTextBox1.Text.ToLower().Contains("appearance") == true)
                                {
                                    marksAttained++;
                                }
                                if (radioButton1.Checked == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem13":
                                if (radioButton1.Checked == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem14":
                                if (radioButton2.Checked == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem15":
                                if (richTextBox1.Text.ToLower().Contains("flame") == true || richTextBox1.Text.ToLower().Contains("energy was given out") == true || richTextBox1.Text.ToLower().Contains("a new substance was formed") == true || richTextBox1.Text.ToLower().Contains("magnessium turned into a white powder") == true || richTextBox1.Text.ToLower().Contains("magnessium turned into a powder") == true)
                                {
                                    marksAttained++;
                                }
                                if (textBox1.Text.ToLower().Contains("magnessium oxide") == true)
                                {
                                    marksAttained++;
                                }
                                break;
                            case "Chem16":
                                if (textBox1.Text == "s")
                                {
                                    marksAttained++;
                                }
                                if (textBox2.Text == "l")
                                {
                                    marksAttained++;
                                }
                                if (radioButton3.Checked == true)
                                {
                                    marksAttained++;
                                }
                                break;
                        }
                        break;
                    case "Physics":

                        break;
                }
            }
        }

        private void btn_NextQuestion_Click(object sender, EventArgs e)
        {
            allQuestions--;
            ChoosingQuestion();
        }
        private void RandomQuestion_Biology()
            //this chooses random questions for biology
        {
            bool exists1 = false;//i just realised that unlike the console application, when ever a number has been generated, 
            //if it can't find it in the list nothing will happen as the process won't repeat itself, so I'll put it in a
            //do-while loop so that it repeats if the number isn't present. I can't use a number because the user may quit the
            //test before they have answered all the questions. I could use a discounter with the total number of questions and
            //it will reduce every single time the next button is pressed, so once it's on zero, the button will be disabled to
            //avoid any crashes in the program.
            do
            {
                Random rnd = new Random();
                biologyQuestionNo = rnd.Next(1, 6);//this generates a random number from 1 to 10 (i will edit it in the course
                                                      //of this program.
                if (biologyQuestions.Contains(biologyQuestionNo) == true)//this checks if the number is present in the list, as it may
                                                                             //have removed it earlier when the number was generated
                {
                    exists1 = true;//if it finds the number
                    switch (biologyQuestionNo)//this switches the number instances
                    {
                        case 1:
                            Biology_Question_1();//if number 1 was generated
                            biologyQuestions.Remove(1);//this removes 1 from the list so that it the question doesn't repeatedly appear
                            break;
                        case 2:
                            Biology_Question_2();//if number 2 was generated
                            biologyQuestions.Remove(2);//this removes 2 from the list so the question isn't shown again
                            break;
                        case 3:
                            Biology_Question_3();//if number 3 was generated
                            biologyQuestions.Remove(3);//this removes 3 from the list so the question isn't shown again
                            break;
                        case 4:
                            Biology_Question_4();//if number 4 was generated
                            biologyQuestions.Remove(4);//this removes 4 from the list so the question isn't shown again
                            break;
                        case 5:
                            Biology_Question_5();//if number 5 was generated
                            biologyQuestions.Remove(5);//this removes 5 from the list so that it the question doesn't repeatedly appear
                            break;

                    }
                }
                else
                {
                    exists1 = false;
                }
            } while (exists1 == false);
        }
        private void RandomQuestion_Chemistry()
            //this chooses random questions for chemistry
        {
            //Chemistry_Question_10();//this is just temporary, will remove this later
            bool exists = false;//i just realised that unlike the console application, when ever a number has been generated, 
            //if it can't find it in the list nothing will happen as the process won't repeat itself, so I'll put it in a
            //do-while loop so that it repeats if the number isn't present. I can't use a number because the user may quit the
            //test before they have answered all the questions. I could use a discounter with the total number of questions and
            //it will reduce every single time the next button is pressed, so once it's on zero, the button will be disabled to
            //avoid any crashes in the program.
            do
            {
                Random rnd = new Random();
                chemistryQuestionNo = rnd.Next(1, 17);//this generates a random number from 1 to 10 (i will edit it in the course
                                                      //of this program.
                if (chemistryQuestions.Contains(chemistryQuestionNo) == true)//this checks if the number is present in the list, as it may
                                                                             //have removed it earlier when the number was generated
                {
                    exists = true;//if it finds the number
                    switch (chemistryQuestionNo)//this switches the number instances
                    {
                        case 1:
                            Chemistry_Question_1();//if number 1 was generated
                            chemistryQuestions.Remove(1);//this removes 1 from the list so that it the question doesn't repeatedly appear
                            break;
                        case 2:
                            Chemistry_Question_2();//if number 2 was generated
                            chemistryQuestions.Remove(2);//this removes 2 from the list so the question isn't shown again
                            break;
                        case 3:
                            Chemistry_Question_3();//if number 3 was generated
                            chemistryQuestions.Remove(3);//this removes 3 from the list so the question isn't shown again
                            break;
                        case 4:
                            Chemistry_Question_4();//if number 4 was generated
                            chemistryQuestions.Remove(4);//this removes 4 from the list so the question isn't shown again
                            break;
                        case 5:
                            Chemistry_Question_5();//if number 5 was generated
                            chemistryQuestions.Remove(5);//this removes 5 from the list so that it the question doesn't repeatedly appear
                            break;
                        case 6:
                            Chemistry_Question_6();//if number 6 was generated
                            chemistryQuestions.Remove(6);//this removes 6 from the list so the question isn't shown again
                            break;
                        case 7:
                            Chemistry_Question_7();//if number 7 was generated
                            chemistryQuestions.Remove(7);//this removes 7 from the list so the question isn't shown again
                            break;
                        case 8:
                            Chemistry_Question_8();//if number 8 was generated
                            chemistryQuestions.Remove(8);//this removes 8 from the list so the question isn't shown again
                            break;
                        case 9:
                            Chemistry_Question_9();//if number 9 was generated
                            chemistryQuestions.Remove(9);//this removes 9 from the list so the question isn't shown again
                            break;
                        case 10:
                            Chemistry_Question_10();//if number 10 was generated
                            chemistryQuestions.Remove(10);//this removes 10 from the list so the question isn't shown again
                            break;
                        case 11:
                            Chemistry_Question_11();//if number 11 was generated
                            chemistryQuestions.Remove(11);//removes 11 from the list so the question doesn't show again
                            break;
                        case 12:
                            Chemistry_Question_12();//if number 12 was generated
                            chemistryQuestions.Remove(12);//removes 12 from the list so the question doesn't show again
                            break;
                        case 13:
                            Chemistry_Question_13();//if number 13 was generated
                            chemistryQuestions.Remove(13);//removes 12 from the list so the question doesn't show again
                            break;
                        case 14:
                            Chemistry_Question_14();//if number 14 was generated
                            chemistryQuestions.Remove(14);
                            break;
                        case 15:
                            Chemistry_Question_15();//if number 15 was generated, yadayadayadayada
                            chemistryQuestions.Remove(15);
                            break;
                        case 16:
                            Chemistry_Question_16();//if number 16 was generated, yadayadayada
                            chemistryQuestions.Remove(16);
                            break;
                    }
                }
                else
                {
                    exists = false;
                }
            } while (exists == false);
        }

        private void RandomQuestion_Physics()
            //this chooses random questions for physics
        {
            bool exists2 = false;//i just realised that unlike the console application, when ever a number has been generated, 
            //if it can't find it in the list nothing will happen as the process won't repeat itself, so I'll put it in a
            //do-while loop so that it repeats if the number isn't present. I can't use a number because the user may quit the
            //test before they have answered all the questions. I could use a discounter with the total number of questions and
            //it will reduce every single time the next button is pressed, so once it's on zero, the button will be disabled to
            //avoid any crashes in the program.
            do
            {
                Random rnd = new Random();
                physicsQuestionNo = rnd.Next(1, 11);//this generates a random number from 1 to 10 (i will edit it in the course
                                                      //of this program.
                if (physicsQuestions.Contains(physicsQuestionNo) == true)//this checks if the number is present in the list, as it may
                                                                             //have removed it earlier when the number was generated
                {
                    exists2 = true;//if it finds the number
                    switch (physicsQuestionNo)//this switches the number instances
                    {
                        case 1:
                            Physics_Question_1();//if number 1 was generated
                            physicsQuestions.Remove(1);//this removes 1 from the list so that it the question doesn't repeatedly appear
                            break;
                        case 2:
                            Physics_Question_2();//if number 2 was generated
                            physicsQuestions.Remove(2);//this removes 2 from the list so the question isn't shown again
                            break;
                        case 3:
                            Physics_Question_3();//if number 3 was generated
                            physicsQuestions.Remove(3);//this removes 3 from the list so the question isn't shown again
                            break;
                        case 4:
                            Physics_Question_4();//if number 4 was generated
                            physicsQuestions.Remove(4);//this removes 4 from the list so the question isn't shown again
                            break;
                        case 5:
                            Physics_Question_5();//if number 5 was generated
                            physicsQuestions.Remove(5);//this removes 5 from the list so that it the question doesn't repeatedly appear
                            break;
                        case 6:
                            Physics_Question_6();//if number 6 was generated
                            physicsQuestions.Remove(6);//this removes 6 from the list so the question isn't shown again
                            break;
                        case 7:
                            Physics_Question_7();//if number 7 was generated
                            physicsQuestions.Remove(7);//this removes 7 from the list so the question isn't shown again
                            break;
                        case 8:
                            Physics_Question_8();//if number 8 was generated
                            physicsQuestions.Remove(8);//this removes 8 from the list so the question isn't shown again
                            break;
                        case 9:
                            Physics_Question_9();//if number 9 was generated
                            physicsQuestions.Remove(9);//this removes 9 from the list so the question isn't shown again
                            break;
                        case 10:
                            Physics_Question_10();//if number 10 was generated
                            physicsQuestions.Remove(10);//this removes 10 from the list so the question isn't shown again
                            break;
                    }
                }
                else
                {
                    exists2 = false;
                }
            } while (exists2 == false);
        }


        private void ChoosingQuestion()
            //this is to randomly choose questions depending on what the subject is.
            //it is to be called whenever the "next" button is pressed or whenever the form loads
        {
            if (allQuestions == 0)
            {
                btn_NextQuestion.Enabled = false;
            }
            switch (Topics.subjectLabels)
            {
                case "Biology"://if the subject selected earlier was biology
                    totalMarks = 18;//this is where the total marks of the question will be initialized.
                    //will change this during the course of making this program
                    //allQuestions = 10;//this is where the total number of questions will be initialized.
                    //will change during the course of making this program
                    this.Text = "Biology Exam Questions";//the text as shown on the form
                    RandomQuestion_Biology();//calls the procedure to randomly select a question on biology
                    break;
                case "Chemistry"://if the subject selected earlier was chemistry
                    totalMarks = 32;//this is where the total marks of the question will be initialized.
                    //will change this during the course of making this program
                    this.Text = "Chemistry Exam Questions";//the text as shown on the form
                    RandomQuestion_Chemistry();//calls this procedure to randomly select a question on chemistry
                    break;
                case "Physics"://if the subject selected earlier was physics
                    totalMarks = 10;//this is where the total marks of the question will be initialized.
                    //will change this during the course of making this program
                    //allQuestions = 10;//this is where the total number of questions will be initialized.
                    //will change during the course of making this program
                    this.Text = "Physics Exam Questions";//the text as shown on the form
                    RandomQuestion_Physics();//calls this procedure to randomly select a question on physics
                    break;
            }
        }
    }
}
/*
 * When adding a new question, stuff to change:
 * 1. random number generator
 * 2. add a new number to the list in this form and the startup page form
 * 3. change total marks
 * 4. change total questions
 * 5. add the new question identifier in the AddingMarks() and AddFinalMarks() procedures
 */
