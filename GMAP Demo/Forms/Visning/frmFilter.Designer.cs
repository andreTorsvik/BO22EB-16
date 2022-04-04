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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // btnRessurs
            // 
            this.btnRessurs.Location = new System.Drawing.Point(39, 172);
            this.btnRessurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRessurs.Name = "btnRessurs";
            this.btnRessurs.Size = new System.Drawing.Size(113, 46);
            this.btnRessurs.TabIndex = 4;
            this.btnRessurs.Text = "Legg til Markører kartet";
            this.btnRessurs.UseVisualStyleBackColor = true;
            this.btnRessurs.Click += new System.EventHandler(this.btnRessurs_Click);
            // 
            // btnLeggTil
            // 
            this.btnLeggTil.Location = new System.Drawing.Point(39, 119);
            this.btnLeggTil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTil.Name = "btnLeggTil";
            this.btnLeggTil.Size = new System.Drawing.Size(113, 47);
            this.btnLeggTil.TabIndex = 5;
            this.btnLeggTil.Text = "Hent ressurs fra database";
            this.btnLeggTil.UseVisualStyleBackColor = true;
            this.btnLeggTil.Click += new System.EventHandler(this.btnLeggTil_Click);
            // 
            // txtAntall
            // 
            this.txtAntall.Location = new System.Drawing.Point(173, 130);
            this.txtAntall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAntall.Name = "txtAntall";
            this.txtAntall.Size = new System.Drawing.Size(49, 22);
            this.txtAntall.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(171, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Antall ressurser";
            // 
            // btnFjern
            // 
            this.btnFjern.Location = new System.Drawing.Point(39, 223);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(113, 32);
            this.btnFjern.TabIndex = 8;
            this.btnFjern.Text = "Fjern markør ";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.btnFjern_Click);
            // 
            // txtNavn
            // 
            this.txtNavn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNavn.Location = new System.Drawing.Point(173, 278);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNavn.Multiline = true;
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.ReadOnly = true;
            this.txtNavn.Size = new System.Drawing.Size(217, 24);
            this.txtNavn.TabIndex = 9;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNavn.Location = new System.Drawing.Point(39, 282);
            this.lblNavn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(39, 16);
            this.lblNavn.TabIndex = 10;
            this.lblNavn.Text = "Navn";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategori.Location = new System.Drawing.Point(39, 311);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(57, 16);
            this.lblKategori.TabIndex = 11;
            this.lblKategori.Text = "Kategori";
            // 
            // lblDato_opprettet
            // 
            this.lblDato_opprettet.AutoSize = true;
            this.lblDato_opprettet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDato_opprettet.Location = new System.Drawing.Point(39, 341);
            this.lblDato_opprettet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDato_opprettet.Name = "lblDato_opprettet";
            this.lblDato_opprettet.Size = new System.Drawing.Size(92, 16);
            this.lblDato_opprettet.TabIndex = 12;
            this.lblDato_opprettet.Text = "Dato opprettet";
            // 
            // lblOpprettetAvBruker
            // 
            this.lblOpprettetAvBruker.AutoSize = true;
            this.lblOpprettetAvBruker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOpprettetAvBruker.Location = new System.Drawing.Point(39, 370);
            this.lblOpprettetAvBruker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpprettetAvBruker.Name = "lblOpprettetAvBruker";
            this.lblOpprettetAvBruker.Size = new System.Drawing.Size(121, 16);
            this.lblOpprettetAvBruker.TabIndex = 13;
            this.lblOpprettetAvBruker.Text = "Opprettet av bruker";
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(39, 400);
            this.lblSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(122, 16);
            this.lblSikkerhetsklarering.TabIndex = 14;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering";
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKommentar.Location = new System.Drawing.Point(39, 430);
            this.lblKommentar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(75, 16);
            this.lblKommentar.TabIndex = 15;
            this.lblKommentar.Text = "Kommentar";
            // 
            // txtKategori
            // 
            this.txtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKategori.Location = new System.Drawing.Point(173, 308);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKategori.Multiline = true;
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.ReadOnly = true;
            this.txtKategori.Size = new System.Drawing.Size(217, 24);
            this.txtKategori.TabIndex = 16;
            // 
            // txtDato_opprettet
            // 
            this.txtDato_opprettet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDato_opprettet.Location = new System.Drawing.Point(173, 337);
            this.txtDato_opprettet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDato_opprettet.Multiline = true;
            this.txtDato_opprettet.Name = "txtDato_opprettet";
            this.txtDato_opprettet.ReadOnly = true;
            this.txtDato_opprettet.Size = new System.Drawing.Size(217, 24);
            this.txtDato_opprettet.TabIndex = 17;
            // 
            // txtOpprettetAvBruker
            // 
            this.txtOpprettetAvBruker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtOpprettetAvBruker.Location = new System.Drawing.Point(173, 367);
            this.txtOpprettetAvBruker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpprettetAvBruker.Multiline = true;
            this.txtOpprettetAvBruker.Name = "txtOpprettetAvBruker";
            this.txtOpprettetAvBruker.ReadOnly = true;
            this.txtOpprettetAvBruker.Size = new System.Drawing.Size(217, 24);
            this.txtOpprettetAvBruker.TabIndex = 18;
            // 
            // txtSikkerhetsklarering
            // 
            this.txtSikkerhetsklarering.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(173, 396);
            this.txtSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSikkerhetsklarering.Multiline = true;
            this.txtSikkerhetsklarering.Name = "txtSikkerhetsklarering";
            this.txtSikkerhetsklarering.ReadOnly = true;
            this.txtSikkerhetsklarering.Size = new System.Drawing.Size(217, 24);
            this.txtSikkerhetsklarering.TabIndex = 19;
            // 
            // txtKommentar
            // 
            this.txtKommentar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKommentar.Location = new System.Drawing.Point(173, 426);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKommentar.Multiline = true;
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.ReadOnly = true;
            this.txtKommentar.Size = new System.Drawing.Size(217, 93);
            this.txtKommentar.TabIndex = 20;
            // 
            // btnHentOmråde
            // 
            this.btnHentOmråde.Location = new System.Drawing.Point(39, 572);
            this.btnHentOmråde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHentOmråde.Name = "btnHentOmråde";
            this.btnHentOmråde.Size = new System.Drawing.Size(113, 47);
            this.btnHentOmråde.TabIndex = 21;
            this.btnHentOmråde.Text = "Hent Område fra database";
            this.btnHentOmråde.UseVisualStyleBackColor = true;
            this.btnHentOmråde.Click += new System.EventHandler(this.btnHentOmråde_Click);
            // 
            // btnLeggTilOmrådet
            // 
            this.btnLeggTilOmrådet.Location = new System.Drawing.Point(39, 623);
            this.btnLeggTilOmrådet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilOmrådet.Name = "btnLeggTilOmrådet";
            this.btnLeggTilOmrådet.Size = new System.Drawing.Size(113, 46);
            this.btnLeggTilOmrådet.TabIndex = 22;
            this.btnLeggTilOmrådet.Text = "Legg til Områdene";
            this.btnLeggTilOmrådet.UseVisualStyleBackColor = true;
            this.btnLeggTilOmrådet.Click += new System.EventHandler(this.btnLeggTilOmrådet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(171, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Antall områder";
            // 
            // txtAntallOmråder
            // 
            this.txtAntallOmråder.Location = new System.Drawing.Point(173, 590);
            this.txtAntallOmråder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAntallOmråder.Name = "txtAntallOmråder";
            this.txtAntallOmråder.Size = new System.Drawing.Size(49, 22);
            this.txtAntallOmråder.TabIndex = 23;
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(408, 871);
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
    }
}