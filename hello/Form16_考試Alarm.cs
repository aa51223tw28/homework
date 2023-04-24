using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class Form16_考試Alarm : Form
    {
        public Form16_考試Alarm()
        {
            InitializeComponent();
        }
        string a = "";
        string b = "";
        string c = "";
        //bool flag = true;


        private void timer123_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("hh:mm:ss");  //label要刪掉文字//timer enable=true


            if ((a == DateTime.Now.ToString("hh") && (b == DateTime.Now.ToString("mm")&& (c == DateTime.Now.ToString("ss")))))
            {
                timer123.Stop();
                MessageBox.Show("時間到了");
            }           


            //if (flag)
            //{
            //    button1.BackColor = Color.Yellow;
            //    button1.BackColor = Color.Red;
            //}
            //else
            //{
            //    button1.BackColor = Color.Red;
            //    button1.BackColor = Color.Yellow;
            //}
            //flag = !flag;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            button1.BackColor = Color.Red;


        }

        
    }
}
