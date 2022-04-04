namespace GMAP_Demo
{
    partial class frmFilter
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
            this.btnRessurs = new System.Windows.Forms.Button();
            this.btnLeggTil = new System.Windows.Forms.Button();
            this.txtAntall = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFjern = new System.Windows.Forms.Button();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.lblNavn = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblDato_opprettet = new System.Windows.Forms.Label();
            this.lblOpprettetAvBruker = new System.Windows.Forms.Label();
            this.lblSikkerhetsklarering = new System.Windows.Forms.Label();
            this.lblKommentar = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtDato_opprettet = new System.Windows.Forms.TextBox();
            this.txtOpprettetAvBruker = new System.Windows.Forms.TextBox();
            this.txtSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.txtKommentar = new System.Windows.Forms.TextBox();
            this.btnHentOmråde = new System.Windows.Forms.Button();
            this.btnLeggTilOmrådet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAntallOmråder = new System.Windows.Forms.TextBox();
            this.lbKategorierSkjult = new System.Windows.Forms.ListBox();
            this.lblKategorierSkjult = new System.Windows.Forms.Label();
            this.lblKategorierVises = new System.Windows.Forms.Label();
            this.lbKategorierVises = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // btnRessurs
            // 
            this.btnRessurs.Location = new System.Drawing.Point(24, 217);
            this.btnRessurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRessurs.Name = "btnRessurs";
            this.btnRessurs.Size = new System.Drawing.Size(127, 58);
            this.btnRessurs.TabIndex = 4;
            this.btnRessurs.Text = "Legg til Markører kartet";
            this.btnRessurs.UseVisualStyleBackColor = true;
            this.btnRessurs.Click += new System.EventHandler(this.btnRessurs_Click);
            // 
            // btnLeggTil
            // 
            this.btnLeggTil.Location = new System.Drawing.Point(24, 151);
            this.btnLeggTil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTil.Name = "btnLeggTil";
            this.btnLeggTil.Size = new System.Drawing.Size(127, 59);
            this.btnLeggTil.TabIndex = 5;
            this.btnLeggTil.Text = "Hent ressurs fra database";
            this.btnLeggTil.UseVisualStyleBackColor = true;
            this.btnLeggTil.Click += new System.EventHandler(this.btnLeggTil_Click);
            // 
            // txtAntall
            // 
            this.txtAntall.Location = new System.Drawing.Point(24, 311);
            this.txtAntall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAntall.Name = "txtAntall";
            this.txtAntall.Size = new System.Drawing.Size(55, 26);
            this.txtAntall.TabIndex = 6;
            this.txtAntall.TextChanged += new System.EventHandler(this.txtAntall_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Antall ressurser";
            // 
            // btnFjern
            // 
            this.btnFjern.Location = new System.Drawing.Point(171, 354);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(109, 58);
            this.btnFjern.TabIndex = 8;
            this.btnFjern.Text = "Fjern markør ";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.btnFjern_Click);
            // 
            // txtNavn
            // 
            this.txtNavn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNavn.Location = new System.Drawing.Point(164, 776);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNavn.Multiline = true;
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.ReadOnly = true;
            this.txtNavn.Size = new System.Drawing.Size(244, 29);
            this.txtNavn.TabIndex = 9;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNavn.Location = new System.Drawing.Point(13, 780);
            this.lblNavn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(45, 20);
            this.lblNavn.TabIndex = 10;
            this.lblNavn.Text = "Navn";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategori.Location = new System.Drawing.Point(13, 817);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(68, 20);
            this.lblKategori.TabIndex = 11;
            this.lblKategori.Text = "Kategori";
            // 
            // lblDato_opprettet
            // 
            this.lblDato_opprettet.AutoSize = true;
            this.lblDato_opprettet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDato_opprettet.Location = new System.Drawing.Point(13, 854);
            this.lblDato_opprettet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDato_opprettet.Name = "lblDato_opprettet";
            this.lblDato_opprettet.Size = new System.Drawing.Size(113, 20);
            this.lblDato_opprettet.TabIndex = 12;
            this.lblDato_opprettet.Text = "Dato opprettet";
            // 
            // lblOpprettetAvBruker
            // 
            this.lblOpprettetAvBruker.AutoSize = true;
            this.lblOpprettetAvBruker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOpprettetAvBruker.Location = new System.Drawing.Point(13, 890);
            this.lblOpprettetAvBruker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpprettetAvBruker.Name = "lblOpprettetAvBruker";
            this.lblOpprettetAvBruker.Size = new System.Drawing.Size(146, 20);
            this.lblOpprettetAvBruker.TabIndex = 13;
            this.lblOpprettetAvBruker.Text = "Opprettet av bruker";
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(13, 928);
            this.lblSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(144, 20);
            this.lblSikkerhetsklarering.TabIndex = 14;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering";
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKommentar.Location = new System.Drawing.Point(13, 966);
            this.lblKommentar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(91, 20);
            this.lblKommentar.TabIndex = 15;
            this.lblKommentar.Text = "Kommentar";
            // 
            // txtKategori
            // 
            this.txtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKategori.Location = new System.Drawing.Point(164, 813);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKategori.Multiline = true;
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.ReadOnly = true;
            this.txtKategori.Size = new System.Drawing.Size(244, 29);
            this.txtKategori.TabIndex = 16;
            // 
            // txtDato_opprettet
            // 
            this.txtDato_opprettet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDato_opprettet.Location = new System.Drawing.Point(164, 849);
            this.txtDato_opprettet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDato_opprettet.Multiline = true;
            this.txtDato_opprettet.Name = "txtDato_opprettet";
            this.txtDato_opprettet.ReadOnly = true;
            this.txtDato_opprettet.Size = new System.Drawing.Size(244, 29);
            this.txtDato_opprettet.TabIndex = 17;
            // 
            // txtOpprettetAvBruker
            // 
            this.txtOpprettetAvBruker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtOpprettetAvBruker.Location = new System.Drawing.Point(164, 887);
            this.txtOpprettetAvBruker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpprettetAvBruker.Multiline = true;
            this.txtOpprettetAvBruker.Name = "txtOpprettetAvBruker";
            this.txtOpprettetAvBruker.ReadOnly = true;
            this.txtOpprettetAvBruker.Size = new System.Drawing.Size(244, 29);
            this.txtOpprettetAvBruker.TabIndex = 18;
            // 
            // txtSikkerhetsklarering
            // 
            this.txtSikkerhetsklarering.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(164, 923);
            this.txtSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSikkerhetsklarering.Multiline = true;
            this.txtSikkerhetsklarering.Name = "txtSikkerhetsklarering";
            this.txtSikkerhetsklarering.ReadOnly = true;
            this.txtSikkerhetsklarering.Size = new System.Drawing.Size(244, 29);
            this.txtSikkerhetsklarering.TabIndex = 19;
            // 
            // txtKommentar
            // 
            this.txtKommentar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKommentar.Location = new System.Drawing.Point(164, 960);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKommentar.Multiline = true;
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.ReadOnly = true;
            this.txtKommentar.Size = new System.Drawing.Size(244, 115);
            this.txtKommentar.TabIndex = 20;
            // 
            // btnHentOmråde
            // 
            this.btnHentOmråde.Location = new System.Drawing.Point(292, 151);
            this.btnHentOmråde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHentOmråde.Name = "btnHentOmråde";
            this.btnHentOmråde.Size = new System.Drawing.Size(127, 59);
            this.btnHentOmråde.TabIndex = 21;
            this.btnHentOmråde.Text = "Hent Område fra database";
            this.btnHentOmråde.UseVisualStyleBackColor = true;
            this.btnHentOmråde.Click += new System.EventHandler(this.btnHentOmråde_Click);
            // 
            // btnLeggTilOmrådet
            // 
            this.btnLeggTilOmrådet.Location = new System.Drawing.Point(292, 215);
            this.btnLeggTilOmrådet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilOmrådet.Name = "btnLeggTilOmrådet";
            this.btnLeggTilOmrådet.Size = new System.Drawing.Size(127, 58);
            this.btnLeggTilOmrådet.TabIndex = 22;
            this.btnLeggTilOmrådet.Text = "Legg til Områdene";
            this.btnLeggTilOmrådet.UseVisualStyleBackColor = true;
            this.btnLeggTilOmrådet.Click += new System.EventHandler(this.btnLeggTilOmrådet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(288, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Antall områder";
            // 
            // txtAntallOmråder
            // 
            this.txtAntallOmråder.Location = new System.Drawing.Point(291, 311);
            this.txtAntallOmråder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAntallOmråder.Name = "txtAntallOmråder";
            this.txtAntallOmråder.Size = new System.Drawing.Size(55, 26);
            this.txtAntallOmråder.TabIndex = 23;
            // 
            // lbKategorierSkjult
            // 
            this.lbKategorierSkjult.FormattingEnabled = true;
            this.lbKategorierSkjult.ItemHeight = 20;
            this.lbKategorierSkjult.Location = new System.Drawing.Point(24, 522);
            this.lbKategorierSkjult.Name = "lbKategorierSkjult";
            this.lbKategorierSkjult.Size = new System.Drawing.Size(125, 184);
            this.lbKategorierSkjult.TabIndex = 25;
            this.lbKategorierSkjult.DoubleClick += new System.EventHandler(this.lbKategorierSkjult_DoubleClick);
            // 
            // lblKategorierSkjult
            // 
            this.lblKategorierSkjult.AutoSize = true;
            this.lblKategorierSkjult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorierSkjult.Location = new System.Drawing.Point(20, 499);
            this.lblKategorierSkjult.Name = "lblKategorierSkjult";
            this.lblKategorierSkjult.Size = new System.Drawing.Size(43, 20);
            this.lblKategorierSkjult.TabIndex = 26;
            this.lblKategorierSkjult.Text = "Skjul";
            // 
            // lblKategorierVises
            // 
            this.lblKategorierVises.AutoSize = true;
            this.lblKategorierVises.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorierVises.Location = new System.Drawing.Point(287, 499);
            this.lblKategorierVises.Name = "lblKategorierVises";
            this.lblKategorierVises.Size = new System.Drawing.Size(31, 20);
            this.lblKategorierVises.TabIndex = 28;
            this.lblKategorierVises.Text = "Vis";
            // 
            // lbKategorierVises
            // 
            this.lbKategorierVises.FormattingEnabled = true;
            this.lbKategorierVises.ItemHeight = 20;
            this.lbKategorierVises.Location = new System.Drawing.Point(291, 522);
            this.lbKategorierVises.Name = "lbKategorierVises";
            this.lbKategorierVises.Size = new System.Drawing.Size(125, 184);
            this.lbKategorierVises.TabIndex = 27;
            this.lbKategorierVises.DoubleClick += new System.EventHandler(this.lbKategorierVises_DoubleClick);
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(459, 1089);
            this.Controls.Add(this.lblKategorierVises);
            this.Controls.Add(this.lbKategorierVises);
            this.Controls.Add(this.lblKategorierSkjult);
            this.Controls.Add(this.lbKategorierSkjult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAntallOmråder);
            this.Controls.Add(this.btnLeggTilOmrådet);
            this.Controls.Add(this.btnHentOmråde);
            this.Controls.Add(this.txtKommentar);
            this.Controls.Add(this.txtSikkerhetsklarering);
            this.Controls.Add(this.txtOpprettetAvBruker);
            this.Controls.Add(this.txtDato_opprettet);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.lblKommentar);
            this.Controls.Add(this.lblSikkerhetsklarering);
            this.Controls.Add(this.lblOpprettetAvBruker);
            this.Controls.Add(this.lblDato_opprettet);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblNavn);
            this.Controls.Add(this.txtNavn);
            this.Controls.Add(this.btnFjern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAntall);
            this.Controls.Add(this.btnLeggTil);
            this.Controls.Add(this.btnRessurs);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFilter";
            this.Text = "frmFilter";
            this.Load += new System.EventHandler(this.frmFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRessurs;
        private System.Windows.Forms.Button btnLeggTil;
        private System.Windows.Forms.TextBox txtAntall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFjern;
        public System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.Label lblNavn;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblDato_opprettet;
        private System.Windows.Forms.Label lblOpprettetAvBruker;
        private System.Windows.Forms.Label lblSikkerhetsklarering;
        private System.Windows.Forms.Label lblKommentar;
        public System.Windows.Forms.TextBox txtKategori;
        public System.Windows.Forms.TextBox txtDato_opprettet;
        public System.Windows.Forms.TextBox txtOpprettetAvBruker;
        public System.Windows.Forms.TextBox txtSikkerhetsklarering;
        public System.Windows.Forms.TextBox txtKommentar;
        private System.Windows.Forms.Button btnHentOmråde;
        private System.Windows.Forms.Button btnLeggTilOmrådet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAntallOmråder;
        private System.Windows.Forms.ListBox lbKategorierSkjult;
        private System.Windows.Forms.Label lblKategorierSkjult;
        private System.Windows.Forms.Label lblKategorierVises;
        private System.Windows.Forms.ListBox lbKategorierVises;
    }
}