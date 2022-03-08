namespace GMAP_Demo
{
    partial class frm_S_LeggTilBilde
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
            this.pbValgtBilde = new System.Windows.Forms.PictureBox();
            this.lblValgtBilde = new System.Windows.Forms.Label();
            this.lblVelgBilde = new System.Windows.Forms.Label();
            this.btnLeggTilIDb = new System.Windows.Forms.Button();
            this.lblLastOppTilDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbValgtBilde)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Legg til Bilde";
            // 
            // btnLVelgBildeFraFiler
            // 
            this.btnLVelgBildeFraFiler.Location = new System.Drawing.Point(35, 298);
            this.btnLVelgBildeFraFiler.Margin = new System.Windows.Forms.Padding(2);
            this.btnLVelgBildeFraFiler.Name = "btnLVelgBildeFraFiler";
            this.btnLVelgBildeFraFiler.Size = new System.Drawing.Size(166, 44);
            this.btnLVelgBildeFraFiler.TabIndex = 63;
            this.btnLVelgBildeFraFiler.Text = "Velg bilde fra Filer";
            this.btnLVelgBildeFraFiler.UseVisualStyleBackColor = true;
            this.btnLVelgBildeFraFiler.Click += new System.EventHandler(this.btnLeggTilBilde_Click);
            // 
            // lbTilgjengligKategorier
            // 
            this.lbTilgjengligKategorier.FormattingEnabled = true;
            this.lbTilgjengligKategorier.Location = new System.Drawing.Point(35, 84);
            this.lbTilgjengligKategorier.Margin = new System.Windows.Forms.Padding(2);
            this.lbTilgjengligKategorier.Name = "lbTilgjengligKategorier";
            this.lbTilgjengligKategorier.Size = new System.Drawing.Size(166, 134);
            this.lbTilgjengligKategorier.TabIndex = 64;
            this.lbTilgjengligKategorier.DoubleClick += new System.EventHandler(this.lbTilgjengligKategorier_DoubleClick);
            // 
            // txtValgtKategori
            // 
            this.txtValgtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtValgtKategori.Location = new System.Drawing.Point(252, 84);
            this.txtValgtKategori.Margin = new System.Windows.Forms.Padding(2);
            this.txtValgtKategori.Name = "txtValgtKategori";
            this.txtValgtKategori.ReadOnly = true;
            this.txtValgtKategori.Size = new System.Drawing.Size(104, 20);
            this.txtValgtKategori.TabIndex = 65;
            // 
            // lblTilgjengeligeKategorier
            // 
            this.lblTilgjengeligeKategorier.AutoSize = true;
            this.lblTilgjengeligeKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilgjengeligeKategorier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTilgjengeligeKategorier.Location = new System.Drawing.Point(32, 65);
            this.lblTilgjengeligeKategorier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTilgjengeligeKategorier.Name = "lblTilgjengeligeKategorier";
            this.lblTilgjengeligeKategorier.Size = new System.Drawing.Size(182, 17);
            this.lblTilgjengeligeKategorier.TabIndex = 66;
            this.lblTilgjengeligeKategorier.Text = "Tilgjengelige Kategorier";
            // 
            // lblValgtKategori
            // 
            this.lblValgtKategori.AutoSize = true;
            this.lblValgtKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValgtKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblValgtKategori.Location = new System.Drawing.Point(249, 65);
            this.lblValgtKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValgtKategori.Name = "lblValgtKategori";
            this.lblValgtKategori.Size = new System.Drawing.Size(111, 17);
            this.lblValgtKategori.TabIndex = 67;
            this.lblValgtKategori.Text = "Valgt Kategori";
            // 
            // pbValgtBilde
            // 
            this.pbValgtBilde.Location = new System.Drawing.Point(252, 298);
            this.pbValgtBilde.Name = "pbValgtBilde";
            this.pbValgtBilde.Size = new System.Drawing.Size(104, 127);
            this.pbValgtBilde.TabIndex = 68;
            this.pbValgtBilde.TabStop = false;
            // 
            // lblValgtBilde
            // 
            this.lblValgtBilde.AutoSize = true;
            this.lblValgtBilde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValgtBilde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblValgtBilde.Location = new System.Drawing.Point(257, 257);
            this.lblValgtBilde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValgtBilde.Name = "lblValgtBilde";
            this.lblValgtBilde.Size = new System.Drawing.Size(86, 17);
            this.lblValgtBilde.TabIndex = 70;
            this.lblValgtBilde.Text = "Valgt Bilde";
            // 
            // lblVelgBilde
            // 
            this.lblVelgBilde.AutoSize = true;
            this.lblVelgBilde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelgBilde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblVelgBilde.Location = new System.Drawing.Point(40, 257);
            this.lblVelgBilde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVelgBilde.Name = "lblVelgBilde";
            this.lblVelgBilde.Size = new System.Drawing.Size(81, 17);
            this.lblVelgBilde.TabIndex = 69;
            this.lblVelgBilde.Text = "Velg Bilde";
            // 
            // btnLeggTilIDb
            // 
            this.btnLeggTilIDb.Location = new System.Drawing.Point(35, 471);
            this.btnLeggTilIDb.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeggTilIDb.Name = "btnLeggTilIDb";
            this.btnLeggTilIDb.Size = new System.Drawing.Size(166, 44);
            this.btnLeggTilIDb.TabIndex = 71;
            this.btnLeggTilIDb.Text = "Legg til Bilde i Database";
            this.btnLeggTilIDb.UseVisualStyleBackColor = true;
            this.btnLeggTilIDb.Click += new System.EventHandler(this.btnLeggTilIDb_Click);
            // 
            // lblLastOppTilDB
            // 
            this.lblLastOppTilDB.AutoSize = true;
            this.lblLastOppTilDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastOppTilDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblLastOppTilDB.Location = new System.Drawing.Point(32, 452);
            this.lblLastOppTilDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastOppTilDB.Name = "lblLastOppTilDB";
            this.lblLastOppTilDB.Size = new System.Drawing.Size(273, 17);
            this.lblLastOppTilDB.TabIndex = 72;
            this.lblLastOppTilDB.Text = "Last opp valgt bilde til valgt kategori";
            // 
            // frm_S_LeggTilBilde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.Controls.Add(this.lblLastOppTilDB);
            this.Controls.Add(this.btnLeggTilIDb);
            this.Controls.Add(this.lblValgtBilde);
            this.Controls.Add(this.lblVelgBilde);
            this.Controls.Add(this.pbValgtBilde);
            this.Controls.Add(this.lblValgtKategori);
            this.Controls.Add(this.lblTilgjengeligeKategorier);
            this.Controls.Add(this.txtValgtKategori);
            this.Controls.Add(this.lbTilgjengligKategorier);
            this.Controls.Add(this.btnLVelgBildeFraFiler);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_S_LeggTilBilde";
            this.Text = "frm_S_LeggTilBilde";
            this.Load += new System.EventHandler(this.frm_S_LeggTilBilde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbValgtBilde)).EndInit();
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
    }
}