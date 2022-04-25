namespace GMAP_Demo
{
    partial class Frm_S_StartPosisjon
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
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNyLong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNyLat = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNåværendeLong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNåværendeLat = new System.Windows.Forms.TextBox();
            this.txtNåværendeAdresse = new System.Windows.Forms.TextBox();
            this.txtNyAdresse = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Posisjon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Long";
            // 
            // txtNyLong
            // 
            this.txtNyLong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNyLong.Location = new System.Drawing.Point(9, 154);
            this.txtNyLong.Name = "txtNyLong";
            this.txtNyLong.ReadOnly = true;
            this.txtNyLong.Size = new System.Drawing.Size(261, 22);
            this.txtNyLong.TabIndex = 23;
            this.txtNyLong.Text = "Dobbelklikk på kart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Lat";
            // 
            // txtNyLat
            // 
            this.txtNyLat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNyLat.Location = new System.Drawing.Point(9, 97);
            this.txtNyLat.Name = "txtNyLat";
            this.txtNyLat.ReadOnly = true;
            this.txtNyLat.Size = new System.Drawing.Size(261, 22);
            this.txtNyLat.TabIndex = 21;
            this.txtNyLat.Text = "Dobbelklikk på kart";
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(10, 194);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 34);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Bruk som start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbInfo.Location = new System.Drawing.Point(11, 29);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(130, 16);
            this.lbInfo.TabIndex = 26;
            this.lbInfo.Text = "Info tekst til brukeren ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nåværende startpunkt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Long";
            // 
            // txtNåværendeLong
            // 
            this.txtNåværendeLong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNåværendeLong.Location = new System.Drawing.Point(9, 108);
            this.txtNåværendeLong.Name = "txtNåværendeLong";
            this.txtNåværendeLong.ReadOnly = true;
            this.txtNåværendeLong.Size = new System.Drawing.Size(261, 22);
            this.txtNåværendeLong.TabIndex = 30;
            this.txtNåværendeLong.Text = "Dobbelklikk på kart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Lat";
            // 
            // txtNåværendeLat
            // 
            this.txtNåværendeLat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNåværendeLat.Location = new System.Drawing.Point(9, 51);
            this.txtNåværendeLat.Name = "txtNåværendeLat";
            this.txtNåværendeLat.ReadOnly = true;
            this.txtNåværendeLat.Size = new System.Drawing.Size(261, 22);
            this.txtNåværendeLat.TabIndex = 28;
            this.txtNåværendeLat.Text = "Dobbelklikk på kart";
            // 
            // txtNåværendeAdresse
            // 
            this.txtNåværendeAdresse.Location = new System.Drawing.Point(307, 51);
            this.txtNåværendeAdresse.Multiline = true;
            this.txtNåværendeAdresse.Name = "txtNåværendeAdresse";
            this.txtNåværendeAdresse.ReadOnly = true;
            this.txtNåværendeAdresse.Size = new System.Drawing.Size(154, 79);
            this.txtNåværendeAdresse.TabIndex = 33;
            // 
            // txtNyAdresse
            // 
            this.txtNyAdresse.Location = new System.Drawing.Point(307, 97);
            this.txtNyAdresse.Multiline = true;
            this.txtNyAdresse.Name = "txtNyAdresse";
            this.txtNyAdresse.ReadOnly = true;
            this.txtNyAdresse.Size = new System.Drawing.Size(154, 79);
            this.txtNyAdresse.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNåværendeAdresse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNåværendeLat);
            this.groupBox1.Controls.Add(this.txtNåværendeLong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 160);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nåværende startpunkt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNyLat);
            this.groupBox2.Controls.Add(this.txtNyAdresse);
            this.groupBox2.Controls.Add(this.lbInfo);
            this.groupBox2.Controls.Add(this.txtNyLong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 242);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nytt Startpunkt";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Frm_S_StartPosisjon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 825);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_S_StartPosisjon";
            this.Text = "Frm_S_StartPosisjon";
            this.Load += new System.EventHandler(this.Frm_S_StartPosisjon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNyLong;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtNyLat;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNåværendeLong;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNåværendeLat;
        private System.Windows.Forms.TextBox txtNåværendeAdresse;
        private System.Windows.Forms.TextBox txtNyAdresse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}