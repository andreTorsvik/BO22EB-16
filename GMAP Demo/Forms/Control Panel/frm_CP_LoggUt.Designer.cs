namespace GMAP_Demo
{
    partial class Frm_CP_LoggUt
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(9, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 37);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Logg Ut";
            // 
            // btnLoggUt
            // 
            this.btnLoggUt.FlatAppearance.BorderSize = 0;
            this.btnLoggUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLoggUt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoggUt.Location = new System.Drawing.Point(9, 277);
            this.btnLoggUt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLoggUt.Name = "btnLoggUt";
            this.btnLoggUt.Size = new System.Drawing.Size(107, 23);
            this.btnLoggUt.TabIndex = 5;
            this.btnLoggUt.Text = "Logg ut";
            this.btnLoggUt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoggUt.UseVisualStyleBackColor = true;
            this.btnLoggUt.Click += new System.EventHandler(this.BtnLoggUt_Click);
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
            this.gblInnloggetBruker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gblInnloggetBruker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gblInnloggetBruker.Location = new System.Drawing.Point(9, 58);
            this.gblInnloggetBruker.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gblInnloggetBruker.Name = "gblInnloggetBruker";
            this.gblInnloggetBruker.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gblInnloggetBruker.Size = new System.Drawing.Size(224, 216);
            this.gblInnloggetBruker.TabIndex = 17;
            this.gblInnloggetBruker.TabStop = false;
            this.gblInnloggetBruker.Text = "Din brukerinformasjon:";
            // 
            // lblFornavn
            // 
            this.lblFornavn.AutoSize = true;
            this.lblFornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFornavn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFornavn.Location = new System.Drawing.Point(4, 14);
            this.lblFornavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFornavn.Name = "lblFornavn";
            this.lblFornavn.Size = new System.Drawing.Size(46, 13);
            this.lblFornavn.TabIndex = 6;
            this.lblFornavn.Text = "Fornavn";
            // 
            // lblSikkerhetsklarering
            // 
            this.lblSikkerhetsklarering.AutoSize = true;
            this.lblSikkerhetsklarering.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSikkerhetsklarering.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSikkerhetsklarering.Location = new System.Drawing.Point(3, 170);
            this.lblSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSikkerhetsklarering.Name = "lblSikkerhetsklarering";
            this.lblSikkerhetsklarering.Size = new System.Drawing.Size(97, 13);
            this.lblSikkerhetsklarering.TabIndex = 14;
            this.lblSikkerhetsklarering.Text = "Sikkerhetsklarering";
            // 
            // tbFornavn
            // 
            this.tbFornavn.Location = new System.Drawing.Point(5, 31);
            this.tbFornavn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbFornavn.Name = "tbFornavn";
            this.tbFornavn.ReadOnly = true;
            this.tbFornavn.Size = new System.Drawing.Size(197, 20);
            this.tbFornavn.TabIndex = 5;
            // 
            // tbSikkerhetsklarering
            // 
            this.tbSikkerhetsklarering.Location = new System.Drawing.Point(5, 187);
            this.tbSikkerhetsklarering.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSikkerhetsklarering.Name = "tbSikkerhetsklarering";
            this.tbSikkerhetsklarering.ReadOnly = true;
            this.tbSikkerhetsklarering.Size = new System.Drawing.Size(197, 20);
            this.tbSikkerhetsklarering.TabIndex = 13;
            // 
            // tbEtternavn
            // 
            this.tbEtternavn.Location = new System.Drawing.Point(5, 70);
            this.tbEtternavn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbEtternavn.Name = "tbEtternavn";
            this.tbEtternavn.ReadOnly = true;
            this.tbEtternavn.Size = new System.Drawing.Size(197, 20);
            this.tbEtternavn.TabIndex = 7;
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEpost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEpost.Location = new System.Drawing.Point(4, 131);
            this.lblEpost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(34, 13);
            this.lblEpost.TabIndex = 12;
            this.lblEpost.Text = "Epost";
            // 
            // lblEtternavn
            // 
            this.lblEtternavn.AutoSize = true;
            this.lblEtternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEtternavn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEtternavn.Location = new System.Drawing.Point(4, 53);
            this.lblEtternavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtternavn.Name = "lblEtternavn";
            this.lblEtternavn.Size = new System.Drawing.Size(53, 13);
            this.lblEtternavn.TabIndex = 8;
            this.lblEtternavn.Text = "Etternavn";
            // 
            // tbEpost
            // 
            this.tbEpost.Location = new System.Drawing.Point(5, 148);
            this.tbEpost.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbEpost.Name = "tbEpost";
            this.tbEpost.ReadOnly = true;
            this.tbEpost.Size = new System.Drawing.Size(197, 20);
            this.tbEpost.TabIndex = 11;
            // 
            // tbTelefonnummer
            // 
            this.tbTelefonnummer.Location = new System.Drawing.Point(5, 109);
            this.tbTelefonnummer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbTelefonnummer.Name = "tbTelefonnummer";
            this.tbTelefonnummer.ReadOnly = true;
            this.tbTelefonnummer.Size = new System.Drawing.Size(197, 20);
            this.tbTelefonnummer.TabIndex = 9;
            // 
            // lblTelefonnummer
            // 
            this.lblTelefonnummer.AutoSize = true;
            this.lblTelefonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTelefonnummer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefonnummer.Location = new System.Drawing.Point(4, 92);
            this.lblTelefonnummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonnummer.Name = "lblTelefonnummer";
            this.lblTelefonnummer.Size = new System.Drawing.Size(80, 13);
            this.lblTelefonnummer.TabIndex = 10;
            this.lblTelefonnummer.Text = "Telefonnummer";
            // 
            // Frm_CP_LoggUt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.Controls.Add(this.gblInnloggetBruker);
            this.Controls.Add(this.btnLoggUt);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Frm_CP_LoggUt";
            this.Text = "frm_S_LoggInn";
            this.Load += new System.EventHandler(this.Frm_S_LoggUt_Load);
            this.gblInnloggetBruker.ResumeLayout(false);
            this.gblInnloggetBruker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
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