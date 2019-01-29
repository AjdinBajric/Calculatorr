using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {

        double result = 0;
        char operation;
        double FirstNum;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void on_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "0")
                textBoxResult.Clear();
            textBoxResult.Text += button.Text;
        }

        private void click_operator(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            char operacija = Convert.ToChar(button.Text);

            switch (operacija)
            {
                case '+':
                    FirstNum = Convert.ToDouble(textBoxResult.Text);
                    labelText.Text = FirstNum + " + ";
                    textBoxResult.Clear();
                    operation = '+';
                    break;

                case '-':
                    FirstNum = Convert.ToDouble(textBoxResult.Text);
                    labelText.Text = FirstNum + " - ";
                    textBoxResult.Clear();
                    operation = '-';
                    break;

                case '*':
                    FirstNum = Convert.ToDouble(textBoxResult.Text);
                    labelText.Text = FirstNum + " * ";
                    textBoxResult.Clear();
                    operation = '*';
                    break;

                case '/':
                    FirstNum= Convert.ToDouble(textBoxResult.Text);
                    labelText.Text = FirstNum + " / ";
                    textBoxResult.Clear();
                    operation = '/';
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (operation == '+')
            {

                labelText.Text += Convert.ToDouble(textBoxResult.Text);
                result =FirstNum+Convert.ToDouble(textBoxResult.Text);
               
            }
            else if(operation == '-')
            {
                labelText.Text += Convert.ToDouble(textBoxResult.Text);
                result = FirstNum - Convert.ToDouble(textBoxResult.Text);
                
            }
            else if(operation == '*')
            {
                labelText.Text += Convert.ToDouble(textBoxResult.Text);
                result = FirstNum * Convert.ToDouble(textBoxResult.Text);
                
            }
            else
            {
                labelText.Text += Convert.ToDouble(textBoxResult.Text);
                result = FirstNum / Convert.ToDouble(textBoxResult.Text);
                
            }
            textBoxResult.Text = result.ToString();
            FirstNum = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            labelText.Text = "";
            result = 0;
            FirstNum = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += ",";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
