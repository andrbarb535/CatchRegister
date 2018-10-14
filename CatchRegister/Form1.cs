using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CatchRegister
{
    public partial class catchRegister : Form
    {

        double sum, difference, product, quotient;
        string mode = "happy";

        public catchRegister()
        {
            InitializeComponent();
        }

        private void catchRegister_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            backImage.Visible = true;
        }

        private void firstFlowerPot_Click(object sender, EventArgs e)
        {

        }

        private void secondFlowerPot_Click(object sender, EventArgs e)
        {

        }

        private void wateringCan_Click(object sender, EventArgs e)
        {

        }

        private void bag_Click(object sender, EventArgs e)
        {

        }

        private void crazyDaveSpeechBubble_Click(object sender, EventArgs e)
        {
            if (mode == "happy")
            {
                mode = "sad";
                crazyDaveSpeechBubble.Text = "I'm Crazy Dave!";

            }
            else if (mode == "sad")
            {
                mode = "angry";
                crazyDaveSpeechBubble.Text = "My Prices are Crazy!";
            }
            else
            {
                mode = "happy";
                crazyDaveSpeechBubble.Text = "Why? \n Because I'm Crazy!";
            }
        }

        private void next_Click(object sender, EventArgs e)
        {

        }

        private void prev_Click(object sender, EventArgs e)
        {

        }

        private void thirdFlowerPot_Click(object sender, EventArgs e)
        {

        }

        private void licencePlate_Click(object sender, EventArgs e)
        {

        }

        private void sprayBottle_Click(object sender, EventArgs e)
        {

        }

        private void recordPlayer_Click(object sender, EventArgs e)
        {

        }

        private void glove_Click(object sender, EventArgs e)
        {

        }
    }
}
