namespace GMAP_Demo
{
    partial class Frm_V_Posisjon
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.lblLand = new System.Windows.Forms.Label();
            this.lblByKommune = new System.Windows.Forms.Label();
            this.txtByKommune = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.btnSøk = new System.Windows.Forms.Button();
            this.tbFra = new System.Windows.Forms.TextBox();
            this.tbTil = new System.Windows.Forms.TextBox();
            this.lblFra = new System.Windows.Forms.Label();
            this.lblTil = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSlutt = new System.Windows.Forms.Button();
            this.btnFinnRute = new System.Windows.Forms.Button();
            this.lblLong = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.btnFjernRute = new System.Windows.Forms.Button();
            this.lblDistanse = new System.Windows.Forms.Label();
            this.gbPosisjon = new System.Windows.Forms.GroupBox();
            this.gbKoordinater = new System.Windows.Forms.GroupBox();
            this.lblBasertPå = new System.Windows.Forms.Label();
            this.gbRute = new System.Windows.Forms.GroupBox();
            this.lblBasertPå2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbPosisjon.SuspendLayout();
            this.gbKoordinater.SuspendLayout();
            this.gbRute.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(146, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Posisjon";
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(7, 32);
            this.txtLand.Margin = new System.Windows.Forms.Padding(2);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(197, 20);
            this.txtLand.TabIndex = 3;
            // 
            // lblLand
            // 
            this.lblLand.AutoSize = true;
            this.lblLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLand.Location = new System.Drawing.Point(4, 15);
            this.lblLand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLand.Name = "lblLand";
            this.lblLand.Size = new System.Drawing.Size(31, 13);
            this.lblLand.TabIndex = 4;
            this.lblLand.Text = "Land";
            // 
            // lblByKommune
            // 
            this.lblByKommune.AutoSize = true;
            this.lblByKommune.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblByKommune.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblByKommune.Location = new System.Drawing.Point(4, 52);
            this.lblByKommune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblByKommune.Name = "lblByKommune";
            this.lblByKommune.Size = new System.Drawing.Size(71, 13);
            this.lblByKommune.TabIndex = 6;
            this.lblByKommune.Text = "By/Kommune";
            // 
            // txtByKommune
            // 
            this.txtByKommune.Location = new System.Drawing.Point(7, 69);
            this.txtByKommune.Margin = new System.Windows.Forms.Padding(2);
            this.txtByKommune.Name = "txtByKommune";
            this.txtByKommune.Size = new System.Drawing.Size(197, 20);
            this.txtByKommune.TabIndex = 5;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAdresse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdresse.Location = new System.Drawing.Point(4, 89);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 8;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(7, 106);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(197, 20);
            this.txtAdresse.TabIndex = 7;
            // 
            // btnSøk
            // 
            this.btnSøk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSøk.Location = new System.Drawing.Point(8, 129);
            this.btnSøk.Margin = new System.Windows.Forms.Padding(2);
            this.btnSøk.Name = "btnSøk";
            this.btnSøk.Size = new System.Drawing.Size(72, 28);
            this.btnSøk.TabIndex = 9;
            this.btnSøk.Text = "Søk";
            this.toolTip1.SetToolTip(this.btnSøk, "Tips: \r\nOfte holder kun adresse\r\n");
            this.btnSøk.UseVisualStyleBackColor = true;
            this.btnSøk.Click += new System.EventHandler(this.BtnSøk_Click);
            // 
            // tbFra
            // 
            this.tbFra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbFra.Location = new System.Drawing.Point(5, 95);
            this.tbFra.Margin = new System.Windows.Forms.Padding(2);
            this.tbFra.Multiline = true;
            this.tbFra.Name = "tbFra";
            this.tbFra.ReadOnly = true;
            this.tbFra.Size = new System.Drawing.Size(107, 88);
            this.tbFra.TabIndex = 10;
            // 
            // tbTil
            // 
            this.tbTil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbTil.Location = new System.Drawing.Point(125, 95);
            this.tbTil.Margin = new System.Windows.Forms.Padding(2);
            this.tbTil.Multiline = true;
            this.tbTil.Name = "tbTil";
            this.tbTil.ReadOnly = true;
            this.tbTil.Size = new System.Drawing.Size(107, 88);
            this.tbTil.TabIndex = 11;
            // 
            // lblFra
            // 
            this.lblFra.AutoSize = true;
            this.lblFra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFra.Location = new System.Drawing.Point(2, 76);
            this.lblFra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFra.Name = "lblFra";
            this.lblFra.Size = new System.Drawing.Size(22, 13);
            this.lblFra.TabIndex = 12;
            this.lblFra.Text = "Fra";
            // 
            // lblTil
            // 
            this.lblTil.AutoSize = true;
            this.lblTil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTil.Location = new System.Drawing.Point(122, 76);
            this.lblTil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTil.Name = "lblTil";
            this.lblTil.Size = new System.Drawing.Size(18, 13);
            this.lblTil.TabIndex = 13;
            this.lblTil.Text = "Til";
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(4, 46);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 28);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Bruk som start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnSlutt
            // 
            this.btnSlutt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSlutt.Location = new System.Drawing.Point(124, 46);
            this.btnSlutt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlutt.Name = "btnSlutt";
            this.btnSlutt.Size = new System.Drawing.Size(87, 28);
            this.btnSlutt.TabIndex = 15;
            this.btnSlutt.Text = "Bruk som Mål";
            this.btnSlutt.UseVisualStyleBackColor = true;
            this.btnSlutt.Click += new System.EventHandler(this.BtnSlutt_Click);
            // 
            // btnFinnRute
            // 
            this.btnFinnRute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinnRute.Location = new System.Drawing.Point(4, 187);
            this.btnFinnRute.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinnRute.Name = "btnFinnRute";
            this.btnFinnRute.Size = new System.Drawing.Size(76, 28);
            this.btnFinnRute.TabIndex = 16;
            this.btnFinnRute.Text = "Finn Rute";
            this.btnFinnRute.UseVisualStyleBackColor = true;
            this.btnFinnRute.Click += new System.EventHandler(this.BtnFinnRute_Click);
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLong.Location = new System.Drawing.Point(4, 71);
            this.lblLong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(31, 13);
            this.lblLong.TabIndex = 20;
            this.lblLong.Text = "Long";
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLong.Location = new System.Drawing.Point(6, 88);
            this.txtLong.Margin = new System.Windows.Forms.Padding(2);
            this.txtLong.Name = "txtLong";
            this.txtLong.ReadOnly = true;
            this.txtLong.Size = new System.Drawing.Size(197, 20);
            this.txtLong.TabIndex = 19;
            this.txtLong.Text = "Dobbelklikk på kart";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLat.Location = new System.Drawing.Point(4, 33);
            this.lblLat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(22, 13);
            this.lblLat.TabIndex = 18;
            this.lblLat.Text = "Lat";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLat.Location = new System.Drawing.Point(7, 50);
            this.txtLat.Margin = new System.Windows.Forms.Padding(2);
            this.txtLat.Name = "txtLat";
            this.txtLat.ReadOnly = true;
            this.txtLat.Size = new System.Drawing.Size(197, 20);
            this.txtLat.TabIndex = 17;
            this.txtLat.Text = "Dobbelklikk på kart";
            // 
            // btnFjernRute
            // 
            this.btnFjernRute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFjernRute.Location = new System.Drawing.Point(124, 187);
            this.btnFjernRute.Margin = new System.Windows.Forms.Padding(2);
            this.btnFjernRute.Name = "btnFjernRute";
            this.btnFjernRute.Size = new System.Drawing.Size(76, 28);
            this.btnFjernRute.TabIndex = 21;
            this.btnFjernRute.Text = "Fjern Rute";
            this.btnFjernRute.UseVisualStyleBackColor = true;
            this.btnFjernRute.Click += new System.EventHandler(this.BtnFjernRute_Click);
            // 
            // lblDistanse
            // 
            this.lblDistanse.AutoSize = true;
            this.lblDistanse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDistanse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDistanse.Location = new System.Drawing.Point(3, 217);
            this.lblDistanse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistanse.Name = "lblDistanse";
            this.lblDistanse.Size = new System.Drawing.Size(77, 13);
            this.lblDistanse.TabIndex = 22;
            this.lblDistanse.Text = "[Distanse i Km]";
            // 
            // gbPosisjon
            // 
            this.gbPosisjon.Controls.Add(this.lblLand);
            this.gbPosisjon.Controls.Add(this.txtLand);
            this.gbPosisjon.Controls.Add(this.txtByKommune);
            this.gbPosisjon.Controls.Add(this.lblByKommune);
            this.gbPosisjon.Controls.Add(this.txtAdresse);
            this.gbPosisjon.Controls.Add(this.lblAdresse);
            this.gbPosisjon.Controls.Add(this.btnSøk);
            this.gbPosisjon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbPosisjon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbPosisjon.Location = new System.Drawing.Point(15, 57);
            this.gbPosisjon.Margin = new System.Windows.Forms.Padding(2);
            this.gbPosisjon.Name = "gbPosisjon";
            this.gbPosisjon.Padding = new System.Windows.Forms.Padding(2);
            this.gbPosisjon.Size = new System.Drawing.Size(236, 162);
            this.gbPosisjon.TabIndex = 23;
            this.gbPosisjon.TabStop = false;
            this.gbPosisjon.Text = "Posisjon";
            this.toolTip1.SetToolTip(this.gbPosisjon, "Tips: \r\nOfte holder kun adresse\r\n");
            // 
            // gbKoordinater
            // 
            this.gbKoordinater.Controls.Add(this.lblBasertPå);
            this.gbKoordinater.Controls.Add(this.lblLat);
            this.gbKoordinater.Controls.Add(this.txtLat);
            this.gbKoordinater.Controls.Add(this.txtLong);
            this.gbKoordinater.Controls.Add(this.lblLong);
            this.gbKoordinater.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbKoordinater.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbKoordinater.Location = new System.Drawing.Point(15, 234);
            this.gbKoordinater.Margin = new System.Windows.Forms.Padding(2);
            this.gbKoordinater.Name = "gbKoordinater";
            this.gbKoordinater.Padding = new System.Windows.Forms.Padding(2);
            this.gbKoordinater.Size = new System.Drawing.Size(236, 113);
            this.gbKoordinater.TabIndex = 24;
            this.gbKoordinater.TabStop = false;
            this.gbKoordinater.Text = "koordinater";
            // 
            // lblBasertPå
            // 
            this.lblBasertPå.AutoSize = true;
            this.lblBasertPå.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblBasertPå.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBasertPå.Location = new System.Drawing.Point(4, 20);
            this.lblBasertPå.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasertPå.Name = "lblBasertPå";
            this.lblBasertPå.Size = new System.Drawing.Size(199, 13);
            this.lblBasertPå.TabIndex = 26;
            this.lblBasertPå.Text = "Basert på dobbelklikk på kartet eller søk ";
            // 
            // gbRute
            // 
            this.gbRute.Controls.Add(this.lblBasertPå2);
            this.gbRute.Controls.Add(this.btnStart);
            this.gbRute.Controls.Add(this.tbFra);
            this.gbRute.Controls.Add(this.tbTil);
            this.gbRute.Controls.Add(this.lblDistanse);
            this.gbRute.Controls.Add(this.lblFra);
            this.gbRute.Controls.Add(this.btnFjernRute);
            this.gbRute.Controls.Add(this.lblTil);
            this.gbRute.Controls.Add(this.btnFinnRute);
            this.gbRute.Controls.Add(this.btnSlutt);
            this.gbRute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbRute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbRute.Location = new System.Drawing.Point(15, 362);
            this.gbRute.Margin = new System.Windows.Forms.Padding(2);
            this.gbRute.Name = "gbRute";
            this.gbRute.Padding = new System.Windows.Forms.Padding(2);
            this.gbRute.Size = new System.Drawing.Size(236, 248);
            this.gbRute.TabIndex = 25;
            this.gbRute.TabStop = false;
            this.gbRute.Text = "Rute";
            // 
            // lblBasertPå2
            // 
            this.lblBasertPå2.AutoSize = true;
            this.lblBasertPå2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblBasertPå2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBasertPå2.Location = new System.Drawing.Point(5, 20);
            this.lblBasertPå2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasertPå2.Name = "lblBasertPå2";
            this.lblBasertPå2.Size = new System.Drawing.Size(199, 13);
            this.lblBasertPå2.TabIndex = 27;
            this.lblBasertPå2.Text = "Basert på dobbelklikk på kartet eller søk ";
            // 
            // Frm_V_Posisjon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(306, 708);
            this.Controls.Add(this.gbRute);
            this.Controls.Add(this.gbKoordinater);
            this.Controls.Add(this.gbPosisjon);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_V_Posisjon";
            this.Text = "frmPosisjon";
            this.gbPosisjon.ResumeLayout(false);
            this.gbPosisjon.PerformLayout();
            this.gbKoordinater.ResumeLayout(false);
            this.gbKoordinater.PerformLayout();
            this.gbRute.ResumeLayout(false);
            this.gbRute.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Label lblLand;
        private System.Windows.Forms.Label lblByKommune;
        private System.Windows.Forms.TextBox txtByKommune;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Button btnSøk;
        private System.Windows.Forms.TextBox tbFra;
        private System.Windows.Forms.TextBox tbTil;
        private System.Windows.Forms.Label lblFra;
        private System.Windows.Forms.Label lblTil;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSlutt;
        private System.Windows.Forms.Button btnFinnRute;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Button btnFjernRute;
        public System.Windows.Forms.TextBox txtLong;
        public System.Windows.Forms.TextBox txtLat;
        public System.Windows.Forms.Label lblDistanse;
        private System.Windows.Forms.GroupBox gbPosisjon;
        private System.Windows.Forms.GroupBox gbKoordinater;
        private System.Windows.Forms.Label lblBasertPå;
        private System.Windows.Forms.GroupBox gbRute;
        private System.Windows.Forms.Label lblBasertPå2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}