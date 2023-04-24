using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hello
{
    public partial class Form6_StudnetsGrade_List : Form
    {
        public Form6_StudnetsGrade_List()
        {
            InitializeComponent();

        }

        bool btn_delete1 = false;
        //泛型--把物件存取在清單內
        List<int> lstChinese = new List<int>();
        List<int> lstEnglish = new List<int>();
        List<int> lstMath = new List<int>();


        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_delete1 = true;
            if (btn_delete1)
            {
                btn_delete.Enabled = true;
            }



            if ((string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)))
            {
                MessageBox.Show("請輸入姓名!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string a = textBox1.Text;
                string b = textBox2.Text;
                string c = textBox3.Text;
                string d = textBox4.Text;



                Dictionary<string, int> scores = new Dictionary<string, int>();
                scores.Add("國文", int.Parse(textBox2.Text));
                scores.Add("英文", int.Parse(textBox3.Text));
                scores.Add("數學", int.Parse(textBox4.Text));

                int sum = scores.Values.Sum();
                double avg = scores.Values.Average();
                double roundedAvg = Math.Round(avg, 1);
                int minScore = scores.Values.Min();
                int maxScore = scores.Values.Max();

                string sumName = scores.FirstOrDefault(x => x.Value == sum).Key;
                string avgName = scores.FirstOrDefault(x => x.Value == avg).Key;
                string minName = scores.FirstOrDefault(x => x.Value == minScore).Key;
                string maxName = scores.FirstOrDefault(x => x.Value == maxScore).Key;

                ListViewItem item = new ListViewItem(a);
                item.SubItems.Add(b);
                item.SubItems.Add(c);
                item.SubItems.Add(d);
                item.SubItems.Add(sum.ToString());
                item.SubItems.Add(roundedAvg.ToString());
                item.SubItems.Add(minName + (minScore.ToString()));
                item.SubItems.Add(maxName + (maxScore.ToString()));
                listView1.Items.Add(item);
                //textBox1.Clear();
                //textBox2.Clear();
                //textBox3.Clear();
                //textBox4.Clear();
                //textBox1.Focus();

                lstChinese.Add(int.Parse(b));
                lstEnglish.Add(int.Parse(c));
                lstMath.Add(int.Parse(d));

            }
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            btn_delete1 = true;
            if (btn_delete1)
            {
                btn_delete.Enabled = true;
            }



            if ((string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)))
            {
                MessageBox.Show("請輸入姓名!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string a = textBox1.Text;
                string b = textBox2.Text;
                string c = textBox3.Text;
                string d = textBox4.Text;



                Dictionary<string, int> scores = new Dictionary<string, int>();
                scores.Add("國文", int.Parse(textBox2.Text));
                scores.Add("英文", int.Parse(textBox3.Text));
                scores.Add("數學", int.Parse(textBox4.Text));

                int sum = scores.Values.Sum();
                double avg = scores.Values.Average();
                double roundedAvg = Math.Round(avg, 1);
                int minScore = scores.Values.Min();
                int maxScore = scores.Values.Max();

                string sumName = scores.FirstOrDefault(x => x.Value == sum).Key;
                string avgName = scores.FirstOrDefault(x => x.Value == avg).Key;
                string minName = scores.FirstOrDefault(x => x.Value == minScore).Key;
                string maxName = scores.FirstOrDefault(x => x.Value == maxScore).Key;

                ListViewItem item = new ListViewItem(a);
                int index = 0;
                item.SubItems.Add(b);
                item.SubItems.Add(c);
                item.SubItems.Add(d);
                item.SubItems.Add(sum.ToString());
                item.SubItems.Add(roundedAvg.ToString());
                item.SubItems.Add(minName + (minScore.ToString()));
                item.SubItems.Add(maxName + (maxScore.ToString()));
                listView1.Items.Insert(index, item);

                lstChinese.Add(int.Parse(b));
                lstEnglish.Add(int.Parse(c));
                lstMath.Add(int.Parse(d));
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.Items[0];
                listView1.Items.Remove(item);
            }

        }


        private void btn_reset_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            listView2.Items.Clear();
            btn_add.Enabled = true;
            btn_insert.Enabled = true;
            btn_delete.Enabled = true;

        }



        private void btn_sum_Click(object sender, EventArgs e)
        {
            double iChineseSum = 0;//加總
            double iEnglishSum = 0;
            double iMathSum = 0;
            double ChineseAvg = 0;//平均
            double EnglishAvg = 0;
            double MathAvg = 0;

            //加總
            for (int i = 0; i <= lstChinese.Count - 1; i++)
            {
                iChineseSum += lstChinese[i];
            }

            ChineseAvg = Math.Round((iChineseSum / lstChinese.Count), 1);




            for (int i = 0; i <= lstEnglish.Count - 1; i++)
            {
                iEnglishSum += lstEnglish[i];
            }

            EnglishAvg = Math.Round((iEnglishSum / lstEnglish.Count), 1);


            for (int i = 0; i <= lstMath.Count - 1; i++)
            {
                iMathSum += lstMath[i];
            }

            MathAvg = Math.Round((iMathSum / lstMath.Count), 1);


            //最高分最低分
            int maxNumChinese = lstChinese[0];
            int minNumChinese = lstChinese[0];
            foreach (int num in lstChinese)
            {
                if (num > maxNumChinese)
                {
                    maxNumChinese = num;
                }

                if (num < minNumChinese)
                {
                    minNumChinese = num;
                }
            }

            int maxNumEnglish = lstEnglish[0];
            int minNumEnglish = lstEnglish[0];
            foreach (int num in lstEnglish)
            {
                if (num > maxNumEnglish)
                {
                    maxNumEnglish = num;
                }

                if (num < minNumEnglish)
                {
                    minNumEnglish = num;
                }
            }


            int maxNumMath = lstMath[0];
            int minNumMath = lstMath[0];
            foreach (int num in lstMath)
            {
                if (num > maxNumMath)
                {
                    maxNumMath = num;
                }

                if (num < minNumMath)
                {
                    minNumMath = num;
                }
            }


            //加入listview
            string[][] xxx = new string[4][];
            xxx[0] = new string[] { "總分", iChineseSum.ToString(), iEnglishSum.ToString(), iMathSum.ToString() };
            xxx[1] = new string[] { "平均", ChineseAvg.ToString(), EnglishAvg.ToString(), MathAvg.ToString() };
            xxx[2] = new string[] { "最高分", maxNumChinese.ToString(), maxNumEnglish.ToString(), maxNumMath.ToString() };
            xxx[3] = new string[] { "最低分", minNumChinese.ToString(), minNumEnglish.ToString(), minNumMath.ToString() };

            for (int i = 0; i < xxx.Length; i++)
            {
                ListViewItem item = new ListViewItem(xxx[i]);
                listView2.Items.Add(item);
            }




            //控制按鈕
            btn_add.Enabled = false;
            btn_insert.Enabled = false;
            btn_delete.Enabled = false;

        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_from.Text);
            int b = int.Parse(txt_to.Text);

            //從listView1中刪除項目需要避免在遍歷集合時修改它，因為這樣會產生錯誤，通常的做法是從最後一個元素開始遍歷，並且從後往前進行遍歷。

            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {


                if (int.Parse(listView1.Items[i].SubItems[1].Text) < a || int.Parse(listView1.Items[i].SubItems[1].Text) > b)
                {
                    listView1.Items.RemoveAt(i);
                }

            }

        }


        
    }
}
