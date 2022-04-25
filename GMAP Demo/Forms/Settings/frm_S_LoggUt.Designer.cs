namespace GMAP_Demo
{
    partial class frm_S_LoggUt
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
            this.btnLoggUt = new System.Windows.Forms.Button();
            this.gblInnloggetBruker = new System.Windows.Forms.GroupBox();
            this.lblFornavn = new System.Windows.Forms.Label();
            this.lblSikkerhetsklarering = new System.Windows.Forms.Label();
            this.tbFornavn = new System.Windows.Forms.TextBox();
            this.tbSikkerhetsklarering = new System.Windows.Forms.TextBox();
            this.tbEtternavn = new System.Windows.Forms.TextBox();
            this.lblEpost = new System.Windows.Forms.Label();
            this.lblEtternavn = new System.Windows.Forms.Label();
            this.tbEpost = new System.Windows.Forms.TextBox();
            this.tbTelefonnummer = new System.Windows.Forms.TextBox();
            this.lblTelefonnummer = new System.Windows.Forms.Label();
            this.gblInnloggetBruker.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Logg Ut";
            // 
            // btnLoggUt
            // 
            this.btnLoggUt.FlatAppearance.BorderSize = 0;
            this.btnLoggUt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggUt.ForeColor = System.Drawing.Color.Black;
            this.btnLoggUt.Location = new System.Drawing.Point(12, 341);
            this.btnLoggUt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoggUt.Name = "btnLoggUt";
            this.btnLoggUt.Size = new System.Drawing.Size(122, 51);
            this.btnLoggUt.TabIndex = 5;
            this.btnLoggUt.Text = "Logg ut";
            this.btnLoggUt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoggUt.UseVisualStyleBackColor = true;
            this.btnLoggUt.Click += new System.EventHandler(this.btnLoggUt_Click);
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
            this.gblInnloggetBruker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.gblInnloggetBruker.Location = new System.Drawing.Point(12, 71);
            this.gblInnloggetBruker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gblInnloggetBruker.Name = "gblInnloggetBruker";
            this.gblInnloggetBruker.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gblInnloggetBruker.Size = new System.Drawing.Size(299, 266);
            this.gblInnloggetBruker.TabIndex = 17;
            this.gblInnloggetBruker.TabStop = false;
            this.gblInnloggetBruker.Text = "Din brukerinformasjon:";
            // 
            // lblFornavn
            // 
            this.lblFornavn.AutoSize = true;
            this.lblFornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornavn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.lblFornavn.Location = new System.Drawing.Point(5, 18);
            this.lblFornavn.Name = "lblFornavn";
            this.lblFornavn.Size = new System.Drawing.Size(76, 20);
            this.lblFornavn.TabIndex = 6;
            this.lblFornavn.Text = "Fornavn";
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(4, 210);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(170, 20);
            this.lblSikkerhetsklarering.TabIndex = 14;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering";
            // 
            // tbFornavn
            // 
            this.tbFornavn.Location = new System.Drawing.Point(7, 38);
            this.tbFornavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFornavn.Name = "tbFornavn";
            this.tbFornavn.ReadOnly = true;
            this.tbFornavn.Size = new System.Drawing.Size(262, 22);
            this.tbFornavn.TabIndex = 5;
            // 
            // tbSikkerhetsklarering
            // 
            this.tbSikkerhetsklarering.Location = new System.Drawing.Point(6, 230);
            this.tbSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSikkerhetsklarering.Name = "tbSikkerhetsklarering";
            this.tbSikkerhetsklarering.ReadOnly = true;
            this.tbSikkerhetsklarering.Size = new System.Drawing.Size(262, 22);
            this.tbSikkerhetsklarering.TabIndex = 13;
            // 
            // tbEtternavn
            // 
            this.tbEtternavn.Location = new System.Drawing.Point(7, 86);
            this.tbEtternavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEtternavn.Name = "tbEtternavn";
            this.tbEtternavn.ReadOnly = true;
            this.tbEtternavn.Size = new System.Drawing.Size(262, 22);
            this.tbEtternavn.TabIndex = 7;
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.lblEpost.Location = new System.Drawing.Point(5, 162);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(57, 20);
            this.lblEpost.TabIndex = 12;
            this.lblEpost.Text = "Epost";
            // 
            // lblEtternavn
            // 
            this.lblEtternavn.AutoSize = true;
            this.lblEtternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtternavn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.lblEtternavn.Location = new System.Drawing.Point(5, 66);
            this.lblEtternavn.Name = "lblEtternavn";
            this.lblEtternavn.Size = new System.Drawing.Size(89, 20);
            this.lblEtternavn.TabIndex = 8;
            this.lblEtternavn.Text = "Etternavn";
            // 
            // tbEpost
            // 
            this.tbEpost.Location = new System.Drawing.Point(7, 182);
            this.tbEpost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEpost.Name = "tbEpost";
            this.tbEpost.ReadOnly = true;
            this.tbEpost.Size = new System.Drawing.Size(262, 22);
            this.tbEpost.TabIndex = 11;
            // 
            // tbTelefonnummer
            // 
            this.tbTelefonnummer.Location = new System.Drawing.Point(7, 134);
            this.tbTelefonnummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelefonnummer.Name = "tbTelefonnummer";
            this.tbTelefonnummer.ReadOnly = true;
            this.tbTelefonnummer.Size = new System.Drawing.Size(262, 22);
            this.tbTelefonnummer.TabIndex = 9;
            // 
            // lblTelefonnummer
            // 
            this.lblTelefonnummer.AutoSize = true;
            this.lblTelefonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonnummer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.lblTelefonnummer.Location = new System.Drawing.Point(5, 114);
            this.lblTelefonnummer.Name = "lblTelefonnummer";
            this.lblTelefonnummer.Size = new System.Drawing.Size(138, 20);
            this.lblTelefonnummer.TabIndex = 10;
            this.lblTelefonnummer.Text = "Telefonnummer";
            // 
            // frm_S_LoggUt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 825);
            this.Controls.Add(this.gblInnloggetBruker);
            this.Controls.Add(this.btnLoggUt);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_S_LoggUt";
            this.Text = "frm_S_LoggInn";
            this.Load += new System.EventHandler(this.frm_S_LoggUt_Load);
            this.gblInnloggetBruker.ResumeLayout(false);
            this.gblInnloggetBruker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoggUt;
        private System.Windows.Forms.GroupBox gblInnloggetBruker;
        private System.Windows.Forms.Label lblFornavn;
        private System.Windows.Forms.Label lblSikkerhetsklarering;
        private System.Windows.Forms.TextBox tbFornavn;
        private System.Windows.Forms.TextBox tbSikkerhetsklarering;
        private System.Windows.Forms.TextBox tbEtternavn;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.Label lblEtternavn;
        private System.Windows.Forms.TextBox tbEpost;
        private System.Windows.Forms.TextBox tbTelefonnummer;
        private System.Windows.Forms.Label lblTelefonnummer;
    }
}