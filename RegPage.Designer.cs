namespace ZhiCoffee
{
    partial class RegPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorLog = new System.Windows.Forms.Label();
            this.LoginRegField = new System.Windows.Forms.TextBox();
            this.ErrorPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMail = new System.Windows.Forms.Label();
            this.RegBut = new System.Windows.Forms.Button();
            this.PassRegField = new System.Windows.Forms.TextBox();
            this.Reg = new System.Windows.Forms.Label();
            this.MailField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.timerReg = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(133)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ErrorLog);
            this.panel1.Controls.Add(this.LoginRegField);
            this.panel1.Controls.Add(this.ErrorPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ErrorMail);
            this.panel1.Controls.Add(this.RegBut);
            this.panel1.Controls.Add(this.PassRegField);
            this.panel1.Controls.Add(this.Reg);
            this.panel1.Controls.Add(this.MailField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 402);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 24);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ErrorLog
            // 
            this.ErrorLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ErrorLog.AutoSize = true;
            this.ErrorLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ErrorLog.Location = new System.Drawing.Point(120, 188);
            this.ErrorLog.Name = "ErrorLog";
            this.ErrorLog.Size = new System.Drawing.Size(0, 16);
            this.ErrorLog.TabIndex = 10;
            // 
            // LoginRegField
            // 
            this.LoginRegField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginRegField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginRegField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginRegField.Location = new System.Drawing.Point(118, 207);
            this.LoginRegField.Name = "LoginRegField";
            this.LoginRegField.Size = new System.Drawing.Size(220, 30);
            this.LoginRegField.TabIndex = 9;
            this.LoginRegField.TabStop = false;
            this.LoginRegField.Text = "Введите логин";
            this.LoginRegField.Click += new System.EventHandler(this.LoginRegField_Click);
            // 
            // ErrorPass
            // 
            this.ErrorPass.AutoSize = true;
            this.ErrorPass.Location = new System.Drawing.Point(120, 244);
            this.ErrorPass.Name = "ErrorPass";
            this.ErrorPass.Size = new System.Drawing.Size(0, 16);
            this.ErrorPass.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // ErrorMail
            // 
            this.ErrorMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ErrorMail.AutoSize = true;
            this.ErrorMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ErrorMail.Location = new System.Drawing.Point(121, 127);
            this.ErrorMail.Name = "ErrorMail";
            this.ErrorMail.Size = new System.Drawing.Size(0, 16);
            this.ErrorMail.TabIndex = 6;
            // 
            // RegBut
            // 
            this.RegBut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RegBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(133)))), ((int)(((byte)(83)))));
            this.RegBut.FlatAppearance.BorderSize = 0;
            this.RegBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(37)))));
            this.RegBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBut.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBut.ForeColor = System.Drawing.Color.Moccasin;
            this.RegBut.Location = new System.Drawing.Point(117, 318);
            this.RegBut.Name = "RegBut";
            this.RegBut.Size = new System.Drawing.Size(223, 40);
            this.RegBut.TabIndex = 5;
            this.RegBut.TabStop = false;
            this.RegBut.Text = "Зарегистрироваться";
            this.RegBut.UseVisualStyleBackColor = true;
            this.RegBut.Click += new System.EventHandler(this.RegBut_Click);
            // 
            // PassRegField
            // 
            this.PassRegField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassRegField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassRegField.Location = new System.Drawing.Point(118, 263);
            this.PassRegField.Name = "PassRegField";
            this.PassRegField.Size = new System.Drawing.Size(220, 30);
            this.PassRegField.TabIndex = 3;
            this.PassRegField.TabStop = false;
            this.PassRegField.Text = "Введите пароль";
            this.PassRegField.Click += new System.EventHandler(this.PassRegField_Click);
            // 
            // Reg
            // 
            this.Reg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Reg.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg.Location = new System.Drawing.Point(0, 62);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(441, 53);
            this.Reg.TabIndex = 2;
            this.Reg.Text = "  Регистрация";
            this.Reg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MailField
            // 
            this.MailField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MailField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MailField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailField.Location = new System.Drawing.Point(118, 146);
            this.MailField.Name = "MailField";
            this.MailField.Size = new System.Drawing.Size(220, 30);
            this.MailField.TabIndex = 1;
            this.MailField.TabStop = false;
            this.MailField.Text = "Ведите e-mail";
            this.MailField.Click += new System.EventHandler(this.MailField_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.Label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 62);
            this.panel2.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(441, 62);
            this.Label.TabIndex = 0;
            this.Label.Text = "EFKO Products";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerReg
            // 
            this.timerReg.Interval = 1000;
            this.timerReg.Tick += new System.EventHandler(this.timerReg_Tick);
            // 
            // RegPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(441, 402);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegPage_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ErrorMail;
        private System.Windows.Forms.Button RegBut;
        private System.Windows.Forms.Label Reg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerReg;
        private System.Windows.Forms.Label ErrorPass;
        private System.Windows.Forms.Label ErrorLog;
        public System.Windows.Forms.TextBox PassRegField;
        public System.Windows.Forms.TextBox MailField;
        public System.Windows.Forms.TextBox LoginRegField;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}