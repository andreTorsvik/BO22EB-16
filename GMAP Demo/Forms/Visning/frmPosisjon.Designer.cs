namespace GMAP_Demo
{
    partial class frmPosisjon
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
            this.txtLand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtByKommune = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.btnSøk = new System.Windows.Forms.Button();
            this.txtFra = new System.Windows.Forms.TextBox();
            this.txtTil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSlutt = new System.Windows.Forms.Button();
            this.btnFinnRute = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.btnFjernRute = new System.Windows.Forms.Button();
            this.LbDistanse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posisjon";
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(22, 138);
            this.txtLand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(293, 26);
            this.txtLand.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(19, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Land";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(19, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "By/Kommune";
            // 
            // txtByKommune
            // 
            this.txtByKommune.Location = new System.Drawing.Point(22, 211);
            this.txtByKommune.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtByKommune.Name = "txtByKommune";
            this.txtByKommune.Size = new System.Drawing.Size(293, 26);
            this.txtByKommune.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(19, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(22, 282);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(293, 26);
            this.txtAdresse.TabIndex = 7;
            // 
            // btnSøk
            // 
            this.btnSøk.Location = new System.Drawing.Point(22, 329);
            this.btnSøk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSøk.Name = "btnSøk";
            this.btnSøk.Size = new System.Drawing.Size(108, 42);
            this.btnSøk.TabIndex = 9;
            this.btnSøk.Text = "Søk";
            this.btnSøk.UseVisualStyleBackColor = true;
            this.btnSøk.Click += new System.EventHandler(this.btnSøk_Click);
            // 
            // txtFra
            // 
            this.txtFra.Location = new System.Drawing.Point(24, 696);
            this.txtFra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFra.Multiline = true;
            this.txtFra.Name = "txtFra";
            this.txtFra.ReadOnly = true;
            this.txtFra.Size = new System.Drawing.Size(173, 133);
            this.txtFra.TabIndex = 10;
            // 
            // txtTil
            // 
            this.txtTil.Location = new System.Drawing.Point(204, 696);
            this.txtTil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTil.Multiline = true;
            this.txtTil.Name = "txtTil";
            this.txtTil.ReadOnly = true;
            this.txtTil.Size = new System.Drawing.Size(173, 133);
            this.txtTil.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(19, 668);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(199, 668);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Til";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 604);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 42);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Bruk som start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSlutt
            // 
            this.btnSlutt.Location = new System.Drawing.Point(201, 604);
            this.btnSlutt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSlutt.Name = "btnSlutt";
            this.btnSlutt.Size = new System.Drawing.Size(130, 42);
            this.btnSlutt.TabIndex = 15;
            this.btnSlutt.Text = "Bruk som Mål";
            this.btnSlutt.UseVisualStyleBackColor = true;
            this.btnSlutt.Click += new System.EventHandler(this.btnSlutt_Click);
            // 
            // btnFinnRute
            // 
            this.btnFinnRute.Location = new System.Drawing.Point(22, 838);
            this.btnFinnRute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinnRute.Name = "btnFinnRute";
            this.btnFinnRute.Size = new System.Drawing.Size(115, 42);
            this.btnFinnRute.TabIndex = 16;
            this.btnFinnRute.Text = "Finn Rute";
            this.btnFinnRute.UseVisualStyleBackColor = true;
            this.btnFinnRute.Click += new System.EventHandler(this.btnFinnRute_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(19, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Long";
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLong.Location = new System.Drawing.Point(22, 535);
            this.txtLong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLong.Name = "txtLong";
            this.txtLong.ReadOnly = true;
            this.txtLong.Size = new System.Drawing.Size(293, 26);
            this.txtLong.TabIndex = 19;
            this.txtLong.Text = "Dobbelklikk på kart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(19, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lat";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLat.Location = new System.Drawing.Point(22, 464);
            this.txtLat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLat.Name = "txtLat";
            this.txtLat.ReadOnly = true;
            this.txtLat.Size = new System.Drawing.Size(293, 26);
            this.txtLat.TabIndex = 17;
            this.txtLat.Text = "Dobbelklikk på kart";
            // 
            // btnFjernRute
            // 
            this.btnFjernRute.Location = new System.Drawing.Point(201, 838);
            this.btnFjernRute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFjernRute.Name = "btnFjernRute";
            this.btnFjernRute.Size = new System.Drawing.Size(115, 42);
            this.btnFjernRute.TabIndex = 21;
            this.btnFjernRute.Text = "Fjern Rute";
            this.btnFjernRute.UseVisualStyleBackColor = true;
            this.btnFjernRute.Click += new System.EventHandler(this.btnFjernRute_Click);
            // 
            // LbDistanse
            // 
            this.LbDistanse.AutoSize = true;
            this.LbDistanse.ForeColor = System.Drawing.SystemColors.Control;
            this.LbDistanse.Location = new System.Drawing.Point(20, 884);
            this.LbDistanse.Name = "LbDistanse";
            this.LbDistanse.Size = new System.Drawing.Size(114, 20);
            this.LbDistanse.TabIndex = 22;
            this.LbDistanse.Text = "[Distanse i Km]";
            // 
            // frmPosisjon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(459, 1090);
            this.Controls.Add(this.LbDistanse);
            this.Controls.Add(this.btnFjernRute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.btnFinnRute);
            this.Controls.Add(this.btnSlutt);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTil);
            this.Controls.Add(this.txtFra);
            this.Controls.Add(this.btnSøk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtByKommune);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPosisjon";
            this.Text = "frmPosisjon";
            this.Load += new System.EventHandler(this.frmPosisjon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtByKommune;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Button btnSøk;
        private System.Windows.Forms.TextBox txtFra;
        private System.Windows.Forms.TextBox txtTil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSlutt;
        private System.Windows.Forms.Button btnFinnRute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFjernRute;
        public System.Windows.Forms.TextBox txtLong;
        public System.Windows.Forms.TextBox txtLat;
        public System.Windows.Forms.Label LbDistanse;
    }
}