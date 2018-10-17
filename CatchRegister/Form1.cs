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

            /*g.DrawRectangle(drawPen, 1000, 60, 100, 100);
            g.FillRectangle(drawBrush, 1000, 60, 100, 100);
            this.Refresh();*/

            string I;
            string II;
            string III;
            string IV;

            Random randGenI = new Random();

            string[] l = new string[26];
            l[0] = "A";
            l[1] = "B";
            l[2] = "C";
            l[3] = "D";
            l[4] = "E";
            l[5] = "F";
            l[6] = "G";
            l[7] = "H";
            l[8] = "I";
            l[9] = "J";
            l[10] = "K";
            l[11] = "L";
            l[12] = "M";
            l[13] = "N";
            l[14] = "O";
            l[15] = "P";
            l[16] = "Q";
            l[17] = "R";
            l[18] = "S";
            l[19] = "T";
            l[20] = "U";
            l[21] = "V";
            l[22] = "W";
            l[23] = "X";
            l[24] = "Y";
            l[25] = "Z";

            int ALetter = randGenI.Next(0, 26);
            I = l[ALetter];

            int BLetter = randGenI.Next(0, 26);
            II = l[BLetter];

            int CLetter = randGenI.Next(0, 26);
            III = l[CLetter];

            int DLetter = randGenI.Next(0, 26);
            IV = l[DLetter];

            licencePlate.Text = (I + II + III + IV);

            //random letters

            Random randGenII = new Random();

            string[] n = new string[10];
            n[0] = "0";
            n[1] = "1";
            n[2] = "2";
            n[3] = "3";
            n[4] = "4";
            n[5] = "5";
            n[6] = "6";
            n[7] = "7";
            n[8] = "8";
            n[9] = "9";

            int ANumber = randGenII.Next(0, 10);
            I = n[ANumber];

            int BNumber = randGenII.Next(0, 10);
            II = n[BNumber];

            int CNumber = randGenII.Next(0, 10);
            III = n[CNumber];

            licencePlate.Text += " " + (I + II + III);

            //random numbers
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
            this.Refresh();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void thirdFlowerPot_Click(object sender, EventArgs e)
        {

        }

        private void licencePlate_Click(object sender, EventArgs e)
        {
            string I;
            string II;
            string III;
            string IV;

            Random randGenI = new Random();

            string[] l = new string[26];
            l[0] = "A";
            l[1] = "B";
            l[2] = "C";
            l[3] = "D";
            l[4] = "E";
            l[5] = "F";
            l[6] = "G";
            l[7] = "H";
            l[8] = "I";
            l[9] = "J";
            l[10] = "K";
            l[11] = "L";
            l[12] = "M";
            l[13] = "N";
            l[14] = "O";
            l[15] = "P";
            l[16] = "Q";
            l[17] = "R";
            l[18] = "S";
            l[19] = "T";
            l[20] = "U";
            l[21] = "V";
            l[22] = "W";
            l[23] = "X";
            l[24] = "Y";
            l[25] = "Z";

            int ALetter = randGenI.Next(0, 26);
            I = l[ALetter];

            int BLetter = randGenI.Next(0, 26);
            II = l[BLetter];

            int CLetter = randGenI.Next(0, 26);
            III = l[CLetter];

            int DLetter = randGenI.Next(0, 26);
            IV = l[DLetter];

            licencePlate.Text = (I + II + III + IV);

            //random letters

            Random randGenII = new Random();

            string[] n = new string[10];
            n[0] = "0";
            n[1] = "1";
            n[2] = "2";
            n[3] = "3";
            n[4] = "4";
            n[5] = "5";
            n[6] = "6";
            n[7] = "7";
            n[8] = "8";
            n[9] = "9";

            int ANumber = randGenII.Next(0, 10);
            I = n[ANumber];

            int BNumber = randGenII.Next(0, 10);
            II = n[BNumber];

            int CNumber = randGenII.Next(0, 10);
            III = n[CNumber];

            licencePlate.Text += " " + (I + II + III);
        }

        private void backImage_Click(object sender, EventArgs e)
        {

        }

        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {
            //variables
            int flowerPotCost = 2500;
            int wateringCanCost = 10000;
            int bagCost = 750;
            int sprayBottleCost = 1000;
            int recordPlayerCost = 15000;
            int gloveCost = 1000;
            double numberFlowerPot, numberWateringCan, numberBag, numberSprayBottle, numberRecordPlayer, numberGlove;
            double HST = 0.13;
            double flowerPotProduct, wateringCanProduct, bagProduct, sprayBottleProduct, recordPlayerProduct, gloveProduct;
            double sum, difference, product, quotient;
            double subTotalNumber, taxNumber, totalNumber;

            try
            {
                //input

                //text to numbers
                numberFlowerPot = Convert.ToInt16(flowerPotTextBox.Text);
                numberWateringCan = Convert.ToInt16(wateringCanTextBox.Text);
                numberBag = Convert.ToInt16(bagOfFertilizerTextBox.Text);
                numberSprayBottle = Convert.ToInt16(sprayBottleTextBox.Text);
                numberRecordPlayer = Convert.ToInt16(recordPlayerTextBox.Text);
                numberGlove = Convert.ToInt16(gloveTextBox.Text);


                //calculations
                flowerPotProduct = numberFlowerPot * flowerPotCost;
                wateringCanProduct = numberWateringCan * wateringCanCost;
                bagProduct = numberBag * bagCost;
                sprayBottleProduct = numberSprayBottle * sprayBottleCost;
                recordPlayerProduct = numberRecordPlayer * recordPlayerCost;
                gloveProduct = numberGlove * gloveCost;

                subTotalNumber = flowerPotProduct + wateringCanProduct + bagProduct + sprayBottleProduct + recordPlayerProduct + gloveProduct;

                //output
                subTotal.Text = subTotalNumber.ToString("C");

                //input

                //calculations
                taxNumber = subTotalNumber * HST;

                //output
                tax.Text = taxNumber.ToString("C");

                //input

                //calculations
                totalNumber = subTotalNumber + taxNumber;

                //output
                total.Text = totalNumber.ToString("C");
            }
            catch
            {
                    subTotal.Text = "Enter numerical values only!";
                    tax.Text = "Enter numerical values only!";
                    total.Text = "Enter numerical values only!";
            }
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            //variables
            int flowerPotCost = 2500;
            int wateringCanCost = 10000;
            int bagCost = 750;
            int sprayBottleCost = 1000;
            int recordPlayerCost = 15000;
            int gloveCost = 1000;
            double numberFlowerPot, numberWateringCan, numberBag, numberSprayBottle, numberRecordPlayer, numberGlove, numberTendered;
            double HST = 0.13;
            double flowerPotProduct, wateringCanProduct, bagProduct, sprayBottleProduct, recordPlayerProduct, gloveProduct;
            double tenderedDifference;
            double sum, difference, product, quotient;
            double subTotalNumber, taxNumber, totalNumber;
            double changeNumber;

            try
            {
                //input

                //text to numbers
                numberFlowerPot = Convert.ToInt16(flowerPotTextBox.Text);
                numberWateringCan = Convert.ToInt16(wateringCanTextBox.Text);
                numberBag = Convert.ToInt16(bagOfFertilizerTextBox.Text);
                numberSprayBottle = Convert.ToInt16(sprayBottleTextBox.Text);
                numberRecordPlayer = Convert.ToInt16(recordPlayerTextBox.Text);
                numberGlove = Convert.ToInt16(gloveTextBox.Text);
                numberTendered = Convert.ToInt32(tenderedTextBox.Text);


                //calculations
                flowerPotProduct = numberFlowerPot * flowerPotCost;
                wateringCanProduct = numberWateringCan * wateringCanCost;
                bagProduct = numberBag * bagCost;
                sprayBottleProduct = numberSprayBottle * sprayBottleCost;
                recordPlayerProduct = numberRecordPlayer * recordPlayerCost;
                gloveProduct = numberGlove * gloveCost;

                subTotalNumber = flowerPotProduct + wateringCanProduct + bagProduct + sprayBottleProduct + recordPlayerProduct + gloveProduct;

                //input

                //calculations
                taxNumber = subTotalNumber * HST;

                //input

                //calculations
                totalNumber = subTotalNumber + taxNumber;

                //calculations
                changeNumber = numberTendered - totalNumber;

                //output
                change.Text = changeNumber.ToString("C");
            }
            catch
            {
                change.Text = "Enter numerical values only!";
            }
        }

        private void printRecipt_Click(object sender, EventArgs e)
        {
            string I;
            string II;
            string III;
            string IV;
            double orderNumber;

            Random randGenII = new Random();

            string[] n = new string[10];
            n[0] = "0";
            n[1] = "1";
            n[2] = "2";
            n[3] = "3";
            n[4] = "4";
            n[5] = "5";
            n[6] = "6";
            n[7] = "7";
            n[8] = "8";
            n[9] = "9";

            int ANumber = randGenII.Next(0, 10);
            I = n[ANumber];

            int BNumber = randGenII.Next(0, 10);
            II = n[BNumber];

            int CNumber = randGenII.Next(0, 10);
            III = n[CNumber];

            int DNumber = randGenII.Next(0, 10);
            IV = n[DNumber];

            //output label
            recieptTitle.Text = "Crazy Dave's Twinkie Dinkies.";
            reciept.Text = "\n\n\n" + "Order Number" + "                                                         " + (I + II + III + IV);
            reciept.Text += "\n\n";

            //variables
            int flowerPotCost = 2500;
            int wateringCanCost = 10000;
            int bagCost = 750;
            int sprayBottleCost = 1000;
            int recordPlayerCost = 15000;
            int gloveCost = 1000;
            double numberFlowerPot, numberWateringCan, numberBag, numberSprayBottle, numberRecordPlayer, numberGlove;
            double HST = 0.13;
            double flowerPotProduct, wateringCanProduct, bagProduct, sprayBottleProduct, recordPlayerProduct, gloveProduct;
            double sum, difference, product, quotient;
            double subTotalNumber, taxNumber, totalNumber;

            try
            {
                //input

                //text to numbers
                numberFlowerPot = Convert.ToInt16(flowerPotTextBox.Text);
                numberWateringCan = Convert.ToInt16(wateringCanTextBox.Text);
                numberBag = Convert.ToInt16(bagOfFertilizerTextBox.Text);
                numberSprayBottle = Convert.ToInt16(sprayBottleTextBox.Text);
                numberRecordPlayer = Convert.ToInt16(recordPlayerTextBox.Text);
                numberGlove = Convert.ToInt16(gloveTextBox.Text);


                //calculations
                flowerPotProduct = numberFlowerPot * flowerPotCost;
                wateringCanProduct = numberWateringCan * wateringCanCost;
                bagProduct = numberBag * bagCost;
                sprayBottleProduct = numberSprayBottle * sprayBottleCost;
                recordPlayerProduct = numberRecordPlayer * recordPlayerCost;
                gloveProduct = numberGlove * gloveCost;

                subTotalNumber = flowerPotProduct + wateringCanProduct + bagProduct + sprayBottleProduct + recordPlayerProduct + gloveProduct;

                //output
                reciept.Text = "\n\n\nFlower Pots";
                recieptCosts.Text = "x" + numberFlowerPot.ToString() + " @        " + flowerPotCost.ToString("C");
                reciept.Text += "\n\nWatering Cans";
                recieptCosts.Text += "\n\nx" + numberWateringCan.ToString() + " @      " + wateringCanCost.ToString("C");
                reciept.Text += "\n\nBags of Fertilizer";
                recieptCosts.Text += "\n\nx" + numberBag.ToString() + " @           " + bagCost.ToString("C");
                reciept.Text += "\n\nSpray Bottles";
                recieptCosts.Text += "\n\nx" + numberSprayBottle.ToString() + " @        " + sprayBottleCost.ToString("C");
                reciept.Text += "\n\nRecord Players";
                recieptCosts.Text += "\n\nx" + numberRecordPlayer.ToString() + " @      " + recordPlayerCost.ToString("C");
                reciept.Text += "\n\nGloves";
                recieptCosts.Text += "\n\nx" + numberGlove.ToString() + " @        " + gloveCost.ToString("C");

                reciept.Text += "\n\n\nSubtotal";
                recieptCosts.Text += "\n\n\n" + subTotalNumber.ToString("C");

                //input

                //calculations
                taxNumber = subTotalNumber * HST;

                //output
                reciept.Text += "\n\nTax";
                recieptCosts.Text += "\n\n" + taxNumber.ToString("C");

                //input

                //calculations
                totalNumber = subTotalNumber + taxNumber;

                //output
                reciept.Text += "\n\nTotal";
                recieptCosts.Text += "\n\n" + totalNumber.ToString("C");

                reciept.Text += "\n\n\n\n\n\n\n\n\n\nHave a crazy day!";
            }
            catch
            {
                reciept.Text = "";
                recieptTitle.Text = "Enter numerical values only!";
            }
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
