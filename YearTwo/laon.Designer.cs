namespace YearTwo
{
    partial class laon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnTher = new System.Windows.Forms.Button();
            this.btnThay = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.month = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.installment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.principal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.interest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.debtBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Loan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Month";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(256, 54);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(455, 39);
            this.txtLoan.TabIndex = 3;
            this.txtLoan.TextChanged += new System.EventHandler(this.txtLoan_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(256, 100);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(455, 39);
            this.txtRate.TabIndex = 4;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(256, 149);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(455, 39);
            this.txtMonth.TabIndex = 5;
            // 
            // btnTher
            // 
            this.btnTher.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTher.Font = new System.Drawing.Font("Khmer OS Content", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTher.Location = new System.Drawing.Point(791, 48);
            this.btnTher.Name = "btnTher";
            this.btnTher.Size = new System.Drawing.Size(133, 51);
            this.btnTher.TabIndex = 6;
            this.btnTher.Text = "បង់ថេរ";
            this.btnTher.UseVisualStyleBackColor = false;
            this.btnTher.Click += new System.EventHandler(this.btnTher_Click);
            // 
            // btnThay
            // 
            this.btnThay.BackColor = System.Drawing.Color.Red;
            this.btnThay.Font = new System.Drawing.Font("Khmer OS Content", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThay.Location = new System.Drawing.Point(791, 143);
            this.btnThay.Name = "btnThay";
            this.btnThay.Size = new System.Drawing.Size(133, 51);
            this.btnThay.TabIndex = 7;
            this.btnThay.Text = "បង់ថយ";
            this.btnThay.UseVisualStyleBackColor = false;
            this.btnThay.Click += new System.EventHandler(this.btnThay_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.month,
            this.installment,
            this.principal,
            this.interest,
            this.debtBalance});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 216);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1007, 399);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // month
            // 
            this.month.Text = "Month";
            this.month.Width = 174;
            // 
            // installment
            // 
            this.installment.Text = "Installment";
            this.installment.Width = 197;
            // 
            // principal
            // 
            this.principal.Text = "Principal";
            this.principal.Width = 220;
            // 
            // interest
            // 
            this.interest.Text = "Interest";
            this.interest.Width = 197;
            // 
            // debtBalance
            // 
            this.debtBalance.Text = "Debt Balance";
            this.debtBalance.Width = 223;
            // 
            // laon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 644);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnThay);
            this.Controls.Add(this.btnTher);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "laon";
            this.Text = "laon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnTher;
        private System.Windows.Forms.Button btnThay;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader month;
        private System.Windows.Forms.ColumnHeader installment;
        private System.Windows.Forms.ColumnHeader principal;
        private System.Windows.Forms.ColumnHeader interest;
        private System.Windows.Forms.ColumnHeader debtBalance;
    }
}