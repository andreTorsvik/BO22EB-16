namespace GMAP_Demo
{
    partial class frm_R_RedigerOmråde
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
            this.lbTilgjengligFarge = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfarge = new System.Windows.Forms.TextBox();
            this.txtNrPunkt = new System.Windows.Forms.TextBox();
            this.lbPunkter = new System.Windows.Forms.ListBox();
            this.btnLeggTilPunkt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNyOverlay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKommentar = new System.Windows.Forms.TextBox();
            this.btnLeggTilOverlay = new System.Windows.Forms.Button();
            this.lbValgtOverlays = new System.Windows.Forms.ListBox();
            this.lbTilgjengeligeOverlays = new System.Windows.Forms.ListBox();
            this.LabelSikkerhetsklarering = new System.Windows.Forms.Label();
            this.txtSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.btnFjernPunktIListe = new System.Windows.Forms.Button();
            this.btnLagreEndring = new System.Windows.Forms.Button();
            this.gbOmråde = new System.Windows.Forms.GroupBox();
            this.gbOverlay = new System.Windows.Forms.GroupBox();
            this.gbOmråde.SuspendLayout();
            this.gbOverlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rediger Område";
            // 
            // lbTilgjengligFarge
            // 
            this.lbTilgjengligFarge.FormattingEnabled = true;
            this.lbTilgjengligFarge.ItemHeight = 20;
            this.lbTilgjengligFarge.Location = new System.Drawing.Point(6, 213);
            this.lbTilgjengligFarge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTilgjengligFarge.Name = "lbTilgjengligFarge";
            this.lbTilgjengligFarge.Size = new System.Drawing.Size(155, 44);
            this.lbTilgjengligFarge.TabIndex = 80;
            this.lbTilgjengligFarge.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTilgjengligFarge_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Farge";
            // 
            // txtfarge
            // 
            this.txtfarge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtfarge.Location = new System.Drawing.Point(171, 212);
            this.txtfarge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfarge.Name = "txtfarge";
            this.txtfarge.ReadOnly = true;
            this.txtfarge.Size = new System.Drawing.Size(155, 26);
            this.txtfarge.TabIndex = 78;
            // 
            // txtNrPunkt
            // 
            this.txtNrPunkt.Location = new System.Drawing.Point(130, 378);
            this.txtNrPunkt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNrPunkt.Name = "txtNrPunkt";
            this.txtNrPunkt.Size = new System.Drawing.Size(31, 26);
            this.txtNrPunkt.TabIndex = 77;
            this.txtNrPunkt.Text = "0";
            // 
            // lbPunkter
            // 
            this.lbPunkter.FormattingEnabled = true;
            this.lbPunkter.ItemHeight = 20;
            this.lbPunkter.Location = new System.Drawing.Point(6, 416);
            this.lbPunkter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbPunkter.Name = "lbPunkter";
            this.lbPunkter.Size = new System.Drawing.Size(320, 104);
            this.lbPunkter.TabIndex = 76;
            // 
            // btnLeggTilPunkt
            // 
            this.btnLeggTilPunkt.Location = new System.Drawing.Point(6, 374);
            this.btnLeggTilPunkt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeggTilPunkt.Name = "btnLeggTilPunkt";
            this.btnLeggTilPunkt.Size = new System.Drawing.Size(117, 35);
            this.btnLeggTilPunkt.TabIndex = 75;
            this.btnLeggTilPunkt.Text = "Legg til punkt";
            this.btnLeggTilPunkt.UseVisualStyleBackColor = true;
            this.btnLeggTilPunkt.Click += new System.EventHandler(this.btnLeggTilPunkt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(171, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Valgt for dette område";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(6, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "Ekisterende";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(6, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 72;
            this.label9.Text = "Ny Overlay ";
            // 
            // txtNyOverlay
            // 
            this.txtNyOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.txtNyOverlay.Location = new System.Drawing.Point(6, 359);
            this.txtNyOverlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNyOverlay.Name = "txtNyOverlay";
            this.txtNyOverlay.Size = new System.Drawing.Size(137, 26);
            this.txtNyOverlay.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Velg Hvilke overlays";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(6, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Long";
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.SystemColors.Control;
            this.txtLong.Location = new System.Drawing.Point(6, 339);
            this.txtLong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(320, 26);
            this.txtLong.TabIndex = 68;
            this.txtLong.Text = "Dobbelklikk på kartet + \"legg til";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(6, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Lat";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.Control;
            this.txtLat.Location = new System.Drawing.Point(6, 284);
            this.txtLat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(322, 26);
            this.txtLat.TabIndex = 66;
            this.txtLat.Text = "Dobbelklikk på kartet + \"legg til";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Kommentar";
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(6, 158);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.Size = new System.Drawing.Size(320, 26);
            this.txtKommentar.TabIndex = 64;
            // 
            // btnLeggTilOverlay
            // 
            this.btnLeggTilOverlay.Location = new System.Drawing.Point(150, 357);
            this.btnLeggTilOverlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeggTilOverlay.Name = "btnLeggTilOverlay";
            this.btnLeggTilOverlay.Size = new System.Drawing.Size(82, 34);
            this.btnLeggTilOverlay.TabIndex = 63;
            this.btnLeggTilOverlay.Text = "Legg til";
            this.btnLeggTilOverlay.UseVisualStyleBackColor = true;
            this.btnLeggTilOverlay.Click += new System.EventHandler(this.btnLeggTilOverlay_Click);
            // 
            // lbValgtOverlays
            // 
            this.lbValgtOverlays.FormattingEnabled = true;
            this.lbValgtOverlays.ItemHeight = 20;
            this.lbValgtOverlays.Location = new System.Drawing.Point(171, 77);
            this.lbValgtOverlays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbValgtOverlays.Name = "lbValgtOverlays";
            this.lbValgtOverlays.Size = new System.Drawing.Size(157, 244);
            this.lbValgtOverlays.TabIndex = 62;
            this.lbValgtOverlays.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbValgtOverlays_MouseDoubleClick);
            // 
            // lbTilgjengeligeOverlays
            // 
            this.lbTilgjengeligeOverlays.FormattingEnabled = true;
            this.lbTilgjengeligeOverlays.ItemHeight = 20;
            this.lbTilgjengeligeOverlays.Location = new System.Drawing.Point(6, 77);
            this.lbTilgjengeligeOverlays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTilgjengeligeOverlays.Name = "lbTilgjengeligeOverlays";
            this.lbTilgjengeligeOverlays.Size = new System.Drawing.Size(158, 244);
            this.lbTilgjengeligeOverlays.TabIndex = 61;
            this.lbTilgjengeligeOverlays.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTilgjengeligeOverlays_MouseDoubleClick);
            // 
            // LabelSikkerhetsklarering
            // 
            this.LabelSikkerhetsklarering.AutoSize = true;
            this.LabelSikkerhetsklarering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSikkerhetsklarering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelSikkerhetsklarering.Location = new System.Drawing.Point(6, 76);
            this.LabelSikkerhetsklarering.Name = "LabelSikkerhetsklarering";
            this.LabelSikkerhetsklarering.Size = new System.Drawing.Size(184, 17);
            this.LabelSikkerhetsklarering.TabIndex = 60;
            this.LabelSikkerhetsklarering.Text = "Sikkerhetsklarering(1-3)";
            // 
            // txtSikkerhetsklarering
            // 
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(6, 103);
            this.txtSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSikkerhetsklarering.Name = "txtSikkerhetsklarering";
            this.txtSikkerhetsklarering.Size = new System.Drawing.Size(322, 26);
            this.txtSikkerhetsklarering.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Navn";
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(6, 48);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.Size = new System.Drawing.Size(320, 26);
            this.txtNavn.TabIndex = 57;
            // 
            // btnFjernPunktIListe
            // 
            this.btnFjernPunktIListe.Location = new System.Drawing.Point(195, 374);
            this.btnFjernPunktIListe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFjernPunktIListe.Name = "btnFjernPunktIListe";
            this.btnFjernPunktIListe.Size = new System.Drawing.Size(132, 35);
            this.btnFjernPunktIListe.TabIndex = 81;
            this.btnFjernPunktIListe.Text = "Fjern punktene";
            this.btnFjernPunktIListe.UseVisualStyleBackColor = true;
            this.btnFjernPunktIListe.Click += new System.EventHandler(this.btnFjernPunktIListe_Click);
            // 
            // btnLagreEndring
            // 
            this.btnLagreEndring.Location = new System.Drawing.Point(21, 982);
            this.btnLagreEndring.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLagreEndring.Name = "btnLagreEndring";
            this.btnLagreEndring.Size = new System.Drawing.Size(138, 42);
            this.btnLagreEndring.TabIndex = 82;
            this.btnLagreEndring.Text = "Lagre endring";
            this.btnLagreEndring.UseVisualStyleBackColor = true;
            this.btnLagreEndring.Click += new System.EventHandler(this.btnLagreEndring_Click);
            // 
            // gbOmråde
            // 
            this.gbOmråde.Controls.Add(this.label1);
            this.gbOmråde.Controls.Add(this.txtNavn);
            this.gbOmråde.Controls.Add(this.txtSikkerhetsklarering);
            this.gbOmråde.Controls.Add(this.btnFjernPunktIListe);
            this.gbOmråde.Controls.Add(this.LabelSikkerhetsklarering);
            this.gbOmråde.Controls.Add(this.lbTilgjengligFarge);
            this.gbOmråde.Controls.Add(this.txtKommentar);
            this.gbOmråde.Controls.Add(this.label2);
            this.gbOmråde.Controls.Add(this.label5);
            this.gbOmråde.Controls.Add(this.txtfarge);
            this.gbOmråde.Controls.Add(this.txtLat);
            this.gbOmråde.Controls.Add(this.txtNrPunkt);
            this.gbOmråde.Controls.Add(this.label8);
            this.gbOmråde.Controls.Add(this.lbPunkter);
            this.gbOmråde.Controls.Add(this.txtLong);
            this.gbOmråde.Controls.Add(this.btnLeggTilPunkt);
            this.gbOmråde.Controls.Add(this.label7);
            this.gbOmråde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbOmråde.Location = new System.Drawing.Point(21, 51);
            this.gbOmråde.Name = "gbOmråde";
            this.gbOmråde.Size = new System.Drawing.Size(335, 527);
            this.gbOmråde.TabIndex = 83;
            this.gbOmråde.TabStop = false;
            this.gbOmråde.Text = "Område";
            // 
            // gbOverlay
            // 
            this.gbOverlay.Controls.Add(this.label6);
            this.gbOverlay.Controls.Add(this.lbTilgjengeligeOverlays);
            this.gbOverlay.Controls.Add(this.lbValgtOverlays);
            this.gbOverlay.Controls.Add(this.label11);
            this.gbOverlay.Controls.Add(this.btnLeggTilOverlay);
            this.gbOverlay.Controls.Add(this.label10);
            this.gbOverlay.Controls.Add(this.txtNyOverlay);
            this.gbOverlay.Controls.Add(this.label9);
            this.gbOverlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbOverlay.Location = new System.Drawing.Point(21, 584);
            this.gbOverlay.Name = "gbOverlay";
            this.gbOverlay.Size = new System.Drawing.Size(335, 391);
            this.gbOverlay.TabIndex = 83;
            this.gbOverlay.TabStop = false;
            this.gbOverlay.Text = "Overlay";
            // 
            // frm_R_RedigerOmråde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(440, 1031);
            this.Controls.Add(this.gbOverlay);
            this.Controls.Add(this.gbOmråde);
            this.Controls.Add(this.btnLagreEndring);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_R_RedigerOmråde";
            this.Text = "frm_R_RedigerOmråde";
            this.Load += new System.EventHandler(this.frm_R_RedigerOmråde_Load);
            this.gbOmråde.ResumeLayout(false);
            this.gbOmråde.PerformLayout();
            this.gbOverlay.ResumeLayout(false);
            this.gbOverlay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTilgjengligFarge;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtfarge;
        public System.Windows.Forms.TextBox txtNrPunkt;
        public System.Windows.Forms.ListBox lbPunkter;
        private System.Windows.Forms.Button btnLeggTilPunkt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtNyOverlay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtKommentar;
        private System.Windows.Forms.Button btnLeggTilOverlay;
        private System.Windows.Forms.ListBox lbValgtOverlays;
        private System.Windows.Forms.ListBox lbTilgjengeligeOverlays;
        private System.Windows.Forms.Label LabelSikkerhetsklarering;
        public System.Windows.Forms.TextBox txtSikkerhetsklarering;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.Button btnFjernPunktIListe;
        private System.Windows.Forms.Button btnLagreEndring;
        private System.Windows.Forms.GroupBox gbOmråde;
        private System.Windows.Forms.GroupBox gbOverlay;
    }
}