namespace GMAP_Demo
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
            this.LbNyBruker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(142, 63);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BO22EB-16";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblUserName.Location = new System.Drawing.Point(80, 194);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(69, 14);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Brukernavn";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblPassword.Location = new System.Drawing.Point(80, 251);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(49, 14);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Passord";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUserName.Location = new System.Drawing.Point(261, 189);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(148, 26);
            this.tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.Location = new System.Drawing.Point(261, 246);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(148, 26);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(274, 302);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Logg inn";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnTestUser
            // 
            this.btnTestUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnTestUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestUser.ForeColor = System.Drawing.Color.White;
            this.btnTestUser.Location = new System.Drawing.Point(274, 475);
            this.btnTestUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTestUser.Name = "btnTestUser";
            this.btnTestUser.Size = new System.Drawing.Size(112, 35);
            this.btnTestUser.TabIndex = 6;
            this.btnTestUser.Text = "Testbruker";
            this.btnTestUser.UseVisualStyleBackColor = false;
            this.btnTestUser.Click += new System.EventHandler(this.btnTestUser_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblTest.Location = new System.Drawing.Point(80, 483);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(115, 14);
            this.lblTest.TabIndex = 7;
            this.lblTest.Text = "Test ut programmet:";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblTitle2.Location = new System.Drawing.Point(51, 120);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(292, 22);
            this.lblTitle2.TabIndex = 8;
            this.lblTitle2.Text = "OpenStreetMap i programmer ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GMAP_Demo.Properties.Resources.HVL;
            this.pictureBox1.Location = new System.Drawing.Point(57, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LbNyBruker
            // 
            this.LbNyBruker.AutoSize = true;
            this.LbNyBruker.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNyBruker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.LbNyBruker.Location = new System.Drawing.Point(285, 359);
            this.LbNyBruker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNyBruker.Name = "LbNyBruker";
            this.LbNyBruker.Size = new System.Drawing.Size(87, 14);
            this.LbNyBruker.TabIndex = 11;
            this.LbNyBruker.Text = "Opprett bruker";
            this.LbNyBruker.Click += new System.EventHandler(this.LbNyBruker_Click);
            this.LbNyBruker.MouseEnter += new System.EventHandler(this.LbNyBruker_MouseEnter);
            this.LbNyBruker.MouseLeave += new System.EventHandler(this.LbNyBruker_MouseLeave);
            // 
            // frmInnlogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 543);
            this.Controls.Add(this.LbNyBruker);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(547, 582);
            this.MinimumSize = new System.Drawing.Size(547, 582);
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
        private System.Windows.Forms.Label LbNyBruker;
    }
}