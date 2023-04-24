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
    public partial class Form15_考試Guess : Form
    {
        public Form15_考試Guess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15_考試Guess小視窗 Form15 = new Form15_考試Guess小視窗();
            Form15.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer:");
        }
    }
}
