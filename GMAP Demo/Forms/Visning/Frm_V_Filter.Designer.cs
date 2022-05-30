namespace BO22EB16
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
            this.btnNesteObjekt = new System.Windows.Forms.Button();
            this.btnForrigeObjekt = new System.Windows.Forms.Button();
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
            this.lblTitle.Location = new System.Drawing.Point(14, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 55);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Filter";
            // 
            // tbNavn
            // 
            this.tbNavn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbNavn.Location = new System.Drawing.Point(165, 35);
            this.tbNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNavn.Multiline = true;
            this.tbNavn.Name = "tbNavn";
            this.tbNavn.ReadOnly = true;
            this.tbNavn.Size = new System.Drawing.Size(244, 29);
            this.tbNavn.TabIndex = 9;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNavn.Location = new System.Drawing.Point(14, 40);
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
            this.lblKategori.Location = new System.Drawing.Point(14, 78);
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
            this.lblDato_opprettet.Location = new System.Drawing.Point(14, 188);
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
            this.lblOpprettetAvBruker.Location = new System.Drawing.Point(14, 222);
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
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(14, 260);
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
            this.lblKommentar.Location = new System.Drawing.Point(14, 291);
            this.lblKommentar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(91, 20);
            this.lblKommentar.TabIndex = 15;
            this.lblKommentar.Text = "Kommentar";
            // 
            // tbKategori
            // 
            this.tbKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbKategori.Location = new System.Drawing.Point(165, 71);
            this.tbKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKategori.Multiline = true;
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.ReadOnly = true;
            this.tbKategori.Size = new System.Drawing.Size(244, 29);
            this.tbKategori.TabIndex = 16;
            // 
            // tbDato_opprettet
            // 
            this.tbDato_opprettet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbDato_opprettet.Location = new System.Drawing.Point(165, 181);
            this.tbDato_opprettet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDato_opprettet.Multiline = true;
            this.tbDato_opprettet.Name = "tbDato_opprettet";
            this.tbDato_opprettet.ReadOnly = true;
            this.tbDato_opprettet.Size = new System.Drawing.Size(244, 29);
            this.tbDato_opprettet.TabIndex = 17;
            this.ttTimerMåling.SetToolTip(this.tbDato_opprettet, "mm/dd/yyyy");
            // 
            // tbOpprettetAvBruker
            // 
            this.tbOpprettetAvBruker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbOpprettetAvBruker.Location = new System.Drawing.Point(165, 219);
            this.tbOpprettetAvBruker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOpprettetAvBruker.Multiline = true;
            this.tbOpprettetAvBruker.Name = "tbOpprettetAvBruker";
            this.tbOpprettetAvBruker.ReadOnly = true;
            this.tbOpprettetAvBruker.Size = new System.Drawing.Size(244, 29);
            this.tbOpprettetAvBruker.TabIndex = 18;
            // 
            // tbSikkerhetsklarering
            // 
            this.tbSikkerhetsklarering.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbSikkerhetsklarering.Location = new System.Drawing.Point(165, 255);
            this.tbSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSikkerhetsklarering.Multiline = true;
            this.tbSikkerhetsklarering.Name = "tbSikkerhetsklarering";
            this.tbSikkerhetsklarering.ReadOnly = true;
            this.tbSikkerhetsklarering.Size = new System.Drawing.Size(244, 29);
            this.tbSikkerhetsklarering.TabIndex = 19;
            // 
            // tbKommentar
            // 
            this.tbKommentar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbKommentar.Location = new System.Drawing.Point(165, 291);
            this.tbKommentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKommentar.Multiline = true;
            this.tbKommentar.Name = "tbKommentar";
            this.tbKommentar.ReadOnly = true;
            this.tbKommentar.Size = new System.Drawing.Size(244, 93);
            this.tbKommentar.TabIndex = 20;
            // 
            // lbKategorierSkjult
            // 
            this.lbKategorierSkjult.FormattingEnabled = true;
            this.lbKategorierSkjult.ItemHeight = 20;
            this.lbKategorierSkjult.Location = new System.Drawing.Point(21, 49);
            this.lbKategorierSkjult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbKategorierSkjult.Name = "lbKategorierSkjult";
            this.lbKategorierSkjult.Size = new System.Drawing.Size(126, 104);
            this.lbKategorierSkjult.Sorted = true;
            this.lbKategorierSkjult.TabIndex = 25;
            this.ttTimerMåling.SetToolTip(this.lbKategorierSkjult, "Dobbelklikk for å flytte over");
            this.lbKategorierSkjult.DoubleClick += new System.EventHandler(this.LbKategorierSkjult_DoubleClick);
            // 
            // lblKategorierSkjult
            // 
            this.lblKategorierSkjult.AutoSize = true;
            this.lblKategorierSkjult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorierSkjult.Location = new System.Drawing.Point(18, 25);
            this.lblKategorierSkjult.Name = "lblKategorierSkjult";
            this.lblKategorierSkjult.Size = new System.Drawing.Size(132, 20);
            this.lblKategorierSkjult.TabIndex = 26;
            this.lblKategorierSkjult.Text = "Skjulte kategorier";
            // 
            // lblKategorierVises
            // 
            this.lblKategorierVises.AutoSize = true;
            this.lblKategorierVises.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategorierVises.Location = new System.Drawing.Point(285, 25);
            this.lblKategorierVises.Name = "lblKategorierVises";
            this.lblKategorierVises.Size = new System.Drawing.Size(135, 20);
            this.lblKategorierVises.TabIndex = 28;
            this.lblKategorierVises.Text = "Synlige kategorier";
            // 
            // lbKategorierVises
            // 
            this.lbKategorierVises.FormattingEnabled = true;
            this.lbKategorierVises.ItemHeight = 20;
            this.lbKategorierVises.Location = new System.Drawing.Point(288, 49);
            this.lbKategorierVises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbKategorierVises.Name = "lbKategorierVises";
            this.lbKategorierVises.Size = new System.Drawing.Size(126, 104);
            this.lbKategorierVises.Sorted = true;
            this.lbKategorierVises.TabIndex = 27;
            this.ttTimerMåling.SetToolTip(this.lbKategorierVises, "Dobbelklikk for å flytte over");
            this.lbKategorierVises.DoubleClick += new System.EventHandler(this.LbKategorierVises_DoubleClick);
            // 
            // lbTagsSkjult
            // 
            this.lbTagsSkjult.FormattingEnabled = true;
            this.lbTagsSkjult.ItemHeight = 20;
            this.lbTagsSkjult.Location = new System.Drawing.Point(22, 185);
            this.lbTagsSkjult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTagsSkjult.Name = "lbTagsSkjult";
            this.lbTagsSkjult.Size = new System.Drawing.Size(126, 104);
            this.lbTagsSkjult.Sorted = true;
            this.lbTagsSkjult.TabIndex = 25;
            this.ttTimerMåling.SetToolTip(this.lbTagsSkjult, "Dobbelklikk for å flytte over");
            this.lbTagsSkjult.DoubleClick += new System.EventHandler(this.LbTagsSkjult_DoubleClick);
            // 
            // lblTagsSkjult
            // 
            this.lblTagsSkjult.AutoSize = true;
            this.lblTagsSkjult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTagsSkjult.Location = new System.Drawing.Point(18, 161);
            this.lblTagsSkjult.Name = "lblTagsSkjult";
            this.lblTagsSkjult.Size = new System.Drawing.Size(92, 20);
            this.lblTagsSkjult.TabIndex = 26;
            this.lblTagsSkjult.Text = "Skjulte tags";
            // 
            // lbTagsVises
            // 
            this.lbTagsVises.FormattingEnabled = true;
            this.lbTagsVises.ItemHeight = 20;
            this.lbTagsVises.Location = new System.Drawing.Point(289, 185);
            this.lbTagsVises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTagsVises.Name = "lbTagsVises";
            this.lbTagsVises.Size = new System.Drawing.Size(126, 104);
            this.lbTagsVises.Sorted = true;
            this.lbTagsVises.TabIndex = 27;
            this.ttTimerMåling.SetToolTip(this.lbTagsVises, "Dobbelklikk for å flytte over");
            this.lbTagsVises.DoubleClick += new System.EventHandler(this.LbTagsVises_DoubleClick);
            // 
            // lblTagsVises
            // 
            this.lblTagsVises.AutoSize = true;
            this.lblTagsVises.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTagsVises.Location = new System.Drawing.Point(285, 161);
            this.lblTagsVises.Name = "lblTagsVises";
            this.lblTagsVises.Size = new System.Drawing.Size(95, 20);
            this.lblTagsVises.TabIndex = 28;
            this.lblTagsVises.Text = "Synlige tags";
            // 
            // cbViseOmråde
            // 
            this.cbViseOmråde.AutoSize = true;
            this.cbViseOmråde.ForeColor = System.Drawing.SystemColors.Control;
            this.cbViseOmråde.Location = new System.Drawing.Point(22, 298);
            this.cbViseOmråde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbViseOmråde.Name = "cbViseOmråde";
            this.cbViseOmråde.Size = new System.Drawing.Size(136, 24);
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
            this.gbFilter.Location = new System.Drawing.Point(10, 91);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilter.Size = new System.Drawing.Size(435, 362);
            this.gbFilter.TabIndex = 30;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // cbAND
            // 
            this.cbAND.AutoSize = true;
            this.cbAND.Location = new System.Drawing.Point(288, 329);
            this.cbAND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAND.Name = "cbAND";
            this.cbAND.Size = new System.Drawing.Size(69, 24);
            this.cbAND.TabIndex = 36;
            this.cbAND.Text = "AND";
            this.ttTimerMåling.SetToolTip(this.cbAND, "Alle tag(ene) må være identiske for å vises\r\npå kartet \r\n");
            this.cbAND.UseVisualStyleBackColor = true;
            this.cbAND.CheckedChanged += new System.EventHandler(this.CbAND_CheckedChanged);
            // 
            // cbOR
            // 
            this.cbOR.AutoSize = true;
            this.cbOR.Checked = true;
            this.cbOR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOR.Location = new System.Drawing.Point(289, 298);
            this.cbOR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOR.Name = "cbOR";
            this.cbOR.Size = new System.Drawing.Size(59, 24);
            this.cbOR.TabIndex = 35;
            this.cbOR.Text = "OR";
            this.ttTimerMåling.SetToolTip(this.cbOR, "Kun en av tag(ene) trenger å være like for å \r\nvises på kartet");
            this.cbOR.UseVisualStyleBackColor = true;
            this.cbOR.CheckedChanged += new System.EventHandler(this.CbOR_CheckedChanged);
            // 
            // btnTagFjernAlle
            // 
            this.btnTagFjernAlle.ForeColor = System.Drawing.Color.Coral;
            this.btnTagFjernAlle.Image = global::BO22EB16.Properties.Resources.arrow_24px1;
            this.btnTagFjernAlle.Location = new System.Drawing.Point(174, 241);
            this.btnTagFjernAlle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTagFjernAlle.Name = "btnTagFjernAlle";
            this.btnTagFjernAlle.Size = new System.Drawing.Size(84, 38);
            this.btnTagFjernAlle.TabIndex = 34;
            this.ttTimerMåling.SetToolTip(this.btnTagFjernAlle, "Fjern alle");
            this.btnTagFjernAlle.UseVisualStyleBackColor = true;
            this.btnTagFjernAlle.Click += new System.EventHandler(this.BtnTagFjernAlle_Click);
            // 
            // btnKategoriFjernAlle
            // 
            this.btnKategoriFjernAlle.ForeColor = System.Drawing.Color.Crimson;
            this.btnKategoriFjernAlle.Image = global::BO22EB16.Properties.Resources.arrow_24px1;
            this.btnKategoriFjernAlle.Location = new System.Drawing.Point(174, 105);
            this.btnKategoriFjernAlle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKategoriFjernAlle.Name = "btnKategoriFjernAlle";
            this.btnKategoriFjernAlle.Size = new System.Drawing.Size(84, 38);
            this.btnKategoriFjernAlle.TabIndex = 32;
            this.ttTimerMåling.SetToolTip(this.btnKategoriFjernAlle, "Fjern alle");
            this.btnKategoriFjernAlle.UseVisualStyleBackColor = true;
            this.btnKategoriFjernAlle.Click += new System.EventHandler(this.BtnKategoriFjernAlle_Click);
            // 
            // btnTagLeggTilAlle
            // 
            this.btnTagLeggTilAlle.ForeColor = System.Drawing.Color.Coral;
            this.btnTagLeggTilAlle.Image = global::BO22EB16.Properties.Resources.arrow_24px;
            this.btnTagLeggTilAlle.Location = new System.Drawing.Point(174, 198);
            this.btnTagLeggTilAlle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTagLeggTilAlle.Name = "btnTagLeggTilAlle";
            this.btnTagLeggTilAlle.Size = new System.Drawing.Size(84, 38);
            this.btnTagLeggTilAlle.TabIndex = 33;
            this.ttTimerMåling.SetToolTip(this.btnTagLeggTilAlle, "Legg til alle");
            this.btnTagLeggTilAlle.UseVisualStyleBackColor = true;
            this.btnTagLeggTilAlle.Click += new System.EventHandler(this.BtnTagLeggTilAlle_Click);
            // 
            // btnKategoriLeggTilAlle
            // 
            this.btnKategoriLeggTilAlle.ForeColor = System.Drawing.Color.Coral;
            this.btnKategoriLeggTilAlle.Image = global::BO22EB16.Properties.Resources.arrow_24px;
            this.btnKategoriLeggTilAlle.Location = new System.Drawing.Point(174, 61);
            this.btnKategoriLeggTilAlle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKategoriLeggTilAlle.Name = "btnKategoriLeggTilAlle";
            this.btnKategoriLeggTilAlle.Size = new System.Drawing.Size(84, 38);
            this.btnKategoriLeggTilAlle.TabIndex = 31;
            this.ttTimerMåling.SetToolTip(this.btnKategoriLeggTilAlle, "Legg til alle ");
            this.btnKategoriLeggTilAlle.UseVisualStyleBackColor = true;
            this.btnKategoriLeggTilAlle.Click += new System.EventHandler(this.BtnKategoriLeggTilAlle_Click);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTag.Location = new System.Drawing.Point(14, 391);
            this.lblTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(36, 20);
            this.lblTag.TabIndex = 31;
            this.lblTag.Text = "Tag";
            // 
            // lbTags
            // 
            this.lbTags.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 20;
            this.lbTags.Location = new System.Drawing.Point(165, 391);
            this.lbTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(244, 84);
            this.lbTags.Sorted = true;
            this.lbTags.TabIndex = 32;
            // 
            // tbMåling
            // 
            this.tbMåling.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbMåling.Location = new System.Drawing.Point(165, 145);
            this.tbMåling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMåling.Multiline = true;
            this.tbMåling.Name = "tbMåling";
            this.tbMåling.ReadOnly = true;
            this.tbMåling.Size = new System.Drawing.Size(124, 29);
            this.tbMåling.TabIndex = 34;
            // 
            // lblMåling
            // 
            this.lblMåling.AutoSize = true;
            this.lblMåling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMåling.Location = new System.Drawing.Point(14, 149);
            this.lblMåling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMåling.Name = "lblMåling";
            this.lblMåling.Size = new System.Drawing.Size(55, 20);
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
            this.gbInfo.Location = new System.Drawing.Point(10, 561);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInfo.Size = new System.Drawing.Size(435, 486);
            this.gbInfo.TabIndex = 35;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // tbEnhetMåling
            // 
            this.tbEnhetMåling.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbEnhetMåling.Location = new System.Drawing.Point(359, 145);
            this.tbEnhetMåling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEnhetMåling.Multiline = true;
            this.tbEnhetMåling.Name = "tbEnhetMåling";
            this.tbEnhetMåling.ReadOnly = true;
            this.tbEnhetMåling.Size = new System.Drawing.Size(49, 29);
            this.tbEnhetMåling.TabIndex = 39;
            // 
            // lblEnhetMåling
            // 
            this.lblEnhetMåling.AutoSize = true;
            this.lblEnhetMåling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnhetMåling.Location = new System.Drawing.Point(298, 149);
            this.lblEnhetMåling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnhetMåling.Name = "lblEnhetMåling";
            this.lblEnhetMåling.Size = new System.Drawing.Size(52, 20);
            this.lblEnhetMåling.TabIndex = 38;
            this.lblEnhetMåling.Text = "Enhet";
            // 
            // lbMålingDato
            // 
            this.lbMålingDato.AutoSize = true;
            this.lbMålingDato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMålingDato.Location = new System.Drawing.Point(14, 112);
            this.lbMålingDato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMålingDato.Name = "lbMålingDato";
            this.lbMålingDato.Size = new System.Drawing.Size(97, 20);
            this.lbMålingDato.TabIndex = 35;
            this.lbMålingDato.Text = "Måling utført";
            // 
            // tbMålingDato
            // 
            this.tbMålingDato.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbMålingDato.Location = new System.Drawing.Point(165, 108);
            this.tbMålingDato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMålingDato.Multiline = true;
            this.tbMålingDato.Name = "tbMålingDato";
            this.tbMålingDato.ReadOnly = true;
            this.tbMålingDato.Size = new System.Drawing.Size(242, 29);
            this.tbMålingDato.TabIndex = 34;
            this.ttTimerMåling.SetToolTip(this.tbMålingDato, "mm/dd/yyyy");
            // 
            // btnTimerMåling
            // 
            this.btnTimerMåling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerMåling.ForeColor = System.Drawing.Color.Black;
            this.btnTimerMåling.Location = new System.Drawing.Point(10, 1054);
            this.btnTimerMåling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimerMåling.Name = "btnTimerMåling";
            this.btnTimerMåling.Size = new System.Drawing.Size(436, 29);
            this.btnTimerMåling.TabIndex = 38;
            this.btnTimerMåling.Text = "Simulering av målinger inaktiv";
            this.ttTimerMåling.SetToolTip(this.btnTimerMåling, resources.GetString("btnTimerMåling.ToolTip"));
            this.btnTimerMåling.UseVisualStyleBackColor = true;
            this.btnTimerMåling.Click += new System.EventHandler(this.BtnTimerMåling_Click);
            // 
            // btnNesteObjekt
            // 
            this.btnNesteObjekt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNesteObjekt.Image = global::BO22EB16.Properties.Resources.arrow_24px;
            this.btnNesteObjekt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNesteObjekt.Location = new System.Drawing.Point(288, 46);
            this.btnNesteObjekt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNesteObjekt.Name = "btnNesteObjekt";
            this.btnNesteObjekt.Size = new System.Drawing.Size(123, 42);
            this.btnNesteObjekt.TabIndex = 37;
            this.btnNesteObjekt.Text = "Til Neste";
            this.btnNesteObjekt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNesteObjekt.UseVisualStyleBackColor = true;
            this.btnNesteObjekt.Click += new System.EventHandler(this.BtnNesteObjekt_Click);
            // 
            // btnForrigeObjekt
            // 
            this.btnForrigeObjekt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnForrigeObjekt.Image = global::BO22EB16.Properties.Resources.arrow_24px1;
            this.btnForrigeObjekt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForrigeObjekt.Location = new System.Drawing.Point(12, 46);
            this.btnForrigeObjekt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForrigeObjekt.Name = "btnForrigeObjekt";
            this.btnForrigeObjekt.Size = new System.Drawing.Size(123, 42);
            this.btnForrigeObjekt.TabIndex = 36;
            this.btnForrigeObjekt.Text = "Til Forrige";
            this.btnForrigeObjekt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForrigeObjekt.UseVisualStyleBackColor = true;
            this.btnForrigeObjekt.Click += new System.EventHandler(this.BtnForrigeObjekt_Click);
            // 
            // gbObjekt
            // 
            this.gbObjekt.Controls.Add(this.tbAntallObjekter);
            this.gbObjekt.Controls.Add(this.lblObjektAntall);
            this.gbObjekt.Controls.Add(this.lblHoppTilEtOmråde);
            this.gbObjekt.Controls.Add(this.btnNesteObjekt);
            this.gbObjekt.Controls.Add(this.btnForrigeObjekt);
            this.gbObjekt.ForeColor = System.Drawing.SystemColors.Control;
            this.gbObjekt.Location = new System.Drawing.Point(10, 460);
            this.gbObjekt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbObjekt.Name = "gbObjekt";
            this.gbObjekt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbObjekt.Size = new System.Drawing.Size(435, 95);
            this.gbObjekt.TabIndex = 39;
            this.gbObjekt.TabStop = false;
            this.gbObjekt.Text = "Objekt";
            // 
            // tbAntallObjekter
            // 
            this.tbAntallObjekter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbAntallObjekter.Location = new System.Drawing.Point(213, 54);
            this.tbAntallObjekter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAntallObjekter.Name = "tbAntallObjekter";
            this.tbAntallObjekter.ReadOnly = true;
            this.tbAntallObjekter.Size = new System.Drawing.Size(31, 26);
            this.tbAntallObjekter.TabIndex = 54;
            this.tbAntallObjekter.Text = "0";
            this.ttTimerMåling.SetToolTip(this.tbAntallObjekter, "Antall objekter som er synlig");
            // 
            // lblObjektAntall
            // 
            this.lblObjektAntall.AutoSize = true;
            this.lblObjektAntall.Location = new System.Drawing.Point(161, 59);
            this.lblObjektAntall.Name = "lblObjektAntall";
            this.lblObjektAntall.Size = new System.Drawing.Size(49, 20);
            this.lblObjektAntall.TabIndex = 37;
            this.lblObjektAntall.Text = "Antall";
            // 
            // lblHoppTilEtOmråde
            // 
            this.lblHoppTilEtOmråde.AutoSize = true;
            this.lblHoppTilEtOmråde.Location = new System.Drawing.Point(6, 22);
            this.lblHoppTilEtOmråde.Name = "lblHoppTilEtOmråde";
            this.lblHoppTilEtOmråde.Size = new System.Drawing.Size(295, 20);
            this.lblHoppTilEtOmråde.TabIndex = 38;
            this.lblHoppTilEtOmråde.Text = "Hopp til et objekt med hjelp av knappene";
            // 
            // Frm_V_Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(459, 1089);
            this.Controls.Add(this.gbObjekt);
            this.Controls.Add(this.btnTimerMåling);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnForrigeObjekt;
        private System.Windows.Forms.Button btnNesteObjekt;
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