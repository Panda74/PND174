using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate1
{
    public partial class Form1 : Form
    {
        string variant = "";
        double per = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text.Contains(","))
            {
                textBox1.Text += 0;
            }
            if (textBox1.Text.Contains("1") || textBox1.Text.Contains("2") || textBox1.Text.Contains("3") || textBox1.Text.Contains("4") || textBox1.Text.Contains("5") || textBox1.Text.Contains("6") || textBox1.Text.Contains("7") || textBox1.Text.Contains("8") || textBox1.Text.Contains("9"))
            {
                textBox1.Text += 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(","))
            {

            }
            else
            {
                textBox1.Text += ",";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            per = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            variant = "сумма";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            per = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            variant = "разность";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            per = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            variant = "деление";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            per = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            variant = "умножение";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (variant == "сумма")
            {
                double otvet = per + Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(otvet);
            }
            if (variant == "разность")
            {
                double otvet = per - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(otvet);
            }
            if (variant == "деление")
            {
                double otvet = per / Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(otvet);
            }
            if (variant == "умножение")
            {
                double otvet = per * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(otvet);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            variant = "";
            per = 0;
        }
    }
}
