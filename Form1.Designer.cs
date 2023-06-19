namespace TimeZoneClock
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cboxTimeZone = new System.Windows.Forms.ComboBox();
            this.lblIsDLS = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Green;
            this.lblTime.Location = new System.Drawing.Point(1, 58);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(438, 82);
            this.lblTime.TabIndex = 0;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cboxTimeZone
            // 
            this.cboxTimeZone.FormattingEnabled = true;
            this.cboxTimeZone.Location = new System.Drawing.Point(228, 12);
            this.cboxTimeZone.Name = "cboxTimeZone";
            this.cboxTimeZone.Size = new System.Drawing.Size(199, 21);
            this.cboxTimeZone.TabIndex = 1;
            this.cboxTimeZone.SelectedIndexChanged += new System.EventHandler(this.cboxTimeZone_SelectedIndexChanged);
            // 
            // lblIsDLS
            // 
            this.lblIsDLS.AutoSize = true;
            this.lblIsDLS.BackColor = System.Drawing.Color.Black;
            this.lblIsDLS.ForeColor = System.Drawing.Color.Green;
            this.lblIsDLS.Location = new System.Drawing.Point(9, 9);
            this.lblIsDLS.Name = "lblIsDLS";
            this.lblIsDLS.Size = new System.Drawing.Size(111, 13);
            this.lblIsDLS.TabIndex = 2;
            this.lblIsDLS.Text = "Daylight Savings label";
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Agency FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Green;
            this.btn0.Location = new System.Drawing.Point(57, 129);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(35, 64);
            this.btn0.TabIndex = 3;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Agency FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Green;
            this.btn1.Location = new System.Drawing.Point(96, 129);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 64);
            this.btn1.TabIndex = 4;
            this.btn1.Tag = "1";
            this.btn1.Text = "0";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Agency FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Green;
            this.btn3.Location = new System.Drawing.Point(177, 129);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 64);
            this.btn3.TabIndex = 5;
            this.btn3.Tag = "3";
            this.btn3.Text = "0";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Agency FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Green;
            this.btn4.Location = new System.Drawing.Point(216, 129);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 64);
            this.btn4.TabIndex = 6;
            this.btn4.Tag = "4";
            this.btn4.Text = "0";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Green;
            this.btn2.Location = new System.Drawing.Point(136, 129);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 64);
            this.btn2.TabIndex = 7;
            this.btn2.Tag = "2";
            this.btn2.Text = ":";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Green;
            this.btn5.Location = new System.Drawing.Point(257, 129);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 64);
            this.btn5.TabIndex = 10;
            this.btn5.Tag = "5";
            this.btn5.Text = ":";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Agency FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Green;
            this.btn7.Location = new System.Drawing.Point(339, 129);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 64);
            this.btn7.TabIndex = 9;
            this.btn7.Tag = "7";
            this.btn7.Text = "0";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Agency FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Green;
            this.btn6.Location = new System.Drawing.Point(298, 129);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 64);
            this.btn6.TabIndex = 8;
            this.btn6.Tag = "6";
            this.btn6.Text = "0";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Agency FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Green;
            this.btn8.Location = new System.Drawing.Point(177, 198);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(35, 64);
            this.btn8.TabIndex = 11;
            this.btn8.Tag = "8";
            this.btn8.Text = "0";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Agency FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Green;
            this.btn9.Location = new System.Drawing.Point(218, 199);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(35, 64);
            this.btn9.TabIndex = 12;
            this.btn9.Tag = "9";
            this.btn9.Text = "0";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(439, 280);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.lblIsDLS);
            this.Controls.Add(this.cboxTimeZone);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Zone Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cboxTimeZone;
        private System.Windows.Forms.Label lblIsDLS;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
    }
}

