namespace GMAP_Demo
{
    partial class Frm_CP_FjernKategori
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbTilgjengligKategorier = new System.Windows.Forms.ListBox();
            this.tbValgtKategori = new System.Windows.Forms.TextBox();
            this.gbFjernKategori = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblValgtKategori = new System.Windows.Forms.Label();
            this.lblSlettbareKategorier = new System.Windows.Forms.Label();
            this.btnFjern = new System.Windows.Forms.Button();
            this.gbFjernKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(479, 46);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Fjern Ubrukte Kategorier";
            // 
            // lbTilgjengligKategorier
            // 
            this.lbTilgjengligKategorier.FormattingEnabled = true;
            this.lbTilgjengligKategorier.ItemHeight = 16;
            this.lbTilgjengligKategorier.Location = new System.Drawing.Point(16, 103);
            this.lbTilgjengligKategorier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTilgjengligKategorier.Name = "lbTilgjengligKategorier";
            this.lbTilgjengligKategorier.Size = new System.Drawing.Size(291, 212);
            this.lbTilgjengligKategorier.Sorted = true;
            this.lbTilgjengligKategorier.TabIndex = 5;
            this.lbTilgjengligKategorier.DoubleClick += new System.EventHandler(this.LbKategorier_DoubleClick);
            // 
            // tbValgtKategori
            // 
            this.tbValgtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbValgtKategori.Location = new System.Drawing.Point(313, 103);
            this.tbValgtKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbValgtKategori.Name = "tbValgtKategori";
            this.tbValgtKategori.ReadOnly = true;
            this.tbValgtKategori.Size = new System.Drawing.Size(163, 22);
            this.tbValgtKategori.TabIndex = 6;
            // 
            // gbFjernKategori
            // 
            this.gbFjernKategori.Controls.Add(this.lblInfo);
            this.gbFjernKategori.Controls.Add(this.lblValgtKategori);
            this.gbFjernKategori.Controls.Add(this.lblSlettbareKategorier);
            this.gbFjernKategori.Controls.Add(this.btnFjern);
            this.gbFjernKategori.Controls.Add(this.tbValgtKategori);
            this.gbFjernKategori.Controls.Add(this.lbTilgjengligKategorier);
            this.gbFjernKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbFjernKategori.Location = new System.Drawing.Point(15, 58);
            this.gbFjernKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFjernKategori.Name = "gbFjernKategori";
            this.gbFjernKategori.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFjernKategori.Size = new System.Drawing.Size(531, 345);
            this.gbFjernKategori.TabIndex = 7;
            this.gbFjernKategori.TabStop = false;
            this.gbFjernKategori.Text = "Fjern Kategori";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(8, 17);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(485, 32);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Du må fjerne alle forkomster av kategorien før den kommer opp her.\r\nDet er ikke s" +
    "ikkert du har tilgang til alle objektene på grunn av sikkerhetsklarering";
            // 
            // lblValgtKategori
            // 
            this.lblValgtKategori.AutoSize = true;
            this.lblValgtKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValgtKategori.Location = new System.Drawing.Point(313, 85);
            this.lblValgtKategori.Name = "lblValgtKategori";
            this.lblValgtKategori.Size = new System.Drawing.Size(102, 16);
            this.lblValgtKategori.TabIndex = 8;
            this.lblValgtKategori.Text = "Valgt kategorier";
            // 
            // lblSlettbareKategorier
            // 
            this.lblSlettbareKategorier.AutoSize = true;
            this.lblSlettbareKategorier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSlettbareKategorier.Location = new System.Drawing.Point(13, 85);
            this.lblSlettbareKategorier.Name = "lblSlettbareKategorier";
            this.lblSlettbareKategorier.Size = new System.Drawing.Size(125, 16);
            this.lblSlettbareKategorier.TabIndex = 8;
            this.lblSlettbareKategorier.Text = "Slettbare kategorier";
            // 
            // btnFjern
            // 
            this.btnFjern.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFjern.Location = new System.Drawing.Point(313, 132);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(143, 28);
            this.btnFjern.TabIndex = 7;
            this.btnFjern.Text = "Fjern";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.BtnFjern_Click);
            // 
            // Frm_CP_FjernKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 825);
            this.Controls.Add(this.gbFjernKategori);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Frm_CP_FjernKategori";
            this.Text = "frm_S_BrukerInfo";
            this.Load += new System.EventHandler(this.Frm_S_BrukerInfo_Load);
            this.gbFjernKategori.ResumeLayout(false);
            this.gbFjernKategori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lbTilgjengligKategorier;
        private System.Windows.Forms.TextBox tbValgtKategori;
        private System.Windows.Forms.GroupBox gbFjernKategori;
        private System.Windows.Forms.Label lblValgtKategori;
        private System.Windows.Forms.Label lblSlettbareKategorier;
        private System.Windows.Forms.Button btnFjern;
        private System.Windows.Forms.Label lblInfo;
    }
}