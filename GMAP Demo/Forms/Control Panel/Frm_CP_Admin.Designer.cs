namespace GMAP_Demo
{
    partial class Frm_CP_Admin
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
            this.lbVenterPåGodkjenning = new System.Windows.Forms.ListBox();
            this.btnGodta = new System.Windows.Forms.Button();
            this.btnAvslå = new System.Windows.Forms.Button();
            this.btnNedgrader = new System.Windows.Forms.Button();
            this.btnOppgrader = new System.Windows.Forms.Button();
            this.lbListeOverbrukere = new System.Windows.Forms.ListBox();
            this.lblVenterGodkjenning = new System.Windows.Forms.Label();
            this.lblListeOverBrukere = new System.Windows.Forms.Label();
            this.btnFjern = new System.Windows.Forms.Button();
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
            this.lblTitle.Size = new System.Drawing.Size(114, 37);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Admin";
            // 
            // lbVenterPåGodkjenning
            // 
            this.lbVenterPåGodkjenning.FormattingEnabled = true;
            this.lbVenterPåGodkjenning.Location = new System.Drawing.Point(59, 74);
            this.lbVenterPåGodkjenning.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbVenterPåGodkjenning.Name = "lbVenterPåGodkjenning";
            this.lbVenterPåGodkjenning.Size = new System.Drawing.Size(373, 160);
            this.lbVenterPåGodkjenning.Sorted = true;
            this.lbVenterPåGodkjenning.TabIndex = 5;
            // 
            // btnGodta
            // 
            this.btnGodta.Location = new System.Drawing.Point(439, 74);
            this.btnGodta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGodta.Name = "btnGodta";
            this.btnGodta.Size = new System.Drawing.Size(107, 23);
            this.btnGodta.TabIndex = 6;
            this.btnGodta.Text = "Godta";
            this.btnGodta.UseVisualStyleBackColor = true;
            this.btnGodta.Click += new System.EventHandler(this.btnGodta_Click);
            // 
            // btnAvslå
            // 
            this.btnAvslå.Location = new System.Drawing.Point(439, 103);
            this.btnAvslå.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAvslå.Name = "btnAvslå";
            this.btnAvslå.Size = new System.Drawing.Size(107, 23);
            this.btnAvslå.TabIndex = 7;
            this.btnAvslå.Text = "Avslå";
            this.btnAvslå.UseVisualStyleBackColor = true;
            this.btnAvslå.Click += new System.EventHandler(this.BtnAvslå_Click);
            // 
            // btnNedgrader
            // 
            this.btnNedgrader.Location = new System.Drawing.Point(439, 289);
            this.btnNedgrader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNedgrader.Name = "btnNedgrader";
            this.btnNedgrader.Size = new System.Drawing.Size(107, 23);
            this.btnNedgrader.TabIndex = 10;
            this.btnNedgrader.Text = "Nedgrader";
            this.btnNedgrader.UseVisualStyleBackColor = true;
            this.btnNedgrader.Click += new System.EventHandler(this.BtnNedgrader_Click);
            // 
            // btnOppgrader
            // 
            this.btnOppgrader.Location = new System.Drawing.Point(439, 261);
            this.btnOppgrader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOppgrader.Name = "btnOppgrader";
            this.btnOppgrader.Size = new System.Drawing.Size(107, 23);
            this.btnOppgrader.TabIndex = 9;
            this.btnOppgrader.Text = "Oppgrader";
            this.btnOppgrader.UseVisualStyleBackColor = true;
            this.btnOppgrader.Click += new System.EventHandler(this.BtnOppgrader_Click);
            // 
            // lbListeOverbrukere
            // 
            this.lbListeOverbrukere.FormattingEnabled = true;
            this.lbListeOverbrukere.Location = new System.Drawing.Point(59, 261);
            this.lbListeOverbrukere.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbListeOverbrukere.Name = "lbListeOverbrukere";
            this.lbListeOverbrukere.Size = new System.Drawing.Size(373, 160);
            this.lbListeOverbrukere.Sorted = true;
            this.lbListeOverbrukere.TabIndex = 8;
            // 
            // lblVenterGodkjenning
            // 
            this.lblVenterGodkjenning.AutoSize = true;
            this.lblVenterGodkjenning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVenterGodkjenning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVenterGodkjenning.Location = new System.Drawing.Point(56, 58);
            this.lblVenterGodkjenning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenterGodkjenning.Name = "lblVenterGodkjenning";
            this.lblVenterGodkjenning.Size = new System.Drawing.Size(116, 13);
            this.lblVenterGodkjenning.TabIndex = 11;
            this.lblVenterGodkjenning.Text = "Venter på Godkjenning";
            // 
            // lblListeOverBrukere
            // 
            this.lblListeOverBrukere.AutoSize = true;
            this.lblListeOverBrukere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblListeOverBrukere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblListeOverBrukere.Location = new System.Drawing.Point(56, 246);
            this.lblListeOverBrukere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListeOverBrukere.Name = "lblListeOverBrukere";
            this.lblListeOverBrukere.Size = new System.Drawing.Size(204, 13);
            this.lblListeOverBrukere.TabIndex = 12;
            this.lblListeOverBrukere.Text = "Lister over brukere, og sikkerhetsklarering";
            // 
            // btnFjern
            // 
            this.btnFjern.Location = new System.Drawing.Point(439, 396);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(107, 23);
            this.btnFjern.TabIndex = 10;
            this.btnFjern.Text = "Fjern";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.BtnFjern_Click);
            // 
            // Frm_CP_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.Controls.Add(this.lblListeOverBrukere);
            this.Controls.Add(this.lblVenterGodkjenning);
            this.Controls.Add(this.btnFjern);
            this.Controls.Add(this.btnNedgrader);
            this.Controls.Add(this.btnOppgrader);
            this.Controls.Add(this.lbListeOverbrukere);
            this.Controls.Add(this.btnAvslå);
            this.Controls.Add(this.btnGodta);
            this.Controls.Add(this.lbVenterPåGodkjenning);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm_CP_Admin";
            this.Text = "frm_S_EndreLagretBilde";
            this.Load += new System.EventHandler(this.Frm_S_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lbVenterPåGodkjenning;
        private System.Windows.Forms.Button btnGodta;
        private System.Windows.Forms.Button btnAvslå;
        private System.Windows.Forms.Button btnNedgrader;
        private System.Windows.Forms.Button btnOppgrader;
        private System.Windows.Forms.ListBox lbListeOverbrukere;
        private System.Windows.Forms.Label lblVenterGodkjenning;
        private System.Windows.Forms.Label lblListeOverBrukere;
        private System.Windows.Forms.Button btnFjern;
    }
}