namespace GMAP_Demo
{
    partial class frm_R_RedigerObjekt
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
            this.txtNyKategori = new System.Windows.Forms.TextBox();
            this.btnLeggTilNyKategori = new System.Windows.Forms.Button();
            this.lbTilgjengligKategori = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNyTag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKommentar = new System.Windows.Forms.TextBox();
            this.btnLeggTilTag = new System.Windows.Forms.Button();
            this.lbValgtTags = new System.Windows.Forms.ListBox();
            this.lbTilgjengeligeTags = new System.Windows.Forms.ListBox();
            this.btnLagreEndring = new System.Windows.Forms.Button();
            this.LabelSikkerhetsklarering = new System.Windows.Forms.Label();
            this.txtSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.gbObjekt = new System.Windows.Forms.GroupBox();
            this.gbTag = new System.Windows.Forms.GroupBox();
            this.cbOmråde = new System.Windows.Forms.CheckBox();
            this.gbObjekt.SuspendLayout();
            this.gbTag.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rediger Objekt";
            // 
            // txtNyKategori
            // 
            this.txtNyKategori.BackColor = System.Drawing.SystemColors.Control;
            this.txtNyKategori.Location = new System.Drawing.Point(5, 170);
            this.txtNyKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNyKategori.Name = "txtNyKategori";
            this.txtNyKategori.Size = new System.Drawing.Size(139, 22);
            this.txtNyKategori.TabIndex = 87;
            // 
            // btnLeggTilNyKategori
            // 
            this.btnLeggTilNyKategori.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilNyKategori.Location = new System.Drawing.Point(154, 170);
            this.btnLeggTilNyKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilNyKategori.Name = "btnLeggTilNyKategori";
            this.btnLeggTilNyKategori.Size = new System.Drawing.Size(140, 27);
            this.btnLeggTilNyKategori.TabIndex = 86;
            this.btnLeggTilNyKategori.Text = "Legg til ny Kategori";
            this.btnLeggTilNyKategori.UseVisualStyleBackColor = true;
            this.btnLeggTilNyKategori.Click += new System.EventHandler(this.btnLeggTilNyKategori_Click);
            // 
            // lbTilgjengligKategori
            // 
            this.lbTilgjengligKategori.FormattingEnabled = true;
            this.lbTilgjengligKategori.ItemHeight = 16;
            this.lbTilgjengligKategori.Location = new System.Drawing.Point(5, 127);
            this.lbTilgjengligKategori.Name = "lbTilgjengligKategori";
            this.lbTilgjengligKategori.Size = new System.Drawing.Size(138, 36);
            this.lbTilgjengligKategori.Sorted = true;
            this.lbTilgjengligKategori.TabIndex = 85;
            this.lbTilgjengligKategori.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTilgjengligKategori_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(5, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Kategori";
            // 
            // txtKategori
            // 
            this.txtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKategori.Location = new System.Drawing.Point(152, 127);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.ReadOnly = true;
            this.txtKategori.Size = new System.Drawing.Size(138, 22);
            this.txtKategori.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(152, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 16);
            this.label11.TabIndex = 82;
            this.label11.Text = "valgt for dette Objektet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(5, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 81;
            this.label10.Text = "Ekisterende";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(5, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 80;
            this.label9.Text = "Ny Tag ";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(5, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "Velg Hvilke tags";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(5, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 77;
            this.label7.Text = "Long";
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
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(5, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Lat";
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(5, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Kommentar";
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(5, 221);
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
            this.btnLeggTilTag.Click += new System.EventHandler(this.btnLeggTilTag_Click);
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
            this.lbValgtTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbValgtTags_MouseDoubleClick);
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
            this.lbTilgjengeligeTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTilgjengeligeTags_MouseDoubleClick);
            // 
            // btnLagreEndring
            // 
            this.btnLagreEndring.Location = new System.Drawing.Point(20, 752);
            this.btnLagreEndring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLagreEndring.Name = "btnLagreEndring";
            this.btnLagreEndring.Size = new System.Drawing.Size(123, 34);
            this.btnLagreEndring.TabIndex = 68;
            this.btnLagreEndring.Text = "Lagre endering";
            this.btnLagreEndring.UseVisualStyleBackColor = true;
            this.btnLagreEndring.Click += new System.EventHandler(this.btnLeggTilObjekt_Click);
            // 
            // LabelSikkerhetsklarering
            // 
            this.LabelSikkerhetsklarering.AutoSize = true;
            this.LabelSikkerhetsklarering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSikkerhetsklarering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.LabelSikkerhetsklarering.Location = new System.Drawing.Point(5, 63);
            this.LabelSikkerhetsklarering.Name = "LabelSikkerhetsklarering";
            this.LabelSikkerhetsklarering.Size = new System.Drawing.Size(211, 20);
            this.LabelSikkerhetsklarering.TabIndex = 67;
            this.LabelSikkerhetsklarering.Text = "Sikkerhetsklarering(1-3)";
            // 
            // txtSikkerhetsklarering
            // 
            this.txtSikkerhetsklarering.Location = new System.Drawing.Point(5, 84);
            this.txtSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSikkerhetsklarering.Name = "txtSikkerhetsklarering";
            this.txtSikkerhetsklarering.Size = new System.Drawing.Size(287, 22);
            this.txtSikkerhetsklarering.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Navn";
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
            this.gbObjekt.Controls.Add(this.cbOmråde);
            this.gbObjekt.Controls.Add(this.label1);
            this.gbObjekt.Controls.Add(this.txtNyKategori);
            this.gbObjekt.Controls.Add(this.txtNavn);
            this.gbObjekt.Controls.Add(this.btnLeggTilNyKategori);
            this.gbObjekt.Controls.Add(this.txtSikkerhetsklarering);
            this.gbObjekt.Controls.Add(this.lbTilgjengligKategori);
            this.gbObjekt.Controls.Add(this.LabelSikkerhetsklarering);
            this.gbObjekt.Controls.Add(this.label2);
            this.gbObjekt.Controls.Add(this.txtKommentar);
            this.gbObjekt.Controls.Add(this.txtKategori);
            this.gbObjekt.Controls.Add(this.label5);
            this.gbObjekt.Controls.Add(this.txtLat);
            this.gbObjekt.Controls.Add(this.label8);
            this.gbObjekt.Controls.Add(this.txtLong);
            this.gbObjekt.Controls.Add(this.label7);
            this.gbObjekt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.gbObjekt.Location = new System.Drawing.Point(20, 57);
            this.gbObjekt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbObjekt.Name = "gbObjekt";
            this.gbObjekt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbObjekt.Size = new System.Drawing.Size(303, 373);
            this.gbObjekt.TabIndex = 88;
            this.gbObjekt.TabStop = false;
            this.gbObjekt.Text = "Objekt";
            // 
            // gbTag
            // 
            this.gbTag.Controls.Add(this.label6);
            this.gbTag.Controls.Add(this.lbTilgjengeligeTags);
            this.gbTag.Controls.Add(this.label11);
            this.gbTag.Controls.Add(this.lbValgtTags);
            this.gbTag.Controls.Add(this.label10);
            this.gbTag.Controls.Add(this.btnLeggTilTag);
            this.gbTag.Controls.Add(this.label9);
            this.gbTag.Controls.Add(this.txtNyTag);
            this.gbTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.gbTag.Location = new System.Drawing.Point(20, 434);
            this.gbTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTag.Name = "gbTag";
            this.gbTag.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTag.Size = new System.Drawing.Size(300, 314);
            this.gbTag.TabIndex = 89;
            this.gbTag.TabStop = false;
            this.gbTag.Text = "Tag";
            // 
            // cbOmråde
            // 
            this.cbOmråde.AutoSize = true;
            this.cbOmråde.Location = new System.Drawing.Point(4, 341);
            this.cbOmråde.Name = "cbOmråde";
            this.cbOmråde.Size = new System.Drawing.Size(244, 20);
            this.cbOmråde.TabIndex = 88;
            this.cbOmråde.Text = "Kan legge inni eksisterende område";
            this.cbOmråde.UseVisualStyleBackColor = true;
            this.cbOmråde.CheckedChanged += new System.EventHandler(this.cbOmråde_CheckedChanged);
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
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_R_RedigerObjekt";
            this.Text = "frm_R_RedigerObjektOmråde";
            this.Load += new System.EventHandler(this.frm_R_RedigerObjekt_Load);
            this.gbObjekt.ResumeLayout(false);
            this.gbObjekt.PerformLayout();
            this.gbTag.ResumeLayout(false);
            this.gbTag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNyKategori;
        private System.Windows.Forms.Button btnLeggTilNyKategori;
        private System.Windows.Forms.ListBox lbTilgjengligKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNyTag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKommentar;
        private System.Windows.Forms.Button btnLeggTilTag;
        private System.Windows.Forms.ListBox lbValgtTags;
        private System.Windows.Forms.ListBox lbTilgjengeligeTags;
        private System.Windows.Forms.Button btnLagreEndring;
        private System.Windows.Forms.Label LabelSikkerhetsklarering;
        private System.Windows.Forms.TextBox txtSikkerhetsklarering;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.GroupBox gbObjekt;
        private System.Windows.Forms.GroupBox gbTag;
        private System.Windows.Forms.CheckBox cbOmråde;
    }
}