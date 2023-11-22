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

namespace Enigma_Learning
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("That's great! Keep up the good work and the good spirit! Always be proud of " +
                    "your achievements, because the little victories can take you to even bigger ones!", "Great!", MessageBoxButtons.OK, MessageBoxIcon.None); ;
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("That's not so bad, at least it's better than nothing. Keep on practicing on your " +
                    "skills until you're very confident of yourself. Try and try again until you get it right!", "Okay", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("Aww, too bad you couldn't perform at your very best! But however, as you rightly " +
                    "said, this can be improved. Anything can be improved! Just don't take failure too much to heart, " +
                    "but instead learn from it and move on, because what you're unsuccesful at today, you could do " +
                    "much better tomorrow!", "Can be Improved", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            Thread.Sleep(750);
            this.Close();
        }
    }
}
