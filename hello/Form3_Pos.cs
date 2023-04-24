using System;
using System.Collections;
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
    public partial class Form3_Pos : Form
    {
        public Form3_Pos()
        {
            InitializeComponent();
            btn_Beer.Text = "啤酒"+ Environment.NewLine+"Beer"+ Environment.NewLine+"NT$120";
            btn_Tequila.Text = "龍舌蘭" + Environment.NewLine + "Tequila" + Environment.NewLine + "NT$180";
            btn_Whisky.Text = "威士忌" + Environment.NewLine + "Whisky" + Environment.NewLine + "NT$350";
            btn_wine.Text = "紅酒" + Environment.NewLine + "Wine" + Environment.NewLine + "NT$320";
            listBox1.Items.Add("尚未點餐");
            txt_totalprice.Text = "NT$0";

        }

        static double total = 0;

        private void btn_cash_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("尚未點餐"))
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("總金額：" + txt_totalprice.Text, "確認付款", MessageBoxButtons.OKCancel);
            }
            
            
            
        }

        private void btn_card_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("尚未點餐"))
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double cardprice =sum*0.9 ;
                MessageBox.Show("總金額：" + txt_totalprice.Text + "\n折扣後金額：NT$" + cardprice, "確認付款", MessageBoxButtons.OKCancel);
                
                
                
            }
                
            
        }
        
        string Beerlist="啤酒";
        string Tequilalist = "龍舌蘭";
        string Whiskylist = "威士忌";
        string Winelist = "紅酒";

        int BeerPrice = 120;
        int TequilaPrice = 180;
        int WhiskyPrice = 350;
        int WinePrice = 320;

        int Beercount = 1;
        int Tequilacount = 1;
        int Whiskycount = 1;
        int Winecount = 1;
                  
        bool Beerbool = true;
        bool Tequilabool = true;
        bool Whiskybool = true;
        bool Winebool = true;

        bool clearbool = true;

        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int sum= 0;


        private void btn_Beer_Click(object sender, EventArgs e)
        {
            if (clearbool)
            {
                listBox1.Items.Clear();
                clearbool=false;
            }
            

            if (listBox1.Items.Count<=0)
            {
                
                listBox1.Items.Add(Beerlist + "Beer x"+ Beercount+",共NT$ "+ BeerPrice * Beercount + "元");
                Beerbool = false; //第一次點時會執行第一段listBox1.Items.Count<=0，有其他商品時，再按一次會跑 if (Beerbool) 此時不應要再加一次相同商品項目
                a = BeerPrice * Beercount;
            }
            else
            {
                for (int i = 0; i <= listBox1.Items.Count-1;i++)  //要逐層檢查是否有相同資料，為何要減一，因為資料的起始位置從0開始，.Count為資料個數(1開始)
                {
                    if (listBox1.Items[i].ToString().Substring(0, 2) == Beerlist) //0起位置，2取的個數，[i]取listBox1的字串
                    {
                        
                        Beercount++;
                        listBox1.Items.RemoveAt(i);  //移除位置i的資料
                        listBox1.Items.Insert(i, Beerlist + "Beer x" + Beercount + ",共NT$ " + BeerPrice * Beercount + "元");
                        a = BeerPrice * Beercount;

                    }
                    else
                    {
                        if (Beerbool)  
                        {
                            listBox1.Items.Add(Beerlist + "Beer x" + Beercount + ",共NT$ " + BeerPrice * Beercount + "元");
                            Beerbool = false; //執行完一次，就不要在執行，所以寫false，即不會跑if裡的判斷式
                            a = BeerPrice * Beercount;
                            break;
                        }
                    }
                }
            }

            sum = a + b + c + d;
            txt_totalprice.Text = "NT$"+sum.ToString();
            getSort();
        }

        private void btn_Tequila_Click(object sender, EventArgs e)
        {
            if (clearbool)
            {
                listBox1.Items.Clear();
                clearbool = false;
            }

            if (listBox1.Items.Count <= 0)
            {

                listBox1.Items.Add(Tequilalist + "Tequila x" + Tequilacount + ",共NT$ " + TequilaPrice * Tequilacount + "元");
                Tequilabool = false;
                b = TequilaPrice * Tequilacount;
            }
            else
            {
                for (int i = 0; i <= listBox1.Items.Count - 1; i++)  //為何要減一，因為陣列從0開始
                {
                    if (listBox1.Items[i].ToString().Substring(0, 3) == Tequilalist)
                    {
                        Tequilacount++;
                        listBox1.Items.RemoveAt(i);
                        listBox1.Items.Insert(i, Tequilalist + "Tequila x" + Tequilacount + ",共NT$ " + TequilaPrice * Tequilacount + "元");
                        b = TequilaPrice * Tequilacount;
                    }
                    else
                    {
                        if (Tequilabool)
                        {
                            listBox1.Items.Add(Tequilalist + "Tequila x" + Tequilacount + ",共NT$ " + TequilaPrice * Tequilacount + "元");
                            Tequilabool = false;
                            b = TequilaPrice * Tequilacount;
                            break;
                        }
                    }
                }
            }
            sum = a + b + c + d;
            txt_totalprice.Text = "NT$" + sum.ToString();
            getSort();
        }

        private void btn_Whisky_Click(object sender, EventArgs e)
        {
            if (clearbool)
            {
                listBox1.Items.Clear();
                clearbool = false;
            }

            if (listBox1.Items.Count <= 0)
            {

                listBox1.Items.Add(Whiskylist + "Whisky x" + Whiskycount + ",共NT$ " + WhiskyPrice * Whiskycount + "元");
                Whiskybool = false;
                c = WhiskyPrice * Whiskycount;
            }
            else
            {
                for (int i = 0; i <= listBox1.Items.Count - 1; i++)  //為何要減一，因為陣列從0開始
                {
                    if (listBox1.Items[i].ToString().Substring(0, 3) == Whiskylist)
                    {
                        Whiskycount++;
                        listBox1.Items.RemoveAt(i);
                        listBox1.Items.Insert(i, Whiskylist + "Whisky x" + Whiskycount + ",共NT$ " + WhiskyPrice * Whiskycount + "元");
                        c = WhiskyPrice * Whiskycount;
                    }
                    else
                    {
                        if (Whiskybool)
                        {
                            listBox1.Items.Add(Whiskylist + "Whisky x" + Whiskycount + ",共NT$ " + WhiskyPrice * Whiskycount + "元");
                            Whiskybool = false;
                            c = WhiskyPrice * Whiskycount;
                            break;
                        }
                    }
                }
            }
            sum = a + b + c + d;
            txt_totalprice.Text = "NT$" + sum.ToString();
            getSort();
        }

        private void btn_wine_Click(object sender, EventArgs e)
        {
            if (clearbool)
            {
                listBox1.Items.Clear();
                clearbool = false;
            }

            if (listBox1.Items.Count <= 0)
            {

                listBox1.Items.Add(Winelist + "Wine x" + Winecount + ",共NT$ " + WinePrice * Winecount + "元");
                Winebool = false;
                d= WinePrice * Winecount;
            }
            else
            {
                for (int i = 0; i <= listBox1.Items.Count - 1; i++)  //為何要減一，因為陣列從0開始
                {
                    if (listBox1.Items[i].ToString().Substring(0, 2) == Winelist)
                    {
                        Winecount++;
                        listBox1.Items.RemoveAt(i);
                        listBox1.Items.Insert(i, Winelist + "Wine x" + Winecount + ",共NT$ " + WinePrice * Winecount + "元");
                        d = WinePrice * Winecount;
                    }
                    else
                    {
                        if (Winebool)
                        {
                            listBox1.Items.Add(Winelist + "Wine x" + Winecount + ",共NT$ " + WinePrice * Winecount + "元");
                            Winebool = false;
                            d = WinePrice * Winecount;
                            break;
                        }
                    }
                }
            }
            sum = a + b + c + d;
            txt_totalprice.Text = "NT$" + sum.ToString();
            getSort();
        }
        
        
        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Beerbool = true;
            Tequilabool = true;
            Whiskybool = true;
            Winebool = true;
            clearbool = true;
            Beercount = 1;
            Tequilacount = 1;
            Whiskycount = 1;
            Winecount = 1;
            listBox1.Items.Add("尚未點餐");
            txt_totalprice.Text = "NT$0";


        }


        //listbox排序方法
        public void getSort()
        {
            //ArrayList可以儲存不同類型的對象，並且支援像"陣列"一樣的索引存取方式。
            ArrayList q = new ArrayList();
            ArrayList FF = new ArrayList();

            string subName = "";
            string tempName1 = "";
            string tempName2 = "";
            string tempName3 = "";
            string tempName4 = "";

            int subNum;  //給編號

            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                subName = listBox1.Items[i].ToString().Substring(0, 1);

                switch (subName)
                {
                    case "啤":
                        subNum = 1;
                        q.Add(subNum);  //存編號q=[1]
                        tempName1 = listBox1.Items[i].ToString();  //存原本的字串
                        break;
                    case "龍":
                        subNum = 2;
                        q.Add(subNum);
                        tempName2 = listBox1.Items[i].ToString();
                        break;
                    case "威":
                        subNum = 3;
                        q.Add(subNum);
                        tempName3 = listBox1.Items[i].ToString();
                        break;
                    case "紅":
                        subNum = 4;
                        q.Add(subNum);
                        tempName4 = listBox1.Items[i].ToString();
                        break;
                    default:
                        break;
                }
            }
            //假設目前q的陣列物件是[1,4,3]
            q.Sort();  //sort方法，ArrayList適用 //[1,3,4]

            string GG = "";

            for (int i = 0; i <= q.Count - 1; i++)
            {
                if (q[i].ToString() == "1")
                {
                    GG = q[i].ToString().Replace("1", tempName1);
                    FF.Add(GG);
                }
                else if (q[i].ToString() == "2")
                {
                    GG = q[i].ToString().Replace("2", tempName2);
                    FF.Add(GG);
                }
                else if (q[i].ToString() == "3")
                {
                    GG = q[i].ToString().Replace("3", tempName3);
                    FF.Add(GG);
                }
                else if (q[i].ToString() == "4")
                {
                    GG = q[i].ToString().Replace("4", tempName4);
                    FF.Add(GG);
                }
            }

            listBox1.Items.Clear();

            foreach (object o in FF)
            {
                listBox1.Items.Add(o);
            }
        }


    }
}
