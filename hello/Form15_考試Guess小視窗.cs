using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static hello.Class1;

namespace hello
{
    public partial class Form15_考試Guess小視窗 : Form
    {
        public Form15_考試Guess小視窗()
        {
            InitializeComponent();
            // 取得螢幕的高度和寬度
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;

            // 取得視窗的高度和寬度
            int windowHeight = this.Height;
            int windowWidth = this.Width;

            // 計算視窗置中時的左上角座標
            int left = (screenWidth - windowWidth) / 2;
            int top = (screenHeight - windowHeight) / 2;

            // 設定視窗的位置
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(left, top);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randomnumber num = new Randomnumber();

            Random rand = new Random();
                      
            num.answer = rand.Next(1, 100);
            int guess = int.Parse(textBox1.Text);
            //int attempts = 0;

            

            //while (guess != num.answer)
            //{
            //    //Console.Write("Enter your guess: ");
            //    //guess = int.Parse(Console.ReadLine());
            //    //attempts++;

            //    if (guess == num.answer)
            //    {
            //        MessageBox.Show("正確");
            //    }
            //    else if (guess < num.answer)
            //    {
            //        MessageBox.Show("Too Small");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Too Large");
            //    }
            //}

        }
    }
}
