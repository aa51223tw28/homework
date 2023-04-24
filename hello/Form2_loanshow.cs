using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static hello.Class1;

namespace hello
{
    public partial class Form2_loanshow : Form
    {
        public Form2_loanshow(string AA, string BB, string CC, string DD, string EE, string FF)
        {
            InitializeComponent();
            richTextBox1.Text = AA;
            richTextBox2.Text = BB;
            richTextBox3.Text = CC;
            richTextBox4.Text = DD;
            richTextBox5.Text = EE;
            richTextBox6.Text = FF;

        }
        
    }
}
