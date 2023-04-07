using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "0") {   
                txtDisplay.Text = "7"; 
            }
            else { 
                txtDisplay.Text = txtDisplay.Text + "7"; 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "+";
            txtDisplay.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "-";
            txtDisplay.Text = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "x";
            txtDisplay.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "/";
            txtDisplay.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            
            secondNumber = double.Parse(txtDisplay.Text);

            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "x":
                    txtDisplay.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (firstNumber / secondNumber).ToString();
                    break;

                default:
                    break;
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1*q);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            string first, second;
            first = Convert.ToString(firstNumber);
            second = Convert.ToString(secondNumber);

            first = "";
            second = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0) {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text ="0";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(","))
            {
                // Add the decimal point to the end of the display text
                txtDisplay.Text = txtDisplay.Text + ",";
               
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
