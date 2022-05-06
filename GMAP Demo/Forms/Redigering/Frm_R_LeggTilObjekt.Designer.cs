namespace GMAP_Demo
{
    partial class Frm_R_LeggTilObjekt
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLeggTilObjekt = new System.Windows.Forms.Button();
            this.lblSikkerhetsklarering = new System.Windows.Forms.Label();
            this.txtSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.lblNavn = new System.Windows.Forms.Label();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.lbTilgjengeligeTags = new System.Windows.Forms.ListBox();
            this.lbValgtTags = new System.Windows.Forms.ListBox();
            this.btnLeggTilTag = new System.Windows.Forms.Button();
            this.lblKommentar = new System.Windows.Forms.Label();
            this.txtKommentar = new System.Windows.Forms.TextBox();
            this.lblLong = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.lblVelgTags = new System.Windows.Forms.Label();
            this.lblNyTag = new System.Windows.Forms.Label();
            this.txtNyTag = new System.Windows.Forms.TextBox();
            this.lblEksisterende = new System.Windows.Forms.Label();
            this.lblValgtForDetteObjektet = new System.Windows.Forms.Label();
            this.lbTilgjengligKategori = new System.Windows.Forms.ListBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtNyKategori = new System.Windows.Forms.TextBox();
            this.btnLeggTilNyKategori = new System.Windows.Forms.Button();
            this.gbTag = new System.Windows.Forms.GroupBox();
            this.gbObjekt = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbTag.SuspendLayout();
            this.gbObjekt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(9, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Legg til Objekt";
            // 
            // btnLeggTilObjekt
            // 
            this.btnLeggTilObjekt.Location = new System.Drawing.Point(15, 587);
            this.btnLeggTilObjekt.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeggTilObjekt.Name = "btnLeggTilObjekt";
            this.btnLeggTilObjekt.Size = new System.Drawing.Size(92, 28);
            this.btnLeggTilObjekt.TabIndex = 16;
            this.btnLeggTilObjekt.Text = "Lagre objekt";
            this.btnLeggTilObjekt.UseVisualStyleBackColor = true;
            this.btnLeggTilObjekt.Click += new System.EventHandler(this.BtnLeggTilObjekt_Click);
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(4, 52);
            this.lblSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(118, 13);
            this.lblSikkerhetsklarering.TabIndex = 15;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering(1-3)";
            // 
            // txtSikkerhetsklarering
            // 
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(4, 67);
            this.txtSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(2);
            this.txtSikkerhetsklarering.MaxLength = 1;
            this.txtSikkerhetsklarering.Name = "txtSikkerhetsklarering";
            this.txtSikkerhetsklarering.Size = new System.Drawing.Size(216, 20);
            this.txtSikkerhetsklarering.TabIndex = 14;
            this.txtSikkerhetsklarering.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSikkerhetsklarering_KeyPress);
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNavn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNavn.Location = new System.Drawing.Point(4, 15);
            this.lblNavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(33, 13);
            this.lblNavn.TabIndex = 11;
            this.lblNavn.Text = "Navn";
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(4, 31);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(2);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.Size = new System.Drawing.Size(215, 20);
            this.txtNavn.TabIndex = 10;
            // 
            // lbTilgjengeligeTags
            // 
            this.lbTilgjengeligeTags.FormattingEnabled = true;
            this.lbTilgjengeligeTags.Location = new System.Drawing.Point(4, 46);
            this.lbTilgjengeligeTags.Margin = new System.Windows.Forms.Padding(2);
            this.lbTilgjengeligeTags.Name = "lbTilgjengeligeTags";
            this.lbTilgjengeligeTags.Size = new System.Drawing.Size(107, 160);
            this.lbTilgjengeligeTags.Sorted = true;
            this.lbTilgjengeligeTags.TabIndex = 17;
            this.toolTip1.SetToolTip(this.lbTilgjengeligeTags, "Dobbelklikk for å flytte over");
            this.lbTilgjengeligeTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbTilgjengelige_MouseDoubleClick);
            // 
            // lbValgtTags
            // 
            this.lbValgtTags.FormattingEnabled = true;
            this.lbValgtTags.Location = new System.Drawing.Point(114, 46);
            this.lbValgtTags.Margin = new System.Windows.Forms.Padding(2);
            this.lbValgtTags.Name = "lbValgtTags";
            this.lbValgtTags.Size = new System.Drawing.Size(106, 160);
            this.lbValgtTags.Sorted = true;
            this.lbValgtTags.TabIndex = 18;
            this.toolTip1.SetToolTip(this.lbValgtTags, "Dobbelklikk for å flytte over");
            this.lbValgtTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbValgtTags_MouseDoubleClick);
            // 
            // btnLeggTilTag
            // 
            this.btnLeggTilTag.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilTag.Location = new System.Drawing.Point(98, 224);
            this.btnLeggTilTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeggTilTag.Name = "btnLeggTilTag";
            this.btnLeggTilTag.Size = new System.Drawing.Size(55, 22);
            this.btnLeggTilTag.TabIndex = 19;
            this.btnLeggTilTag.Text = "Legg til";
            this.btnLeggTilTag.UseVisualStyleBackColor = true;
            this.btnLeggTilTag.Click += new System.EventHandler(this.BtnLeggTilTag_Click);
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblKommentar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKommentar.Location = new System.Drawing.Point(4, 161);
            this.lblKommentar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(60, 13);
            this.lblKommentar.TabIndex = 22;
            this.lblKommentar.Text = "Kommentar";
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(4, 178);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(2);
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.Size = new System.Drawing.Size(215, 20);
            this.txtKommentar.TabIndex = 21;
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLong.Location = new System.Drawing.Point(4, 236);
            this.lblLong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(31, 13);
            this.lblLong.TabIndex = 26;
            this.lblLong.Text = "Long";
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.SystemColors.Control;
            this.txtLong.Location = new System.Drawing.Point(4, 255);
            this.txtLong.Margin = new System.Windows.Forms.Padding(2);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(215, 20);
            this.txtLong.TabIndex = 25;
            this.txtLong.Text = "Dobbelklikk på kartet";
            this.toolTip1.SetToolTip(this.txtLong, "Dobbelklikk på kartet");
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLat.Location = new System.Drawing.Point(4, 199);
            this.lblLat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(22, 13);
            this.lblLat.TabIndex = 24;
            this.lblLat.Text = "Lat";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.Control;
            this.txtLat.Location = new System.Drawing.Point(4, 216);
            this.txtLat.Margin = new System.Windows.Forms.Padding(2);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(216, 20);
            this.txtLat.TabIndex = 23;
            this.txtLat.Text = "Dobbelklikk på kartet";
            this.toolTip1.SetToolTip(this.txtLat, "Dobbelklikk på kartet");
            // 
            // lblVelgTags
            // 
            this.lblVelgTags.AutoSize = true;
            this.lblVelgTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVelgTags.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVelgTags.Location = new System.Drawing.Point(4, 15);
            this.lblVelgTags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVelgTags.Name = "lblVelgTags";
            this.lblVelgTags.Size = new System.Drawing.Size(84, 13);
            this.lblVelgTags.TabIndex = 27;
            this.lblVelgTags.Text = "Velg Hvilke tags";
            // 
            // lblNyTag
            // 
            this.lblNyTag.AutoSize = true;
            this.lblNyTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNyTag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNyTag.Location = new System.Drawing.Point(4, 207);
            this.lblNyTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNyTag.Name = "lblNyTag";
            this.lblNyTag.Size = new System.Drawing.Size(45, 13);
            this.lblNyTag.TabIndex = 29;
            this.lblNyTag.Text = "Ny Tag ";
            // 
            // txtNyTag
            // 
            this.txtNyTag.BackColor = System.Drawing.SystemColors.Control;
            this.txtNyTag.Location = new System.Drawing.Point(3, 226);
            this.txtNyTag.Margin = new System.Windows.Forms.Padding(2);
            this.txtNyTag.Name = "txtNyTag";
            this.txtNyTag.Size = new System.Drawing.Size(92, 20);
            this.txtNyTag.TabIndex = 28;
            // 
            // lblEksisterende
            // 
            this.lblEksisterende.AutoSize = true;
            this.lblEksisterende.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEksisterende.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEksisterende.Location = new System.Drawing.Point(4, 31);
            this.lblEksisterende.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEksisterende.Name = "lblEksisterende";
            this.lblEksisterende.Size = new System.Drawing.Size(65, 13);
            this.lblEksisterende.TabIndex = 30;
            this.lblEksisterende.Text = "Tilhører ikke";
            // 
            // lblValgtForDetteObjektet
            // 
            this.lblValgtForDetteObjektet.AutoSize = true;
            this.lblValgtForDetteObjektet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblValgtForDetteObjektet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValgtForDetteObjektet.Location = new System.Drawing.Point(114, 31);
            this.lblValgtForDetteObjektet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValgtForDetteObjektet.Name = "lblValgtForDetteObjektet";
            this.lblValgtForDetteObjektet.Size = new System.Drawing.Size(68, 13);
            this.lblValgtForDetteObjektet.TabIndex = 31;
            this.lblValgtForDetteObjektet.Text = "Tilhører valgt";
            // 
            // lbTilgjengligKategori
            // 
            this.lbTilgjengligKategori.FormattingEnabled = true;
            this.lbTilgjengligKategori.Location = new System.Drawing.Point(4, 104);
            this.lbTilgjengligKategori.Margin = new System.Windows.Forms.Padding(2);
            this.lbTilgjengligKategori.Name = "lbTilgjengligKategori";
            this.lbTilgjengligKategori.Size = new System.Drawing.Size(104, 30);
            this.lbTilgjengligKategori.Sorted = true;
            this.lbTilgjengligKategori.TabIndex = 61;
            this.toolTip1.SetToolTip(this.lbTilgjengligKategori, "Dobbelklikk for å velge");
            this.lbTilgjengligKategori.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LbTilgjengligKategori_MouseClick);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategori.Location = new System.Drawing.Point(4, 87);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 60;
            this.lblKategori.Text = "Kategori";
            // 
            // txtKategori
            // 
            this.txtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKategori.Location = new System.Drawing.Point(115, 104);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.ReadOnly = true;
            this.txtKategori.Size = new System.Drawing.Size(104, 20);
            this.txtKategori.TabIndex = 59;
            this.toolTip1.SetToolTip(this.txtKategori, "Valgt Kategori");
            // 
            // txtNyKategori
            // 
            this.txtNyKategori.BackColor = System.Drawing.SystemColors.Control;
            this.txtNyKategori.Location = new System.Drawing.Point(4, 141);
            this.txtNyKategori.Margin = new System.Windows.Forms.Padding(2);
            this.txtNyKategori.Name = "txtNyKategori";
            this.txtNyKategori.Size = new System.Drawing.Size(105, 20);
            this.txtNyKategori.TabIndex = 63;
            // 
            // btnLeggTilNyKategori
            // 
            this.btnLeggTilNyKategori.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilNyKategori.Location = new System.Drawing.Point(115, 137);
            this.btnLeggTilNyKategori.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeggTilNyKategori.Name = "btnLeggTilNyKategori";
            this.btnLeggTilNyKategori.Size = new System.Drawing.Size(103, 22);
            this.btnLeggTilNyKategori.TabIndex = 62;
            this.btnLeggTilNyKategori.Text = "Legg til ny Kategori";
            this.btnLeggTilNyKategori.UseVisualStyleBackColor = true;
            this.btnLeggTilNyKategori.Click += new System.EventHandler(this.BtnLeggTilNyKategori_Click);
            // 
            // gbTag
            // 
            this.gbTag.Controls.Add(this.lblVelgTags);
            this.gbTag.Controls.Add(this.lbTilgjengeligeTags);
            this.gbTag.Controls.Add(this.lblValgtForDetteObjektet);
            this.gbTag.Controls.Add(this.lbValgtTags);
            this.gbTag.Controls.Add(this.lblEksisterende);
            this.gbTag.Controls.Add(this.btnLeggTilTag);
            this.gbTag.Controls.Add(this.lblNyTag);
            this.gbTag.Controls.Add(this.txtNyTag);
            this.gbTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbTag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbTag.Location = new System.Drawing.Point(15, 332);
            this.gbTag.Margin = new System.Windows.Forms.Padding(2);
            this.gbTag.Name = "gbTag";
            this.gbTag.Padding = new System.Windows.Forms.Padding(2);
            this.gbTag.Size = new System.Drawing.Size(227, 252);
            this.gbTag.TabIndex = 84;
            this.gbTag.TabStop = false;
            this.gbTag.Text = "Tag";
            // 
            // gbObjekt
            // 
            this.gbObjekt.Controls.Add(this.lblNavn);
            this.gbObjekt.Controls.Add(this.txtNavn);
            this.gbObjekt.Controls.Add(this.txtNyKategori);
            this.gbObjekt.Controls.Add(this.txtSikkerhetsklarering);
            this.gbObjekt.Controls.Add(this.btnLeggTilNyKategori);
            this.gbObjekt.Controls.Add(this.lblSikkerhetsklarering);
            this.gbObjekt.Controls.Add(this.lbTilgjengligKategori);
            this.gbObjekt.Controls.Add(this.txtKommentar);
            this.gbObjekt.Controls.Add(this.lblKategori);
            this.gbObjekt.Controls.Add(this.lblKommentar);
            this.gbObjekt.Controls.Add(this.txtKategori);
            this.gbObjekt.Controls.Add(this.txtLat);
            this.gbObjekt.Controls.Add(this.lblLat);
            this.gbObjekt.Controls.Add(this.txtLong);
            this.gbObjekt.Controls.Add(this.lblLong);
            this.gbObjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbObjekt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbObjekt.Location = new System.Drawing.Point(15, 46);
            this.gbObjekt.Margin = new System.Windows.Forms.Padding(2);
            this.gbObjekt.Name = "gbObjekt";
            this.gbObjekt.Padding = new System.Windows.Forms.Padding(2);
            this.gbObjekt.Size = new System.Drawing.Size(227, 282);
            this.gbObjekt.TabIndex = 85;
            this.gbObjekt.TabStop = false;
            this.gbObjekt.Text = "Objekt";
            // 
            // Frm_R_LeggTilObjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(293, 670);
            this.Controls.Add(this.gbTag);
            this.Controls.Add(this.gbObjekt);
            this.Controls.Add(this.btnLeggTilObjekt);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_R_LeggTilObjekt";
            this.Text = "frm_R_LeggTilObjekt";
            this.Load += new System.EventHandler(this.Frm_R_LeggTilObjekt_Load);
            this.gbTag.ResumeLayout(false);
            this.gbTag.PerformLayout();
            this.gbObjekt.ResumeLayout(false);
            this.gbObjekt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Her er et ekempel der vi bruker public textbox
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLeggTilObjekt;
        private System.Windows.Forms.Label lblSikkerhetsklarering;
        private System.Windows.Forms.TextBox txtSikkerhetsklarering;
        private System.Windows.Forms.Label lblNavn;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.ListBox lbTilgjengeligeTags;
        private System.Windows.Forms.ListBox lbValgtTags;
        private System.Windows.Forms.Button btnLeggTilTag;
        private System.Windows.Forms.Label lblKommentar;
        private System.Windows.Forms.TextBox txtKommentar;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblVelgTags;
        private System.Windows.Forms.Label lblNyTag;
        private System.Windows.Forms.TextBox txtNyTag;
        private System.Windows.Forms.Label lblEksisterende;
        private System.Windows.Forms.Label lblValgtForDetteObjektet;
        private System.Windows.Forms.ListBox lbTilgjengligKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtNyKategori;
        private System.Windows.Forms.Button btnLeggTilNyKategori;
        private System.Windows.Forms.GroupBox gbTag;
        private System.Windows.Forms.GroupBox gbObjekt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}