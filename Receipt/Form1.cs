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

namespace Receipt
{
    public partial class Form1 : Form
    {
        double pencils = 1.25;
        double erasers = 0.99;
        double pens = 2.34;
        double pencilPrice;
        double eraserPrice;
        double penPrice;
        int pencilAmount;
        int erasersAmount;
        int pensAmount;
        double subtotal;
        double taxRate = 0.13;
        double tax;
        double total;
        double tendered;
        double change;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            pencilAmount = Convert.ToInt32(pencilBox.Text);
            erasersAmount = Convert.ToInt32(eraserBox.Text);
            pensAmount = Convert.ToInt32(penBox.Text);

            pencilPrice = pencils * pencilAmount;
            eraserPrice = erasers * erasersAmount;
            penPrice = pens * pensAmount;
            subtotal = pencilPrice + eraserPrice + penPrice;
            tax = subtotal * taxRate;
            total = subtotal + tax;

            subtotLabel.Text = $"{subtotal.ToString("C")}";
            taxLabel.Text = $"{tax.ToString("C")}";
            totalLabel.Text = $"{total.ToString("C")}";




        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void subLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            try
            {
                tendered = Convert.ToInt16(moneyBox.Text);
                if (tendered >= total)
                {
                    change = tendered - total;
                    amountLabel.Text = $"{change.ToString("C")}";
                }
                else
                {
                    amountLabel.Text = "Insufficient funds";
                }
            }
            catch
            {
                amountLabel.Text = "Please input numbers";
            }


        }

        private void getButton_Click(object sender, EventArgs e)
        {
            if ((tendered >= total) && (total > 0))
            {
                SoundPlayer Print = new SoundPlayer(Properties.Resources.printSound);
                Print.Play();
                Refresh();
                nameLabel.Visible = true;

                Refresh();
                Thread.Sleep(5);
                productLabel.Text = $"Pencil x{pencilAmount}";
                numberLabel.Text = $"{pencilPrice.ToString("C")}";

                Refresh();
                Thread.Sleep(5);
                productLabel.Text += $"\nEraser x{erasersAmount}";
                numberLabel.Text += $"\n{eraserPrice.ToString("C")}";

                Refresh();
                Thread.Sleep(5);
                productLabel.Text += $"\nPen x{pensAmount}";
                numberLabel.Text += $"\n{penPrice.ToString("C")}";

                Refresh();
                Thread.Sleep(5);
                productLabel.Text += $"\n\nSubTotal";
                numberLabel.Text += $"\n\n{subtotal.ToString("C")}";

                Refresh();
                Thread.Sleep(5);
                productLabel.Text += $"\nTax";
                numberLabel.Text += $"\n{tax.ToString("C")}";

                Refresh();
                Thread.Sleep(5);
                productLabel.Text += $"\nTotal";
                numberLabel.Text += $"\n{total.ToString("C")}";

                Refresh();
                Thread.Sleep(5);
                productLabel.Text += $"\n\nTendered";
                numberLabel.Text += $"\n\n{tendered.ToString("C")}";

                Refresh();
                Thread.Sleep(5);
                productLabel.Text += $"\nChange";
                numberLabel.Text += $"\n{change.ToString("C")}";

                Refresh();
                Thread.Sleep(5);
                messageLabel.Visible = true;
            }
            else
            {
                amountLabel.Text = "Please fill out the required fields";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pencilAmount = 0;
            erasersAmount = 0;
            pensAmount = 0;
            pencilPrice = 0;
            eraserPrice = 0;
            penPrice = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
            tendered = 0;
            change = 0;

            pencilBox.Text = "0";
            eraserBox.Text = "0";
            penBox.Text = "0";
            subtotLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";
            moneyBox.Text = "";
            amountLabel.Text = "";

            productLabel.Text = "";
            numberLabel.Text = "";

            nameLabel.Visible = false;
            messageLabel.Visible = false;
        }
    }
}
