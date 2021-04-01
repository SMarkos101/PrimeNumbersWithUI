using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrimeNumbersWithUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateASinglePrimeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SinglePrimeNumberResultLabel.Visible = true;
                int input = Int32.Parse(SinglePrimeTxtBox.Text);
                if (PrimeCalculation.IsPrime(input))
                    SinglePrimeNumberResultLabel.Text = ($"{input} is a prime number");
                else
                    SinglePrimeNumberResultLabel.Text = ($"{input} is not a prime number");

            }
            catch (FormatException i)
            {

                MessageBox.Show($"{i.Message}");
            }
        }

        private void CalculatePrimesWithinARangeBtn_Click(object sender, EventArgs e)
        {
            ListOfPrimesListBox.Items.Clear();

            try
            {
                int input = Int32.Parse(textBox2.Text.Trim());
                int input2 = Int32.Parse(textBox3.Text.Trim());
                List<int> PrimesResultList = PrimeCalculation.FindPrimesInACertainRange(input, input2);

                ListOfPrimesListBox.Visible = true;

                if(PrimesResultList.Count<1)
                    ListOfPrimesListBox.Items.Add("None found");
                else
                 foreach (int num in PrimesResultList)
                    ListOfPrimesListBox.Items.Add(num.ToString());

                

            }
            catch (FormatException i)
            {
                ListOfPrimesListBox.Visible = false;
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show($"{i.Message}");
            }
        }
    }


    
}
