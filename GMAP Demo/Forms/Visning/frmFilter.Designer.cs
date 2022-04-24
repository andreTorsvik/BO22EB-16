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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTagsSkjult = new System.Windows.Forms.ListBox();
            this.lblTagsSkjult = new System.Windows.Forms.Label();
            this.lbTagsVises = new System.Windows.Forms.ListBox();
            this.lblTagsVises = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // btnRessurs
            // 
            this.btnRessurs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRessurs.Location = new System.Drawing.Point(22, 96);
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
            this.btnLeggTil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLeggTil.Location = new System.Drawing.Point(22, 30);
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
            this.txtAntall.Location = new System.Drawing.Point(22, 190);
            this.txtAntall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAntall.Name = "txtAntall";
            this.txtAntall.Size = new System.Drawing.Size(55, 26);
            this.txtAntall.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Antall ressurser";
            // 
            // btnFjern
            // 
            this.btnFjern.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFjern.Location = new System.Drawing.Point(170, 234);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(109, 58);
            this.btnFjern.TabIndex = 8;
            this.btnFjern.Text = "Fjern Alt";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.btnFjern_Click);
            // 
            // txtNavn
            // 
            this.txtNavn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNavn.Location = new System.Drawing.Point(164, 638);
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
            this.lblNavn.Location = new System.Drawing.Point(14, 642);
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
            this.lblKategori.Location = new System.Drawing.Point(14, 679);
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
            this.lblDato_opprettet.Location = new System.Drawing.Point(14, 716);
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
            this.lblOpprettetAvBruker.Location = new System.Drawing.Point(14, 752);
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
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(14, 790);
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
            this.lblKommentar.Location = new System.Drawing.Point(14, 828);
            this.lblKommentar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(91, 20);
            this.lblKommentar.TabIndex = 15;
            this.lblKommentar.Text = "Kommentar";
            // 
            // txtKategori
            // 
            this.txtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKategori.Location = new System.Drawing.Point(164, 675);
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
            this.txtDato_opprettet.Location = new System.Drawing.Point(164, 711);
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
            this.txtOpprettetAvBruker.Location = new System.Drawing.Point(164, 749);
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
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(164, 785);
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
            this.txtKommentar.Location = new System.Drawing.Point(164, 822);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKommentar.Multiline = true;
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.ReadOnly = true;
            this.txtKommentar.Size = new System.Drawing.Size(244, 115);
            this.txtKommentar.TabIndex = 20;
            // 
            // btnHentOmråde
            // 
            this.btnHentOmråde.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHentOmråde.Location = new System.Drawing.Point(291, 30);
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
            this.btnLeggTilOmrådet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLeggTilOmrådet.Location = new System.Drawing.Point(291, 95);
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
            this.label2.Location = new System.Drawing.Point(287, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Antall områder";
            // 
            // txtAntallOmråder
            // 
            this.txtAntallOmråder.Location = new System.Drawing.Point(290, 190);
            this.txtAntallOmråder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAntallOmråder.Name = "txtAntallOmråder";
            this.txtAntallOmråder.Size = new System.Drawing.Size(55, 26);
            this.txtAntallOmråder.TabIndex = 23;
            // 
            // lbKategorierSkjult
            // 
            this.lbKategorierSkjult.FormattingEnabled = true;
            this.lbKategorierSkjult.ItemHeight = 20;
            this.lbKategorierSkjult.Location = new System.Drawing.Point(36, 394);
            this.lbKategorierSkjult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbKategorierSkjult.Name = "lbKategorierSkjult";
            this.lbKategorierSkjult.Size = new System.Drawing.Size(126, 104);
            this.lbKategorierSkjult.TabIndex = 25;
            this.lbKategorierSkjult.DoubleClick += new System.EventHandler(this.lbKategorierSkjult_DoubleClick);
            // 
            // lblKategorierSkjult
            // 
            this.lblKategorierSkjult.AutoSize = true;
            this.lblKategorierSkjult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorierSkjult.Location = new System.Drawing.Point(32, 370);
            this.lblKategorierSkjult.Name = "lblKategorierSkjult";
            this.lblKategorierSkjult.Size = new System.Drawing.Size(43, 20);
            this.lblKategorierSkjult.TabIndex = 26;
            this.lblKategorierSkjult.Text = "Skjul";
            // 
            // lblKategorierVises
            // 
            this.lblKategorierVises.AutoSize = true;
            this.lblKategorierVises.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorierVises.Location = new System.Drawing.Point(299, 370);
            this.lblKategorierVises.Name = "lblKategorierVises";
            this.lblKategorierVises.Size = new System.Drawing.Size(31, 20);
            this.lblKategorierVises.TabIndex = 28;
            this.lblKategorierVises.Text = "Vis";
            // 
            // lbKategorierVises
            // 
            this.lbKategorierVises.FormattingEnabled = true;
            this.lbKategorierVises.ItemHeight = 20;
            this.lbKategorierVises.Location = new System.Drawing.Point(303, 394);
            this.lbKategorierVises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbKategorierVises.Name = "lbKategorierVises";
            this.lbKategorierVises.Size = new System.Drawing.Size(126, 104);
            this.lbKategorierVises.TabIndex = 27;
            this.lbKategorierVises.DoubleClick += new System.EventHandler(this.lbKategorierVises_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAntallOmråder);
            this.groupBox1.Controls.Add(this.btnLeggTilOmrådet);
            this.groupBox1.Controls.Add(this.btnHentOmråde);
            this.groupBox1.Controls.Add(this.btnFjern);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAntall);
            this.groupBox1.Controls.Add(this.btnLeggTil);
            this.groupBox1.Controls.Add(this.btnRessurs);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(14, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(432, 298);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kun midlertidig";
            // 
            // lbTagsSkjult
            // 
            this.lbTagsSkjult.FormattingEnabled = true;
            this.lbTagsSkjult.ItemHeight = 20;
            this.lbTagsSkjult.Location = new System.Drawing.Point(37, 530);
            this.lbTagsSkjult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTagsSkjult.Name = "lbTagsSkjult";
            this.lbTagsSkjult.Size = new System.Drawing.Size(126, 104);
            this.lbTagsSkjult.TabIndex = 25;
            this.lbTagsSkjult.DoubleClick += new System.EventHandler(this.lbTagsSkjult_DoubleClick);
            // 
            // lblTagsSkjult
            // 
            this.lblTagsSkjult.AutoSize = true;
            this.lblTagsSkjult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTagsSkjult.Location = new System.Drawing.Point(33, 506);
            this.lblTagsSkjult.Name = "lblTagsSkjult";
            this.lblTagsSkjult.Size = new System.Drawing.Size(43, 20);
            this.lblTagsSkjult.TabIndex = 26;
            this.lblTagsSkjult.Text = "Skjul";
            // 
            // lbTagsVises
            // 
            this.lbTagsVises.FormattingEnabled = true;
            this.lbTagsVises.ItemHeight = 20;
            this.lbTagsVises.Location = new System.Drawing.Point(304, 530);
            this.lbTagsVises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTagsVises.Name = "lbTagsVises";
            this.lbTagsVises.Size = new System.Drawing.Size(126, 104);
            this.lbTagsVises.TabIndex = 27;
            this.lbTagsVises.DoubleClick += new System.EventHandler(this.lbTagsVises_DoubleClick);
            // 
            // lblTagsVises
            // 
            this.lblTagsVises.AutoSize = true;
            this.lblTagsVises.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTagsVises.Location = new System.Drawing.Point(300, 506);
            this.lblTagsVises.Name = "lblTagsVises";
            this.lblTagsVises.Size = new System.Drawing.Size(31, 20);
            this.lblTagsVises.TabIndex = 28;
            this.lblTagsVises.Text = "Vis";
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(459, 1089);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTagsVises);
            this.Controls.Add(this.lblKategorierVises);
            this.Controls.Add(this.lbTagsVises);
            this.Controls.Add(this.lbKategorierVises);
            this.Controls.Add(this.lblTagsSkjult);
            this.Controls.Add(this.lblKategorierSkjult);
            this.Controls.Add(this.lbTagsSkjult);
            this.Controls.Add(this.lbKategorierSkjult);
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
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFilter";
            this.Text = "frmFilter";
            this.Load += new System.EventHandler(this.frmFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbTagsSkjult;
        private System.Windows.Forms.Label lblTagsSkjult;
        private System.Windows.Forms.ListBox lbTagsVises;
        private System.Windows.Forms.Label lblTagsVises;
    }
}