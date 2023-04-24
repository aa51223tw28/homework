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
    public partial class Form13_Draw : Form
    {
        public Form13_Draw()
        {
            InitializeComponent();
           
        }

        int x0, y0;



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X; y0=e.Y;
        }



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           if (e.Button == MouseButtons.Left)
            {
                if (pictureBox1.Image == null)
                {
                    pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                }

               
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(colorDialog1.Color, trackBar1.Value);
                g.DrawLine(p, x0, y0, e.X, e.Y);
                x0 = e.X; 
                y0 = e.Y;
                pictureBox1.Refresh();  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            // 將TrackBar選擇的值顯示在Label控制項中
            label1.Text = trackBar1.Value.ToString();
        }

        //在C#中，將滑鼠游標（Cursor）設置為十字形，可以使用Cursor類別提供的Cross常量。
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;            
        }
         


    }
}
