using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class Form9_ForDoWhile : Form
    {
        public Form9_ForDoWhile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_result.Text = "結果";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //聖誕樹            
            //int height = int.Parse(textBox4.Text);
            //string result = "";
            //for (int i = 1; i <= height; i++)
            //{
            //    // 输出空格
            //    for (int j = 1; j <= height - i; j++)
            //    {
            //        result += " ";
            //    }

            //    // 输出星号
            //    for (int k = 1; k <= i; k++)
            //    {
            //        result += "*";
            //    }
            //    result += "\n"; // 換行
            //}
            //label_result.Text = result;

            //直角聖誕樹 

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                int height = int.Parse(textBox4.Text);
                string result = "";
                for (int i = 1; i <= height; i++)
                {
                    // 输出星号
                    for (int k = 1; k <= i; k++)
                    {
                        result += "*";
                    }

                    // 输出空格
                    for (int j = 1; j <= height - i; j++)
                    {
                        result += " ";
                    }
                    result += "\n"; // 換行
                }
                label_result.Text = result;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            //Convert.ToString(number, 2) 是一個 C# 中的內建方法，用於將整數轉換為指定
            //進位制的字串表示形式。其中的 2 參數表示要轉換為二進位，所以轉換後的結果是
            //一個由 '0' 和 '1' 字元組成的字串，表示整數 number 的二進位形式。
            int number = 100;
            string binary = Convert.ToString(number, 2);
            label_result.Text = binary;
        }


        //九九乘法表
        private void button3_Click(object sender, EventArgs e)
        {
            string result = "";
            string temp = "";

            for (int j = 1; j <= 9; j++)
            {
                for (int i = 2; i <= 9; i++)
                {
                    if(i*j<=9)
                    {
                        temp=(i*j).ToString();
                        result += ($"{i} x {j} = {temp.PadLeft(3)}" + "|");
                    }
                    else
                    {
                        result += ($"{i} x {j} = {i * j}" + "|");
                    }
                    

                }
                result += "\n";
            }
            label_result.Text = result;
        }

        //From起始值
        //To最終值
        //Step等差

        private void btn_for_Click(object sender, EventArgs e)
        {
            

            //for (i = From; i >= To; i += Step)
            //{
            //    sum -= i;
            //    label_result.Text += i + "+";
            //}
            //label_result.Text += " = " + sum;

            //for (i = From; i <= To; i += Step)
            //{
            //    sum += i;
            //    label_result.Text += i + "+";
            //}
            //label_result.Text += " = " + sum;


            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                int From, To, Step, i, sum = 0;
               

                From = Convert.ToInt32(textBox1.Text);
                To = Convert.ToInt32(textBox2.Text);
                Step = Convert.ToInt32(textBox3.Text);

                label_result.Text = "";
                
                for (i = From; i <= To; i += Step)
                {
                    sum += i;
                    //label_result.Text += i + "+";                   

                }
               
                label_result.Text = From + "到" + To + "相隔" + $"{Step - 1}" + "\n" + "加總為" + sum;
                //label_result.Text += "=" + sum;
            }
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                int From, To, Step, sum = 0;
                
                From = Convert.ToInt32(textBox1.Text);
                To = Convert.ToInt32(textBox2.Text);
                Step = Convert.ToInt32(textBox3.Text);

                int startNum = From;

                label_result.Text = "";

                while (From <= To)
                {
                    sum += From;    //sum=sum+from
                    From += Step;   //from=from+step
                }

                            
                label_result.Text = startNum + "到" + To + "相隔" + $"{Step - 1}" + "\n" + "加總為" + sum;
              
            }
        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                int From, To, Step, sum = 0;

                From = Convert.ToInt32(textBox1.Text);
                To = Convert.ToInt32(textBox2.Text);
                Step = Convert.ToInt32(textBox3.Text);

                int startNum = From;

                label_result.Text = "";

                do
                {
                    sum += From;   
                    From += Step;
                } while (From <= To);


                label_result.Text = startNum + "到" + To + "相隔" + $"{Step - 1}" + "\n" + "加總為" + sum;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Random rand = new Random();  //Random 是 C# 中的一個類別，用來產生亂數
            List<int> nums = new List<int>();  //泛用集合

            while (nums.Count < 6)
            {
                int num = rand.Next(1, 49); //rand.Next(1, 49)
                if (!nums.Contains(num))
                {
                    nums.Add(num);
                }
            }

            //nums.Sort();
            string result = "";
           
            foreach (int A in nums)
            {
                result += A.ToString() + " ";
            }
            label_result.Text = "樂透號碼" + "\n"+ result;
        }
    }
}
