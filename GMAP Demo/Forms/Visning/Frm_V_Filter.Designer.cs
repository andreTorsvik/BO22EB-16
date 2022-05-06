namespace GMAP_Demo
{
    partial class Frm_V_Filter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_V_Filter));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbNavn = new System.Windows.Forms.TextBox();
            this.lblNavn = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblDato_opprettet = new System.Windows.Forms.Label();
            this.lblOpprettetAvBruker = new System.Windows.Forms.Label();
            this.lblSikkerhetsklarering = new System.Windows.Forms.Label();
            this.lblKommentar = new System.Windows.Forms.Label();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.tbDato_opprettet = new System.Windows.Forms.TextBox();
            this.tbOpprettetAvBruker = new System.Windows.Forms.TextBox();
            this.tbSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.tbKommentar = new System.Windows.Forms.TextBox();
            this.lbKategorierSkjult = new System.Windows.Forms.ListBox();
            this.lblKategorierSkjult = new System.Windows.Forms.Label();
            this.lblKategorierVises = new System.Windows.Forms.Label();
            this.lbKategorierVises = new System.Windows.Forms.ListBox();
            this.lbTagsSkjult = new System.Windows.Forms.ListBox();
            this.lblTagsSkjult = new System.Windows.Forms.Label();
            this.lbTagsVises = new System.Windows.Forms.ListBox();
            this.lblTagsVises = new System.Windows.Forms.Label();
            this.cbViseOmråde = new System.Windows.Forms.CheckBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cbAND = new System.Windows.Forms.CheckBox();
            this.cbOR = new System.Windows.Forms.CheckBox();
            this.btnTagFjernAlle = new System.Windows.Forms.Button();
            this.btnKategoriFjernAlle = new System.Windows.Forms.Button();
            this.btnTagLeggTilAlle = new System.Windows.Forms.Button();
            this.btnKategoriLeggTilAlle = new System.Windows.Forms.Button();
            this.lblTag = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.tbMåling = new System.Windows.Forms.TextBox();
            this.lblMåling = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbEnhetMåling = new System.Windows.Forms.TextBox();
            this.lblEnhetMåling = new System.Windows.Forms.Label();
            this.lbMålingDato = new System.Windows.Forms.Label();
            this.tbMålingDato = new System.Windows.Forms.TextBox();
            this.btnTimerMåling = new System.Windows.Forms.Button();
            this.btnNesteRessurs = new System.Windows.Forms.Button();
            this.btnForrigeRessurs = new System.Windows.Forms.Button();
            this.gbObjekt = new System.Windows.Forms.GroupBox();
            this.tbAntallObjekter = new System.Windows.Forms.TextBox();
            this.lblObjektAntall = new System.Windows.Forms.Label();
            this.lblHoppTilEtOmråde = new System.Windows.Forms.Label();
            this.ttTimerMåling = new System.Windows.Forms.ToolTip(this.components);
            this.gbFilter.SuspendLayout();
            this.gbInfo.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(94, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Filter";
            // 
            // tbNavn
            // 
            this.tbNavn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbNavn.Location = new System.Drawing.Point(110, 23);
            this.tbNavn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNavn.Multiline = true;
            this.tbNavn.Name = "tbNavn";
            this.tbNavn.ReadOnly = true;
            this.tbNavn.Size = new System.Drawing.Size(164, 20);
            this.tbNavn.TabIndex = 9;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNavn.Location = new System.Drawing.Point(9, 26);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(33, 13);
            this.lblNavn.TabIndex = 10;
            this.lblNavn.Text = "Navn";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategori.Location = new System.Drawing.Point(9, 50);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 11;
            this.lblKategori.Text = "Kategori";
            // 
            // lblDato_opprettet
            // 
            this.lblDato_opprettet.AutoSize = true;
            this.lblDato_opprettet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDato_opprettet.Location = new System.Drawing.Point(9, 122);
            this.lblDato_opprettet.Name = "lblDato_opprettet";
            this.lblDato_opprettet.Size = new System.Drawing.Size(75, 13);
            this.lblDato_opprettet.TabIndex = 12;
            this.lblDato_opprettet.Text = "Dato opprettet";
            // 
            // lblOpprettetAvBruker
            // 
            this.lblOpprettetAvBruker.AutoSize = true;
            this.lblOpprettetAvBruker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOpprettetAvBruker.Location = new System.Drawing.Point(9, 145);
            this.lblOpprettetAvBruker.Name = "lblOpprettetAvBruker";
            this.lblOpprettetAvBruker.Size = new System.Drawing.Size(99, 13);
            this.lblOpprettetAvBruker.TabIndex = 13;
            this.lblOpprettetAvBruker.Text = "Opprettet av bruker";
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(9, 169);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(97, 13);
            this.lblSikkerhetsklarering.TabIndex = 14;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering";
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKommentar.Location = new System.Drawing.Point(9, 189);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(60, 13);
            this.lblKommentar.TabIndex = 15;
            this.lblKommentar.Text = "Kommentar";
            // 
            // tbKategori
            // 
            this.tbKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbKategori.Location = new System.Drawing.Point(110, 46);
            this.tbKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbKategori.Multiline = true;
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.ReadOnly = true;
            this.tbKategori.Size = new System.Drawing.Size(164, 20);
            this.tbKategori.TabIndex = 16;
            // 
            // tbDato_opprettet
            // 
            this.tbDato_opprettet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbDato_opprettet.Location = new System.Drawing.Point(110, 118);
            this.tbDato_opprettet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDato_opprettet.Multiline = true;
            this.tbDato_opprettet.Name = "tbDato_opprettet";
            this.tbDato_opprettet.ReadOnly = true;
            this.tbDato_opprettet.Size = new System.Drawing.Size(164, 20);
            this.tbDato_opprettet.TabIndex = 17;
            this.ttTimerMåling.SetToolTip(this.tbDato_opprettet, "mm/dd/yyyy");
            // 
            // tbOpprettetAvBruker
            // 
            this.tbOpprettetAvBruker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbOpprettetAvBruker.Location = new System.Drawing.Point(110, 142);
            this.tbOpprettetAvBruker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOpprettetAvBruker.Multiline = true;
            this.tbOpprettetAvBruker.Name = "tbOpprettetAvBruker";
            this.tbOpprettetAvBruker.ReadOnly = true;
            this.tbOpprettetAvBruker.Size = new System.Drawing.Size(164, 20);
            this.tbOpprettetAvBruker.TabIndex = 18;
            // 
            // tbSikkerhetsklarering
            // 
            this.tbSikkerhetsklarering.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbSikkerhetsklarering.Location = new System.Drawing.Point(110, 166);
            this.tbSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSikkerhetsklarering.Multiline = true;
            this.tbSikkerhetsklarering.Name = "tbSikkerhetsklarering";
            this.tbSikkerhetsklarering.ReadOnly = true;
            this.tbSikkerhetsklarering.Size = new System.Drawing.Size(164, 20);
            this.tbSikkerhetsklarering.TabIndex = 19;
            // 
            // tbKommentar
            // 
            this.tbKommentar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbKommentar.Location = new System.Drawing.Point(110, 189);
            this.tbKommentar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbKommentar.Multiline = true;
            this.tbKommentar.Name = "tbKommentar";
            this.tbKommentar.ReadOnly = true;
            this.tbKommentar.Size = new System.Drawing.Size(164, 62);
            this.tbKommentar.TabIndex = 20;
            // 
            // lbKategorierSkjult
            // 
            this.lbKategorierSkjult.FormattingEnabled = true;
            this.lbKategorierSkjult.Location = new System.Drawing.Point(14, 32);
            this.lbKategorierSkjult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbKategorierSkjult.Name = "lbKategorierSkjult";
            this.lbKategorierSkjult.Size = new System.Drawing.Size(85, 69);
            this.lbKategorierSkjult.Sorted = true;
            this.lbKategorierSkjult.TabIndex = 25;
            this.ttTimerMåling.SetToolTip(this.lbKategorierSkjult, "Dobbelklikk for å flytte over");
            this.lbKategorierSkjult.DoubleClick += new System.EventHandler(this.LbKategorierSkjult_DoubleClick);
            // 
            // lblKategorierSkjult
            // 
            this.lblKategorierSkjult.AutoSize = true;
            this.lblKategorierSkjult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorierSkjult.Location = new System.Drawing.Point(12, 16);
            this.lblKategorierSkjult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategorierSkjult.Name = "lblKategorierSkjult";
            this.lblKategorierSkjult.Size = new System.Drawing.Size(81, 13);
            this.lblKategorierSkjult.TabIndex = 26;
            this.lblKategorierSkjult.Text = "Skjul Kategorier";
            // 
            // lblKategorierVises
            // 
            this.lblKategorierVises.AutoSize = true;
            this.lblKategorierVises.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorierVises.Location = new System.Drawing.Point(190, 16);
            this.lblKategorierVises.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategorierVises.Name = "lblKategorierVises";
            this.lblKategorierVises.Size = new System.Drawing.Size(72, 13);
            this.lblKategorierVises.TabIndex = 28;
            this.lblKategorierVises.Text = "Vis Kategorier";
            // 
            // lbKategorierVises
            // 
            this.lbKategorierVises.FormattingEnabled = true;
            this.lbKategorierVises.Location = new System.Drawing.Point(192, 32);
            this.lbKategorierVises.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbKategorierVises.Name = "lbKategorierVises";
            this.lbKategorierVises.Size = new System.Drawing.Size(85, 69);
            this.lbKategorierVises.Sorted = true;
            this.lbKategorierVises.TabIndex = 27;
            this.ttTimerMåling.SetToolTip(this.lbKategorierVises, "Dobbelklikk for å flytte over");
            this.lbKategorierVises.DoubleClick += new System.EventHandler(this.LbKategorierVises_DoubleClick);
            // 
            // lbTagsSkjult
            // 
            this.lbTagsSkjult.FormattingEnabled = true;
            this.lbTagsSkjult.Location = new System.Drawing.Point(15, 120);
            this.lbTagsSkjult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbTagsSkjult.Name = "lbTagsSkjult";
            this.lbTagsSkjult.Size = new System.Drawing.Size(85, 69);
            this.lbTagsSkjult.Sorted = true;
            this.lbTagsSkjult.TabIndex = 25;
            this.ttTimerMåling.SetToolTip(this.lbTagsSkjult, "Dobbelklikk for å flytte over");
            this.lbTagsSkjult.DoubleClick += new System.EventHandler(this.LbTagsSkjult_DoubleClick);
            // 
            // lblTagsSkjult
            // 
            this.lblTagsSkjult.AutoSize = true;
            this.lblTagsSkjult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTagsSkjult.Location = new System.Drawing.Point(12, 105);
            this.lblTagsSkjult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTagsSkjult.Name = "lblTagsSkjult";
            this.lblTagsSkjult.Size = new System.Drawing.Size(60, 13);
            this.lblTagsSkjult.TabIndex = 26;
            this.lblTagsSkjult.Text = "Skjult Tags";
            // 
            // lbTagsVises
            // 
            this.lbTagsVises.FormattingEnabled = true;
            this.lbTagsVises.Location = new System.Drawing.Point(193, 120);
            this.lbTagsVises.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbTagsVises.Name = "lbTagsVises";
            this.lbTagsVises.Size = new System.Drawing.Size(85, 69);
            this.lbTagsVises.Sorted = true;
            this.lbTagsVises.TabIndex = 27;
            this.ttTimerMåling.SetToolTip(this.lbTagsVises, "Dobbelklikk for å flytte over");
            this.lbTagsVises.DoubleClick += new System.EventHandler(this.LbTagsVises_DoubleClick);
            // 
            // lblTagsVises
            // 
            this.lblTagsVises.AutoSize = true;
            this.lblTagsVises.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTagsVises.Location = new System.Drawing.Point(190, 105);
            this.lblTagsVises.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTagsVises.Name = "lblTagsVises";
            this.lblTagsVises.Size = new System.Drawing.Size(57, 13);
            this.lblTagsVises.TabIndex = 28;
            this.lblTagsVises.Text = "Viste Tags";
            // 
            // cbViseOmråde
            // 
            this.cbViseOmråde.AutoSize = true;
            this.cbViseOmråde.ForeColor = System.Drawing.SystemColors.Control;
            this.cbViseOmråde.Location = new System.Drawing.Point(15, 193);
            this.cbViseOmråde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbViseOmråde.Name = "cbViseOmråde";
            this.cbViseOmråde.Size = new System.Drawing.Size(93, 17);
            this.cbViseOmråde.TabIndex = 29;
            this.cbViseOmråde.Text = "Skjule område";
            this.ttTimerMåling.SetToolTip(this.cbViseOmråde, "Skjuler alle områder");
            this.cbViseOmråde.UseVisualStyleBackColor = true;
            this.cbViseOmråde.CheckedChanged += new System.EventHandler(this.CbViseOmråde_CheckedChanged);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cbAND);
            this.gbFilter.Controls.Add(this.cbOR);
            this.gbFilter.Controls.Add(this.btnTagFjernAlle);
            this.gbFilter.Controls.Add(this.btnKategoriFjernAlle);
            this.gbFilter.Controls.Add(this.btnTagLeggTilAlle);
            this.gbFilter.Controls.Add(this.btnKategoriLeggTilAlle);
            this.gbFilter.Controls.Add(this.cbViseOmråde);
            this.gbFilter.Controls.Add(this.lblTagsVises);
            this.gbFilter.Controls.Add(this.lblKategorierVises);
            this.gbFilter.Controls.Add(this.lbTagsVises);
            this.gbFilter.Controls.Add(this.lbKategorierVises);
            this.gbFilter.Controls.Add(this.lblTagsSkjult);
            this.gbFilter.Controls.Add(this.lblKategorierSkjult);
            this.gbFilter.Controls.Add(this.lbTagsSkjult);
            this.gbFilter.Controls.Add(this.lbKategorierSkjult);
            this.gbFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.gbFilter.Location = new System.Drawing.Point(7, 59);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFilter.Size = new System.Drawing.Size(290, 236);
            this.gbFilter.TabIndex = 30;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // cbAND
            // 
            this.cbAND.AutoSize = true;
            this.cbAND.Location = new System.Drawing.Point(192, 214);
            this.cbAND.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAND.Name = "cbAND";
            this.cbAND.Size = new System.Drawing.Size(49, 17);
            this.cbAND.TabIndex = 36;
            this.cbAND.Text = "AND";
            this.ttTimerMåling.SetToolTip(this.cbAND, "Alle tag(ene) må stemme for å visses\r\npå kartet \r\n");
            this.cbAND.UseVisualStyleBackColor = true;
            this.cbAND.CheckedChanged += new System.EventHandler(this.CbAND_CheckedChanged);
            // 
            // cbOR
            // 
            this.cbOR.AutoSize = true;
            this.cbOR.Checked = true;
            this.cbOR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOR.Location = new System.Drawing.Point(193, 193);
            this.cbOR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOR.Name = "cbOR";
            this.cbOR.Size = new System.Drawing.Size(42, 17);
            this.cbOR.TabIndex = 35;
            this.cbOR.Text = "OR";
            this.ttTimerMåling.SetToolTip(this.cbOR, "Kun en av tag(ene) trenger å stemme for å \r\nvisses på kartet");
            this.cbOR.UseVisualStyleBackColor = true;
            this.cbOR.CheckedChanged += new System.EventHandler(this.CbOR_CheckedChanged);
            // 
            // btnTagFjernAlle
            // 
            this.btnTagFjernAlle.ForeColor = System.Drawing.Color.Coral;
            this.btnTagFjernAlle.Image = global::GMAP_Demo.Properties.Resources.arrow_24px1;
            this.btnTagFjernAlle.Location = new System.Drawing.Point(116, 157);
            this.btnTagFjernAlle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTagFjernAlle.Name = "btnTagFjernAlle";
            this.btnTagFjernAlle.Size = new System.Drawing.Size(56, 24);
            this.btnTagFjernAlle.TabIndex = 34;
            this.ttTimerMåling.SetToolTip(this.btnTagFjernAlle, "Fjern alle");
            this.btnTagFjernAlle.UseVisualStyleBackColor = true;
            this.btnTagFjernAlle.Click += new System.EventHandler(this.BtnTagFjernAlle_Click);
            // 
            // btnKategoriFjernAlle
            // 
            this.btnKategoriFjernAlle.ForeColor = System.Drawing.Color.Crimson;
            this.btnKategoriFjernAlle.Image = global::GMAP_Demo.Properties.Resources.arrow_24px1;
            this.btnKategoriFjernAlle.Location = new System.Drawing.Point(116, 68);
            this.btnKategoriFjernAlle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKategoriFjernAlle.Name = "btnKategoriFjernAlle";
            this.btnKategoriFjernAlle.Size = new System.Drawing.Size(56, 24);
            this.btnKategoriFjernAlle.TabIndex = 32;
            this.ttTimerMåling.SetToolTip(this.btnKategoriFjernAlle, "Fjern alle");
            this.btnKategoriFjernAlle.UseVisualStyleBackColor = true;
            this.btnKategoriFjernAlle.Click += new System.EventHandler(this.BtnKategoriFjernAlle_Click);
            // 
            // btnTagLeggTilAlle
            // 
            this.btnTagLeggTilAlle.ForeColor = System.Drawing.Color.Coral;
            this.btnTagLeggTilAlle.Image = global::GMAP_Demo.Properties.Resources.arrow_24px;
            this.btnTagLeggTilAlle.Location = new System.Drawing.Point(116, 128);
            this.btnTagLeggTilAlle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTagLeggTilAlle.Name = "btnTagLeggTilAlle";
            this.btnTagLeggTilAlle.Size = new System.Drawing.Size(56, 24);
            this.btnTagLeggTilAlle.TabIndex = 33;
            this.ttTimerMåling.SetToolTip(this.btnTagLeggTilAlle, "Legg til alle");
            this.btnTagLeggTilAlle.UseVisualStyleBackColor = true;
            this.btnTagLeggTilAlle.Click += new System.EventHandler(this.BtnTagLeggTilAlle_Click);
            // 
            // btnKategoriLeggTilAlle
            // 
            this.btnKategoriLeggTilAlle.ForeColor = System.Drawing.Color.Coral;
            this.btnKategoriLeggTilAlle.Image = global::GMAP_Demo.Properties.Resources.arrow_24px;
            this.btnKategoriLeggTilAlle.Location = new System.Drawing.Point(116, 40);
            this.btnKategoriLeggTilAlle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKategoriLeggTilAlle.Name = "btnKategoriLeggTilAlle";
            this.btnKategoriLeggTilAlle.Size = new System.Drawing.Size(56, 24);
            this.btnKategoriLeggTilAlle.TabIndex = 31;
            this.ttTimerMåling.SetToolTip(this.btnKategoriLeggTilAlle, "Legg til alle ");
            this.btnKategoriLeggTilAlle.UseVisualStyleBackColor = true;
            this.btnKategoriLeggTilAlle.Click += new System.EventHandler(this.BtnKategoriLeggTilAlle_Click);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTag.Location = new System.Drawing.Point(9, 254);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(26, 13);
            this.lblTag.TabIndex = 31;
            this.lblTag.Text = "Tag";
            // 
            // lbTags
            // 
            this.lbTags.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbTags.FormattingEnabled = true;
            this.lbTags.Location = new System.Drawing.Point(110, 254);
            this.lbTags.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(164, 56);
            this.lbTags.Sorted = true;
            this.lbTags.TabIndex = 32;
            // 
            // tbMåling
            // 
            this.tbMåling.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbMåling.Location = new System.Drawing.Point(110, 94);
            this.tbMåling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMåling.Multiline = true;
            this.tbMåling.Name = "tbMåling";
            this.tbMåling.ReadOnly = true;
            this.tbMåling.Size = new System.Drawing.Size(84, 20);
            this.tbMåling.TabIndex = 34;
            // 
            // lblMåling
            // 
            this.lblMåling.AutoSize = true;
            this.lblMåling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMåling.Location = new System.Drawing.Point(9, 97);
            this.lblMåling.Name = "lblMåling";
            this.lblMåling.Size = new System.Drawing.Size(38, 13);
            this.lblMåling.TabIndex = 33;
            this.lblMåling.Text = "Måling";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tbEnhetMåling);
            this.gbInfo.Controls.Add(this.lblEnhetMåling);
            this.gbInfo.Controls.Add(this.lbMålingDato);
            this.gbInfo.Controls.Add(this.tbMålingDato);
            this.gbInfo.Controls.Add(this.tbMåling);
            this.gbInfo.Controls.Add(this.lblMåling);
            this.gbInfo.Controls.Add(this.lbTags);
            this.gbInfo.Controls.Add(this.lblTag);
            this.gbInfo.Controls.Add(this.tbKommentar);
            this.gbInfo.Controls.Add(this.tbSikkerhetsklarering);
            this.gbInfo.Controls.Add(this.tbOpprettetAvBruker);
            this.gbInfo.Controls.Add(this.tbDato_opprettet);
            this.gbInfo.Controls.Add(this.tbKategori);
            this.gbInfo.Controls.Add(this.lblKommentar);
            this.gbInfo.Controls.Add(this.lblSikkerhetsklarering);
            this.gbInfo.Controls.Add(this.lblOpprettetAvBruker);
            this.gbInfo.Controls.Add(this.lblDato_opprettet);
            this.gbInfo.Controls.Add(this.lblKategori);
            this.gbInfo.Controls.Add(this.lblNavn);
            this.gbInfo.Controls.Add(this.tbNavn);
            this.gbInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.gbInfo.Location = new System.Drawing.Point(7, 365);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInfo.Size = new System.Drawing.Size(290, 316);
            this.gbInfo.TabIndex = 35;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // tbEnhetMåling
            // 
            this.tbEnhetMåling.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbEnhetMåling.Location = new System.Drawing.Point(239, 94);
            this.tbEnhetMåling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEnhetMåling.Multiline = true;
            this.tbEnhetMåling.Name = "tbEnhetMåling";
            this.tbEnhetMåling.ReadOnly = true;
            this.tbEnhetMåling.Size = new System.Drawing.Size(34, 20);
            this.tbEnhetMåling.TabIndex = 39;
            // 
            // lblEnhetMåling
            // 
            this.lblEnhetMåling.AutoSize = true;
            this.lblEnhetMåling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnhetMåling.Location = new System.Drawing.Point(199, 97);
            this.lblEnhetMåling.Name = "lblEnhetMåling";
            this.lblEnhetMåling.Size = new System.Drawing.Size(35, 13);
            this.lblEnhetMåling.TabIndex = 38;
            this.lblEnhetMåling.Text = "Enhet";
            // 
            // lbMålingDato
            // 
            this.lbMålingDato.AutoSize = true;
            this.lbMålingDato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMålingDato.Location = new System.Drawing.Point(9, 73);
            this.lbMålingDato.Name = "lbMålingDato";
            this.lbMålingDato.Size = new System.Drawing.Size(65, 13);
            this.lbMålingDato.TabIndex = 35;
            this.lbMålingDato.Text = "Måling utført";
            // 
            // tbMålingDato
            // 
            this.tbMålingDato.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbMålingDato.Location = new System.Drawing.Point(110, 70);
            this.tbMålingDato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMålingDato.Multiline = true;
            this.tbMålingDato.Name = "tbMålingDato";
            this.tbMålingDato.ReadOnly = true;
            this.tbMålingDato.Size = new System.Drawing.Size(163, 20);
            this.tbMålingDato.TabIndex = 34;
            this.ttTimerMåling.SetToolTip(this.tbMålingDato, "mm/dd/yyyy");
            // 
            // btnTimerMåling
            // 
            this.btnTimerMåling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerMåling.ForeColor = System.Drawing.Color.Black;
            this.btnTimerMåling.Location = new System.Drawing.Point(7, 685);
            this.btnTimerMåling.Name = "btnTimerMåling";
            this.btnTimerMåling.Size = new System.Drawing.Size(291, 19);
            this.btnTimerMåling.TabIndex = 38;
            this.btnTimerMåling.Text = "Simulering av målinger inaktiv";
            this.ttTimerMåling.SetToolTip(this.btnTimerMåling, resources.GetString("btnTimerMåling.ToolTip"));
            this.btnTimerMåling.UseVisualStyleBackColor = true;
            this.btnTimerMåling.Click += new System.EventHandler(this.BtnTimerMåling_Click);
            // 
            // btnNesteRessurs
            // 
            this.btnNesteRessurs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNesteRessurs.Image = global::GMAP_Demo.Properties.Resources.arrow_24px;
            this.btnNesteRessurs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNesteRessurs.Location = new System.Drawing.Point(192, 30);
            this.btnNesteRessurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNesteRessurs.Name = "btnNesteRessurs";
            this.btnNesteRessurs.Size = new System.Drawing.Size(82, 28);
            this.btnNesteRessurs.TabIndex = 37;
            this.btnNesteRessurs.Text = "Til Neste";
            this.btnNesteRessurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNesteRessurs.UseVisualStyleBackColor = true;
            this.btnNesteRessurs.Click += new System.EventHandler(this.BtnNesteRessurs_Click);
            // 
            // btnForrigeRessurs
            // 
            this.btnForrigeRessurs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnForrigeRessurs.Image = global::GMAP_Demo.Properties.Resources.arrow_24px1;
            this.btnForrigeRessurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForrigeRessurs.Location = new System.Drawing.Point(8, 30);
            this.btnForrigeRessurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnForrigeRessurs.Name = "btnForrigeRessurs";
            this.btnForrigeRessurs.Size = new System.Drawing.Size(82, 28);
            this.btnForrigeRessurs.TabIndex = 36;
            this.btnForrigeRessurs.Text = "Til Forrige";
            this.btnForrigeRessurs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForrigeRessurs.UseVisualStyleBackColor = true;
            this.btnForrigeRessurs.Click += new System.EventHandler(this.BtnForrigeRessurs_Click);
            // 
            // gbObjekt
            // 
            this.gbObjekt.Controls.Add(this.tbAntallObjekter);
            this.gbObjekt.Controls.Add(this.lblObjektAntall);
            this.gbObjekt.Controls.Add(this.lblHoppTilEtOmråde);
            this.gbObjekt.Controls.Add(this.btnNesteRessurs);
            this.gbObjekt.Controls.Add(this.btnForrigeRessurs);
            this.gbObjekt.ForeColor = System.Drawing.SystemColors.Control;
            this.gbObjekt.Location = new System.Drawing.Point(7, 299);
            this.gbObjekt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbObjekt.Name = "gbObjekt";
            this.gbObjekt.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbObjekt.Size = new System.Drawing.Size(290, 62);
            this.gbObjekt.TabIndex = 39;
            this.gbObjekt.TabStop = false;
            this.gbObjekt.Text = "Objekt";
            // 
            // tbAntallObjekter
            // 
            this.tbAntallObjekter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbAntallObjekter.Location = new System.Drawing.Point(142, 35);
            this.tbAntallObjekter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAntallObjekter.Name = "tbAntallObjekter";
            this.tbAntallObjekter.ReadOnly = true;
            this.tbAntallObjekter.Size = new System.Drawing.Size(22, 20);
            this.tbAntallObjekter.TabIndex = 54;
            this.tbAntallObjekter.Text = "0";
            this.ttTimerMåling.SetToolTip(this.tbAntallObjekter, "Antall objekter som er synlig");
            // 
            // lblObjektAntall
            // 
            this.lblObjektAntall.AutoSize = true;
            this.lblObjektAntall.Location = new System.Drawing.Point(107, 38);
            this.lblObjektAntall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObjektAntall.Name = "lblObjektAntall";
            this.lblObjektAntall.Size = new System.Drawing.Size(33, 13);
            this.lblObjektAntall.TabIndex = 37;
            this.lblObjektAntall.Text = "Antall";
            // 
            // lblHoppTilEtOmråde
            // 
            this.lblHoppTilEtOmråde.AutoSize = true;
            this.lblHoppTilEtOmråde.Location = new System.Drawing.Point(4, 15);
            this.lblHoppTilEtOmråde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoppTilEtOmråde.Name = "lblHoppTilEtOmråde";
            this.lblHoppTilEtOmråde.Size = new System.Drawing.Size(201, 13);
            this.lblHoppTilEtOmråde.TabIndex = 38;
            this.lblHoppTilEtOmråde.Text = "Hopp til et objekt med hjelp av knappene";
            // 
            // Frm_V_Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(306, 708);
            this.Controls.Add(this.gbObjekt);
            this.Controls.Add(this.btnTimerMåling);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_V_Filter";
            this.Text = "frmFilter";
            this.Load += new System.EventHandler(this.FrmFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbObjekt.ResumeLayout(false);
            this.gbObjekt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbNavn;
        private System.Windows.Forms.Label lblNavn;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblDato_opprettet;
        private System.Windows.Forms.Label lblOpprettetAvBruker;
        private System.Windows.Forms.Label lblSikkerhetsklarering;
        private System.Windows.Forms.Label lblKommentar;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.TextBox tbDato_opprettet;
        private System.Windows.Forms.TextBox tbOpprettetAvBruker;
        private System.Windows.Forms.TextBox tbSikkerhetsklarering;
        private System.Windows.Forms.TextBox tbKommentar;
        private System.Windows.Forms.ListBox lbKategorierSkjult;
        private System.Windows.Forms.Label lblKategorierSkjult;
        private System.Windows.Forms.Label lblKategorierVises;
        private System.Windows.Forms.ListBox lbKategorierVises;
        private System.Windows.Forms.ListBox lbTagsSkjult;
        private System.Windows.Forms.Label lblTagsSkjult;
        private System.Windows.Forms.ListBox lbTagsVises;
        private System.Windows.Forms.Label lblTagsVises;
        private System.Windows.Forms.CheckBox cbViseOmråde;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnTagFjernAlle;
        private System.Windows.Forms.Button btnKategoriFjernAlle;
        private System.Windows.Forms.Button btnTagLeggTilAlle;
        private System.Windows.Forms.Button btnKategoriLeggTilAlle;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.TextBox tbMåling;
        private System.Windows.Forms.Label lblMåling;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnForrigeRessurs;
        private System.Windows.Forms.Button btnNesteRessurs;
        private System.Windows.Forms.CheckBox cbAND;
        private System.Windows.Forms.CheckBox cbOR;
        public System.Windows.Forms.TextBox tbEnhetMåling;
        private System.Windows.Forms.Label lblEnhetMåling;
        private System.Windows.Forms.Label lbMålingDato;
        public System.Windows.Forms.TextBox tbMålingDato;
        private System.Windows.Forms.Button btnTimerMåling;
        private System.Windows.Forms.GroupBox gbObjekt;
        private System.Windows.Forms.Label lblHoppTilEtOmråde;
        private System.Windows.Forms.ToolTip ttTimerMåling;
        private System.Windows.Forms.Label lblObjektAntall;
        private System.Windows.Forms.TextBox tbAntallObjekter;
    }
}