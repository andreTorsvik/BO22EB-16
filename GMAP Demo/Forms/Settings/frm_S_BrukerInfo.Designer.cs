namespace GMAP_Demo
{
    partial class frm_S_BrukerInfo
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
            this.lblFornavn = new System.Windows.Forms.Label();
            this.tbFornavn = new System.Windows.Forms.TextBox();
            this.lblEtternavn = new System.Windows.Forms.Label();
            this.tbEtternavn = new System.Windows.Forms.TextBox();
            this.lblTelefonnummer = new System.Windows.Forms.Label();
            this.tbTelefonnummer = new System.Windows.Forms.TextBox();
            this.lblEpost = new System.Windows.Forms.Label();
            this.tbEpost = new System.Windows.Forms.TextBox();
            this.lblSikkerhetsklarering = new System.Windows.Forms.Label();
            this.tbSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.gblInnloggetBruker = new System.Windows.Forms.GroupBox();
            this.gblInnloggetBruker.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bruker info";
            // 
            // lblFornavn
            // 
            this.lblFornavn.AutoSize = true;
            this.lblFornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornavn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblFornavn.Location = new System.Drawing.Point(6, 22);
            this.lblFornavn.Name = "lblFornavn";
            this.lblFornavn.Size = new System.Drawing.Size(67, 17);
            this.lblFornavn.TabIndex = 6;
            this.lblFornavn.Text = "Fornavn";
            // 
            // tbFornavn
            // 
            this.tbFornavn.Location = new System.Drawing.Point(8, 48);
            this.tbFornavn.Name = "tbFornavn";
            this.tbFornavn.ReadOnly = true;
            this.tbFornavn.Size = new System.Drawing.Size(294, 26);
            this.tbFornavn.TabIndex = 5;
            // 
            // lblEtternavn
            // 
            this.lblEtternavn.AutoSize = true;
            this.lblEtternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtternavn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEtternavn.Location = new System.Drawing.Point(6, 82);
            this.lblEtternavn.Name = "lblEtternavn";
            this.lblEtternavn.Size = new System.Drawing.Size(78, 17);
            this.lblEtternavn.TabIndex = 8;
            this.lblEtternavn.Text = "Etternavn";
            // 
            // tbEtternavn
            // 
            this.tbEtternavn.Location = new System.Drawing.Point(8, 108);
            this.tbEtternavn.Name = "tbEtternavn";
            this.tbEtternavn.ReadOnly = true;
            this.tbEtternavn.Size = new System.Drawing.Size(294, 26);
            this.tbEtternavn.TabIndex = 7;
            // 
            // lblTelefonnummer
            // 
            this.lblTelefonnummer.AutoSize = true;
            this.lblTelefonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonnummer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTelefonnummer.Location = new System.Drawing.Point(6, 142);
            this.lblTelefonnummer.Name = "lblTelefonnummer";
            this.lblTelefonnummer.Size = new System.Drawing.Size(120, 17);
            this.lblTelefonnummer.TabIndex = 10;
            this.lblTelefonnummer.Text = "Telefonnummer";
            // 
            // tbTelefonnummer
            // 
            this.tbTelefonnummer.Location = new System.Drawing.Point(8, 168);
            this.tbTelefonnummer.Name = "tbTelefonnummer";
            this.tbTelefonnummer.ReadOnly = true;
            this.tbTelefonnummer.Size = new System.Drawing.Size(294, 26);
            this.tbTelefonnummer.TabIndex = 9;
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEpost.Location = new System.Drawing.Point(6, 202);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(49, 17);
            this.lblEpost.TabIndex = 12;
            this.lblEpost.Text = "Epost";
            // 
            // tbEpost
            // 
            this.tbEpost.Location = new System.Drawing.Point(8, 228);
            this.tbEpost.Name = "tbEpost";
            this.tbEpost.ReadOnly = true;
            this.tbEpost.Size = new System.Drawing.Size(294, 26);
            this.tbEpost.TabIndex = 11;
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(4, 262);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(148, 17);
            this.lblSikkerhetsklarering.TabIndex = 14;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering";
            // 
            // tbSikkerhetsklarering
            // 
            this.tbSikkerhetsklarering.Location = new System.Drawing.Point(7, 288);
            this.tbSikkerhetsklarering.Name = "tbSikkerhetsklarering";
            this.tbSikkerhetsklarering.ReadOnly = true;
            this.tbSikkerhetsklarering.Size = new System.Drawing.Size(294, 26);
            this.tbSikkerhetsklarering.TabIndex = 13;
            // 
            // gblInnloggetBruker
            // 
            this.gblInnloggetBruker.Controls.Add(this.lblFornavn);
            this.gblInnloggetBruker.Controls.Add(this.lblSikkerhetsklarering);
            this.gblInnloggetBruker.Controls.Add(this.tbFornavn);
            this.gblInnloggetBruker.Controls.Add(this.tbSikkerhetsklarering);
            this.gblInnloggetBruker.Controls.Add(this.tbEtternavn);
            this.gblInnloggetBruker.Controls.Add(this.lblEpost);
            this.gblInnloggetBruker.Controls.Add(this.lblEtternavn);
            this.gblInnloggetBruker.Controls.Add(this.tbEpost);
            this.gblInnloggetBruker.Controls.Add(this.tbTelefonnummer);
            this.gblInnloggetBruker.Controls.Add(this.lblTelefonnummer);
            this.gblInnloggetBruker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gblInnloggetBruker.Location = new System.Drawing.Point(21, 70);
            this.gblInnloggetBruker.Name = "gblInnloggetBruker";
            this.gblInnloggetBruker.Size = new System.Drawing.Size(306, 321);
            this.gblInnloggetBruker.TabIndex = 16;
            this.gblInnloggetBruker.TabStop = false;
            this.gblInnloggetBruker.Text = "Din brukerinformasjon:";
            // 
            // frm_S_BrukerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1440, 1031);
            this.Controls.Add(this.gblInnloggetBruker);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_S_BrukerInfo";
            this.Text = "frm_S_BrukerInfo";
            this.gblInnloggetBruker.ResumeLayout(false);
            this.gblInnloggetBruker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFornavn;
        private System.Windows.Forms.TextBox tbFornavn;
        private System.Windows.Forms.Label lblEtternavn;
        private System.Windows.Forms.TextBox tbEtternavn;
        private System.Windows.Forms.Label lblTelefonnummer;
        private System.Windows.Forms.TextBox tbTelefonnummer;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.TextBox tbEpost;
        private System.Windows.Forms.Label lblSikkerhetsklarering;
        private System.Windows.Forms.TextBox tbSikkerhetsklarering;
        private System.Windows.Forms.GroupBox gblInnloggetBruker;
    }
}