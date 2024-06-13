using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ident_num
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double num3 = Convert.ToDouble(textBox3.Text);
            double num4 = Convert.ToDouble(textBox4.Text);
            double num5 = Convert.ToDouble(textBox5.Text);

            double[] numbers = { num1, num2, num3, num4, num5 };

            double max = numbers[0];
            double min = numbers[0]; 

            foreach (double num in numbers)
            {
                if (num > max)
                {
                    max = num; 
                }
                if (num < min)
                {
                    min = num;
                }
                txtBoxMaior.Text = max.ToString();
                txtBoxMenor.Text = min.ToString();
            }
        }
    }
}
