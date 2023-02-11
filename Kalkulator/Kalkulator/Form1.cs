using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void l1_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "1";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "1";
            }
        }

        private void l2_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "2";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "2";
            }
        }

        private void l3_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "3";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "3";
            }
        }

        private void l4_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "4";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "4";
            }
        }

        private void l5_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "5";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "5";
            }
        }

        private void l6_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "6";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "6";
            }
        }

        private void l7_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "7";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "7";
            }
        }

        private void l8_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "8";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "8";
            }
        }

        private void l9_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "9";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "9";
            }
        }

        private void l0_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "0";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = "0";
            Operation = "+";
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = "0";
            Operation = "-";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = "0";
            Operation = "/";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = "0";
            Operation = "×";
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + ".";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox_Result.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox_Result.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox_Result.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "×")
            {
                Result = (FirstNumber * SecondNumber);
                textBox_Result.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox_Result.Text = "PAMIĘTAJ CHOLERO NIE DZIEL PRZEZ ZERO!";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox_Result.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }
        }


    }
}
