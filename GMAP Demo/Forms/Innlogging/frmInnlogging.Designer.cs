﻿namespace GMAP_Demo
{
    partial class frmInnlogging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInnlogging));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnTestUser = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LbNyBruker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(127, 50);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BO22EB-16";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUserName.Location = new System.Drawing.Point(71, 155);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 16);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Brukernavn";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPassword.Location = new System.Drawing.Point(71, 201);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Passord";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUserName.Location = new System.Drawing.Point(232, 151);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(132, 22);
            this.tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.Location = new System.Drawing.Point(232, 197);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(132, 22);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(244, 241);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Logg inn";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnTestUser
            // 
            this.btnTestUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTestUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestUser.ForeColor = System.Drawing.Color.White;
            this.btnTestUser.Location = new System.Drawing.Point(244, 343);
            this.btnTestUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestUser.Name = "btnTestUser";
            this.btnTestUser.Size = new System.Drawing.Size(100, 28);
            this.btnTestUser.TabIndex = 6;
            this.btnTestUser.Text = "Testbruker";
            this.btnTestUser.UseVisualStyleBackColor = false;
            this.btnTestUser.Click += new System.EventHandler(this.btnTestUser_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTest.Location = new System.Drawing.Point(71, 350);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(141, 16);
            this.lblTest.TabIndex = 7;
            this.lblTest.Text = "Test ut programmet:";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.lblTitle2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle2.Location = new System.Drawing.Point(45, 96);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(380, 27);
            this.lblTitle2.TabIndex = 8;
            this.lblTitle2.Text = "OpenStreetMap i programmer ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Send Epost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbNyBruker
            // 
            this.LbNyBruker.AutoSize = true;
            this.LbNyBruker.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNyBruker.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LbNyBruker.Location = new System.Drawing.Point(71, 253);
            this.LbNyBruker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNyBruker.Name = "LbNyBruker";
            this.LbNyBruker.Size = new System.Drawing.Size(106, 16);
            this.LbNyBruker.TabIndex = 11;
            this.LbNyBruker.Text = "Opprett bruker";
            this.LbNyBruker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LbNyBruker_MouseClick);
            this.LbNyBruker.MouseEnter += new System.EventHandler(this.LbNyBruker_MouseEnter);
            this.LbNyBruker.MouseLeave += new System.EventHandler(this.LbNyBruker_MouseLeave);
            // 
            // frmInnlogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 444);
            this.Controls.Add(this.LbNyBruker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnTestUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(490, 481);
            this.Name = "frmInnlogging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logg inn";
            this.Load += new System.EventHandler(this.frmInnlogging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnTestUser;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LbNyBruker;
    }
}