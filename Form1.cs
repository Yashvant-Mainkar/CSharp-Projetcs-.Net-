using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Calculator(string operation)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Both Fields Are Empty");
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("One Of The Fields Is Empty");
            }
            else
            {
                int num1 = Convert.ToInt16(textBox1.Text);
                int num2 = Convert.ToInt16(textBox2.Text);
                int result = 0;

                switch (operation)
                {
                    case "add":
                        result = num1 + num2;
                        break;
                    case "sub":
                        result = num1 - num2;
                        break;
                    case "mul":
                        result = num1 * num2;
                        break;
                    case "div":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Division by zero is not allowed");
                            return;
                        }
                        result = num1 / num2;
                        break;
                }

                textBox3.Text = result.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Calculator("add");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator("sub");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator("mul");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculator("div");
        }

       
    }
}
