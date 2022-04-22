namespace GMAP_Demo
{
    partial class frm_R_LeggTilObjekt
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
            this.btnLeggTilObjekt = new System.Windows.Forms.Button();
            this.LabelSikkerhetsklarering = new System.Windows.Forms.Label();
            this.txtSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.lbTilgjengeligeOverlays = new System.Windows.Forms.ListBox();
            this.lbValgtOverlays = new System.Windows.Forms.ListBox();
            this.btnLeggTilOverlay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKommentar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNyOverlay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTilgjengligKategori = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtNyKategori = new System.Windows.Forms.TextBox();
            this.btnLeggTilNyKategori = new System.Windows.Forms.Button();
            this.gbOverlay = new System.Windows.Forms.GroupBox();
            this.gbObjekt = new System.Windows.Forms.GroupBox();
            this.gbOverlay.SuspendLayout();
            this.gbObjekt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Legg til Objekt";
            // 
            // btnLeggTilObjekt
            // 
            this.btnLeggTilObjekt.Location = new System.Drawing.Point(21, 878);
            this.btnLeggTilObjekt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilObjekt.Name = "btnLeggTilObjekt";
            this.btnLeggTilObjekt.Size = new System.Drawing.Size(138, 42);
            this.btnLeggTilObjekt.TabIndex = 16;
            this.btnLeggTilObjekt.Text = "Lagre objekt";
            this.btnLeggTilObjekt.UseVisualStyleBackColor = true;
            this.btnLeggTilObjekt.Click += new System.EventHandler(this.btnLeggTilObjekt_Click);
            // 
            // LabelSikkerhetsklarering
            // 
            this.LabelSikkerhetsklarering.AutoSize = true;
            this.LabelSikkerhetsklarering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSikkerhetsklarering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelSikkerhetsklarering.Location = new System.Drawing.Point(7, 80);
            this.LabelSikkerhetsklarering.Name = "LabelSikkerhetsklarering";
            this.LabelSikkerhetsklarering.Size = new System.Drawing.Size(184, 17);
            this.LabelSikkerhetsklarering.TabIndex = 15;
            this.LabelSikkerhetsklarering.Text = "Sikkerhetsklarering(1-3)";
            // 
            // txtSikkerhetsklarering
            // 
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(7, 104);
            this.txtSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSikkerhetsklarering.MaxLength = 1;
            this.txtSikkerhetsklarering.Name = "txtSikkerhetsklarering";
            this.txtSikkerhetsklarering.Size = new System.Drawing.Size(322, 26);
            this.txtSikkerhetsklarering.TabIndex = 14;
            this.txtSikkerhetsklarering.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSikkerhetsklarering_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Navn";
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(7, 48);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.Size = new System.Drawing.Size(320, 26);
            this.txtNavn.TabIndex = 10;
            // 
            // lbTilgjengeligeOverlays
            // 
            this.lbTilgjengeligeOverlays.FormattingEnabled = true;
            this.lbTilgjengeligeOverlays.ItemHeight = 20;
            this.lbTilgjengeligeOverlays.Location = new System.Drawing.Point(6, 71);
            this.lbTilgjengeligeOverlays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTilgjengeligeOverlays.Name = "lbTilgjengeligeOverlays";
            this.lbTilgjengeligeOverlays.Size = new System.Drawing.Size(158, 244);
            this.lbTilgjengeligeOverlays.TabIndex = 17;
            this.lbTilgjengeligeOverlays.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTilgjengelige_MouseDoubleClick);
            // 
            // lbValgtOverlays
            // 
            this.lbValgtOverlays.FormattingEnabled = true;
            this.lbValgtOverlays.ItemHeight = 20;
            this.lbValgtOverlays.Location = new System.Drawing.Point(171, 71);
            this.lbValgtOverlays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbValgtOverlays.Name = "lbValgtOverlays";
            this.lbValgtOverlays.Size = new System.Drawing.Size(157, 244);
            this.lbValgtOverlays.TabIndex = 18;
            this.lbValgtOverlays.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbValgtOverlays_MouseDoubleClick);
            // 
            // btnLeggTilOverlay
            // 
            this.btnLeggTilOverlay.Location = new System.Drawing.Point(147, 345);
            this.btnLeggTilOverlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilOverlay.Name = "btnLeggTilOverlay";
            this.btnLeggTilOverlay.Size = new System.Drawing.Size(82, 34);
            this.btnLeggTilOverlay.TabIndex = 19;
            this.btnLeggTilOverlay.Text = "Legg til";
            this.btnLeggTilOverlay.UseVisualStyleBackColor = true;
            this.btnLeggTilOverlay.Click += new System.EventHandler(this.btnLeggTilOverlay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(6, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kommentar";
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(6, 274);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.Size = new System.Drawing.Size(320, 26);
            this.txtKommentar.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(6, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Long";
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.SystemColors.Control;
            this.txtLong.Location = new System.Drawing.Point(6, 392);
            this.txtLong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(320, 26);
            this.txtLong.TabIndex = 25;
            this.txtLong.Text = "Dobbelklikk på kartet ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(6, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Lat";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.Control;
            this.txtLat.Location = new System.Drawing.Point(6, 332);
            this.txtLat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(322, 26);
            this.txtLat.TabIndex = 23;
            this.txtLat.Text = "Dobbelklikk på kartet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Velg Hvilke overlays";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(6, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ny Overlay ";
            // 
            // txtNyOverlay
            // 
            this.txtNyOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.txtNyOverlay.Location = new System.Drawing.Point(4, 347);
            this.txtNyOverlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNyOverlay.Name = "txtNyOverlay";
            this.txtNyOverlay.Size = new System.Drawing.Size(136, 26);
            this.txtNyOverlay.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Ekisterende";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(171, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "valgt for dette Objektet";
            // 
            // lbTilgjengligKategori
            // 
            this.lbTilgjengligKategori.FormattingEnabled = true;
            this.lbTilgjengligKategori.ItemHeight = 20;
            this.lbTilgjengligKategori.Location = new System.Drawing.Point(7, 160);
            this.lbTilgjengligKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTilgjengligKategori.Name = "lbTilgjengligKategori";
            this.lbTilgjengligKategori.Size = new System.Drawing.Size(155, 44);
            this.lbTilgjengligKategori.TabIndex = 61;
            this.lbTilgjengligKategori.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTilgjengligKategori_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(7, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Kategori";
            // 
            // txtKategori
            // 
            this.txtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKategori.Location = new System.Drawing.Point(172, 160);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.ReadOnly = true;
            this.txtKategori.Size = new System.Drawing.Size(155, 26);
            this.txtKategori.TabIndex = 59;
            // 
            // txtNyKategori
            // 
            this.txtNyKategori.BackColor = System.Drawing.SystemColors.Control;
            this.txtNyKategori.Location = new System.Drawing.Point(7, 216);
            this.txtNyKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNyKategori.Name = "txtNyKategori";
            this.txtNyKategori.Size = new System.Drawing.Size(156, 26);
            this.txtNyKategori.TabIndex = 63;
            // 
            // btnLeggTilNyKategori
            // 
            this.btnLeggTilNyKategori.Location = new System.Drawing.Point(175, 213);
            this.btnLeggTilNyKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilNyKategori.Name = "btnLeggTilNyKategori";
            this.btnLeggTilNyKategori.Size = new System.Drawing.Size(158, 34);
            this.btnLeggTilNyKategori.TabIndex = 62;
            this.btnLeggTilNyKategori.Text = "Legg til ny Kategori";
            this.btnLeggTilNyKategori.UseVisualStyleBackColor = true;
            this.btnLeggTilNyKategori.Click += new System.EventHandler(this.btnLeggTilNyKategori_Click);
            // 
            // gbOverlay
            // 
            this.gbOverlay.Controls.Add(this.label6);
            this.gbOverlay.Controls.Add(this.lbTilgjengeligeOverlays);
            this.gbOverlay.Controls.Add(this.label11);
            this.gbOverlay.Controls.Add(this.lbValgtOverlays);
            this.gbOverlay.Controls.Add(this.label10);
            this.gbOverlay.Controls.Add(this.btnLeggTilOverlay);
            this.gbOverlay.Controls.Add(this.label9);
            this.gbOverlay.Controls.Add(this.txtNyOverlay);
            this.gbOverlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbOverlay.Location = new System.Drawing.Point(21, 486);
            this.gbOverlay.Name = "gbOverlay";
            this.gbOverlay.Size = new System.Drawing.Size(341, 387);
            this.gbOverlay.TabIndex = 84;
            this.gbOverlay.TabStop = false;
            this.gbOverlay.Text = "Overlay";
            // 
            // gbObjekt
            // 
            this.gbObjekt.Controls.Add(this.label1);
            this.gbObjekt.Controls.Add(this.txtNavn);
            this.gbObjekt.Controls.Add(this.txtNyKategori);
            this.gbObjekt.Controls.Add(this.txtSikkerhetsklarering);
            this.gbObjekt.Controls.Add(this.btnLeggTilNyKategori);
            this.gbObjekt.Controls.Add(this.LabelSikkerhetsklarering);
            this.gbObjekt.Controls.Add(this.lbTilgjengligKategori);
            this.gbObjekt.Controls.Add(this.txtKommentar);
            this.gbObjekt.Controls.Add(this.label2);
            this.gbObjekt.Controls.Add(this.label5);
            this.gbObjekt.Controls.Add(this.txtKategori);
            this.gbObjekt.Controls.Add(this.txtLat);
            this.gbObjekt.Controls.Add(this.label8);
            this.gbObjekt.Controls.Add(this.txtLong);
            this.gbObjekt.Controls.Add(this.label7);
            this.gbObjekt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbObjekt.Location = new System.Drawing.Point(21, 51);
            this.gbObjekt.Name = "gbObjekt";
            this.gbObjekt.Size = new System.Drawing.Size(341, 429);
            this.gbObjekt.TabIndex = 85;
            this.gbObjekt.TabStop = false;
            this.gbObjekt.Text = "Objekt";
            // 
            // frm_R_LeggTilObjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(440, 1031);
            this.Controls.Add(this.gbOverlay);
            this.Controls.Add(this.gbObjekt);
            this.Controls.Add(this.btnLeggTilObjekt);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_R_LeggTilObjekt";
            this.Text = "frm_R_LeggTilObjekt";
            this.Load += new System.EventHandler(this.frm_R_LeggTilObjekt_Load);
            this.gbOverlay.ResumeLayout(false);
            this.gbOverlay.PerformLayout();
            this.gbObjekt.ResumeLayout(false);
            this.gbObjekt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Her er et ekempel der vi bruker public textbox
        public System.Windows.Forms.TextBox txtLat;
        public System.Windows.Forms.TextBox txtLong;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLeggTilObjekt;
        private System.Windows.Forms.Label LabelSikkerhetsklarering;
        private System.Windows.Forms.TextBox txtSikkerhetsklarering;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.ListBox lbTilgjengeligeOverlays;
        private System.Windows.Forms.ListBox lbValgtOverlays;
        private System.Windows.Forms.Button btnLeggTilOverlay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKommentar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtNyOverlay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbTilgjengligKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategori;
        public System.Windows.Forms.TextBox txtNyKategori;
        private System.Windows.Forms.Button btnLeggTilNyKategori;
        private System.Windows.Forms.GroupBox gbOverlay;
        private System.Windows.Forms.GroupBox gbObjekt;
    }
}