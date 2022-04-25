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
            this.label3 = new System.Windows.Forms.Label();
            this.lbTilgjengligKategorier = new System.Windows.Forms.ListBox();
            this.txtValgtKategori = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFjern = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fjern Ubrukte Kategorier";
            // 
            // lbTilgjengligKategorier
            // 
            this.lbTilgjengligKategorier.FormattingEnabled = true;
            this.lbTilgjengligKategorier.ItemHeight = 16;
            this.lbTilgjengligKategorier.Location = new System.Drawing.Point(16, 104);
            this.lbTilgjengligKategorier.Name = "lbTilgjengligKategorier";
            this.lbTilgjengligKategorier.Size = new System.Drawing.Size(290, 212);
            this.lbTilgjengligKategorier.TabIndex = 5;
            this.lbTilgjengligKategorier.DoubleClick += new System.EventHandler(this.lbKategorier_DoubleClick);
            // 
            // txtValgtKategori
            // 
            this.txtValgtKategori.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtValgtKategori.Location = new System.Drawing.Point(324, 104);
            this.txtValgtKategori.Name = "txtValgtKategori";
            this.txtValgtKategori.Size = new System.Drawing.Size(163, 22);
            this.txtValgtKategori.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFjern);
            this.groupBox1.Controls.Add(this.txtValgtKategori);
            this.groupBox1.Controls.Add(this.lbTilgjengligKategorier);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(4, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 344);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fjern Kategori";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(13, 32);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(70, 16);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = "Bruker info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valgt kategorier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Slettbare kategorier";
            // 
            // btnFjern
            // 
            this.btnFjern.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFjern.Location = new System.Drawing.Point(324, 132);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(93, 31);
            this.btnFjern.TabIndex = 7;
            this.btnFjern.Text = "Fjern";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.btnFjern_Click);
            // 
            // frm_S_FjernKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 825);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_S_FjernKategori";
            this.Text = "frm_S_BrukerInfo";
            this.Load += new System.EventHandler(this.frm_S_BrukerInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTilgjengligKategorier;
        private System.Windows.Forms.TextBox txtValgtKategori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFjern;
        private System.Windows.Forms.Label labelInfo;
    }
}