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
    public partial class Form12_Notepad關於 : Form
    {
        public Form12_Notepad關於()
        {
            InitializeComponent();
            // 取得螢幕的高度和寬度
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;

            // 取得視窗的高度和寬度
            int windowHeight = this.Height;
            int windowWidth = this.Width;

            // 計算視窗置中時的左上角座標
            int left = (screenWidth - windowWidth) / 2;
            int top = (screenHeight - windowHeight) / 2;

            // 設定視窗的位置
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(left, top);
        }
    }
}
