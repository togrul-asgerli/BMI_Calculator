using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double mass = Double.Parse(textBox_weight.Text);
                double length = Double.Parse(textBox_heigth.Text);

                double result = mass / (length * length);
                if(mass==0 || length==0||mass<0 ||length<0)
                {
                    MessageBox.Show($"Inputs can't be {0} or less than {0}");
                    return;
                }
                if(length<0 ||length>2.5)
                {
                    MessageBox.Show("Height has to be between 0 and 1");
                    return;
                }
                if (result < 18.5)
                {
                    textBox_Result.Text = $"Your bmi is {result} and you are underweight";
                }
                else if (result >= 18.5 && result < 24.9)
                {
                    textBox_Result.Text = $"Your bmi is {result} and you are normal weight";
                }
                else if (result >= 24.9 && result < 29.9)
                {
                    textBox_Result.Text = $"Your bmi is {result} and you are overweight";
                }
                else if (result >= 29.9)
                {
                    textBox_Result.Text = $"Your bmi is {result} and you are obesity";
                }
            }
            catch
            {
                MessageBox.Show("Enter valid data type!!");
            }
        }  
    }
}
