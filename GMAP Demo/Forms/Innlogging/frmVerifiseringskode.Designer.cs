﻿namespace BO22EB16
{
    partial class FrmVerifiseringskode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerifiseringskode));
            this.tbKode = new System.Windows.Forms.TextBox();
            this.lblSkrivInn = new System.Windows.Forms.Label();
            this.lblKommetPåMail = new System.Windows.Forms.Label();
            this.btnVerifiser = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.lblSjekkSøppelpost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbKode
            // 
            this.tbKode.Location = new System.Drawing.Point(36, 39);
            this.tbKode.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(158, 20);
            this.tbKode.TabIndex = 0;
            this.tbKode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKode_KeyPress);
            // 
            // lblSkrivInn
            // 
            this.lblSkrivInn.AutoSize = true;
            this.lblSkrivInn.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkrivInn.Location = new System.Drawing.Point(36, 25);
            this.lblSkrivInn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkrivInn.Name = "lblSkrivInn";
            this.lblSkrivInn.Size = new System.Drawing.Size(177, 12);
            this.lblSkrivInn.TabIndex = 1;
            this.lblSkrivInn.Text = "Skriv inn verifiseringskoden:";
            // 
            // lblKommetPåMail
            // 
            this.lblKommetPåMail.AutoSize = true;
            this.lblKommetPåMail.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.lblKommetPåMail.Location = new System.Drawing.Point(36, 92);
            this.lblKommetPåMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKommetPåMail.Name = "lblKommetPåMail";
            this.lblKommetPåMail.Size = new System.Drawing.Size(147, 14);
            this.lblKommetPåMail.TabIndex = 2;
            this.lblKommetPåMail.Text = "Koden har kommet på mail";
            // 
            // btnVerifiser
            // 
            this.btnVerifiser.Location = new System.Drawing.Point(36, 62);
            this.btnVerifiser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnVerifiser.Name = "btnVerifiser";
            this.btnVerifiser.Size = new System.Drawing.Size(65, 20);
            this.btnVerifiser.TabIndex = 4;
            this.btnVerifiser.Text = "Verifiser";
            this.btnVerifiser.UseVisualStyleBackColor = true;
            this.btnVerifiser.Click += new System.EventHandler(this.BtnVerifiser_Click);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(128, 62);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(65, 20);
            this.btnAvbryt.TabIndex = 5;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // lblSjekkSøppelpost
            // 
            this.lblSjekkSøppelpost.AutoSize = true;
            this.lblSjekkSøppelpost.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.lblSjekkSøppelpost.Location = new System.Drawing.Point(36, 105);
            this.lblSjekkSøppelpost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSjekkSøppelpost.Name = "lblSjekkSøppelpost";
            this.lblSjekkSøppelpost.Size = new System.Drawing.Size(108, 14);
            this.lblSjekkSøppelpost.TabIndex = 6;
            this.lblSjekkSøppelpost.Text = "(Sjekk Søppelpost)";
            // 
            // FrmVerifiseringskode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(236, 146);
            this.Controls.Add(this.lblSjekkSøppelpost);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnVerifiser);
            this.Controls.Add(this.lblKommetPåMail);
            this.Controls.Add(this.lblSkrivInn);
            this.Controls.Add(this.tbKode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FrmVerifiseringskode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vertifiseringskode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.Label lblSkrivInn;
        private System.Windows.Forms.Label lblKommetPåMail;
        private System.Windows.Forms.Button btnVerifiser;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label lblSjekkSøppelpost;
    }
}