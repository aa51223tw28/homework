namespace hello
{
    partial class Form2_Loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loanmoney = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.txt_loanmoney = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.text_rate = new System.Windows.Forms.TextBox();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.btn_yearpayment = new System.Windows.Forms.Button();
            this.btn_totalpayment = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loanmoney
            // 
            this.loanmoney.AutoSize = true;
            this.loanmoney.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loanmoney.Location = new System.Drawing.Point(61, 46);
            this.loanmoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loanmoney.Name = "loanmoney";
            this.loanmoney.Size = new System.Drawing.Size(155, 43);
            this.loanmoney.TabIndex = 0;
            this.loanmoney.Text = "貸款金額";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.year.Location = new System.Drawing.Point(61, 115);
            this.year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(145, 43);
            this.year.TabIndex = 1;
            this.year.Text = "期限(年)";
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rate.Location = new System.Drawing.Point(61, 186);
            this.rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(142, 43);
            this.rate.TabIndex = 2;
            this.rate.Text = "利率(%)";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.payment.Location = new System.Drawing.Point(61, 258);
            this.payment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(121, 43);
            this.payment.TabIndex = 3;
            this.payment.Text = "頭期款";
            // 
            // txt_loanmoney
            // 
            this.txt_loanmoney.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_loanmoney.Location = new System.Drawing.Point(235, 43);
            this.txt_loanmoney.Name = "txt_loanmoney";
            this.txt_loanmoney.Size = new System.Drawing.Size(355, 51);
            this.txt_loanmoney.TabIndex = 4;
            // 
            // txt_year
            // 
            this.txt_year.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_year.Location = new System.Drawing.Point(235, 115);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(355, 51);
            this.txt_year.TabIndex = 5;
            // 
            // text_rate
            // 
            this.text_rate.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_rate.Location = new System.Drawing.Point(235, 186);
            this.text_rate.Name = "text_rate";
            this.text_rate.Size = new System.Drawing.Size(355, 51);
            this.text_rate.TabIndex = 6;
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_payment.Location = new System.Drawing.Point(235, 256);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(355, 51);
            this.txt_payment.TabIndex = 7;
            // 
            // btn_yearpayment
            // 
            this.btn_yearpayment.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_yearpayment.Location = new System.Drawing.Point(78, 361);
            this.btn_yearpayment.Name = "btn_yearpayment";
            this.btn_yearpayment.Size = new System.Drawing.Size(212, 75);
            this.btn_yearpayment.TabIndex = 8;
            this.btn_yearpayment.Text = "PMT(月付)";
            this.btn_yearpayment.UseVisualStyleBackColor = true;
            this.btn_yearpayment.Click += new System.EventHandler(this.btn_yearpayment_Click);
            // 
            // btn_totalpayment
            // 
            this.btn_totalpayment.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_totalpayment.Location = new System.Drawing.Point(329, 361);
            this.btn_totalpayment.Name = "btn_totalpayment";
            this.btn_totalpayment.Size = new System.Drawing.Size(212, 75);
            this.btn_totalpayment.TabIndex = 9;
            this.btn_totalpayment.Text = "總付款";
            this.btn_totalpayment.UseVisualStyleBackColor = true;
            this.btn_totalpayment.Click += new System.EventHandler(this.btn_totalpayment_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_report.Location = new System.Drawing.Point(577, 361);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(212, 75);
            this.btn_report.TabIndex = 10;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // Form2_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_totalpayment);
            this.Controls.Add(this.btn_yearpayment);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.text_rate);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_loanmoney);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.year);
            this.Controls.Add(this.loanmoney);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loanmoney;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.TextBox txt_loanmoney;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox text_rate;
        private System.Windows.Forms.TextBox txt_payment;
        private System.Windows.Forms.Button btn_yearpayment;
        private System.Windows.Forms.Button btn_totalpayment;
        private System.Windows.Forms.Button btn_report;
    }
}