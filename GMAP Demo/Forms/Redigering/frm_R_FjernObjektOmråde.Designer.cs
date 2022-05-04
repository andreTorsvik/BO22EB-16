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
            this.lblLøpenummer = new System.Windows.Forms.Label();
            this.txtLøpenumemr = new System.Windows.Forms.TextBox();
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
            // lblLøpenummer
            // 
            this.lblLøpenummer.AutoSize = true;
            this.lblLøpenummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLøpenummer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblLøpenummer.Location = new System.Drawing.Point(8, 43);
            this.lblLøpenummer.Name = "lblLøpenummer";
            this.lblLøpenummer.Size = new System.Drawing.Size(117, 20);
            this.lblLøpenummer.TabIndex = 57;
            this.lblLøpenummer.Text = "Løpenummer";
            // 
            // txtLøpenumemr
            // 
            this.txtLøpenumemr.Location = new System.Drawing.Point(8, 64);
            this.txtLøpenumemr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLøpenumemr.Name = "txtLøpenumemr";
            this.txtLøpenumemr.ReadOnly = true;
            this.txtLøpenumemr.Size = new System.Drawing.Size(69, 22);
            this.txtLøpenumemr.TabIndex = 56;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblNavn.Location = new System.Drawing.Point(8, 88);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(51, 20);
            this.lblNavn.TabIndex = 55;
            this.lblNavn.Text = "Navn";
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(8, 110);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.ReadOnly = true;
            this.txtNavn.Size = new System.Drawing.Size(269, 22);
            this.txtNavn.TabIndex = 54;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(8, 155);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(321, 203);
            this.txtInfo.TabIndex = 53;
            // 
            // btnFjern
            // 
            this.btnFjern.Location = new System.Drawing.Point(20, 434);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(104, 28);
            this.btnFjern.TabIndex = 58;
            this.btnFjern.Text = "Fjern";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.BtnFjern_Click);
            // 
            // lblSlettet
            // 
            this.lblSlettet.AutoSize = true;
            this.lblSlettet.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSlettet.Location = new System.Drawing.Point(21, 466);
            this.lblSlettet.Name = "lblSlettet";
            this.lblSlettet.Size = new System.Drawing.Size(44, 16);
            this.lblSlettet.TabIndex = 59;
            this.lblSlettet.Text = "Slettet";
            // 
            // gbObjekt
            // 
            this.gbObjekt.Controls.Add(this.lblKlikkPåObjektet);
            this.gbObjekt.Controls.Add(this.lblInfo);
            this.gbObjekt.Controls.Add(this.lblLøpenummer);
            this.gbObjekt.Controls.Add(this.txtNavn);
            this.gbObjekt.Controls.Add(this.lblNavn);
            this.gbObjekt.Controls.Add(this.txtInfo);
            this.gbObjekt.Controls.Add(this.txtLøpenumemr);
            this.gbObjekt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
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
            this.lblKlikkPåObjektet.ForeColor = System.Drawing.Color.Silver;
            this.lblKlikkPåObjektet.Location = new System.Drawing.Point(9, 17);
            this.lblKlikkPåObjektet.Name = "lblKlikkPåObjektet";
            this.lblKlikkPåObjektet.Size = new System.Drawing.Size(296, 16);
            this.lblKlikkPåObjektet.TabIndex = 61;
            this.lblKlikkPåObjektet.Text = "Klikk på objektet eller område du ønsker å fjerne ";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(8, 134);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(40, 20);
            this.lblInfo.TabIndex = 58;
            this.lblInfo.Text = "Info";
            // 
            // Frm_R_FjernObjektOmråde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Label lblLøpenummer;
        private System.Windows.Forms.TextBox txtLøpenumemr;
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