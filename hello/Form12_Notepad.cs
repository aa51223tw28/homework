
using System;
using System.IO;

using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hello
{
    public partial class Form12_Notepad : Form
    {
        public Form12_Notepad()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text= DateTime.Now.ToString("tt hh:mm:ss");
            //label的text要清除
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName,Encoding.Default);

            }
           
           
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text,Encoding.Default);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName,textBox1.Text,Encoding.Default);
                }
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor= colorDialog1.Color;                       
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Both;
        }

        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);

            }
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
            }
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12_Notepad關於 form12 = new Form12_Notepad關於();
            form12.Show();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            Form12_Notepad關於 form12 = new Form12_Notepad關於();
            form12.Show();
        }
    }
}
