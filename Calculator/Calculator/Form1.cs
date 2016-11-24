using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text== "0")||(operation_pressed))
            {
                textBox1.Clear();
            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void temp_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            String op = b.Text;
            double tv = Double.Parse(textBox1.Text);
             
            switch(op)
            {
                case "Fe":
                    textBox1.Text = (tv * 9 / 5 + 32).ToString();
                    break;
                case "Ce":
                    textBox1.Text = ((tv - 32) * 5 / 9).ToString();
                    break;
            }
            operation_pressed = false;
        }
    }
}
