namespace YearTwo
{
    partial class SalaryTax
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryTax));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtSpouse = new System.Windows.Forms.TextBox();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lSalary = new System.Windows.Forms.Label();
            this.lTax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bonus";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spouse";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(397, 362);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(193, 49);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(204, 64);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(650, 42);
            this.txtSalary.TabIndex = 6;
            this.txtSalary.Text = "0";
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(204, 137);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(650, 42);
            this.txtBonus.TabIndex = 7;
            this.txtBonus.Text = "0";
            this.txtBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBonus_KeyPress);
            // 
            // txtSpouse
            // 
            this.txtSpouse.Location = new System.Drawing.Point(204, 209);
            this.txtSpouse.Name = "txtSpouse";
            this.txtSpouse.Size = new System.Drawing.Size(650, 42);
            this.txtSpouse.TabIndex = 8;
            this.txtSpouse.Text = "0";
            this.txtSpouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpouse_KeyPress);
            // 
            // txtChildren
            // 
            this.txtChildren.Location = new System.Drawing.Point(204, 288);
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.Size = new System.Drawing.Size(650, 42);
            this.txtChildren.TabIndex = 10;
            this.txtChildren.Text = "0";
            this.txtChildren.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChildren_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Children";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last Salary";
            // 
            // lSalary
            // 
            this.lSalary.AutoSize = true;
            this.lSalary.ForeColor = System.Drawing.Color.Red;
            this.lSalary.Location = new System.Drawing.Point(391, 509);
            this.lSalary.Name = "lSalary";
            this.lSalary.Size = new System.Drawing.Size(147, 34);
            this.lSalary.TabIndex = 14;
            this.lSalary.Text = "Last Salary";
            // 
            // lTax
            // 
            this.lTax.AutoSize = true;
            this.lTax.ForeColor = System.Drawing.Color.Red;
            this.lTax.Location = new System.Drawing.Point(391, 440);
            this.lTax.Name = "lTax";
            this.lTax.Size = new System.Drawing.Size(30, 34);
            this.lTax.TabIndex = 13;
            this.lTax.Text = "0";
            // 
            // SalaryTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 605);
            this.Controls.Add(this.lSalary);
            this.Controls.Add(this.lTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChildren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSpouse);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SalaryTax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryTax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtSpouse;
        private System.Windows.Forms.TextBox txtChildren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lSalary;
        private System.Windows.Forms.Label lTax;
    }
}