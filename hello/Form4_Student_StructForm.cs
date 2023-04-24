using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hello
{
    public partial class Form4_Student_StructForm : Form
    {
        public Form4_Student_StructForm()
        {
            InitializeComponent();
            //textBox1.Text = 0.ToString();
            //textBox2.Text = 0.ToString();
            //textBox3.Text = 0.ToString();
            //textBox4.Text = 0.ToString();
        }
        int a = 0;
        bool b=false;
        bool c = false;


        public void btn_save_Click(object sender, EventArgs e)
        {
           b= true;
        }

        private void btn_saveshow_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)))
            {
                textBox5.Text = "姓名：" + Environment.NewLine + "國文：" + a + "分" + Environment.NewLine + "英文：" + a + "分" + Environment.NewLine + "數學：" + a + "分";
                b = false;
                c= true;
            }
            else 
            { 
                if (b)
                {
                    textBox5.Text = "姓名：" + textBox1.Text + Environment.NewLine + "國文：" + textBox2.Text + "分" + Environment.NewLine + "英文：" + textBox3.Text + "分" + Environment.NewLine + "數學：" + textBox4.Text + "分";
                    b = false;
                    c = true;
                }
                  
            }

        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            //Dictionary<TKey, TValue> 是 C# 中的一個泛型集合類型，表示一個由鍵值對組成的集合。其中 TKey 表示鍵的類型，TValue 表示值的類型。
            //FirstOrDefault方法是获取集合中的第一个元素
            //x => x.Value 经常被用作一个条件或转换,x => x.Value 是 C# 中的一个 Lambda 表达式
            //KeyValuePair<string, int> 结构体表示字典集合中的每个键值对，name 变量使用 .Key 属性获取当前键值对中的键，score 变量使用 .Value 属性获取当前键值对中的值。


            //int chinese = int.Parse(textBox2.Text);
            //int english = int.Parse(textBox3.Text);
            //int math = int.Parse(textBox4.Text);

            //int[] scores = { chinese, english, math };
            //int maxScore = scores.Max(); 
            //int minScore = scores.Min();
            //textBox6.Text = "最高科目成績為：" + maxScore + "分" + Environment.NewLine+"最低科目成績為：" + minScore + "分";
            if ((string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)))
            {
                textBox6.Text = "最高科目成績為："  + Environment.NewLine + "最低科目成績為：" ;
                c = false;
            }
            else
            {
                if (c)
                {
                    Dictionary<string, int> scores = new Dictionary<string, int>();
                    scores.Add("國文", int.Parse(textBox2.Text));
                    scores.Add("英文", int.Parse(textBox3.Text));
                    scores.Add("數學", int.Parse(textBox4.Text));

                    int maxScore = scores.Values.Max();
                    int minScore = scores.Values.Min();

                    string maxName = scores.FirstOrDefault(x => x.Value == maxScore).Key;
                    string minName = scores.FirstOrDefault(x => x.Value == minScore).Key;

                    textBox6.Text = "最高科目成績為：" + maxName + maxScore + "分" + Environment.NewLine + "最低科目成績為：" + minName + minScore + "分";
                    c = false;
                }

                
            }
        }
    }
}
