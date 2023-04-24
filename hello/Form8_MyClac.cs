using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class Form8_MyClac : Form
    {
        public Form8_MyClac()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            
            if(!(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)))
            {
                decimal num1 = Decimal.Parse(textBox1.Text);
                decimal num2 = Decimal.Parse(textBox2.Text);
                decimal result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");
                
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)))
            {
                decimal num1 = Decimal.Parse(textBox1.Text);
                decimal num2 = Decimal.Parse(textBox2.Text);
                decimal result = num1 - num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");

            }
            
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)))
            {
                decimal num1 = Decimal.Parse(textBox1.Text);
                decimal num2 = Decimal.Parse(textBox2.Text);
                decimal result = num1 * num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");

            }
           
        }

        private void btn_divided_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)))
            {
               
                decimal num1 = Decimal.Parse(textBox1.Text);
                decimal num2 = Decimal.Parse(textBox2.Text);

                if (num2 == 0)
                {
                    textBox3.Text = "∞";
                }
                else
                {
                    decimal result = Math.Round(num1 / num2, 4);
                    textBox3.Text = result.ToString();
                }
                    
            }
            else
            {
                MessageBox.Show("請輸入數值。");

            }
            
        }
    }
}
