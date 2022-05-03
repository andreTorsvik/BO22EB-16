namespace GMAP_Demo
{
    partial class Frm_R_RedigerObjekt
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
            this.txtNyKategori = new System.Windows.Forms.TextBox();
            this.btnLeggTilNyKategori = new System.Windows.Forms.Button();
            this.lbTilgjengligKategori = new System.Windows.Forms.ListBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.lblValgtForDetteObjektet = new System.Windows.Forms.Label();
            this.lblEksisterende = new System.Windows.Forms.Label();
            this.lblNyTag = new System.Windows.Forms.Label();
            this.txtNyTag = new System.Windows.Forms.TextBox();
            this.lblVelgTags = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.lblKommentar = new System.Windows.Forms.Label();
            this.txtKommentar = new System.Windows.Forms.TextBox();
            this.btnLeggTilTag = new System.Windows.Forms.Button();
            this.lbValgtTags = new System.Windows.Forms.ListBox();
            this.lbTilgjengeligeTags = new System.Windows.Forms.ListBox();
            this.btnLagreEndring = new System.Windows.Forms.Button();
            this.lblSikkerhetsklarering = new System.Windows.Forms.Label();
            this.txtSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.lblNavn = new System.Windows.Forms.Label();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.gbObjekt = new System.Windows.Forms.GroupBox();
            this.gbTag = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbObjekt.SuspendLayout();
            this.gbTag.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 46);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Rediger Objekt";
            // 
            // txtNyKategori
            // 
            this.txtNyKategori.BackColor = System.Drawing.SystemColors.Control;
            this.txtNyKategori.Location = new System.Drawing.Point(5, 173);
            this.txtNyKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNyKategori.Name = "txtNyKategori";
            this.txtNyKategori.Size = new System.Drawing.Size(139, 22);
            this.txtNyKategori.TabIndex = 87;
            // 
            // btnLeggTilNyKategori
            // 
            this.btnLeggTilNyKategori.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilNyKategori.Location = new System.Drawing.Point(152, 168);
            this.btnLeggTilNyKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilNyKategori.Name = "btnLeggTilNyKategori";
            this.btnLeggTilNyKategori.Size = new System.Drawing.Size(138, 27);
            this.btnLeggTilNyKategori.TabIndex = 86;
            this.btnLeggTilNyKategori.Text = "Legg til ny Kategori";
            this.btnLeggTilNyKategori.UseVisualStyleBackColor = true;
            this.btnLeggTilNyKategori.Click += new System.EventHandler(this.BtnLeggTilNyKategori_Click);
            // 
            // lbTilgjengligKategori
            // 
            this.lbTilgjengligKategori.FormattingEnabled = true;
            this.lbTilgjengligKategori.ItemHeight = 16;
            this.lbTilgjengligKategori.Location = new System.Drawing.Point(5, 127);
            this.lbTilgjengligKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTilgjengligKategori.Name = "lbTilgjengligKategori";
            this.lbTilgjengligKategori.Size = new System.Drawing.Size(137, 36);
            this.lbTilgjengligKategori.Sorted = true;
            this.lbTilgjengligKategori.TabIndex = 85;
            this.toolTip1.SetToolTip(this.lbTilgjengligKategori, "Dobbelklikk for å velge");
            this.lbTilgjengligKategori.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LbTilgjengligKategori_MouseClick);            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblKategori.Location = new System.Drawing.Point(5, 108);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(79, 20);
            this.lblKategori.TabIndex = 84;
            this.lblKategori.Text = "Kategori";
            // 
            // txtKategori
            // 
            this.txtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKategori.Location = new System.Drawing.Point(152, 127);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.ReadOnly = true;
            this.txtKategori.Size = new System.Drawing.Size(137, 22);
            this.txtKategori.TabIndex = 83;
            // 
            // lblValgtForDetteObjektet
            // 
            this.lblValgtForDetteObjektet.AutoSize = true;
            this.lblValgtForDetteObjektet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValgtForDetteObjektet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblValgtForDetteObjektet.Location = new System.Drawing.Point(152, 39);
            this.lblValgtForDetteObjektet.Name = "lblValgtForDetteObjektet";
            this.lblValgtForDetteObjektet.Size = new System.Drawing.Size(140, 16);
            this.lblValgtForDetteObjektet.TabIndex = 82;
            this.lblValgtForDetteObjektet.Text = "valgt for dette Objektet";
            // 
            // lblEksisterende
            // 
            this.lblEksisterende.AutoSize = true;
            this.lblEksisterende.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEksisterende.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblEksisterende.Location = new System.Drawing.Point(5, 39);
            this.lblEksisterende.Name = "lblEksisterende";
            this.lblEksisterende.Size = new System.Drawing.Size(86, 16);
            this.lblEksisterende.TabIndex = 81;
            this.lblEksisterende.Text = "Eksisterende";
            // 
            // lblNyTag
            // 
            this.lblNyTag.AutoSize = true;
            this.lblNyTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblNyTag.Location = new System.Drawing.Point(5, 256);
            this.lblNyTag.Name = "lblNyTag";
            this.lblNyTag.Size = new System.Drawing.Size(74, 20);
            this.lblNyTag.TabIndex = 80;
            this.lblNyTag.Text = "Ny Tag ";
            // 
            // txtNyTag
            // 
            this.txtNyTag.BackColor = System.Drawing.SystemColors.Control;
            this.txtNyTag.Location = new System.Drawing.Point(4, 278);
            this.txtNyTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNyTag.Name = "txtNyTag";
            this.txtNyTag.Size = new System.Drawing.Size(121, 22);
            this.txtNyTag.TabIndex = 79;
            // 
            // lblVelgTags
            // 
            this.lblVelgTags.AutoSize = true;
            this.lblVelgTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelgTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblVelgTags.Location = new System.Drawing.Point(5, 18);
            this.lblVelgTags.Name = "lblVelgTags";
            this.lblVelgTags.Size = new System.Drawing.Size(146, 20);
            this.lblVelgTags.TabIndex = 78;
            this.lblVelgTags.Text = "Velg Hvilke tags";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblLong.Location = new System.Drawing.Point(5, 292);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(50, 20);
            this.lblLong.TabIndex = 77;
            this.lblLong.Text = "Long";
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.SystemColors.Control;
            this.txtLong.Location = new System.Drawing.Point(5, 314);
            this.txtLong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(285, 22);
            this.txtLong.TabIndex = 76;
            this.txtLong.Text = "Dobbelklikk på kartet";
            this.toolTip1.SetToolTip(this.txtLong, "Dobbelklikk på kartet");
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblLat.Location = new System.Drawing.Point(5, 246);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(36, 20);
            this.lblLat.TabIndex = 75;
            this.lblLat.Text = "Lat";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.Control;
            this.txtLat.Location = new System.Drawing.Point(5, 266);
            this.txtLat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(287, 22);
            this.txtLat.TabIndex = 74;
            this.txtLat.Text = "Dobbelklikk på kartet";
            this.toolTip1.SetToolTip(this.txtLat, "Dobbelklikk på kartet");
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKommentar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblKommentar.Location = new System.Drawing.Point(5, 199);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(104, 20);
            this.lblKommentar.TabIndex = 73;
            this.lblKommentar.Text = "Kommentar";
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(5, 222);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.Size = new System.Drawing.Size(285, 22);
            this.txtKommentar.TabIndex = 72;
            // 
            // btnLeggTilTag
            // 
            this.btnLeggTilTag.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilTag.Location = new System.Drawing.Point(131, 276);
            this.btnLeggTilTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilTag.Name = "btnLeggTilTag";
            this.btnLeggTilTag.Size = new System.Drawing.Size(73, 27);
            this.btnLeggTilTag.TabIndex = 71;
            this.btnLeggTilTag.Text = "Legg til";
            this.btnLeggTilTag.UseVisualStyleBackColor = true;
            this.btnLeggTilTag.Click += new System.EventHandler(this.BtnLeggTilTag_Click);
            // 
            // lbValgtTags
            // 
            this.lbValgtTags.FormattingEnabled = true;
            this.lbValgtTags.ItemHeight = 16;
            this.lbValgtTags.Location = new System.Drawing.Point(152, 57);
            this.lbValgtTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbValgtTags.Name = "lbValgtTags";
            this.lbValgtTags.Size = new System.Drawing.Size(140, 196);
            this.lbValgtTags.Sorted = true;
            this.lbValgtTags.TabIndex = 70;
            this.toolTip1.SetToolTip(this.lbValgtTags, "Dobbelklikk for å flytte over");
            this.lbValgtTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbValgtTags_MouseDoubleClick);
            // 
            // lbTilgjengeligeTags
            // 
            this.lbTilgjengeligeTags.FormattingEnabled = true;
            this.lbTilgjengeligeTags.ItemHeight = 16;
            this.lbTilgjengeligeTags.Location = new System.Drawing.Point(5, 57);
            this.lbTilgjengeligeTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTilgjengeligeTags.Name = "lbTilgjengeligeTags";
            this.lbTilgjengeligeTags.Size = new System.Drawing.Size(141, 196);
            this.lbTilgjengeligeTags.Sorted = true;
            this.lbTilgjengeligeTags.TabIndex = 69;
            this.toolTip1.SetToolTip(this.lbTilgjengeligeTags, "Dobbelklikk for å flytte over");
            this.lbTilgjengeligeTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbTilgjengeligeTags_MouseDoubleClick);
            // 
            // btnLagreEndring
            // 
            this.btnLagreEndring.Location = new System.Drawing.Point(20, 725);
            this.btnLagreEndring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLagreEndring.Name = "btnLagreEndring";
            this.btnLagreEndring.Size = new System.Drawing.Size(123, 34);
            this.btnLagreEndring.TabIndex = 68;
            this.btnLagreEndring.Text = "Lagre endering";
            this.btnLagreEndring.UseVisualStyleBackColor = true;
            this.btnLagreEndring.Click += new System.EventHandler(this.BtnLeggTilObjekt_Click);
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(5, 63);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(211, 20);
            this.lblSikkerhetsklarering.TabIndex = 67;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering(1-3)";
            // 
            // txtSikkerhetsklarering
            // 
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(5, 84);
            this.txtSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSikkerhetsklarering.Name = "txtSikkerhetsklarering";
            this.txtSikkerhetsklarering.Size = new System.Drawing.Size(287, 22);
            this.txtSikkerhetsklarering.TabIndex = 66;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblNavn.Location = new System.Drawing.Point(5, 18);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(51, 20);
            this.lblNavn.TabIndex = 65;
            this.lblNavn.Text = "Navn";
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(5, 38);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.Size = new System.Drawing.Size(285, 22);
            this.txtNavn.TabIndex = 64;
            // 
            // gbObjekt
            // 
            this.gbObjekt.Controls.Add(this.lblNavn);
            this.gbObjekt.Controls.Add(this.txtNyKategori);
            this.gbObjekt.Controls.Add(this.txtNavn);
            this.gbObjekt.Controls.Add(this.btnLeggTilNyKategori);
            this.gbObjekt.Controls.Add(this.txtSikkerhetsklarering);
            this.gbObjekt.Controls.Add(this.lbTilgjengligKategori);
            this.gbObjekt.Controls.Add(this.lblSikkerhetsklarering);
            this.gbObjekt.Controls.Add(this.lblKategori);
            this.gbObjekt.Controls.Add(this.txtKommentar);
            this.gbObjekt.Controls.Add(this.txtKategori);
            this.gbObjekt.Controls.Add(this.lblKommentar);
            this.gbObjekt.Controls.Add(this.txtLat);
            this.gbObjekt.Controls.Add(this.lblLat);
            this.gbObjekt.Controls.Add(this.txtLong);
            this.gbObjekt.Controls.Add(this.lblLong);
            this.gbObjekt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.gbObjekt.Location = new System.Drawing.Point(20, 57);
            this.gbObjekt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbObjekt.Name = "gbObjekt";
            this.gbObjekt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbObjekt.Size = new System.Drawing.Size(300, 346);
            this.gbObjekt.TabIndex = 88;
            this.gbObjekt.TabStop = false;
            this.gbObjekt.Text = "Objekt";
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
            this.gbTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.gbTag.Location = new System.Drawing.Point(20, 407);
            this.gbTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTag.Name = "gbTag";
            this.gbTag.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTag.Size = new System.Drawing.Size(300, 314);
            this.gbTag.TabIndex = 89;
            this.gbTag.TabStop = false;
            this.gbTag.Text = "Tag";
            // 
            // frm_R_RedigerObjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(391, 825);
            this.Controls.Add(this.gbTag);
            this.Controls.Add(this.gbObjekt);
            this.Controls.Add(this.btnLagreEndring);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_R_RedigerObjekt";
            this.Text = "frm_R_RedigerObjektOmråde";
            this.Load += new System.EventHandler(this.Frm_R_RedigerObjekt_Load);
            this.gbObjekt.ResumeLayout(false);
            this.gbObjekt.PerformLayout();
            this.gbTag.ResumeLayout(false);
            this.gbTag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNyKategori;
        private System.Windows.Forms.Button btnLeggTilNyKategori;
        private System.Windows.Forms.ListBox lbTilgjengligKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label lblValgtForDetteObjektet;
        private System.Windows.Forms.Label lblEksisterende;
        private System.Windows.Forms.Label lblNyTag;
        private System.Windows.Forms.TextBox txtNyTag;
        private System.Windows.Forms.Label lblVelgTags;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label lblKommentar;
        private System.Windows.Forms.TextBox txtKommentar;
        private System.Windows.Forms.Button btnLeggTilTag;
        private System.Windows.Forms.ListBox lbValgtTags;
        private System.Windows.Forms.ListBox lbTilgjengeligeTags;
        private System.Windows.Forms.Button btnLagreEndring;
        private System.Windows.Forms.Label lblSikkerhetsklarering;
        private System.Windows.Forms.TextBox txtSikkerhetsklarering;
        private System.Windows.Forms.Label lblNavn;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.GroupBox gbObjekt;
        private System.Windows.Forms.GroupBox gbTag;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}