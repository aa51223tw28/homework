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
    public partial class Form11_ScreenSaver : Form
    {
        public Form11_ScreenSaver()
        {
            InitializeComponent();
            xPosition = this.Width / 2 - pictureBox1.Width / 2;
            yPosition = this.Height / 2 - pictureBox1.Height / 2;
            xVelocity = 5;
            yVelocity = 5;
        }

        private PictureBox pictureBox;
        private int xPosition;
        private int yPosition;
        private int xVelocity;
        private int yVelocity;




        private void timer1_Tick(object sender, EventArgs e)
        {
            // 計算新的位置
            xPosition += xVelocity;
            yPosition += yVelocity;

            // 檢查是否到達邊界，如果是則反彈
            if (xPosition < 0 || xPosition + pictureBox1.Width > this.Width)
            {
                xVelocity = -xVelocity;
            }
            if (yPosition < 0 || yPosition + pictureBox1.Height > this.Height)
            {
                yVelocity = -yVelocity;
            }

            // 設定 PictureBox 的位置
            pictureBox1.Location = new Point(xPosition, yPosition);
        }

        private void Form11_ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 如果按下的是滑鼠左鍵
            {
                this.Close(); // 關閉表單，從而關閉螢幕保護程式
            }
        }

        



    }
}
