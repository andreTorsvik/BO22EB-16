namespace GMAP_Demo
{
    partial class Frm_R_FjernObjektOmråde
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
            this.lblIdOmråde = new System.Windows.Forms.Label();
            this.txtIdOmråde = new System.Windows.Forms.TextBox();
            this.lblNavn = new System.Windows.Forms.Label();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnFjern = new System.Windows.Forms.Button();
            this.lblSlettet = new System.Windows.Forms.Label();
            this.gbObjekt = new System.Windows.Forms.GroupBox();
            this.lblKlikkPåObjektet = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbObjekt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 46);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Fjern";
            // 
            // lblIdOmråde
            // 
            this.lblIdOmråde.AutoSize = true;
            this.lblIdOmråde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIdOmråde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdOmråde.Location = new System.Drawing.Point(5, 46);
            this.lblIdOmråde.Name = "lblIdOmråde";
            this.lblIdOmråde.Size = new System.Drawing.Size(19, 17);
            this.lblIdOmråde.TabIndex = 57;
            this.lblIdOmråde.Text = "Id";
            // 
            // txtIdOmråde
            // 
            this.txtIdOmråde.Location = new System.Drawing.Point(9, 64);
            this.txtIdOmråde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdOmråde.Name = "txtIdOmråde";
            this.txtIdOmråde.ReadOnly = true;
            this.txtIdOmråde.Size = new System.Drawing.Size(69, 23);
            this.txtIdOmråde.TabIndex = 56;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNavn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNavn.Location = new System.Drawing.Point(4, 91);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(41, 17);
            this.lblNavn.TabIndex = 55;
            this.lblNavn.Text = "Navn";
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(9, 110);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.ReadOnly = true;
            this.txtNavn.Size = new System.Drawing.Size(269, 23);
            this.txtNavn.TabIndex = 54;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(9, 155);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(321, 203);
            this.txtInfo.TabIndex = 53;
            // 
            // btnFjern
            // 
            this.btnFjern.Location = new System.Drawing.Point(20, 436);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(143, 28);
            this.btnFjern.TabIndex = 58;
            this.btnFjern.Text = "Fjern";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.BtnFjern_Click);
            // 
            // lblSlettet
            // 
            this.lblSlettet.AutoSize = true;
            this.lblSlettet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSlettet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSlettet.Location = new System.Drawing.Point(17, 466);
            this.lblSlettet.Name = "lblSlettet";
            this.lblSlettet.Size = new System.Drawing.Size(48, 17);
            this.lblSlettet.TabIndex = 59;
            this.lblSlettet.Text = "Slettet";
            // 
            // gbObjekt
            // 
            this.gbObjekt.Controls.Add(this.lblKlikkPåObjektet);
            this.gbObjekt.Controls.Add(this.lblInfo);
            this.gbObjekt.Controls.Add(this.lblIdOmråde);
            this.gbObjekt.Controls.Add(this.txtNavn);
            this.gbObjekt.Controls.Add(this.lblNavn);
            this.gbObjekt.Controls.Add(this.txtInfo);
            this.gbObjekt.Controls.Add(this.txtIdOmråde);
            this.gbObjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbObjekt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbObjekt.Location = new System.Drawing.Point(12, 57);
            this.gbObjekt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbObjekt.Name = "gbObjekt";
            this.gbObjekt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbObjekt.Size = new System.Drawing.Size(360, 372);
            this.gbObjekt.TabIndex = 60;
            this.gbObjekt.TabStop = false;
            this.gbObjekt.Text = "Objekt";
            // 
            // lblKlikkPåObjektet
            // 
            this.lblKlikkPåObjektet.AutoSize = true;
            this.lblKlikkPåObjektet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblKlikkPåObjektet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKlikkPåObjektet.Location = new System.Drawing.Point(4, 18);
            this.lblKlikkPåObjektet.Name = "lblKlikkPåObjektet";
            this.lblKlikkPåObjektet.Size = new System.Drawing.Size(317, 17);
            this.lblKlikkPåObjektet.TabIndex = 61;
            this.lblKlikkPåObjektet.Text = "Klikk på objektet eller område du ønsker å fjerne ";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(5, 137);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(31, 17);
            this.lblInfo.TabIndex = 58;
            this.lblInfo.Text = "Info";
            // 
            // Frm_R_FjernObjektOmråde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(391, 825);
            this.Controls.Add(this.gbObjekt);
            this.Controls.Add(this.lblSlettet);
            this.Controls.Add(this.btnFjern);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_R_FjernObjektOmråde";
            this.Text = "frm_R_FjernObjektOmråde";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_R_FjernObjektOmråde_FormClosing);
            this.gbObjekt.ResumeLayout(false);
            this.gbObjekt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIdOmråde;
        private System.Windows.Forms.TextBox txtIdOmråde;
        private System.Windows.Forms.Label lblNavn;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnFjern;
        private System.Windows.Forms.Label lblSlettet;
        private System.Windows.Forms.GroupBox gbObjekt;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblKlikkPåObjektet;
    }
}