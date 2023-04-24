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
    public partial class Form1_hello : Form
    {
        public Form1_hello()
        {
            InitializeComponent();            
        }

        //第一個Hello button
        // MessageBox 換行也可以用Environment.NewLine
        private void btn_sayhello_Click(object sender, EventArgs e)
        {
            string Name = txt_name.Text + "," + "\n" ;
            string EnglishName = txt_englishname.Text + "," + "\n" ;
            string Gender = txt_gender.Text + "," + "\n";
            string Sign = txt_sign.Text + "," +"\n" ;
            MessageBox.Show("Hello, 我是"+ Name+"英文名字是"+ EnglishName+"性別是"+ Gender+"星座是"+ Sign+"很高興認識你。");
        }

        private void btn_hi_Click(object sender, EventArgs e)
        {
            string Name = txt_name.Text + "," + "\n";
            string EnglishName = txt_englishname.Text + "," + "\n";
            string Gender = txt_gender.Text + "," + "\n";
            string Sign = txt_sign.Text + "," + "\n";
            MessageBox.Show("Hi, 我是" + Name + "英文名字是" + EnglishName + "性別是" + Gender + "星座是" + Sign + "很高興認識你。");
         
        }
        
    }
}
