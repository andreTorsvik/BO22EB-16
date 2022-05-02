namespace GMAP_Demo
{
    partial class frm_S_FjernKategori
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
            this.lblTitle.Location = new System.Drawing.Point(14, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(574, 55);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Fjern Ubrukte Kategorier";
            // 
            // lbTilgjengligKategorier
            // 
            this.lbTilgjengligKategorier.FormattingEnabled = true;
            this.lbTilgjengligKategorier.ItemHeight = 20;
            this.lbTilgjengligKategorier.Location = new System.Drawing.Point(18, 130);
            this.lbTilgjengligKategorier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTilgjengligKategorier.Name = "lbTilgjengligKategorier";
            this.lbTilgjengligKategorier.Size = new System.Drawing.Size(326, 264);
            this.lbTilgjengligKategorier.Sorted = true;
            this.lbTilgjengligKategorier.TabIndex = 5;
            this.lbTilgjengligKategorier.DoubleClick += new System.EventHandler(this.lbKategorier_DoubleClick);
            // 
            // tbValgtKategori
            // 
            this.tbValgtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbValgtKategori.Location = new System.Drawing.Point(364, 130);
            this.tbValgtKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbValgtKategori.Name = "tbValgtKategori";
            this.tbValgtKategori.Size = new System.Drawing.Size(183, 26);
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
            this.gbFjernKategori.ForeColor = System.Drawing.SystemColors.Control;
            this.gbFjernKategori.Location = new System.Drawing.Point(4, 82);
            this.gbFjernKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFjernKategori.Name = "gbFjernKategori";
            this.gbFjernKategori.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFjernKategori.Size = new System.Drawing.Size(669, 430);
            this.gbFjernKategori.TabIndex = 7;
            this.gbFjernKategori.TabStop = false;
            this.gbFjernKategori.Text = "Fjern Kategori";
            this.gbFjernKategori.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(9, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(86, 20);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Bruker info";
            // 
            // lblValgtKategori
            // 
            this.lblValgtKategori.AutoSize = true;
            this.lblValgtKategori.Location = new System.Drawing.Point(361, 106);
            this.lblValgtKategori.Name = "lblValgtKategori";
            this.lblValgtKategori.Size = new System.Drawing.Size(121, 20);
            this.lblValgtKategori.TabIndex = 8;
            this.lblValgtKategori.Text = "Valgt kategorier";
            // 
            // lblSlettbareKategorier
            // 
            this.lblSlettbareKategorier.AutoSize = true;
            this.lblSlettbareKategorier.Location = new System.Drawing.Point(15, 106);
            this.lblSlettbareKategorier.Name = "lblSlettbareKategorier";
            this.lblSlettbareKategorier.Size = new System.Drawing.Size(149, 20);
            this.lblSlettbareKategorier.TabIndex = 8;
            this.lblSlettbareKategorier.Text = "Slettbare kategorier";
            // 
            // btnFjern
            // 
            this.btnFjern.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFjern.Location = new System.Drawing.Point(364, 165);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(105, 39);
            this.btnFjern.TabIndex = 7;
            this.btnFjern.Text = "Fjern";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.btnFjern_Click);
            // 
            // frm_S_FjernKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1440, 1031);
            this.Controls.Add(this.gbFjernKategori);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_S_FjernKategori";
            this.Text = "frm_S_BrukerInfo";
            this.Load += new System.EventHandler(this.frm_S_BrukerInfo_Load);
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