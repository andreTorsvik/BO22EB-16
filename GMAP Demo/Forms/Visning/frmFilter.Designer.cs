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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // btnRessurs
            // 
            this.btnRessurs.Location = new System.Drawing.Point(29, 140);
            this.btnRessurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRessurs.Name = "btnRessurs";
            this.btnRessurs.Size = new System.Drawing.Size(85, 37);
            this.btnRessurs.TabIndex = 4;
            this.btnRessurs.Text = "Legg til Markører kartet";
            this.btnRessurs.UseVisualStyleBackColor = true;
            this.btnRessurs.Click += new System.EventHandler(this.btnRessurs_Click);
            // 
            // btnLeggTil
            // 
            this.btnLeggTil.Location = new System.Drawing.Point(29, 97);
            this.btnLeggTil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeggTil.Name = "btnLeggTil";
            this.btnLeggTil.Size = new System.Drawing.Size(85, 38);
            this.btnLeggTil.TabIndex = 5;
            this.btnLeggTil.Text = "hent ressurs fra database";
            this.btnLeggTil.UseVisualStyleBackColor = true;
            this.btnLeggTil.Click += new System.EventHandler(this.btnLeggTil_Click);
            // 
            // txtAntall
            // 
            this.txtAntall.Location = new System.Drawing.Point(130, 106);
            this.txtAntall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAntall.Name = "txtAntall";
            this.txtAntall.Size = new System.Drawing.Size(38, 20);
            this.txtAntall.TabIndex = 6;
            this.txtAntall.TextChanged += new System.EventHandler(this.txtAntall_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(128, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Antall ressurser";
            // 
            // btnFjern
            // 
            this.btnFjern.Location = new System.Drawing.Point(29, 181);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(85, 26);
            this.btnFjern.TabIndex = 8;
            this.btnFjern.Text = "Fjern markør ";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.btnFjern_Click);
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(131, 226);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNavn.Multiline = true;
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.Size = new System.Drawing.Size(164, 20);
            this.txtNavn.TabIndex = 9;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNavn.Location = new System.Drawing.Point(29, 229);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(33, 13);
            this.lblNavn.TabIndex = 10;
            this.lblNavn.Text = "Navn";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategori.Location = new System.Drawing.Point(29, 253);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 11;
            this.lblKategori.Text = "Kategori";
            // 
            // lblDato_opprettet
            // 
            this.lblDato_opprettet.AutoSize = true;
            this.lblDato_opprettet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDato_opprettet.Location = new System.Drawing.Point(29, 277);
            this.lblDato_opprettet.Name = "lblDato_opprettet";
            this.lblDato_opprettet.Size = new System.Drawing.Size(75, 13);
            this.lblDato_opprettet.TabIndex = 12;
            this.lblDato_opprettet.Text = "Dato opprettet";
            // 
            // lblOpprettetAvBruker
            // 
            this.lblOpprettetAvBruker.AutoSize = true;
            this.lblOpprettetAvBruker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOpprettetAvBruker.Location = new System.Drawing.Point(29, 301);
            this.lblOpprettetAvBruker.Name = "lblOpprettetAvBruker";
            this.lblOpprettetAvBruker.Size = new System.Drawing.Size(99, 13);
            this.lblOpprettetAvBruker.TabIndex = 13;
            this.lblOpprettetAvBruker.Text = "Opprettet av bruker";
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(29, 325);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(97, 13);
            this.lblSikkerhetsklarering.TabIndex = 14;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering";
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKommentar.Location = new System.Drawing.Point(29, 349);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(60, 13);
            this.lblKommentar.TabIndex = 15;
            this.lblKommentar.Text = "Kommentar";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(131, 250);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategori.Multiline = true;
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(164, 20);
            this.txtKategori.TabIndex = 16;
            // 
            // txtDato_opprettet
            // 
            this.txtDato_opprettet.Location = new System.Drawing.Point(130, 274);
            this.txtDato_opprettet.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato_opprettet.Multiline = true;
            this.txtDato_opprettet.Name = "txtDato_opprettet";
            this.txtDato_opprettet.Size = new System.Drawing.Size(164, 20);
            this.txtDato_opprettet.TabIndex = 17;
            // 
            // txtOpprettetAvBruker
            // 
            this.txtOpprettetAvBruker.Location = new System.Drawing.Point(130, 298);
            this.txtOpprettetAvBruker.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpprettetAvBruker.Multiline = true;
            this.txtOpprettetAvBruker.Name = "txtOpprettetAvBruker";
            this.txtOpprettetAvBruker.Size = new System.Drawing.Size(164, 20);
            this.txtOpprettetAvBruker.TabIndex = 18;
            // 
            // txtSikkerhetsklarering
            // 
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(130, 322);
            this.txtSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(2);
            this.txtSikkerhetsklarering.Multiline = true;
            this.txtSikkerhetsklarering.Name = "txtSikkerhetsklarering";
            this.txtSikkerhetsklarering.Size = new System.Drawing.Size(164, 20);
            this.txtSikkerhetsklarering.TabIndex = 19;
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(130, 346);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(2);
            this.txtKommentar.Multiline = true;
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.Size = new System.Drawing.Size(164, 76);
            this.txtKommentar.TabIndex = 20;
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(306, 708);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmFilter";
            this.Text = "frmFilter";
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
    }
}