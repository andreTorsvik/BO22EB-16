namespace GMAP_Demo
{
    partial class frm_S_Admin
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
            this.lbVenterPåGodkjenning = new System.Windows.Forms.ListBox();
            this.btnGodta = new System.Windows.Forms.Button();
            this.btnAvslå = new System.Windows.Forms.Button();
            this.BtnNedgrader = new System.Windows.Forms.Button();
            this.btnOppgrader = new System.Windows.Forms.Button();
            this.lbListeOverbrukere = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admin";
            // 
            // lbVenterPåGodkjenning
            // 
            this.lbVenterPåGodkjenning.FormattingEnabled = true;
            this.lbVenterPåGodkjenning.ItemHeight = 20;
            this.lbVenterPåGodkjenning.Location = new System.Drawing.Point(88, 114);
            this.lbVenterPåGodkjenning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbVenterPåGodkjenning.Name = "lbVenterPåGodkjenning";
            this.lbVenterPåGodkjenning.Size = new System.Drawing.Size(558, 244);
            this.lbVenterPåGodkjenning.TabIndex = 5;
            // 
            // btnGodta
            // 
            this.btnGodta.Location = new System.Drawing.Point(658, 114);
            this.btnGodta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGodta.Name = "btnGodta";
            this.btnGodta.Size = new System.Drawing.Size(160, 36);
            this.btnGodta.TabIndex = 6;
            this.btnGodta.Text = "Godta";
            this.btnGodta.UseVisualStyleBackColor = true;
            this.btnGodta.Click += new System.EventHandler(this.btnGodta_Click);
            // 
            // btnAvslå
            // 
            this.btnAvslå.Location = new System.Drawing.Point(658, 158);
            this.btnAvslå.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAvslå.Name = "btnAvslå";
            this.btnAvslå.Size = new System.Drawing.Size(160, 36);
            this.btnAvslå.TabIndex = 7;
            this.btnAvslå.Text = "Avslå";
            this.btnAvslå.UseVisualStyleBackColor = true;
            this.btnAvslå.Click += new System.EventHandler(this.btnAvslå_Click);
            // 
            // BtnNedgrader
            // 
            this.BtnNedgrader.Location = new System.Drawing.Point(658, 445);
            this.BtnNedgrader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNedgrader.Name = "BtnNedgrader";
            this.BtnNedgrader.Size = new System.Drawing.Size(160, 36);
            this.BtnNedgrader.TabIndex = 10;
            this.BtnNedgrader.Text = "Nedgrader";
            this.BtnNedgrader.UseVisualStyleBackColor = true;
            this.BtnNedgrader.Click += new System.EventHandler(this.BtnNedgrader_Click);
            // 
            // btnOppgrader
            // 
            this.btnOppgrader.Location = new System.Drawing.Point(658, 401);
            this.btnOppgrader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOppgrader.Name = "btnOppgrader";
            this.btnOppgrader.Size = new System.Drawing.Size(160, 36);
            this.btnOppgrader.TabIndex = 9;
            this.btnOppgrader.Text = "Oppgrader";
            this.btnOppgrader.UseVisualStyleBackColor = true;
            this.btnOppgrader.Click += new System.EventHandler(this.btnOppgrader_Click);
            // 
            // lbListeOverbrukere
            // 
            this.lbListeOverbrukere.FormattingEnabled = true;
            this.lbListeOverbrukere.ItemHeight = 20;
            this.lbListeOverbrukere.Location = new System.Drawing.Point(88, 401);
            this.lbListeOverbrukere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbListeOverbrukere.Name = "lbListeOverbrukere";
            this.lbListeOverbrukere.Size = new System.Drawing.Size(558, 244);
            this.lbListeOverbrukere.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(84, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Venter på Godkjenning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.label2.Location = new System.Drawing.Point(84, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lister over brukere, og sikkerhetsklarering";
            // 
            // frm_S_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1440, 1031);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNedgrader);
            this.Controls.Add(this.btnOppgrader);
            this.Controls.Add(this.lbListeOverbrukere);
            this.Controls.Add(this.btnAvslå);
            this.Controls.Add(this.btnGodta);
            this.Controls.Add(this.lbVenterPåGodkjenning);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_S_Admin";
            this.Text = "frm_S_EndreLagretBilde";
            this.Load += new System.EventHandler(this.frm_S_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbVenterPåGodkjenning;
        private System.Windows.Forms.Button btnGodta;
        private System.Windows.Forms.Button btnAvslå;
        private System.Windows.Forms.Button BtnNedgrader;
        private System.Windows.Forms.Button btnOppgrader;
        private System.Windows.Forms.ListBox lbListeOverbrukere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}