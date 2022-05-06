namespace GMAP_Demo
{
    partial class Frm_V_Hjelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_V_Hjelp));
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.lblBruker = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.llblOSM = new System.Windows.Forms.LinkLabel();
            this.llblGMAP = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMenu.Location = new System.Drawing.Point(12, 125);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(206, 104);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = resources.GetString("lblMenu.Text");
            // 
            // lblMap
            // 
            this.lblMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMap.Location = new System.Drawing.Point(570, 163);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(386, 143);
            this.lblMap.TabIndex = 1;
            this.lblMap.Text = resources.GetString("lblMap.Text");
            // 
            // lblBruker
            // 
            this.lblBruker.AutoSize = true;
            this.lblBruker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruker.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblBruker.Location = new System.Drawing.Point(12, 80);
            this.lblBruker.Name = "lblBruker";
            this.lblBruker.Size = new System.Drawing.Size(223, 26);
            this.lblBruker.TabIndex = 4;
            this.lblBruker.Text = "\"Label\"s oppdateres med informasjon\r\nknyttet til brukeren du logget inn med.";
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMiddle.Location = new System.Drawing.Point(58, 521);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(209, 65);
            this.lblMiddle.TabIndex = 6;
            this.lblMiddle.Text = "Seksjonen i midten er et \"Panel\"\r\n som viser et eget \"Form\".\r\n\r\n\"Button\"s til ven" +
    "stre kan laste\r\nforskjellige \"Forms\" i dette \"Panel\".";
            // 
            // llblOSM
            // 
            this.llblOSM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llblOSM.AutoSize = true;
            this.llblOSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblOSM.Location = new System.Drawing.Point(618, 430);
            this.llblOSM.Name = "llblOSM";
            this.llblOSM.Size = new System.Drawing.Size(187, 13);
            this.llblOSM.TabIndex = 14;
            this.llblOSM.TabStop = true;
            this.llblOSM.Text = "https://www.openstreetmap.org";
            // 
            // llblGMAP
            // 
            this.llblGMAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llblGMAP.AutoSize = true;
            this.llblGMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblGMAP.Location = new System.Drawing.Point(618, 452);
            this.llblGMAP.Name = "llblGMAP";
            this.llblGMAP.Size = new System.Drawing.Size(253, 13);
            this.llblGMAP.TabIndex = 14;
            this.llblGMAP.TabStop = true;
            this.llblGMAP.Text = "https://github.com/judero01col/GMap.NET";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBruker);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 202);
            this.panel1.TabIndex = 15;
            this.panel1.Click += new System.EventHandler(this.CloseForm);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMenu);
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 454);
            this.panel2.TabIndex = 15;
            this.panel2.Click += new System.EventHandler(this.CloseForm);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.lblMiddle);
            this.panel3.Location = new System.Drawing.Point(238, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 656);
            this.panel3.TabIndex = 15;
            this.panel3.Click += new System.EventHandler(this.CloseForm);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(57, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 26);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "En kort forklaring av oppbyggingen \r\ntil programmet/forms.";
            // 
            // Frm_V_Hjelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(968, 656);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llblGMAP);
            this.Controls.Add(this.llblOSM);
            this.Controls.Add(this.lblMap);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(968, 656);
            this.Name = "Frm_V_Hjelp";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmHjelp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClearData);
            this.Click += new System.EventHandler(this.CloseForm);
            this.Leave += new System.EventHandler(this.CloseForm);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblBruker;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.LinkLabel llblOSM;
        private System.Windows.Forms.LinkLabel llblGMAP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
    }
}