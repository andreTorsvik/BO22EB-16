namespace GMAP_Demo
{
    partial class Frm_R_RedigerOmråde
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
            this.lbTilgjengligFarge = new System.Windows.Forms.ListBox();
            this.lblFarge = new System.Windows.Forms.Label();
            this.txtFarge = new System.Windows.Forms.TextBox();
            this.txtNrPunkt = new System.Windows.Forms.TextBox();
            this.lbPunkter = new System.Windows.Forms.ListBox();
            this.btnLeggTilPunkt = new System.Windows.Forms.Button();
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
            this.lblSikkerhetsklarering = new System.Windows.Forms.Label();
            this.txtSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.lblNavn = new System.Windows.Forms.Label();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.btnFjernSistepunkt = new System.Windows.Forms.Button();
            this.btnLagreEndring = new System.Windows.Forms.Button();
            this.gbOmråde = new System.Windows.Forms.GroupBox();
            this.btnFjernAlle = new System.Windows.Forms.Button();
            this.gbTag = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbOmråde.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(327, 46);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Rediger Område";
            // 
            // lbTilgjengligFarge
            // 
            this.lbTilgjengligFarge.FormattingEnabled = true;
            this.lbTilgjengligFarge.ItemHeight = 17;
            this.lbTilgjengligFarge.Location = new System.Drawing.Point(5, 174);
            this.lbTilgjengligFarge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTilgjengligFarge.Name = "lbTilgjengligFarge";
            this.lbTilgjengligFarge.Size = new System.Drawing.Size(137, 38);
            this.lbTilgjengligFarge.Sorted = true;
            this.lbTilgjengligFarge.TabIndex = 80;
            this.toolTip1.SetToolTip(this.lbTilgjengligFarge, "Dobbelklikk for å velge");
            this.lbTilgjengligFarge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LbTilgjengligFarge_MouseClick);
            // 
            // lblFarge
            // 
            this.lblFarge.AutoSize = true;
            this.lblFarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFarge.Location = new System.Drawing.Point(5, 155);
            this.lblFarge.Name = "lblFarge";
            this.lblFarge.Size = new System.Drawing.Size(45, 17);
            this.lblFarge.TabIndex = 79;
            this.lblFarge.Text = "Farge";
            // 
            // txtFarge
            // 
            this.txtFarge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtFarge.Location = new System.Drawing.Point(153, 174);
            this.txtFarge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFarge.Name = "txtFarge";
            this.txtFarge.ReadOnly = true;
            this.txtFarge.Size = new System.Drawing.Size(137, 23);
            this.txtFarge.TabIndex = 78;
            // 
            // txtNrPunkt
            // 
            this.txtNrPunkt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNrPunkt.Location = new System.Drawing.Point(115, 310);
            this.txtNrPunkt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNrPunkt.Name = "txtNrPunkt";
            this.txtNrPunkt.ReadOnly = true;
            this.txtNrPunkt.Size = new System.Drawing.Size(28, 23);
            this.txtNrPunkt.TabIndex = 77;
            this.txtNrPunkt.Text = "0";
            // 
            // lbPunkter
            // 
            this.lbPunkter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbPunkter.FormattingEnabled = true;
            this.lbPunkter.ItemHeight = 17;
            this.lbPunkter.Location = new System.Drawing.Point(5, 340);
            this.lbPunkter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPunkter.Name = "lbPunkter";
            this.lbPunkter.Size = new System.Drawing.Size(285, 72);
            this.lbPunkter.TabIndex = 76;
            this.toolTip1.SetToolTip(this.lbPunkter, "Markøren på kartet er blå når den er lagt til");
            // 
            // btnLeggTilPunkt
            // 
            this.btnLeggTilPunkt.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilPunkt.Location = new System.Drawing.Point(5, 306);
            this.btnLeggTilPunkt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilPunkt.Name = "btnLeggTilPunkt";
            this.btnLeggTilPunkt.Size = new System.Drawing.Size(104, 28);
            this.btnLeggTilPunkt.TabIndex = 75;
            this.btnLeggTilPunkt.Text = "Legg til punkt";
            this.btnLeggTilPunkt.UseVisualStyleBackColor = true;
            this.btnLeggTilPunkt.Click += new System.EventHandler(this.BtnLeggTilPunkt_Click);
            // 
            // lblValgtForDetteObjektet
            // 
            this.lblValgtForDetteObjektet.AutoSize = true;
            this.lblValgtForDetteObjektet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValgtForDetteObjektet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValgtForDetteObjektet.Location = new System.Drawing.Point(149, 34);
            this.lblValgtForDetteObjektet.Name = "lblValgtForDetteObjektet";
            this.lblValgtForDetteObjektet.Size = new System.Drawing.Size(91, 17);
            this.lblValgtForDetteObjektet.TabIndex = 74;
            this.lblValgtForDetteObjektet.Text = "Tilhører valgt";
            // 
            // lblEksisterende
            // 
            this.lblEksisterende.AutoSize = true;
            this.lblEksisterende.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEksisterende.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEksisterende.Location = new System.Drawing.Point(5, 34);
            this.lblEksisterende.Name = "lblEksisterende";
            this.lblEksisterende.Size = new System.Drawing.Size(86, 17);
            this.lblEksisterende.TabIndex = 73;
            this.lblEksisterende.Text = "Tilhører ikke";
            // 
            // lblNyTag
            // 
            this.lblNyTag.AutoSize = true;
            this.lblNyTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyTag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNyTag.Location = new System.Drawing.Point(5, 252);
            this.lblNyTag.Name = "lblNyTag";
            this.lblNyTag.Size = new System.Drawing.Size(58, 17);
            this.lblNyTag.TabIndex = 72;
            this.lblNyTag.Text = "Ny Tag ";
            // 
            // txtNyTag
            // 
            this.txtNyTag.BackColor = System.Drawing.SystemColors.Control;
            this.txtNyTag.Location = new System.Drawing.Point(5, 268);
            this.txtNyTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNyTag.Name = "txtNyTag";
            this.txtNyTag.Size = new System.Drawing.Size(137, 23);
            this.txtNyTag.TabIndex = 71;
            // 
            // lblVelgTags
            // 
            this.lblVelgTags.AutoSize = true;
            this.lblVelgTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelgTags.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVelgTags.Location = new System.Drawing.Point(5, 18);
            this.lblVelgTags.Name = "lblVelgTags";
            this.lblVelgTags.Size = new System.Drawing.Size(114, 17);
            this.lblVelgTags.TabIndex = 70;
            this.lblVelgTags.Text = "Velg Hvilke Tags";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLong.Location = new System.Drawing.Point(5, 258);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(40, 17);
            this.lblLong.TabIndex = 69;
            this.lblLong.Text = "Long";
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.SystemColors.Control;
            this.txtLong.Location = new System.Drawing.Point(5, 277);
            this.txtLong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(285, 23);
            this.txtLong.TabIndex = 68;
            this.txtLong.Text = "Dobbelklikk på kartet + \"legg til\"";
            this.toolTip1.SetToolTip(this.txtLong, "Dobbelklikk på kartet + \"legg til\"");
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLat.Location = new System.Drawing.Point(5, 213);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(28, 17);
            this.lblLat.TabIndex = 67;
            this.lblLat.Text = "Lat";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.Control;
            this.txtLat.Location = new System.Drawing.Point(5, 231);
            this.txtLat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(287, 23);
            this.txtLat.TabIndex = 66;
            this.txtLat.Text = "Dobbelklikk på kartet + \"legg til\"";
            this.toolTip1.SetToolTip(this.txtLat, "Dobbelklikk på kartet + \"legg til\"");
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKommentar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKommentar.Location = new System.Drawing.Point(5, 110);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(80, 17);
            this.lblKommentar.TabIndex = 65;
            this.lblKommentar.Text = "Kommentar";
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(5, 128);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.Size = new System.Drawing.Size(285, 23);
            this.txtKommentar.TabIndex = 64;
            // 
            // btnLeggTilTag
            // 
            this.btnLeggTilTag.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilTag.Location = new System.Drawing.Point(153, 265);
            this.btnLeggTilTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilTag.Name = "btnLeggTilTag";
            this.btnLeggTilTag.Size = new System.Drawing.Size(139, 28);
            this.btnLeggTilTag.TabIndex = 63;
            this.btnLeggTilTag.Text = "Legg til";
            this.btnLeggTilTag.UseVisualStyleBackColor = true;
            this.btnLeggTilTag.Click += new System.EventHandler(this.BtnLeggTilTag_Click);
            // 
            // lbValgtTags
            // 
            this.lbValgtTags.FormattingEnabled = true;
            this.lbValgtTags.ItemHeight = 17;
            this.lbValgtTags.Location = new System.Drawing.Point(153, 53);
            this.lbValgtTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbValgtTags.Name = "lbValgtTags";
            this.lbValgtTags.Size = new System.Drawing.Size(140, 191);
            this.lbValgtTags.Sorted = true;
            this.lbValgtTags.TabIndex = 62;
            this.toolTip1.SetToolTip(this.lbValgtTags, "Dobbelklikk for å flytte over");
            this.lbValgtTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbValgtTags_MouseDoubleClick);
            // 
            // lbTilgjengeligeTags
            // 
            this.lbTilgjengeligeTags.FormattingEnabled = true;
            this.lbTilgjengeligeTags.ItemHeight = 17;
            this.lbTilgjengeligeTags.Location = new System.Drawing.Point(5, 53);
            this.lbTilgjengeligeTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTilgjengeligeTags.Name = "lbTilgjengeligeTags";
            this.lbTilgjengeligeTags.Size = new System.Drawing.Size(141, 191);
            this.lbTilgjengeligeTags.Sorted = true;
            this.lbTilgjengeligeTags.TabIndex = 61;
            this.toolTip1.SetToolTip(this.lbTilgjengeligeTags, "Dobbelklikk for å flytte over");
            this.lbTilgjengeligeTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbTilgjengeligeTags_MouseDoubleClick);
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(5, 64);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(160, 17);
            this.lblSikkerhetsklarering.TabIndex = 60;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering(1-3)";
            // 
            // txtSikkerhetsklarering
            // 
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(5, 82);
            this.txtSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSikkerhetsklarering.Name = "txtSikkerhetsklarering";
            this.txtSikkerhetsklarering.Size = new System.Drawing.Size(287, 23);
            this.txtSikkerhetsklarering.TabIndex = 59;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNavn.Location = new System.Drawing.Point(5, 18);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(41, 17);
            this.lblNavn.TabIndex = 58;
            this.lblNavn.Text = "Navn";
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(5, 37);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.Size = new System.Drawing.Size(285, 23);
            this.txtNavn.TabIndex = 57;
            // 
            // btnFjernSistepunkt
            // 
            this.btnFjernSistepunkt.ForeColor = System.Drawing.Color.Black;
            this.btnFjernSistepunkt.Location = new System.Drawing.Point(149, 308);
            this.btnFjernSistepunkt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFjernSistepunkt.Name = "btnFjernSistepunkt";
            this.btnFjernSistepunkt.Size = new System.Drawing.Size(93, 28);
            this.btnFjernSistepunkt.TabIndex = 81;
            this.btnFjernSistepunkt.Text = "Fjern siste";
            this.btnFjernSistepunkt.UseVisualStyleBackColor = true;
            this.btnFjernSistepunkt.Click += new System.EventHandler(this.BtnFjernSistepunkt_Click);
            // 
            // btnLagreEndring
            // 
            this.btnLagreEndring.Location = new System.Drawing.Point(15, 798);
            this.btnLagreEndring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLagreEndring.Name = "btnLagreEndring";
            this.btnLagreEndring.Size = new System.Drawing.Size(123, 34);
            this.btnLagreEndring.TabIndex = 82;
            this.btnLagreEndring.Text = "Lagre endring";
            this.btnLagreEndring.UseVisualStyleBackColor = true;
            this.btnLagreEndring.Click += new System.EventHandler(this.BtnLagreEndring_Click);
            // 
            // gbOmråde
            // 
            this.gbOmråde.Controls.Add(this.lblNavn);
            this.gbOmråde.Controls.Add(this.txtNavn);
            this.gbOmråde.Controls.Add(this.txtSikkerhetsklarering);
            this.gbOmråde.Controls.Add(this.btnFjernAlle);
            this.gbOmråde.Controls.Add(this.btnFjernSistepunkt);
            this.gbOmråde.Controls.Add(this.lblSikkerhetsklarering);
            this.gbOmråde.Controls.Add(this.lbTilgjengligFarge);
            this.gbOmråde.Controls.Add(this.txtKommentar);
            this.gbOmråde.Controls.Add(this.lblFarge);
            this.gbOmråde.Controls.Add(this.lblKommentar);
            this.gbOmråde.Controls.Add(this.txtFarge);
            this.gbOmråde.Controls.Add(this.txtLat);
            this.gbOmråde.Controls.Add(this.txtNrPunkt);
            this.gbOmråde.Controls.Add(this.lblLat);
            this.gbOmråde.Controls.Add(this.lbPunkter);
            this.gbOmråde.Controls.Add(this.txtLong);
            this.gbOmråde.Controls.Add(this.btnLeggTilPunkt);
            this.gbOmråde.Controls.Add(this.lblLong);
            this.gbOmråde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOmråde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbOmråde.Location = new System.Drawing.Point(15, 57);
            this.gbOmråde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOmråde.Name = "gbOmråde";
            this.gbOmråde.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOmråde.Size = new System.Drawing.Size(332, 432);
            this.gbOmråde.TabIndex = 83;
            this.gbOmråde.TabStop = false;
            this.gbOmråde.Text = "Område";
            // 
            // btnFjernAlle
            // 
            this.btnFjernAlle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnFjernAlle.ForeColor = System.Drawing.Color.Black;
            this.btnFjernAlle.Image = global::GMAP_Demo.Properties.Resources.trash_20px;
            this.btnFjernAlle.Location = new System.Drawing.Point(248, 304);
            this.btnFjernAlle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFjernAlle.Name = "btnFjernAlle";
            this.btnFjernAlle.Size = new System.Drawing.Size(35, 34);
            this.btnFjernAlle.TabIndex = 81;
            this.toolTip1.SetToolTip(this.btnFjernAlle, "Fjern alle punkter");
            this.btnFjernAlle.UseVisualStyleBackColor = false;
            this.btnFjernAlle.Click += new System.EventHandler(this.BtnFjernAlle_Click);
            // 
            // gbTag
            // 
            this.gbTag.Controls.Add(this.lblVelgTags);
            this.gbTag.Controls.Add(this.lbTilgjengeligeTags);
            this.gbTag.Controls.Add(this.lbValgtTags);
            this.gbTag.Controls.Add(this.lblValgtForDetteObjektet);
            this.gbTag.Controls.Add(this.btnLeggTilTag);
            this.gbTag.Controls.Add(this.lblEksisterende);
            this.gbTag.Controls.Add(this.txtNyTag);
            this.gbTag.Controls.Add(this.lblNyTag);
            this.gbTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbTag.Location = new System.Drawing.Point(15, 494);
            this.gbTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTag.Name = "gbTag";
            this.gbTag.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTag.Size = new System.Drawing.Size(359, 299);
            this.gbTag.TabIndex = 83;
            this.gbTag.TabStop = false;
            this.gbTag.Text = "Tag";
            // 
            // Frm_R_RedigerOmråde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(391, 834);
            this.Controls.Add(this.gbTag);
            this.Controls.Add(this.gbOmråde);
            this.Controls.Add(this.btnLagreEndring);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_R_RedigerOmråde";
            this.Text = "frm_R_RedigerOmråde";
            this.Load += new System.EventHandler(this.Frm_R_RedigerOmråde_Load);
            this.gbOmråde.ResumeLayout(false);
            this.gbOmråde.PerformLayout();
            this.gbTag.ResumeLayout(false);
            this.gbTag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lbTilgjengligFarge;
        private System.Windows.Forms.Label lblFarge;
        private System.Windows.Forms.TextBox txtFarge;
        private System.Windows.Forms.TextBox txtNrPunkt;
        private System.Windows.Forms.ListBox lbPunkter;
        private System.Windows.Forms.Button btnLeggTilPunkt;
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
        private System.Windows.Forms.Label lblSikkerhetsklarering;
        private System.Windows.Forms.TextBox txtSikkerhetsklarering;
        private System.Windows.Forms.Label lblNavn;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.Button btnFjernSistepunkt;
        private System.Windows.Forms.Button btnLagreEndring;
        private System.Windows.Forms.GroupBox gbOmråde;
        private System.Windows.Forms.GroupBox gbTag;
        private System.Windows.Forms.Button btnFjernAlle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}