﻿namespace YearTwo
{
    partial class SelectDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDate));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(252, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please Select Day Month and Year";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Month";
            // 
            // comboDay
            // 
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Location = new System.Drawing.Point(111, 259);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(160, 42);
            this.comboDay.TabIndex = 5;
            this.comboDay.SelectedIndexChanged += new System.EventHandler(this.comboDay_SelectedIndexChanged);
            // 
            // comboMonth
            // 
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May ",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboMonth.Location = new System.Drawing.Point(339, 259);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(246, 42);
            this.comboMonth.TabIndex = 6;
            this.comboMonth.SelectedIndexChanged += new System.EventHandler(this.comboMonth_SelectedIndexChanged);
            // 
            // comboYear
            // 
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(654, 259);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(160, 42);
            this.comboYear.TabIndex = 7;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboYear_SelectedIndexChanged);
            // 
            // SelectDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 514);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SelectDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectDate";
            this.Load += new System.EventHandler(this.SelectDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.ComboBox comboYear;
    }
}