using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static hello.Class1;
using static hello.Form2_loanshow;

namespace hello
{
    public partial class Form2_Loan : Form
    {
        public Form2_Loan()
        {
            InitializeComponent();
        }
        //第一種方法
        //private void btn_yearpayment_Click(object sender, EventArgs e)
        //{

        //    decimal loanmoney = Convert.ToDecimal(txt_loanmoney.Text);
        //    decimal year = Convert.ToDecimal(txt_year.Text);
        //    decimal rate = Convert.ToDecimal(text_rate.Text);
        //    decimal payment = Convert.ToDecimal(txt_payment.Text);
        //    decimal total;
        //    Total(loanmoney, year, rate, payment);
        //}



        //public void Total(decimal number1, decimal number2, decimal number3, decimal number4)
        //{
        //    decimal totalmoney = number1 + number2 + number3 + number4;
        //    MessageBox.Show(totalmoney.ToString());
        //}



        //第二種方式
        //private void btn_yearpayment_Click(object sender, EventArgs e)
        //{

        //    decimal loanmoney = Convert.ToDecimal(txt_loanmoney.Text);
        //    decimal year = Convert.ToDecimal(txt_year.Text);
        //    decimal rate = Convert.ToDecimal(text_rate.Text);
        //    decimal payment = Convert.ToDecimal(txt_payment.Text);

        //    decimal total = loanmoney + year + rate + payment;
        //    MessageBox.Show(total.ToString());

        //}


        //第三種方法
        //每月應付本息金額之平均攤還率={[(1+月利率)^月數]*月利率)/{[(1+月利率)^月數]-1)
        //平均每月應攤付本息金額=貸款本金*每月應付本息金額之平均攤還率=每月應還本金金額+每月應付利息金額
        //求次方的方式:Math.Pow(double 底數,double 幾次方),要使用double型態
        //Math.Round 方法：四捨五入

        double total;
        
        public void btn_yearpayment_Click(object sender, EventArgs e)
        {

            double loanmoney = double.Parse(txt_loanmoney.Text);
            double year = (double.Parse(txt_year.Text))*12;  //月份數
            double rate = ((double.Parse(text_rate.Text))/12)/100;  //月利率計算
            double payment = double.Parse(txt_payment.Text);

            
            total = Total(loanmoney, year, rate, payment);
            MessageBox.Show("月付額："+total+"元");
        }

        public double Total(double number1, double number2, double number3, double number4)
        {
            double totalmoney = Math.Round((Math.Round(number1- number4))*(Math.Pow((1+ number3), number2)* number3/ (Math.Pow((1 + number3), number2)-1)));
            return totalmoney;
        }


        double totalall;
        public void btn_totalpayment_Click(object sender, EventArgs e)
        {


            double loanmoney = double.Parse(txt_loanmoney.Text);
            double year = (double.Parse(txt_year.Text)) * 12;  //月份數
            double rate = ((double.Parse(text_rate.Text)) / 12) / 100;  //月利率計算
            double payment = double.Parse(txt_payment.Text);


            totalall = Total2(loanmoney, year, rate, payment);
            MessageBox.Show("總付款：" + totalall + "元");
        }

        public double Total2(double number1, double number2, double number3, double number4)
        {
            double totalmoney2 = (Math.Round((Math.Round(number1 - number4)) * (Math.Pow((1 + number3), number2) * number3 / (Math.Pow((1 + number3), number2) - 1))))* number2;
            return totalmoney2;
        }

        public void btn_report_Click(object sender, EventArgs e)
        {
            Form2_loanshow Form2_ls = new Form2_loanshow(txt_loanmoney.Text, txt_year.Text, text_rate.Text, txt_payment.Text, total.ToString(), totalall.ToString());
            Form2_ls.Show();
        }
    }
}
