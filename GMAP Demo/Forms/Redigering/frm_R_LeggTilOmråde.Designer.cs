namespace GMAP_Demo
{
    partial class frm_R_LeggTilOmråde
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
            this.btnLeggTilOmrådetIDb = new System.Windows.Forms.Button();
            this.lblSikkerhetsklarering = new System.Windows.Forms.Label();
            this.txtSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.lblNavn = new System.Windows.Forms.Label();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.btnLeggTilPunkt = new System.Windows.Forms.Button();
            this.lbPunkter = new System.Windows.Forms.ListBox();
            this.txtNrPunkt = new System.Windows.Forms.TextBox();
            this.lblFarge = new System.Windows.Forms.Label();
            this.txtfarge = new System.Windows.Forms.TextBox();
            this.lbTilgjengligFarge = new System.Windows.Forms.ListBox();
            this.btnFjernSistepunkt = new System.Windows.Forms.Button();
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
            this.lblTitle.Size = new System.Drawing.Size(317, 46);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Legg til Område";
            // 
            // lblValgtForDetteObjektet
            // 
            this.lblValgtForDetteObjektet.AutoSize = true;
            this.lblValgtForDetteObjektet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValgtForDetteObjektet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblValgtForDetteObjektet.Location = new System.Drawing.Point(152, 42);
            this.lblValgtForDetteObjektet.Name = "lblValgtForDetteObjektet";
            this.lblValgtForDetteObjektet.Size = new System.Drawing.Size(139, 16);
            this.lblValgtForDetteObjektet.TabIndex = 50;
            this.lblValgtForDetteObjektet.Text = "Valgt for dette område";
            // 
            // lblEksisterende
            // 
            this.lblEksisterende.AutoSize = true;
            this.lblEksisterende.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEksisterende.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblEksisterende.Location = new System.Drawing.Point(5, 42);
            this.lblEksisterende.Name = "lblEksisterende";
            this.lblEksisterende.Size = new System.Drawing.Size(86, 16);
            this.lblEksisterende.TabIndex = 49;
            this.lblEksisterende.Text = "Eksisterende";
            // 
            // lblNyTag
            // 
            this.lblNyTag.AutoSize = true;
            this.lblNyTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblNyTag.Location = new System.Drawing.Point(4, 255);
            this.lblNyTag.Name = "lblNyTag";
            this.lblNyTag.Size = new System.Drawing.Size(74, 20);
            this.lblNyTag.TabIndex = 48;
            this.lblNyTag.Text = "Ny Tag ";
            // 
            // txtNyTag
            // 
            this.txtNyTag.BackColor = System.Drawing.SystemColors.Control;
            this.txtNyTag.Location = new System.Drawing.Point(5, 278);
            this.txtNyTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNyTag.Name = "txtNyTag";
            this.txtNyTag.Size = new System.Drawing.Size(121, 22);
            this.txtNyTag.TabIndex = 47;
            // 
            // lblVelgTags
            // 
            this.lblVelgTags.AutoSize = true;
            this.lblVelgTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelgTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblVelgTags.Location = new System.Drawing.Point(5, 18);
            this.lblVelgTags.Name = "lblVelgTags";
            this.lblVelgTags.Size = new System.Drawing.Size(146, 20);
            this.lblVelgTags.TabIndex = 46;
            this.lblVelgTags.Text = "Velg Hvilke tags";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblLong.Location = new System.Drawing.Point(5, 250);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(50, 20);
            this.lblLong.TabIndex = 45;
            this.lblLong.Text = "Long";
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.SystemColors.Control;
            this.txtLong.Location = new System.Drawing.Point(5, 272);
            this.txtLong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(285, 22);
            this.txtLong.TabIndex = 38;
            this.txtLong.Text = "Dobbelklikk på kartet + \"legg til\"";
            this.toolTip1.SetToolTip(this.txtLong, "Dobbelklikk på kartet + \"legg til\"");
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblLat.Location = new System.Drawing.Point(5, 206);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(36, 20);
            this.lblLat.TabIndex = 43;
            this.lblLat.Text = "Lat";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.Control;
            this.txtLat.Location = new System.Drawing.Point(5, 226);
            this.txtLat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(287, 22);
            this.txtLat.TabIndex = 37;
            this.txtLat.Text = "Dobbelklikk på kartet + \"legg til\"";
            this.toolTip1.SetToolTip(this.txtLat, "Dobbelklikk på kartet + \"legg til\"");
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKommentar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblKommentar.Location = new System.Drawing.Point(5, 106);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(104, 20);
            this.lblKommentar.TabIndex = 41;
            this.lblKommentar.Text = "Kommentar";
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(5, 126);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.Size = new System.Drawing.Size(285, 22);
            this.txtKommentar.TabIndex = 34;
            // 
            // btnLeggTilTag
            // 
            this.btnLeggTilTag.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilTag.Location = new System.Drawing.Point(133, 274);
            this.btnLeggTilTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilTag.Name = "btnLeggTilTag";
            this.btnLeggTilTag.Size = new System.Drawing.Size(73, 27);
            this.btnLeggTilTag.TabIndex = 39;
            this.btnLeggTilTag.Text = "Legg til";
            this.btnLeggTilTag.UseVisualStyleBackColor = true;
            this.btnLeggTilTag.Click += new System.EventHandler(this.btnLeggTilTag_Click);
            // 
            // lbValgtTags
            // 
            this.lbValgtTags.FormattingEnabled = true;
            this.lbValgtTags.ItemHeight = 16;
            this.lbValgtTags.Location = new System.Drawing.Point(152, 62);
            this.lbValgtTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbValgtTags.Name = "lbValgtTags";
            this.lbValgtTags.Size = new System.Drawing.Size(140, 196);
            this.lbValgtTags.Sorted = true;
            this.lbValgtTags.TabIndex = 38;
            this.toolTip1.SetToolTip(this.lbValgtTags, "Dobbelklikk for å flytte over");
            this.lbValgtTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbValgtTags_MouseDoubleClick);
            // 
            // lbTilgjengeligeTags
            // 
            this.lbTilgjengeligeTags.FormattingEnabled = true;
            this.lbTilgjengeligeTags.ItemHeight = 16;
            this.lbTilgjengeligeTags.Location = new System.Drawing.Point(5, 62);
            this.lbTilgjengeligeTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTilgjengeligeTags.Name = "lbTilgjengeligeTags";
            this.lbTilgjengeligeTags.Size = new System.Drawing.Size(141, 196);
            this.lbTilgjengeligeTags.Sorted = true;
            this.lbTilgjengeligeTags.TabIndex = 39;
            this.toolTip1.SetToolTip(this.lbTilgjengeligeTags, "Dobbelklikk for å flytte over");
            this.lbTilgjengeligeTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTilgjengeligeTags_MouseDoubleClick);
            // 
            // btnLeggTilOmrådetIDb
            // 
            this.btnLeggTilOmrådetIDb.Location = new System.Drawing.Point(20, 798);
            this.btnLeggTilOmrådetIDb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilOmrådetIDb.Name = "btnLeggTilOmrådetIDb";
            this.btnLeggTilOmrådetIDb.Size = new System.Drawing.Size(123, 34);
            this.btnLeggTilOmrådetIDb.TabIndex = 36;
            this.btnLeggTilOmrådetIDb.Text = "Lagre området";
            this.btnLeggTilOmrådetIDb.UseVisualStyleBackColor = true;
            this.btnLeggTilOmrådetIDb.Click += new System.EventHandler(this.btnLeggTilOmrådeIDb_Click);
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(5, 63);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(211, 20);
            this.lblSikkerhetsklarering.TabIndex = 35;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering(1-3)";
            // 
            // txtSikkerhetsklarering
            // 
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(5, 82);
            this.txtSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSikkerhetsklarering.MaxLength = 1;
            this.txtSikkerhetsklarering.Name = "txtSikkerhetsklarering";
            this.txtSikkerhetsklarering.Size = new System.Drawing.Size(287, 22);
            this.txtSikkerhetsklarering.TabIndex = 33;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblNavn.Location = new System.Drawing.Point(5, 18);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(51, 20);
            this.lblNavn.TabIndex = 33;
            this.lblNavn.Text = "Navn";
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(5, 38);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.Size = new System.Drawing.Size(285, 22);
            this.txtNavn.TabIndex = 32;
            // 
            // btnLeggTilPunkt
            // 
            this.btnLeggTilPunkt.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilPunkt.Location = new System.Drawing.Point(5, 299);
            this.btnLeggTilPunkt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilPunkt.Name = "btnLeggTilPunkt";
            this.btnLeggTilPunkt.Size = new System.Drawing.Size(104, 28);
            this.btnLeggTilPunkt.TabIndex = 51;
            this.btnLeggTilPunkt.Text = "Legg til punkt";
            this.btnLeggTilPunkt.UseVisualStyleBackColor = true;
            this.btnLeggTilPunkt.Click += new System.EventHandler(this.btnLeggTilPunktIListe_Click);
            // 
            // lbPunkter
            // 
            this.lbPunkter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbPunkter.FormattingEnabled = true;
            this.lbPunkter.ItemHeight = 16;
            this.lbPunkter.Location = new System.Drawing.Point(5, 334);
            this.lbPunkter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPunkter.Name = "lbPunkter";
            this.lbPunkter.Size = new System.Drawing.Size(285, 84);
            this.lbPunkter.TabIndex = 52;
            this.toolTip1.SetToolTip(this.lbPunkter, "Markøren på kartet er blå når den er lagt til");
            // 
            // txtNrPunkt
            // 
            this.txtNrPunkt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNrPunkt.Location = new System.Drawing.Point(117, 302);
            this.txtNrPunkt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNrPunkt.Name = "txtNrPunkt";
            this.txtNrPunkt.ReadOnly = true;
            this.txtNrPunkt.Size = new System.Drawing.Size(28, 22);
            this.txtNrPunkt.TabIndex = 53;
            this.txtNrPunkt.Text = "0";
            // 
            // lblFarge
            // 
            this.lblFarge.AutoSize = true;
            this.lblFarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblFarge.Location = new System.Drawing.Point(5, 150);
            this.lblFarge.Name = "lblFarge";
            this.lblFarge.Size = new System.Drawing.Size(57, 20);
            this.lblFarge.TabIndex = 55;
            this.lblFarge.Text = "Farge";
            // 
            // txtfarge
            // 
            this.txtfarge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtfarge.Location = new System.Drawing.Point(152, 170);
            this.txtfarge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfarge.Name = "txtfarge";
            this.txtfarge.ReadOnly = true;
            this.txtfarge.Size = new System.Drawing.Size(137, 22);
            this.txtfarge.TabIndex = 36;
            // 
            // lbTilgjengligFarge
            // 
            this.lbTilgjengligFarge.FormattingEnabled = true;
            this.lbTilgjengligFarge.ItemHeight = 16;
            this.lbTilgjengligFarge.Location = new System.Drawing.Point(5, 170);
            this.lbTilgjengligFarge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTilgjengligFarge.Name = "lbTilgjengligFarge";
            this.lbTilgjengligFarge.Size = new System.Drawing.Size(137, 36);
            this.lbTilgjengligFarge.Sorted = true;
            this.lbTilgjengligFarge.TabIndex = 35;
            this.toolTip1.SetToolTip(this.lbTilgjengligFarge, "Dobbelklikk for å velge");
            this.lbTilgjengligFarge.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTilgjengligFarge_MouseDoubleClick);
            // 
            // btnFjernSistepunkt
            // 
            this.btnFjernSistepunkt.ForeColor = System.Drawing.Color.Black;
            this.btnFjernSistepunkt.Location = new System.Drawing.Point(155, 299);
            this.btnFjernSistepunkt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFjernSistepunkt.Name = "btnFjernSistepunkt";
            this.btnFjernSistepunkt.Size = new System.Drawing.Size(93, 28);
            this.btnFjernSistepunkt.TabIndex = 82;
            this.btnFjernSistepunkt.Text = "Fjern siste";
            this.btnFjernSistepunkt.UseVisualStyleBackColor = true;
            this.btnFjernSistepunkt.Click += new System.EventHandler(this.btnFjernSistepunkt_Click);
            // 
            // gbOmråde
            // 
            this.gbOmråde.Controls.Add(this.btnFjernAlle);
            this.gbOmråde.Controls.Add(this.lblNavn);
            this.gbOmråde.Controls.Add(this.txtNavn);
            this.gbOmråde.Controls.Add(this.btnFjernSistepunkt);
            this.gbOmråde.Controls.Add(this.txtSikkerhetsklarering);
            this.gbOmråde.Controls.Add(this.lbTilgjengligFarge);
            this.gbOmråde.Controls.Add(this.lblSikkerhetsklarering);
            this.gbOmråde.Controls.Add(this.lblFarge);
            this.gbOmråde.Controls.Add(this.txtKommentar);
            this.gbOmråde.Controls.Add(this.txtfarge);
            this.gbOmråde.Controls.Add(this.lblKommentar);
            this.gbOmråde.Controls.Add(this.txtNrPunkt);
            this.gbOmråde.Controls.Add(this.txtLat);
            this.gbOmråde.Controls.Add(this.lbPunkter);
            this.gbOmråde.Controls.Add(this.lblLat);
            this.gbOmråde.Controls.Add(this.btnLeggTilPunkt);
            this.gbOmråde.Controls.Add(this.txtLong);
            this.gbOmråde.Controls.Add(this.lblLong);
            this.gbOmråde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.gbOmråde.Location = new System.Drawing.Point(20, 57);
            this.gbOmråde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOmråde.Name = "gbOmråde";
            this.gbOmråde.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOmråde.Size = new System.Drawing.Size(300, 422);
            this.gbOmråde.TabIndex = 83;
            this.gbOmråde.TabStop = false;
            this.gbOmråde.Text = "Område";
            this.toolTip1.SetToolTip(this.gbOmråde, "Test");
            // 
            // btnFjernAlle
            // 
            this.btnFjernAlle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnFjernAlle.ForeColor = System.Drawing.Color.Black;
            this.btnFjernAlle.Image = global::GMAP_Demo.Properties.Resources.trash_20px;
            this.btnFjernAlle.Location = new System.Drawing.Point(255, 295);
            this.btnFjernAlle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFjernAlle.Name = "btnFjernAlle";
            this.btnFjernAlle.Size = new System.Drawing.Size(35, 34);
            this.btnFjernAlle.TabIndex = 84;
            this.toolTip1.SetToolTip(this.btnFjernAlle, "Fjern alle punkter");
            this.btnFjernAlle.UseVisualStyleBackColor = false;
            this.btnFjernAlle.Click += new System.EventHandler(this.btnFjernAlle_Click);
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
            this.gbTag.Location = new System.Drawing.Point(20, 482);
            this.gbTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTag.Name = "gbTag";
            this.gbTag.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTag.Size = new System.Drawing.Size(300, 310);
            this.gbTag.TabIndex = 83;
            this.gbTag.TabStop = false;
            this.gbTag.Text = "Tag";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Hjelp";
            // 
            // frm_R_LeggTilOmråde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(391, 825);
            this.Controls.Add(this.gbTag);
            this.Controls.Add(this.gbOmråde);
            this.Controls.Add(this.btnLeggTilOmrådetIDb);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_R_LeggTilOmråde";
            this.Text = "frm_R_LeggTilOmråde";
            this.Load += new System.EventHandler(this.frm_R_LeggTilOmråde_Load);
            this.gbOmråde.ResumeLayout(false);
            this.gbOmråde.PerformLayout();
            this.gbTag.ResumeLayout(false);
            this.gbTag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.Button btnLeggTilOmrådetIDb;
        private System.Windows.Forms.Label lblSikkerhetsklarering;
        private System.Windows.Forms.TextBox txtSikkerhetsklarering;
        private System.Windows.Forms.Label lblNavn;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.Button btnLeggTilPunkt;
        private System.Windows.Forms.ListBox lbPunkter;
        private System.Windows.Forms.TextBox txtNrPunkt;
        private System.Windows.Forms.Label lblFarge;
        private System.Windows.Forms.TextBox txtfarge;
        private System.Windows.Forms.ListBox lbTilgjengligFarge;
        private System.Windows.Forms.Button btnFjernSistepunkt;
        private System.Windows.Forms.GroupBox gbOmråde;
        private System.Windows.Forms.GroupBox gbTag;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnFjernAlle;
    }
}