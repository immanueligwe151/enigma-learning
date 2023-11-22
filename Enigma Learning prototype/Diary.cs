using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Enigma_Learning_prototype
{
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }
        public string userInput { get; set; }
        public bool SaveFile { get; set; }
        public string FileContent { get; set; }
        public string OurReply { get; set; }
        public DateTime Now()
        {
            DateTime Time = DateTime.Now;
            Time.ToString("dddd, dd MMMM yyyy");
            return Time;
        }
        class Keywords
        {
            public string Day;
            public List<string> Positive = new List<string>{ "okay", "not bad", "best day of my life", "good", "terrific", "great", "wonderful", "marvellous", "fantastic", "superb", "alright", "boring", "isn't going so great" };
            public List<string> Negative = new List<string>{ "terrible", "bad", "horrible", "horrific", "ugly", "hated", "worse", "most terrible thing happened", "worst", "gross", "death", "suicide", "boring", "isn't going so great", "fear", "afraid", "okay" };
        }
        class Messages
        {
            public string Good = "That's great! It's always difficult to have such great moments, so ensure to cherish them and those good feelings, " +
                                            "so that whenever you feel down, you can always look back to when things were going great and you hadn't a" +
                                            " care in this world.";
            public string Bad = "Aww, too bad things didn't go/aren't going too well for you. We all have our bad times, and there are sometimes not much we can " +
                                   "really do about them. However, the best thing you can do is to forget about how bad things went and think of the positive. " +
                                   "You can also try talking to people you trust: friends, families, anyone you can confide in to feel better. Thinking positive is really " +
                                   "important because if we don't think positive and focus more on the bad, then we will have a falling out with ourselves and possibly even worsen " +
                                   "our situation, or miss out on the good parts of life.";
            public string GoodBad = "That's good, at least it's not too bad. But that's just life. There are good moments and" +
                               " bad moments. If we make the most of our good moments and not think of the bad times, we will always find ourselves smiling." +
                               " Don't be too upset about the bad times, but however focus on helping yourself think more positively.";
            public string Nothing = "Sorry, looks like that input is invalid. Please be more clear on what you say.";
        }
        class Found
        {
            public bool FoundGood = false;
            public bool FoundBad = false;
            public bool FoundNothing = false;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            Keywords Words = new Keywords();
            Messages Message = new Messages();
            Found IfFound = new Found();
            string Input;
            Words.Day = Day_Description.Text;
            Input = Words.Day.ToLower();
            foreach (string good in Words.Positive)
            {
                foreach (string bad in Words.Negative)
                {
                    if (Input.Contains(good) == true)
                    {
                        IfFound.FoundGood = true;
                    }
                    else if (Input.Contains(bad) == true)
                    {
                        IfFound.FoundBad = true;
                    }
                    else
                    {
                        IfFound.FoundNothing = true;
                    }
                }
            }
            if (IfFound.FoundGood == true && IfFound.FoundBad == true)
            {
                MessageBox.Show(Message.GoodBad, "Could have been better tho...");
                this.SaveFile = true;
                this.userInput = Words.Day;
                this.OurReply = Message.GoodBad;
            }
            else if (IfFound.FoundGood == true)
            {
                MessageBox.Show(Message.Good, "Great! :)");
                this.SaveFile = true;
                this.userInput = Words.Day;
                this.OurReply = Message.Good;
            }
            else if (IfFound.FoundBad == true)
            {
                MessageBox.Show(Message.Bad, "Oh no, that's not good... :(");
                this.SaveFile = true;
                this.userInput = Words.Day;
                this.OurReply = Message.Bad;
            }
            else if (IfFound.FoundNothing == true)
            {
                MessageBox.Show(Message.Nothing, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.SaveFile = false;
                this.userInput = null;
            }
            if (this.SaveFile == true && this.userInput != null)
            {
                this.FileContent = "Diary entry created on " + this.Now() + ":\n\nYour entry: " + this.userInput + "\n\nOur reply: " + this.OurReply;
            }
        }

        private void btn_SaveEntry_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            if (this.SaveFile == true && this.userInput != null)
            {
                DialogResult Message = MessageBox.Show("Do you want to save your entry?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Message == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    string fileName = saveFileDialog1.FileName;
                    File.WriteAllText(fileName, this.FileContent);
                    this.SaveFile = false;
                    this.userInput = null;
                    this.OurReply = null;
                }
                else
                {
                    this.SaveFile = false;
                    this.userInput = null;
                    this.OurReply = null;
                }
                this.SaveFile = false;
                this.userInput = null;
                this.OurReply = null;
            }
            else
            {
                MessageBox.Show("Please input in something valid and press 'Done' before saving.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Do you really want to leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (message == DialogResult.Yes)
            {
                this.Close();
                Moodlet moodletHome = new Moodlet();
                moodletHome.Show();
            }
        }
    }
}
