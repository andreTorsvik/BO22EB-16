namespace GMAP_Demo
{
    partial class frmFilter
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
            this.btnRessurs = new System.Windows.Forms.Button();
            this.btnLeggTil = new System.Windows.Forms.Button();
            this.txtAntall = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFjern = new System.Windows.Forms.Button();
            txtInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // btnRessurs
            // 
            this.btnRessurs.Location = new System.Drawing.Point(39, 172);
            this.btnRessurs.Name = "btnRessurs";
            this.btnRessurs.Size = new System.Drawing.Size(113, 45);
            this.btnRessurs.TabIndex = 4;
            this.btnRessurs.Text = "Legg til Markører kartet";
            this.btnRessurs.UseVisualStyleBackColor = true;
            this.btnRessurs.Click += new System.EventHandler(this.btnRessurs_Click);
            // 
            // btnLeggTil
            // 
            this.btnLeggTil.Location = new System.Drawing.Point(39, 119);
            this.btnLeggTil.Name = "btnLeggTil";
            this.btnLeggTil.Size = new System.Drawing.Size(113, 47);
            this.btnLeggTil.TabIndex = 5;
            this.btnLeggTil.Text = "hent ressurs fra database";
            this.btnLeggTil.UseVisualStyleBackColor = true;
            this.btnLeggTil.Click += new System.EventHandler(this.btnLeggTil_Click);
            // 
            // txtAntall
            // 
            this.txtAntall.Location = new System.Drawing.Point(173, 131);
            this.txtAntall.Name = "txtAntall";
            this.txtAntall.Size = new System.Drawing.Size(49, 22);
            this.txtAntall.TabIndex = 6;
            this.txtAntall.TextChanged += new System.EventHandler(this.txtAntall_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(170, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Antall ressurser";
            // 
            // btnFjern
            // 
            this.btnFjern.Location = new System.Drawing.Point(39, 223);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(113, 32);
            this.btnFjern.TabIndex = 8;
            this.btnFjern.Text = "Fjern markør ";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.btnFjern_Click);
            // 
            // txtInfo
            // 
          txtInfo.Location = new System.Drawing.Point(39, 275);
          txtInfo.Multiline = true;
          txtInfo.Name = "txtInfo";
          txtInfo.Size = new System.Drawing.Size(113, 120);
          txtInfo.TabIndex = 9;
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(408, 872);
            this.Controls.Add(txtInfo);
            this.Controls.Add(this.btnFjern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAntall);
            this.Controls.Add(this.btnLeggTil);
            this.Controls.Add(this.btnRessurs);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilter";
            this.Text = "frmFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRessurs;
        private System.Windows.Forms.Button btnLeggTil;
        private System.Windows.Forms.TextBox txtAntall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFjern;
        public static System.Windows.Forms.TextBox txtInfo;
    }
}