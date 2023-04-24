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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;  // 設定表單最大化  
        }

        private void btn_Form1_hello_Click(object sender, EventArgs e)
        {
            Form1_hello Form1 = new Form1_hello();
            
            splitContainer2.Panel2.Controls.Clear();
            Form1.TopLevel = false;
            /*Form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None*/;
            //Form1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(Form1);
            Form1.Show();
        }

        private void btn_Form2_Loan_Click(object sender, EventArgs e)
        {
            Form2_Loan Form2 = new Form2_Loan();
            splitContainer2.Panel2.Controls.Clear();
            Form2.TopLevel = false;
            //Form2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //Form2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(Form2);
            Form2.Show();
        }

        private void btn_Form3_Pos_Click(object sender, EventArgs e)
        {
            Form3_Pos Form3 = new Form3_Pos();
            splitContainer2.Panel2.Controls.Clear();
            Form3.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form3);
            Form3.Show();
        }

        private void btn_Form8_MyClac_Click(object sender, EventArgs e)
        {
            Form8_MyClac Form8 = new Form8_MyClac();
            splitContainer2.Panel2.Controls.Clear();
            Form8.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form8);
            Form8.Show();
        }

        private void btn_Form12_Notepad_Click(object sender, EventArgs e)
        {
            Form12_Notepad Form12 = new Form12_Notepad();
            splitContainer2.Panel2.Controls.Clear();
            Form12.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form12);
            Form12.Show();
           
        }

        private void btn_Form13_Draw_Click(object sender, EventArgs e)
        {
            Form13_Draw Form13 = new Form13_Draw();
            splitContainer2.Panel2.Controls.Clear();
            Form13.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form13);
            Form13.Show();
        }

        private void btn_Form11_ScreenSaver_Click(object sender, EventArgs e)
        {
            Form11_ScreenSaver Form11 = new Form11_ScreenSaver();
            Form11.Show();            
        }

        private void btn_Form4_Student_StructForm_Click(object sender, EventArgs e)
        {
            Form4_Student_StructForm Form4 = new Form4_Student_StructForm();
            splitContainer2.Panel2.Controls.Clear();
            Form4.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form4);
            Form4.Show();
        }

        private void btn_Form5_StudnetsGrade_Click(object sender, EventArgs e)
        {
            Form5_StudnetsGrade Form5 = new Form5_StudnetsGrade();
            splitContainer2.Panel2.Controls.Clear();
            Form5.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form5);
            Form5.Show();
        }

        private void btn_Form6_StudnetsGrade_List_Click(object sender, EventArgs e)
        {
            Form6_StudnetsGrade_List Form6 = new Form6_StudnetsGrade_List();
            splitContainer2.Panel2.Controls.Clear();
            Form6.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form6);
            Form6.Show();
        }

        private void btn_Form7_Method_Click(object sender, EventArgs e)
        {
            Form7_Method Form7 = new Form7_Method();
            splitContainer2.Panel2.Controls.Clear();
            Form7.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form7);
            Form7.Show();
        }

        private void btn_Form9_ForDoWhile_Click(object sender, EventArgs e)
        {
            Form9_ForDoWhile Form9 = new Form9_ForDoWhile();
            splitContainer2.Panel2.Controls.Clear();
            Form9.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form9);
            Form9.Show();
        }

        private void btn_Form10_XOGame_Click(object sender, EventArgs e)
        {
            Form10_XOGame Form10 = new Form10_XOGame();
            splitContainer2.Panel2.Controls.Clear();
            Form10.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form10  );
            Form10.Show();
        }

        private void btn_Form14_PictureViewer_Click(object sender, EventArgs e)
        {
            Form14_PictureViewer Form14 = new Form14_PictureViewer();
            splitContainer2.Panel2.Controls.Clear();
            Form14.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form14);
            Form14.Show();
        }

        private void btn_Form15_考試Guess_Click(object sender, EventArgs e)
        {
            Form15_考試Guess Form15 = new Form15_考試Guess();
            splitContainer2.Panel2.Controls.Clear();
            Form15.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form15);
            Form15.Show();
        }

        private void btn_Form16_考試Alarm_Click(object sender, EventArgs e)
        {
            Form16_考試Alarm Form16 = new Form16_考試Alarm();
            splitContainer2.Panel2.Controls.Clear();
            Form16.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Form16);
            Form16.Show();
        }
    }
}
