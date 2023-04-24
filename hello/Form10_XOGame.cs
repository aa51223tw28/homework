using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hello
{
    public partial class Form10_XOGame : Form
    {
        public Form10_XOGame()
        {
            InitializeComponent();
        }
        int tmp = 0;   //設一個全域變數
        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            tmp = tmp + 1;  //每按一下 c就+1
            r = tmp % 2;  //把c除2取餘數 就會剩下0或1 諾是0按鈕就顯示O 諾是1按鈕就顯示 X


            if (r == 0)
            {
                button1.Text = "O";
            }
            else
            {
                button1.Text = "X";
            }
            button1.Enabled = false;  //下好離手 點下後就不能再更改

            judge();   //呼叫函式
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r;
            tmp = tmp + 1;  //每按一下 c就+1
            r = tmp % 2;  //把c除2取餘數 就會剩下0或1 諾是0按鈕就顯示O 諾是1按鈕就顯示 X


            if (r == 0)
            {
                button2.Text = "O";
            }
            else
            {
                button2.Text = "X";
            }
            button2.Enabled = false;  //下好離手 點下後就不能再更改

            judge();   //呼叫函式
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r;
            tmp = tmp + 1;  //每按一下 c就+1
            r = tmp % 2;  //把c除2取餘數 就會剩下0或1 諾是0按鈕就顯示O 諾是1按鈕就顯示 X


            if (r == 0)
            {
                button3.Text = "O";
            }
            else
            {
                button3.Text = "X";
            }
            button3.Enabled = false;  //下好離手 點下後就不能再更改

            judge();   //呼叫函式
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r;
            tmp = tmp + 1;  //每按一下 c就+1
            r = tmp % 2;  //把c除2取餘數 就會剩下0或1 諾是0按鈕就顯示O 諾是1按鈕就顯示 X


            if (r == 0)
            {
                button4.Text = "O";
            }
            else
            {
                button4.Text = "X";
            }
            button4.Enabled = false;  //下好離手 點下後就不能再更改

            judge();   //呼叫函式
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r;
            tmp = tmp + 1;  //每按一下 c就+1
            r = tmp % 2;  //把c除2取餘數 就會剩下0或1 諾是0按鈕就顯示O 諾是1按鈕就顯示 X


            if (r == 0)
            {
                button5.Text = "O";
            }
            else
            {
                button5.Text = "X";
            }
            button5.Enabled = false;  //下好離手 點下後就不能再更改

            judge();   //呼叫函式
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int r;
            tmp = tmp + 1;  //每按一下 c就+1
            r = tmp % 2;  //把c除2取餘數 就會剩下0或1 諾是0按鈕就顯示O 諾是1按鈕就顯示 X


            if (r == 0)
            {
                button6.Text = "O";
            }
            else
            {
                button6.Text = "X";
            }
            button6.Enabled = false;  //下好離手 點下後就不能再更改

            judge();   //呼叫函式
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int r;
            tmp = tmp + 1;  //每按一下 c就+1
            r = tmp % 2;  //把c除2取餘數 就會剩下0或1 諾是0按鈕就顯示O 諾是1按鈕就顯示 X


            if (r == 0)
            {
                button7.Text = "O";
            }
            else
            {
                button7.Text = "X";
            }
            button7.Enabled = false;  //下好離手 點下後就不能再更改

            judge();   //呼叫函式
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int r;
            tmp = tmp + 1;  //每按一下 c就+1
            r = tmp % 2;  //把c除2取餘數 就會剩下0或1 諾是0按鈕就顯示O 諾是1按鈕就顯示 X


            if (r == 0)
            {
                button8.Text = "O";
            }
            else
            {
                button8.Text = "X";
            }
            button8.Enabled = false;  //下好離手 點下後就不能再更改

            judge();   //呼叫函式
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int r;
            tmp = tmp + 1;  //每按一下 c就+1
            r = tmp % 2;  //把c除2取餘數 就會剩下0或1 諾是0按鈕就顯示O 諾是1按鈕就顯示 X


            if (r == 0)
            {
                button9.Text = "O";
            }
            else
            {
                button9.Text = "X";
            }
            button9.Enabled = false;  //下好離手 點下後就不能再更改

            judge();   //呼叫函式

        }
        private void judge()  //設立一個函式 判斷輸贏
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text == "X")
            {
                MessageBox.Show("X 贏了", "完局");
                buttonmethod();


            }
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text == "O")
            {
                MessageBox.Show("O 贏了", "完局");
                buttonmethod();

            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text == "X")
            {
                MessageBox.Show("X 贏了", "完局");
                buttonmethod();

            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text == "O")
            {
                MessageBox.Show("O 贏了", "完局");
                buttonmethod();

            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == "X")
            {
                MessageBox.Show("X 贏了", "完局");
                buttonmethod();

            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == "O")
            {
                MessageBox.Show("O 贏了", "完局");
                buttonmethod();

            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text == "X")
            {
                MessageBox.Show("X 贏了", "完局");
                buttonmethod();

            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text == "O")
            {
                MessageBox.Show("O 贏了", "完局");
                buttonmethod();

            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text == "X")
            {
                MessageBox.Show("X 贏了", "完局");
                buttonmethod();

            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text == "O")
            {
                MessageBox.Show("O 贏了", "完局");
                buttonmethod();

            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text == "X")
            {
                MessageBox.Show("X 贏了", "完局");
                buttonmethod();

            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text == "X")
            {
                MessageBox.Show("X 贏了", "完局");
                buttonmethod();

            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text == "O")
            {
                MessageBox.Show("O 贏了", "完局");
                buttonmethod();

            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text == "X")
            {
                MessageBox.Show("X 贏了", "完局");
                buttonmethod();

            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text == "O")
            {
                MessageBox.Show("O 贏了", "完局");
                buttonmethod();

            }
            if(!(string.IsNullOrEmpty(button1.Text) || string.IsNullOrEmpty(button2.Text) || string.IsNullOrEmpty(button3.Text) || string.IsNullOrEmpty(button4.Text) || string.IsNullOrEmpty(button5.Text) || string.IsNullOrEmpty(button6.Text) || string.IsNullOrEmpty(button7.Text) || string.IsNullOrEmpty(button8.Text) || string.IsNullOrEmpty(button9.Text)))
            {
                MessageBox.Show("兩方平手,請按確定重新遊戲","完局");
                buttonmethod();
            }


        }


        void buttonmethod()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
                        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonmethod();
        }

        //將 KeyPreview 屬性設置為 true。這個屬性的作用是讓 Form 接收所有鍵盤事件，而不僅僅是被焦點控制項接收的事件。
        

        

        private void Form10_XOGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                buttonmethod();
            }

            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
    } 
}
