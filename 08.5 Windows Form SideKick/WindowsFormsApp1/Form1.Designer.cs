namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnAddOne = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.chbCoupon = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clbClothes = new System.Windows.Forms.CheckedListBox();
            this.btnChbListBoxClothes = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAddOne
            // 
            this.btnAddOne.BackColor = System.Drawing.Color.Lime;
            this.btnAddOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddOne.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddOne.Location = new System.Drawing.Point(130, 94);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(100, 38);
            this.btnAddOne.TabIndex = 0;
            this.btnAddOne.Text = "Add One";
            this.btnAddOne.UseVisualStyleBackColor = false;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            this.btnAddOne.MouseEnter += new System.EventHandler(this.btnAddOne_MouseEnter);
            this.btnAddOne.MouseLeave += new System.EventHandler(this.avi);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(130, 51);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRes.ForeColor = System.Drawing.Color.Red;
            this.lblRes.Location = new System.Drawing.Point(130, 159);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(21, 20);
            this.lblRes.TabIndex = 2;
            this.lblRes.Text = "...";
            // 
            // chbCoupon
            // 
            this.chbCoupon.AutoSize = true;
            this.chbCoupon.Location = new System.Drawing.Point(130, 213);
            this.chbCoupon.Name = "chbCoupon";
            this.chbCoupon.Size = new System.Drawing.Size(63, 17);
            this.chbCoupon.TabIndex = 3;
            this.chbCoupon.Text = "Coupn?";
            this.chbCoupon.UseVisualStyleBackColor = true;
            this.chbCoupon.CheckedChanged += new System.EventHandler(this.chbCoupon_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "bmw",
            "toyota",
            "porsche"});
            this.comboBox1.Location = new System.Drawing.Point(130, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clbClothes
            // 
            this.clbClothes.FormattingEnabled = true;
            this.clbClothes.Items.AddRange(new object[] {
            "T-shirt",
            "jeans",
            "dress"});
            this.clbClothes.Location = new System.Drawing.Point(317, 258);
            this.clbClothes.Name = "clbClothes";
            this.clbClothes.Size = new System.Drawing.Size(120, 94);
            this.clbClothes.TabIndex = 5;
            // 
            // btnChbListBoxClothes
            // 
            this.btnChbListBoxClothes.BackColor = System.Drawing.Color.Lime;
            this.btnChbListBoxClothes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnChbListBoxClothes.ForeColor = System.Drawing.Color.Maroon;
            this.btnChbListBoxClothes.Location = new System.Drawing.Point(317, 377);
            this.btnChbListBoxClothes.Name = "btnChbListBoxClothes";
            this.btnChbListBoxClothes.Size = new System.Drawing.Size(100, 38);
            this.btnChbListBoxClothes.TabIndex = 6;
            this.btnChbListBoxClothes.Text = "Clothes";
            this.btnChbListBoxClothes.UseVisualStyleBackColor = false;
            this.btnChbListBoxClothes.Click += new System.EventHandler(this.btnChbListBoxClothes_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(418, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(543, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 496);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnChbListBoxClothes);
            this.Controls.Add(this.clbClothes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chbCoupon);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnAddOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.CheckBox chbCoupon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox clbClothes;
        private System.Windows.Forms.Button btnChbListBoxClothes;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

