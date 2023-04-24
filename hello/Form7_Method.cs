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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace hello
{
    public partial class Form7_Method : Form
    {
        public Form7_Method()
        {
            InitializeComponent();
            button9.Text = "[10,10]二維陣列" + Environment.NewLine + "101010" + Environment.NewLine + "010101";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                string a = "";
                double num1 = double.Parse(textBox1.Text);

                if (num1 % 2 == 0)
                {
                    a = "偶數";
                }
                else
                {
                    a = "奇數";
                }

                label_result.Text = "輸入的數:" + textBox1.Text + "為" + "'" + a + "'" + "。";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_result.Text = "結果";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int evenCount = 0;  //偶數
            int oddCount = 0;  //奇數

            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };

            //foreach迴圈適合陣列[]
            foreach (int num in arr)
            {
                if(num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                } 
                
            }
            label_result.Text = "int陣列arr[1,5,6,8,7,97,54,887,65,578]" +Environment.NewLine+"奇數共" + oddCount +"個" + Environment.NewLine + "偶數共"+ evenCount + "個";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = "";
            
            string[] arr = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };

            foreach (string str in arr)  //foreach沒有明顯要停止迴圈的時間點
            {
                if(str.Length> name.Length)
                {
                    name = str;
                }
            }
            label_result.Text = "陣列arrStr[mother張,emma,迪克蕭,J40,Candy,Cindy,Coconut,Motherfacker]" + Environment.NewLine + "最長的名字為" + name;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int maxNum = arr[0];  //不能設為0，因為出來的結果會是預設值
            int minNum = arr[0];

            foreach (int num in arr)
            {
                if (num > maxNum)
                {
                    maxNum = num;
                }

                if (num < minNum)
                {
                    minNum = num;
                }
            }
            label_result.Text = "int陣列arr[1,5,6,8,7,97,54,887,65,578]" + Environment.NewLine+"最大值為"+ maxNum + Environment.NewLine + "最小值為"+ minNum;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] arr = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int name = 0;

            foreach(string str in arr)
            {
                if (str.ToLower().Contains("c"))  //ToLower轉成小寫
                {
                    name++;
                }
            }
            label_result.Text = "陣列arrStr[mother張,emma,迪克蕭,J40,Candy,Cindy,Coconut,Motherfacker]" + Environment.NewLine + "有C OR c的名字共有"+name+"個";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (i == 0 || i == 9 || j == 0 || j == 9)
                        {
                            arr[i, j] = 1;
                        }
                        else
                        {
                            arr[i, j] = 0;
                        }
                    }
                }

                string arrString = "";

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        arrString += arr[i, j].ToString();
                    }
                    arrString += "\n"; // 換行
                }

                label_result.Text = arrString;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        arr[i, j] = 0;
                    }
                    else
                    {
                        arr[i, j] = 1;
                    }
                }
            }

            string arrString = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arrString += arr[i, j].ToString();
                }
                arrString += "\n"; // 換行
            }

            label_result.Text = arrString;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10] 
            {
            {1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
            {0, 1, 0, 1, 0, 1, 0, 1, 0, 1},
            {1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
            {0, 1, 0, 1, 0, 1, 0, 1, 0, 1},
            {1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
            {0, 1, 0, 1, 0, 1, 0, 1, 0, 1},
            {1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
            {0, 1, 0, 1, 0, 1, 0, 1, 0, 1},
            {1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
            {0, 1, 0, 1, 0, 1, 0, 1, 0, 1}
            };
            string arrString = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arrString += arr[i, j].ToString();
                }
                arrString += "\n"; // 每列結束後換行
            }
            label_result.Text = arrString;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            Swap(ref a, ref b);
            int a1 = 100, b2 = 200;
            label_result.Text = "換位前" + $"a:{a1},b:{b2}" + Environment.NewLine + "換位後" +$"a:{a},b:{b}";
        }
        void Swap(ref int a, ref int b)
        {
            int T = a;
            a = b;
            b = T;

        }

        private void button11_Click(object sender, EventArgs e)
        {

            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            label_result.Text = "int陣列arr[1,5,6,8,7,97,54,887,65,578]" + Environment.NewLine + "加總為" + sum;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int maxNum = arr[0];  
            

            foreach (int num in arr)
            {
                if (num > maxNum)
                {
                    maxNum = num;
                }                               
            }
            label_result.Text = "int陣列arr[1,5,6,8,7,97,54,887,65,578]" + Environment.NewLine + "最大值為" + maxNum ;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }; 
            int minNum = arr[0];

            foreach (int num in arr)
            {
                
                if (num < minNum)
                {
                    minNum = num;
                }
            }
            label_result.Text = "int陣列arr[1,5,6,8,7,97,54,887,65,578]" + Environment.NewLine + "最小值為" + minNum;
        }
    }
}
