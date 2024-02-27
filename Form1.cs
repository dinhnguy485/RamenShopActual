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


namespace RamenShop
{
    public partial class RamenShop : Form
    {
        double ramenPrice = 11.25;
        double banhmiPrice = 8.75;
        double bobaPrice = 6.75;
        int numRamen;
        int numBanhmi;
        int numBoba;
        double tendered;
        double money;
        double banhmiReceipt;
        double ramenReceipt;
        double bobaReceipt;
        SoundPlayer error;
        

        public RamenShop()
        {
            InitializeComponent();
            receiptButton.Visible = false;
            line.Visible = false;
            error = new SoundPlayer(Properties.Resources.ERROR);
            titleLabel.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //when total button is pressed, convert the input to integers, calculate the subtotal, tax and total price.
            //Catch error when user dont enter a number or enter a text message...
            try
            {
                numRamen = Convert.ToInt16(classicInput.Text);
                numBanhmi = Convert.ToInt16(banhmiInput.Text);
                numBoba = Convert.ToInt16(bobaInput.Text);


                double banhmi = numBanhmi * banhmiPrice;
                double ramen = numRamen * ramenPrice;
                double boba = numBoba * bobaPrice;

                banhmiReceipt = banhmi;
                ramenReceipt = ramen;
                bobaReceipt = boba;

                double subTotalPrice = (banhmi) + (ramen) + (boba);
                double tax = subTotalPrice * 0.13;
                double totalPrice = subTotalPrice + tax;
                money = totalPrice;

                subtotalOutput.Text = subTotalPrice.ToString("0.00");
                taxOutput.Text = tax.ToString("0.00");
                totalOutput.Text = totalPrice.ToString("0.00");
            }
            catch
            {
                subtotalOutput.Text = $"Error";
                taxOutput.Text = $"Error";
                totalOutput.Text = $"Error";
                error.Play();
            }


        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            // when calculate change button is pressed, convert the tendered input to double, calculate the change
            // if the tendered money is lower than the total = error
            try
            {
                double changeInput = Convert.ToInt16(moneyPayed.Text);
                double change = (changeInput) - (money);
                changeOutput.Text = change.ToString("0.00");

                if (change < 0)
                {
                    changeOutput.Text = $"U r broke";

                }

                receiptButton.Visible = true;
            }
            catch {
                changeOutput.Text = $"ERROR";
                error.Play() ;
            }

            
        }



        private void receiptButton_Click(object sender, EventArgs e)

            // when receipt button click, print receipt.
        {
            try
            {
                tendered = Convert.ToDouble(moneyPayed.Text);
                SoundPlayer cashPlay = new SoundPlayer(Properties.Resources.receiptSound);
                cashPlay.Play();
                receipt.Text += $"                  {titleLabel.Text}";

                cashPlay.Play();
                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{line.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{qtydespri.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{numRamen}           {ramenLabel.Text}                       ${ramenReceipt.ToString("0.00")}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{numBoba}           {bobaLabel.Text}                           ${bobaReceipt.ToString("0.00")}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{numBanhmi}           {banhmiLabel.Text}                     ${banhmiReceipt.ToString("0.00")}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{line.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{subtotalLabel.Text}                                       ${subtotalOutput.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{taxLabel.Text}                                                 ${taxOutput.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{totalLabel.Text}                                              ${totalOutput.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{line.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{tenderedLabel.Text}                                       ${tendered.ToString("0.00")}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{changeLabel.Text}                                            ${changeOutput.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n{line.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receipt.Text += $"\n                            Thank You!";

                this.Refresh();
                Thread.Sleep(500);
                receipt.Text += $"\n                         Have a nice day!!";
                receipt.Text += $"\n                           23rd Feb 2024";
            }
            catch
            {
                receipt.Text = $"ERROR";
                error.Play();
            }






          

        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            //when new order button is clicked reset the input to 0, reset all the label to " " (empty).
            numRamen = 0 ;
            numBanhmi = 0 ;
            numBoba = 0;
            tendered = 0;

            classicInput.Text = " ";
            bobaInput.Text = " ";
            banhmiInput.Text = " ";
            subtotalOutput.Text = " ";
            taxOutput.Text = " ";  
            totalOutput.Text = " ";
            moneyPayed.Text = " ";
            changeOutput.Text = " ";
            receipt.Text = " ";




        }


    }
}
