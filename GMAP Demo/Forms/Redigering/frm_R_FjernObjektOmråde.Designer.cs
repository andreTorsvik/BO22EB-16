﻿namespace GMAP_Demo
{
    partial class frm_R_FjernObjektOmråde
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
            this.btnSøk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLøpenumemr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnFjern = new System.Windows.Forms.Button();
            this.lableSlettet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fjern";
            // 
            // btnSøk
            // 
            this.btnSøk.Enabled = false;
            this.btnSøk.Location = new System.Drawing.Point(263, 499);
            this.btnSøk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSøk.Name = "btnSøk";
            this.btnSøk.Size = new System.Drawing.Size(117, 35);
            this.btnSøk.TabIndex = 52;
            this.btnSøk.Text = "Søk";
            this.btnSøk.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(18, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Løpenummer";
            // 
            // txtLøpenumemr
            // 
            this.txtLøpenumemr.Location = new System.Drawing.Point(18, 129);
            this.txtLøpenumemr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLøpenumemr.Name = "txtLøpenumemr";
            this.txtLøpenumemr.ReadOnly = true;
            this.txtLøpenumemr.Size = new System.Drawing.Size(77, 26);
            this.txtLøpenumemr.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(18, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Navn";
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(18, 185);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.ReadOnly = true;
            this.txtNavn.Size = new System.Drawing.Size(302, 26);
            this.txtNavn.TabIndex = 54;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(18, 236);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(362, 254);
            this.txtInfo.TabIndex = 53;
            // 
            // btnFjern
            // 
            this.btnFjern.Location = new System.Drawing.Point(18, 499);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(117, 35);
            this.btnFjern.TabIndex = 58;
            this.btnFjern.Text = "Fjern";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.btnFjern_Click);
            // 
            // lableSlettet
            // 
            this.lableSlettet.AutoSize = true;
            this.lableSlettet.ForeColor = System.Drawing.SystemColors.Control;
            this.lableSlettet.Location = new System.Drawing.Point(19, 541);
            this.lableSlettet.Name = "lableSlettet";
            this.lableSlettet.Size = new System.Drawing.Size(56, 20);
            this.lableSlettet.TabIndex = 59;
            this.lableSlettet.Text = "Slettet";
            // 
            // frm_R_FjernObjektOmråde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(440, 1031);
            this.Controls.Add(this.lableSlettet);
            this.Controls.Add(this.btnFjern);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLøpenumemr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNavn);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnSøk);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_R_FjernObjektOmråde";
            this.Text = "frm_R_FjernObjektOmråde";
            this.Load += new System.EventHandler(this.frm_R_FjernObjektOmråde_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSøk;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtLøpenumemr;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNavn;
        public System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnFjern;
        private System.Windows.Forms.Label lableSlettet;
    }
}