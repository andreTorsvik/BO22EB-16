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
            this.btnLVelgBildeFraFiler.Location = new System.Drawing.Point(20, 305);
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
            this.lbTilgjengligKategorier.Location = new System.Drawing.Point(20, 102);
            this.lbTilgjengligKategorier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTilgjengligKategorier.Name = "lbTilgjengligKategorier";
            this.lbTilgjengligKategorier.Size = new System.Drawing.Size(220, 164);
            this.lbTilgjengligKategorier.TabIndex = 64;
            this.lbTilgjengligKategorier.SelectedIndexChanged += new System.EventHandler(this.lbTilgjengligKategorier_SelectedIndexChanged);
            this.lbTilgjengligKategorier.DoubleClick += new System.EventHandler(this.lbTilgjengligKategorier_DoubleClick);
            // 
            // txtValgtKategori
            // 
            this.txtValgtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtValgtKategori.Location = new System.Drawing.Point(250, 103);
            this.txtValgtKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValgtKategori.Name = "txtValgtKategori";
            this.txtValgtKategori.ReadOnly = true;
            this.txtValgtKategori.Size = new System.Drawing.Size(137, 22);
            this.txtValgtKategori.TabIndex = 65;
            // 
            // lblTilgjengeligeKategorier
            // 
            this.lblTilgjengeligeKategorier.AutoSize = true;
            this.lblTilgjengeligeKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilgjengeligeKategorier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTilgjengeligeKategorier.Location = new System.Drawing.Point(16, 79);
            this.lblTilgjengeligeKategorier.Name = "lblTilgjengeligeKategorier";
            this.lblTilgjengeligeKategorier.Size = new System.Drawing.Size(208, 20);
            this.lblTilgjengeligeKategorier.TabIndex = 66;
            this.lblTilgjengeligeKategorier.Text = "Tilgjengelige Kategorier";
            // 
            // lblValgtKategori
            // 
            this.lblValgtKategori.AutoSize = true;
            this.lblValgtKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValgtKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblValgtKategori.Location = new System.Drawing.Point(246, 80);
            this.lblValgtKategori.Name = "lblValgtKategori";
            this.lblValgtKategori.Size = new System.Drawing.Size(128, 20);
            this.lblValgtKategori.TabIndex = 67;
            this.lblValgtKategori.Text = "Valgt Kategori";
            // 
            // pbValgtBilde
            // 
            this.pbValgtBilde.Location = new System.Drawing.Point(25, 397);
            this.pbValgtBilde.Margin = new System.Windows.Forms.Padding(4);
            this.pbValgtBilde.Name = "pbValgtBilde";
            this.pbValgtBilde.Size = new System.Drawing.Size(139, 156);
            this.pbValgtBilde.TabIndex = 68;
            this.pbValgtBilde.TabStop = false;
            // 
            // lblValgtBilde
            // 
            this.lblValgtBilde.AutoSize = true;
            this.lblValgtBilde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValgtBilde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblValgtBilde.Location = new System.Drawing.Point(26, 373);
            this.lblValgtBilde.Name = "lblValgtBilde";
            this.lblValgtBilde.Size = new System.Drawing.Size(101, 20);
            this.lblValgtBilde.TabIndex = 70;
            this.lblValgtBilde.Text = "Valgt Bilde";
            // 
            // lblVelgBilde
            // 
            this.lblVelgBilde.AutoSize = true;
            this.lblVelgBilde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelgBilde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblVelgBilde.Location = new System.Drawing.Point(26, 283);
            this.lblVelgBilde.Name = "lblVelgBilde";
            this.lblVelgBilde.Size = new System.Drawing.Size(95, 20);
            this.lblVelgBilde.TabIndex = 69;
            this.lblVelgBilde.Text = "Velg Bilde";
            // 
            // btnLeggTilIDb
            // 
            this.btnLeggTilIDb.Location = new System.Drawing.Point(20, 601);
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
            this.lblLastOppTilDB.Location = new System.Drawing.Point(16, 577);
            this.lblLastOppTilDB.Name = "lblLastOppTilDB";
            this.lblLastOppTilDB.Size = new System.Drawing.Size(315, 20);
            this.lblLastOppTilDB.TabIndex = 72;
            this.lblLastOppTilDB.Text = "Last opp valgt bilde til valgt kategori";
            // 
            // frm_R_EndreObjektsymbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(391, 825);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_R_EndreObjektsymbol";
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