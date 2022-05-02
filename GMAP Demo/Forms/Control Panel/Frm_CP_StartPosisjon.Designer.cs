namespace GMAP_Demo
{
    partial class Frm_CP_StartPosisjon
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNyLong = new System.Windows.Forms.Label();
            this.txtNyLong = new System.Windows.Forms.TextBox();
            this.lblNyLat = new System.Windows.Forms.Label();
            this.txtNyLat = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNåLong = new System.Windows.Forms.Label();
            this.txtNåværendeLong = new System.Windows.Forms.TextBox();
            this.lblNåLat = new System.Windows.Forms.Label();
            this.txtNåværendeLat = new System.Windows.Forms.TextBox();
            this.txtNåværendeAdresse = new System.Windows.Forms.TextBox();
            this.txtNyAdresse = new System.Windows.Forms.TextBox();
            this.gbNåverendeStartpunkt = new System.Windows.Forms.GroupBox();
            this.gbNyttStartpunkt = new System.Windows.Forms.GroupBox();
            this.gbNåverendeStartpunkt.SuspendLayout();
            this.gbNyttStartpunkt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 55);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Start Posisjon";
            // 
            // lblNyLong
            // 
            this.lblNyLong.AutoSize = true;
            this.lblNyLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyLong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.lblNyLong.Location = new System.Drawing.Point(7, 166);
            this.lblNyLong.Name = "lblNyLong";
            this.lblNyLong.Size = new System.Drawing.Size(64, 25);
            this.lblNyLong.TabIndex = 24;
            this.lblNyLong.Text = "Long";
            // 
            // txtNyLong
            // 
            this.txtNyLong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNyLong.Location = new System.Drawing.Point(10, 192);
            this.txtNyLong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNyLong.Name = "txtNyLong";
            this.txtNyLong.ReadOnly = true;
            this.txtNyLong.Size = new System.Drawing.Size(293, 26);
            this.txtNyLong.TabIndex = 23;
            this.txtNyLong.Text = "Dobbelklikk på kart";
            // 
            // lblNyLat
            // 
            this.lblNyLat.AutoSize = true;
            this.lblNyLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyLat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.lblNyLat.Location = new System.Drawing.Point(7, 95);
            this.lblNyLat.Name = "lblNyLat";
            this.lblNyLat.Size = new System.Drawing.Size(45, 25);
            this.lblNyLat.TabIndex = 22;
            this.lblNyLat.Text = "Lat";
            // 
            // txtNyLat
            // 
            this.txtNyLat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNyLat.Location = new System.Drawing.Point(10, 121);
            this.txtNyLat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNyLat.Name = "txtNyLat";
            this.txtNyLat.ReadOnly = true;
            this.txtNyLat.Size = new System.Drawing.Size(293, 26);
            this.txtNyLat.TabIndex = 21;
            this.txtNyLat.Text = "Dobbelklikk på kart";
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(11, 242);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 42);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Bruk som start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Location = new System.Drawing.Point(12, 36);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(162, 20);
            this.lblInfo.TabIndex = 26;
            this.lblInfo.Text = "Info tekst til brukeren ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nåværende startpunkt";
            // 
            // lblNåLong
            // 
            this.lblNåLong.AutoSize = true;
            this.lblNåLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNåLong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.lblNåLong.Location = new System.Drawing.Point(7, 109);
            this.lblNåLong.Name = "lblNåLong";
            this.lblNåLong.Size = new System.Drawing.Size(64, 25);
            this.lblNåLong.TabIndex = 31;
            this.lblNåLong.Text = "Long";
            // 
            // txtNåværendeLong
            // 
            this.txtNåværendeLong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNåværendeLong.Location = new System.Drawing.Point(10, 135);
            this.txtNåværendeLong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNåværendeLong.Name = "txtNåværendeLong";
            this.txtNåværendeLong.ReadOnly = true;
            this.txtNåværendeLong.Size = new System.Drawing.Size(293, 26);
            this.txtNåværendeLong.TabIndex = 30;
            this.txtNåværendeLong.Text = "Dobbelklikk på kart";
            // 
            // lblNåLat
            // 
            this.lblNåLat.AutoSize = true;
            this.lblNåLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNåLat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.lblNåLat.Location = new System.Drawing.Point(7, 38);
            this.lblNåLat.Name = "lblNåLat";
            this.lblNåLat.Size = new System.Drawing.Size(45, 25);
            this.lblNåLat.TabIndex = 29;
            this.lblNåLat.Text = "Lat";
            // 
            // txtNåværendeLat
            // 
            this.txtNåværendeLat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNåværendeLat.Location = new System.Drawing.Point(10, 64);
            this.txtNåværendeLat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNåværendeLat.Name = "txtNåværendeLat";
            this.txtNåværendeLat.ReadOnly = true;
            this.txtNåværendeLat.Size = new System.Drawing.Size(293, 26);
            this.txtNåværendeLat.TabIndex = 28;
            this.txtNåværendeLat.Text = "Dobbelklikk på kart";
            // 
            // txtNåværendeAdresse
            // 
            this.txtNåværendeAdresse.Location = new System.Drawing.Point(345, 64);
            this.txtNåværendeAdresse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNåværendeAdresse.Multiline = true;
            this.txtNåværendeAdresse.Name = "txtNåværendeAdresse";
            this.txtNåværendeAdresse.ReadOnly = true;
            this.txtNåværendeAdresse.Size = new System.Drawing.Size(173, 98);
            this.txtNåværendeAdresse.TabIndex = 33;
            // 
            // txtNyAdresse
            // 
            this.txtNyAdresse.Location = new System.Drawing.Point(345, 121);
            this.txtNyAdresse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNyAdresse.Multiline = true;
            this.txtNyAdresse.Name = "txtNyAdresse";
            this.txtNyAdresse.ReadOnly = true;
            this.txtNyAdresse.Size = new System.Drawing.Size(173, 98);
            this.txtNyAdresse.TabIndex = 34;
            // 
            // gbNåverendeStartpunkt
            // 
            this.gbNåverendeStartpunkt.Controls.Add(this.txtNåværendeAdresse);
            this.gbNåverendeStartpunkt.Controls.Add(this.lblNåLat);
            this.gbNåverendeStartpunkt.Controls.Add(this.txtNåværendeLat);
            this.gbNåverendeStartpunkt.Controls.Add(this.txtNåværendeLong);
            this.gbNåverendeStartpunkt.Controls.Add(this.lblNåLong);
            this.gbNåverendeStartpunkt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbNåverendeStartpunkt.Location = new System.Drawing.Point(14, 128);
            this.gbNåverendeStartpunkt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNåverendeStartpunkt.Name = "gbNåverendeStartpunkt";
            this.gbNåverendeStartpunkt.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNåverendeStartpunkt.Size = new System.Drawing.Size(526, 200);
            this.gbNåverendeStartpunkt.TabIndex = 35;
            this.gbNåverendeStartpunkt.TabStop = false;
            this.gbNåverendeStartpunkt.Text = "Nåværende startpunkt";
            // 
            // gbNyttStartpunkt
            // 
            this.gbNyttStartpunkt.Controls.Add(this.lblNyLat);
            this.gbNyttStartpunkt.Controls.Add(this.txtNyLat);
            this.gbNyttStartpunkt.Controls.Add(this.txtNyAdresse);
            this.gbNyttStartpunkt.Controls.Add(this.lblInfo);
            this.gbNyttStartpunkt.Controls.Add(this.txtNyLong);
            this.gbNyttStartpunkt.Controls.Add(this.lblNyLong);
            this.gbNyttStartpunkt.Controls.Add(this.btnStart);
            this.gbNyttStartpunkt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbNyttStartpunkt.Location = new System.Drawing.Point(14, 361);
            this.gbNyttStartpunkt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNyttStartpunkt.Name = "gbNyttStartpunkt";
            this.gbNyttStartpunkt.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNyttStartpunkt.Size = new System.Drawing.Size(526, 302);
            this.gbNyttStartpunkt.TabIndex = 36;
            this.gbNyttStartpunkt.TabStop = false;
            this.gbNyttStartpunkt.Text = "Nytt Startpunkt";
            this.gbNyttStartpunkt.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Frm_S_StartPosisjon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1440, 1031);
            this.Controls.Add(this.gbNyttStartpunkt);
            this.Controls.Add(this.gbNåverendeStartpunkt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_S_StartPosisjon";
            this.Text = "Frm_S_StartPosisjon";
            this.Load += new System.EventHandler(this.Frm_S_StartPosisjon_Load);
            this.gbNåverendeStartpunkt.ResumeLayout(false);
            this.gbNåverendeStartpunkt.PerformLayout();
            this.gbNyttStartpunkt.ResumeLayout(false);
            this.gbNyttStartpunkt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNyLong;
        public System.Windows.Forms.TextBox txtNyLong;
        private System.Windows.Forms.Label lblNyLat;
        public System.Windows.Forms.TextBox txtNyLat;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNåLong;
        public System.Windows.Forms.TextBox txtNåværendeLong;
        private System.Windows.Forms.Label lblNåLat;
        public System.Windows.Forms.TextBox txtNåværendeLat;
        private System.Windows.Forms.TextBox txtNåværendeAdresse;
        private System.Windows.Forms.TextBox txtNyAdresse;
        private System.Windows.Forms.GroupBox gbNåverendeStartpunkt;
        private System.Windows.Forms.GroupBox gbNyttStartpunkt;
    }
}