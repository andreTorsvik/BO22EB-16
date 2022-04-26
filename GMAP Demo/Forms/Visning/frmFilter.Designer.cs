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
            this.lbKategorierSkjult = new System.Windows.Forms.ListBox();
            this.lblKategorierSkjult = new System.Windows.Forms.Label();
            this.lblKategorierVises = new System.Windows.Forms.Label();
            this.lbKategorierVises = new System.Windows.Forms.ListBox();
            this.lbTagsSkjult = new System.Windows.Forms.ListBox();
            this.lblTagsSkjult = new System.Windows.Forms.Label();
            this.lbTagsVises = new System.Windows.Forms.ListBox();
            this.lblTagsVises = new System.Windows.Forms.Label();
            this.cbViseOmråde = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAND = new System.Windows.Forms.CheckBox();
            this.cbOR = new System.Windows.Forms.CheckBox();
            this.btnTagFjernAlle = new System.Windows.Forms.Button();
            this.btnKategoriFjernAlle = new System.Windows.Forms.Button();
            this.btnTagLeggTilAlle = new System.Windows.Forms.Button();
            this.btnKategoriLeggTilAlle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.txtMåling = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNesteRessurs = new System.Windows.Forms.Button();
            this.btnForrigeRessurs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // txtNavn
            // 
            this.txtNavn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNavn.Location = new System.Drawing.Point(146, 28);
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
            this.lblNavn.Location = new System.Drawing.Point(12, 32);
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
            this.lblKategori.Location = new System.Drawing.Point(12, 61);
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
            this.lblDato_opprettet.Location = new System.Drawing.Point(12, 119);
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
            this.lblOpprettetAvBruker.Location = new System.Drawing.Point(12, 148);
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
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(12, 177);
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
            this.lblKommentar.Location = new System.Drawing.Point(12, 202);
            this.lblKommentar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(75, 16);
            this.lblKommentar.TabIndex = 15;
            this.lblKommentar.Text = "Kommentar";
            // 
            // txtKategori
            // 
            this.txtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKategori.Location = new System.Drawing.Point(146, 57);
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
            this.txtDato_opprettet.Location = new System.Drawing.Point(146, 115);
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
            this.txtOpprettetAvBruker.Location = new System.Drawing.Point(146, 144);
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
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(146, 173);
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
            this.txtKommentar.Location = new System.Drawing.Point(146, 202);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKommentar.Multiline = true;
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.ReadOnly = true;
            this.txtKommentar.Size = new System.Drawing.Size(217, 75);
            this.txtKommentar.TabIndex = 20;
            // 
            // lbKategorierSkjult
            // 
            this.lbKategorierSkjult.FormattingEnabled = true;
            this.lbKategorierSkjult.ItemHeight = 16;
            this.lbKategorierSkjult.Location = new System.Drawing.Point(19, 39);
            this.lbKategorierSkjult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbKategorierSkjult.Name = "lbKategorierSkjult";
            this.lbKategorierSkjult.Size = new System.Drawing.Size(112, 84);
            this.lbKategorierSkjult.Sorted = true;
            this.lbKategorierSkjult.TabIndex = 25;
            this.lbKategorierSkjult.DoubleClick += new System.EventHandler(this.lbKategorierSkjult_DoubleClick);
            // 
            // lblKategorierSkjult
            // 
            this.lblKategorierSkjult.AutoSize = true;
            this.lblKategorierSkjult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorierSkjult.Location = new System.Drawing.Point(15, 20);
            this.lblKategorierSkjult.Name = "lblKategorierSkjult";
            this.lblKategorierSkjult.Size = new System.Drawing.Size(36, 16);
            this.lblKategorierSkjult.TabIndex = 26;
            this.lblKategorierSkjult.Text = "Skjul";
            // 
            // lblKategorierVises
            // 
            this.lblKategorierVises.AutoSize = true;
            this.lblKategorierVises.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorierVises.Location = new System.Drawing.Point(253, 20);
            this.lblKategorierVises.Name = "lblKategorierVises";
            this.lblKategorierVises.Size = new System.Drawing.Size(26, 16);
            this.lblKategorierVises.TabIndex = 28;
            this.lblKategorierVises.Text = "Vis";
            // 
            // lbKategorierVises
            // 
            this.lbKategorierVises.FormattingEnabled = true;
            this.lbKategorierVises.ItemHeight = 16;
            this.lbKategorierVises.Location = new System.Drawing.Point(256, 39);
            this.lbKategorierVises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbKategorierVises.Name = "lbKategorierVises";
            this.lbKategorierVises.Size = new System.Drawing.Size(112, 84);
            this.lbKategorierVises.Sorted = true;
            this.lbKategorierVises.TabIndex = 27;
            this.lbKategorierVises.DoubleClick += new System.EventHandler(this.lbKategorierVises_DoubleClick);
            // 
            // lbTagsSkjult
            // 
            this.lbTagsSkjult.FormattingEnabled = true;
            this.lbTagsSkjult.ItemHeight = 16;
            this.lbTagsSkjult.Location = new System.Drawing.Point(20, 148);
            this.lbTagsSkjult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTagsSkjult.Name = "lbTagsSkjult";
            this.lbTagsSkjult.Size = new System.Drawing.Size(112, 84);
            this.lbTagsSkjult.Sorted = true;
            this.lbTagsSkjult.TabIndex = 25;
            this.lbTagsSkjult.DoubleClick += new System.EventHandler(this.lbTagsSkjult_DoubleClick);
            // 
            // lblTagsSkjult
            // 
            this.lblTagsSkjult.AutoSize = true;
            this.lblTagsSkjult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTagsSkjult.Location = new System.Drawing.Point(16, 129);
            this.lblTagsSkjult.Name = "lblTagsSkjult";
            this.lblTagsSkjult.Size = new System.Drawing.Size(36, 16);
            this.lblTagsSkjult.TabIndex = 26;
            this.lblTagsSkjult.Text = "Skjul";
            // 
            // lbTagsVises
            // 
            this.lbTagsVises.FormattingEnabled = true;
            this.lbTagsVises.ItemHeight = 16;
            this.lbTagsVises.Location = new System.Drawing.Point(257, 148);
            this.lbTagsVises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTagsVises.Name = "lbTagsVises";
            this.lbTagsVises.Size = new System.Drawing.Size(112, 84);
            this.lbTagsVises.Sorted = true;
            this.lbTagsVises.TabIndex = 27;
            this.lbTagsVises.DoubleClick += new System.EventHandler(this.lbTagsVises_DoubleClick);
            // 
            // lblTagsVises
            // 
            this.lblTagsVises.AutoSize = true;
            this.lblTagsVises.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTagsVises.Location = new System.Drawing.Point(254, 129);
            this.lblTagsVises.Name = "lblTagsVises";
            this.lblTagsVises.Size = new System.Drawing.Size(26, 16);
            this.lblTagsVises.TabIndex = 28;
            this.lblTagsVises.Text = "Vis";
            // 
            // cbViseOmråde
            // 
            this.cbViseOmråde.AutoSize = true;
            this.cbViseOmråde.ForeColor = System.Drawing.SystemColors.Control;
            this.cbViseOmråde.Location = new System.Drawing.Point(20, 252);
            this.cbViseOmråde.Name = "cbViseOmråde";
            this.cbViseOmråde.Size = new System.Drawing.Size(116, 20);
            this.cbViseOmråde.TabIndex = 29;
            this.cbViseOmråde.Text = "Skjule område";
            this.cbViseOmråde.UseVisualStyleBackColor = true;
            this.cbViseOmråde.CheckedChanged += new System.EventHandler(this.cbViseOmråde_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAND);
            this.groupBox1.Controls.Add(this.cbOR);
            this.groupBox1.Controls.Add(this.btnTagFjernAlle);
            this.groupBox1.Controls.Add(this.btnKategoriFjernAlle);
            this.groupBox1.Controls.Add(this.btnTagLeggTilAlle);
            this.groupBox1.Controls.Add(this.btnKategoriLeggTilAlle);
            this.groupBox1.Controls.Add(this.cbViseOmråde);
            this.groupBox1.Controls.Add(this.lblTagsVises);
            this.groupBox1.Controls.Add(this.lblKategorierVises);
            this.groupBox1.Controls.Add(this.lbTagsVises);
            this.groupBox1.Controls.Add(this.lbKategorierVises);
            this.groupBox1.Controls.Add(this.lblTagsSkjult);
            this.groupBox1.Controls.Add(this.lblKategorierSkjult);
            this.groupBox1.Controls.Add(this.lbTagsSkjult);
            this.groupBox1.Controls.Add(this.lbKategorierSkjult);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(9, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 291);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cbAND
            // 
            this.cbAND.AutoSize = true;
            this.cbAND.Location = new System.Drawing.Point(256, 263);
            this.cbAND.Name = "cbAND";
            this.cbAND.Size = new System.Drawing.Size(58, 20);
            this.cbAND.TabIndex = 36;
            this.cbAND.Text = "AND";
            this.cbAND.UseVisualStyleBackColor = true;
            this.cbAND.CheckedChanged += new System.EventHandler(this.cbAND_CheckedChanged);
            // 
            // cbOR
            // 
            this.cbOR.AutoSize = true;
            this.cbOR.Location = new System.Drawing.Point(257, 237);
            this.cbOR.Name = "cbOR";
            this.cbOR.Size = new System.Drawing.Size(49, 20);
            this.cbOR.TabIndex = 35;
            this.cbOR.Text = "OR";
            this.cbOR.UseVisualStyleBackColor = true;
            this.cbOR.CheckedChanged += new System.EventHandler(this.cbOR_CheckedChanged);
            // 
            // btnTagFjernAlle
            // 
            this.btnTagFjernAlle.ForeColor = System.Drawing.Color.Coral;
            this.btnTagFjernAlle.Image = global::GMAP_Demo.Properties.Resources.arrow_24px1;
            this.btnTagFjernAlle.Location = new System.Drawing.Point(155, 193);
            this.btnTagFjernAlle.Name = "btnTagFjernAlle";
            this.btnTagFjernAlle.Size = new System.Drawing.Size(75, 29);
            this.btnTagFjernAlle.TabIndex = 34;
            this.btnTagFjernAlle.UseVisualStyleBackColor = true;
            this.btnTagFjernAlle.Click += new System.EventHandler(this.btnTagFjernAlle_Click);
            // 
            // btnKategoriFjernAlle
            // 
            this.btnKategoriFjernAlle.ForeColor = System.Drawing.Color.Crimson;
            this.btnKategoriFjernAlle.Image = global::GMAP_Demo.Properties.Resources.arrow_24px1;
            this.btnKategoriFjernAlle.Location = new System.Drawing.Point(155, 84);
            this.btnKategoriFjernAlle.Name = "btnKategoriFjernAlle";
            this.btnKategoriFjernAlle.Size = new System.Drawing.Size(75, 29);
            this.btnKategoriFjernAlle.TabIndex = 32;
            this.btnKategoriFjernAlle.UseVisualStyleBackColor = true;
            this.btnKategoriFjernAlle.Click += new System.EventHandler(this.btnKategoriFjernAlle_Click);
            // 
            // btnTagLeggTilAlle
            // 
            this.btnTagLeggTilAlle.ForeColor = System.Drawing.Color.Coral;
            this.btnTagLeggTilAlle.Image = global::GMAP_Demo.Properties.Resources.arrow_24px;
            this.btnTagLeggTilAlle.Location = new System.Drawing.Point(155, 158);
            this.btnTagLeggTilAlle.Name = "btnTagLeggTilAlle";
            this.btnTagLeggTilAlle.Size = new System.Drawing.Size(75, 29);
            this.btnTagLeggTilAlle.TabIndex = 33;
            this.btnTagLeggTilAlle.UseVisualStyleBackColor = true;
            this.btnTagLeggTilAlle.Click += new System.EventHandler(this.btnTagLeggTilAlle_Click);
            // 
            // btnKategoriLeggTilAlle
            // 
            this.btnKategoriLeggTilAlle.ForeColor = System.Drawing.Color.Coral;
            this.btnKategoriLeggTilAlle.Image = global::GMAP_Demo.Properties.Resources.arrow_24px;
            this.btnKategoriLeggTilAlle.Location = new System.Drawing.Point(155, 49);
            this.btnKategoriLeggTilAlle.Name = "btnKategoriLeggTilAlle";
            this.btnKategoriLeggTilAlle.Size = new System.Drawing.Size(75, 29);
            this.btnKategoriLeggTilAlle.TabIndex = 31;
            this.btnKategoriLeggTilAlle.UseVisualStyleBackColor = true;
            this.btnKategoriLeggTilAlle.Click += new System.EventHandler(this.btnKategoriLeggTilAlle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tag";
            // 
            // lbTags
            // 
            this.lbTags.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 16;
            this.lbTags.Location = new System.Drawing.Point(146, 282);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(217, 68);
            this.lbTags.Sorted = true;
            this.lbTags.TabIndex = 32;
            // 
            // txtMåling
            // 
            this.txtMåling.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtMåling.Location = new System.Drawing.Point(146, 86);
            this.txtMåling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMåling.Multiline = true;
            this.txtMåling.Name = "txtMåling";
            this.txtMåling.ReadOnly = true;
            this.txtMåling.Size = new System.Drawing.Size(217, 24);
            this.txtMåling.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Måling";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMåling);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbTags);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtKommentar);
            this.groupBox2.Controls.Add(this.txtSikkerhetsklarering);
            this.groupBox2.Controls.Add(this.txtOpprettetAvBruker);
            this.groupBox2.Controls.Add(this.txtDato_opprettet);
            this.groupBox2.Controls.Add(this.txtKategori);
            this.groupBox2.Controls.Add(this.lblKommentar);
            this.groupBox2.Controls.Add(this.lblSikkerhetsklarering);
            this.groupBox2.Controls.Add(this.lblOpprettetAvBruker);
            this.groupBox2.Controls.Add(this.lblDato_opprettet);
            this.groupBox2.Controls.Add(this.lblKategori);
            this.groupBox2.Controls.Add(this.lblNavn);
            this.groupBox2.Controls.Add(this.txtNavn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(9, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 377);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // btnNesteRessurs
            // 
            this.btnNesteRessurs.Image = global::GMAP_Demo.Properties.Resources.arrow_24px;
            this.btnNesteRessurs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNesteRessurs.Location = new System.Drawing.Point(262, 387);
            this.btnNesteRessurs.Name = "btnNesteRessurs";
            this.btnNesteRessurs.Size = new System.Drawing.Size(110, 35);
            this.btnNesteRessurs.TabIndex = 37;
            this.btnNesteRessurs.Text = "Til Neste";
            this.btnNesteRessurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNesteRessurs.UseVisualStyleBackColor = true;
            this.btnNesteRessurs.Click += new System.EventHandler(this.btnNesteRessurs_Click);
            // 
            // btnForrigeRessurs
            // 
            this.btnForrigeRessurs.Image = global::GMAP_Demo.Properties.Resources.arrow_24px1;
            this.btnForrigeRessurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForrigeRessurs.Location = new System.Drawing.Point(33, 387);
            this.btnForrigeRessurs.Name = "btnForrigeRessurs";
            this.btnForrigeRessurs.Size = new System.Drawing.Size(110, 35);
            this.btnForrigeRessurs.TabIndex = 36;
            this.btnForrigeRessurs.Text = "Til Forrige";
            this.btnForrigeRessurs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForrigeRessurs.UseVisualStyleBackColor = true;
            this.btnForrigeRessurs.Click += new System.EventHandler(this.btnForrigeRessurs_Click);
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(408, 871);
            this.Controls.Add(this.btnNesteRessurs);
            this.Controls.Add(this.btnForrigeRessurs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFilter";
            this.Text = "frmFilter";
            this.Load += new System.EventHandler(this.frmFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.ListBox lbKategorierSkjult;
        private System.Windows.Forms.Label lblKategorierSkjult;
        private System.Windows.Forms.Label lblKategorierVises;
        private System.Windows.Forms.ListBox lbKategorierVises;
        public System.Windows.Forms.ListBox lbTagsSkjult;
        public System.Windows.Forms.Label lblTagsSkjult;
        public System.Windows.Forms.ListBox lbTagsVises;
        public System.Windows.Forms.Label lblTagsVises;
        private System.Windows.Forms.CheckBox cbViseOmråde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTagFjernAlle;
        private System.Windows.Forms.Button btnKategoriFjernAlle;
        private System.Windows.Forms.Button btnTagLeggTilAlle;
        private System.Windows.Forms.Button btnKategoriLeggTilAlle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lbTags;
        public System.Windows.Forms.TextBox txtMåling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnForrigeRessurs;
        private System.Windows.Forms.Button btnNesteRessurs;
        private System.Windows.Forms.CheckBox cbAND;
        private System.Windows.Forms.CheckBox cbOR;
    }
}