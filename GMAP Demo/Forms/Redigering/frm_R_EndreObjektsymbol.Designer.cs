namespace GMAP_Demo
{
    partial class frm_R_EndreObjektsymbol
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
            this.btnLVelgBildeFraFiler = new System.Windows.Forms.Button();
            this.lbTilgjengligKategorier = new System.Windows.Forms.ListBox();
            this.txtValgtKategori = new System.Windows.Forms.TextBox();
            this.lblTilgjengeligeKategorier = new System.Windows.Forms.Label();
            this.lblValgtKategori = new System.Windows.Forms.Label();
            this.lblValgtBilde = new System.Windows.Forms.Label();
            this.lblVelgBilde = new System.Windows.Forms.Label();
            this.btnLeggTilIDb = new System.Windows.Forms.Button();
            this.lblLastOppTilDB = new System.Windows.Forms.Label();
            this.pbValgtKategori = new System.Windows.Forms.PictureBox();
            this.pbValgtBilde = new System.Windows.Forms.PictureBox();
            this.gblLastOppTilDB = new System.Windows.Forms.GroupBox();
            this.gbBilde = new System.Windows.Forms.GroupBox();
            this.gbKategori = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbValgtKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValgtBilde)).BeginInit();
            this.gblLastOppTilDB.SuspendLayout();
            this.gbBilde.SuspendLayout();
            this.gbKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endre objektsymbol";
            // 
            // btnLVelgBildeFraFiler
            // 
            this.btnLVelgBildeFraFiler.ForeColor = System.Drawing.Color.Black;
            this.btnLVelgBildeFraFiler.Location = new System.Drawing.Point(5, 39);
            this.btnLVelgBildeFraFiler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLVelgBildeFraFiler.Name = "btnLVelgBildeFraFiler";
            this.btnLVelgBildeFraFiler.Size = new System.Drawing.Size(221, 54);
            this.btnLVelgBildeFraFiler.TabIndex = 63;
            this.btnLVelgBildeFraFiler.Text = "Velg bilde fra Filer";
            this.btnLVelgBildeFraFiler.UseVisualStyleBackColor = true;
            this.btnLVelgBildeFraFiler.Click += new System.EventHandler(this.btnLeggTilBilde_Click);
            // 
            // lbTilgjengligKategorier
            // 
            this.lbTilgjengligKategorier.FormattingEnabled = true;
            this.lbTilgjengligKategorier.ItemHeight = 16;
            this.lbTilgjengligKategorier.Location = new System.Drawing.Point(7, 39);
            this.lbTilgjengligKategorier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTilgjengligKategorier.Name = "lbTilgjengligKategorier";
            this.lbTilgjengligKategorier.Size = new System.Drawing.Size(220, 164);
            this.lbTilgjengligKategorier.Sorted = true;
            this.lbTilgjengligKategorier.TabIndex = 64;
            this.lbTilgjengligKategorier.DoubleClick += new System.EventHandler(this.lbTilgjengligKategorier_DoubleClick);
            // 
            // txtValgtKategori
            // 
            this.txtValgtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtValgtKategori.Location = new System.Drawing.Point(236, 39);
            this.txtValgtKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValgtKategori.Name = "txtValgtKategori";
            this.txtValgtKategori.ReadOnly = true;
            this.txtValgtKategori.Size = new System.Drawing.Size(137, 22);
            this.txtValgtKategori.TabIndex = 65;
            // 
            // lblTilgjengeligeKategorier
            // 
            this.lblTilgjengeligeKategorier.AutoSize = true;
            this.lblTilgjengeligeKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilgjengeligeKategorier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblTilgjengeligeKategorier.Location = new System.Drawing.Point(7, 18);
            this.lblTilgjengeligeKategorier.Name = "lblTilgjengeligeKategorier";
            this.lblTilgjengeligeKategorier.Size = new System.Drawing.Size(184, 18);
            this.lblTilgjengeligeKategorier.TabIndex = 66;
            this.lblTilgjengeligeKategorier.Text = "Tilgjengelige Kategorier";
            // 
            // lblValgtKategori
            // 
            this.lblValgtKategori.AutoSize = true;
            this.lblValgtKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValgtKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblValgtKategori.Location = new System.Drawing.Point(232, 18);
            this.lblValgtKategori.Name = "lblValgtKategori";
            this.lblValgtKategori.Size = new System.Drawing.Size(113, 18);
            this.lblValgtKategori.TabIndex = 67;
            this.lblValgtKategori.Text = "Valgt Kategori";
            // 
            // lblValgtBilde
            // 
            this.lblValgtBilde.AutoSize = true;
            this.lblValgtBilde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValgtBilde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblValgtBilde.Location = new System.Drawing.Point(232, 18);
            this.lblValgtBilde.Name = "lblValgtBilde";
            this.lblValgtBilde.Size = new System.Drawing.Size(87, 18);
            this.lblValgtBilde.TabIndex = 70;
            this.lblValgtBilde.Text = "Valgt Bilde";
            // 
            // lblVelgBilde
            // 
            this.lblVelgBilde.AutoSize = true;
            this.lblVelgBilde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelgBilde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblVelgBilde.Location = new System.Drawing.Point(7, 18);
            this.lblVelgBilde.Name = "lblVelgBilde";
            this.lblVelgBilde.Size = new System.Drawing.Size(82, 18);
            this.lblVelgBilde.TabIndex = 69;
            this.lblVelgBilde.Text = "Velg Bilde";
            // 
            // btnLeggTilIDb
            // 
            this.btnLeggTilIDb.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilIDb.Location = new System.Drawing.Point(7, 19);
            this.btnLeggTilIDb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeggTilIDb.Name = "btnLeggTilIDb";
            this.btnLeggTilIDb.Size = new System.Drawing.Size(221, 54);
            this.btnLeggTilIDb.TabIndex = 71;
            this.btnLeggTilIDb.Text = "Lagre bilde";
            this.btnLeggTilIDb.UseVisualStyleBackColor = true;
            this.btnLeggTilIDb.Click += new System.EventHandler(this.btnLeggTilIDb_Click);
            // 
            // lblLastOppTilDB
            // 
            this.lblLastOppTilDB.AutoSize = true;
            this.lblLastOppTilDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastOppTilDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLastOppTilDB.Location = new System.Drawing.Point(5, 18);
            this.lblLastOppTilDB.Name = "lblLastOppTilDB";
            this.lblLastOppTilDB.Size = new System.Drawing.Size(0, 20);
            this.lblLastOppTilDB.TabIndex = 72;
            // 
            // pbValgtKategori
            // 
            this.pbValgtKategori.Location = new System.Drawing.Point(236, 66);
            this.pbValgtKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbValgtKategori.Name = "pbValgtKategori";
            this.pbValgtKategori.Size = new System.Drawing.Size(129, 136);
            this.pbValgtKategori.TabIndex = 68;
            this.pbValgtKategori.TabStop = false;
            this.pbValgtKategori.Visible = false;
            // 
            // pbValgtBilde
            // 
            this.pbValgtBilde.Location = new System.Drawing.Point(236, 39);
            this.pbValgtBilde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbValgtBilde.Name = "pbValgtBilde";
            this.pbValgtBilde.Size = new System.Drawing.Size(129, 136);
            this.pbValgtBilde.TabIndex = 68;
            this.pbValgtBilde.TabStop = false;
            // 
            // gblLastOppTilDB
            // 
            this.gblLastOppTilDB.Controls.Add(this.lblLastOppTilDB);
            this.gblLastOppTilDB.Controls.Add(this.btnLeggTilIDb);
            this.gblLastOppTilDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.gblLastOppTilDB.Location = new System.Drawing.Point(9, 475);
            this.gblLastOppTilDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gblLastOppTilDB.Name = "gblLastOppTilDB";
            this.gblLastOppTilDB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gblLastOppTilDB.Size = new System.Drawing.Size(378, 85);
            this.gblLastOppTilDB.TabIndex = 73;
            this.gblLastOppTilDB.TabStop = false;
            this.gblLastOppTilDB.Text = "Last opp valgt bilde til valgt kategori";
            // 
            // gbBilde
            // 
            this.gbBilde.Controls.Add(this.lblValgtBilde);
            this.gbBilde.Controls.Add(this.btnLVelgBildeFraFiler);
            this.gbBilde.Controls.Add(this.pbValgtBilde);
            this.gbBilde.Controls.Add(this.lblVelgBilde);
            this.gbBilde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.gbBilde.Location = new System.Drawing.Point(9, 281);
            this.gbBilde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBilde.Name = "gbBilde";
            this.gbBilde.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBilde.Size = new System.Drawing.Size(378, 190);
            this.gbBilde.TabIndex = 74;
            this.gbBilde.TabStop = false;
            this.gbBilde.Text = "Bilde";
            // 
            // gbKategori
            // 
            this.gbKategori.Controls.Add(this.lblTilgjengeligeKategorier);
            this.gbKategori.Controls.Add(this.lbTilgjengligKategorier);
            this.gbKategori.Controls.Add(this.txtValgtKategori);
            this.gbKategori.Controls.Add(this.pbValgtKategori);
            this.gbKategori.Controls.Add(this.lblValgtKategori);
            this.gbKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.gbKategori.Location = new System.Drawing.Point(9, 48);
            this.gbKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbKategori.Name = "gbKategori";
            this.gbKategori.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbKategori.Size = new System.Drawing.Size(378, 228);
            this.gbKategori.TabIndex = 74;
            this.gbKategori.TabStop = false;
            this.gbKategori.Text = "Kategori";
            // 
            // frm_R_EndreObjektsymbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(391, 825);
            this.Controls.Add(this.gbKategori);
            this.Controls.Add(this.gbBilde);
            this.Controls.Add(this.gblLastOppTilDB);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_R_EndreObjektsymbol";
            this.Text = "frm_S_LeggTilBilde";
            this.Load += new System.EventHandler(this.frm_S_LeggTilBilde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbValgtKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValgtBilde)).EndInit();
            this.gblLastOppTilDB.ResumeLayout(false);
            this.gblLastOppTilDB.PerformLayout();
            this.gbBilde.ResumeLayout(false);
            this.gbBilde.PerformLayout();
            this.gbKategori.ResumeLayout(false);
            this.gbKategori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLVelgBildeFraFiler;
        private System.Windows.Forms.ListBox lbTilgjengligKategorier;
        private System.Windows.Forms.TextBox txtValgtKategori;
        private System.Windows.Forms.Label lblTilgjengeligeKategorier;
        private System.Windows.Forms.Label lblValgtKategori;
        private System.Windows.Forms.PictureBox pbValgtBilde;
        private System.Windows.Forms.Label lblValgtBilde;
        private System.Windows.Forms.Label lblVelgBilde;
        private System.Windows.Forms.Button btnLeggTilIDb;
        private System.Windows.Forms.Label lblLastOppTilDB;
        private System.Windows.Forms.PictureBox pbValgtKategori;
        private System.Windows.Forms.GroupBox gblLastOppTilDB;
        private System.Windows.Forms.GroupBox gbBilde;
        private System.Windows.Forms.GroupBox gbKategori;
    }
}