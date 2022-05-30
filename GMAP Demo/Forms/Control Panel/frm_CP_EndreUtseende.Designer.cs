namespace BO22EB16
{
    partial class Frm_CP_EndreUtseende
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbThemes = new System.Windows.Forms.ListBox();
            this.btnSelectTheme = new System.Windows.Forms.Button();
            this.gbUtseende = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gbUtseende.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(260, 37);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Endre Utseende";
            // 
            // lbThemes
            // 
            this.lbThemes.FormattingEnabled = true;
            this.lbThemes.Location = new System.Drawing.Point(5, 18);
            this.lbThemes.Margin = new System.Windows.Forms.Padding(2);
            this.lbThemes.Name = "lbThemes";
            this.lbThemes.Size = new System.Drawing.Size(243, 56);
            this.lbThemes.TabIndex = 5;
            // 
            // btnSelectTheme
            // 
            this.btnSelectTheme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectTheme.Location = new System.Drawing.Point(5, 77);
            this.btnSelectTheme.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectTheme.Name = "btnSelectTheme";
            this.btnSelectTheme.Size = new System.Drawing.Size(107, 23);
            this.btnSelectTheme.TabIndex = 6;
            this.btnSelectTheme.Text = "Endre Utseende";
            this.btnSelectTheme.UseVisualStyleBackColor = true;
            this.btnSelectTheme.Click += new System.EventHandler(this.BtnSelectTheme_Click);
            // 
            // gbUtseende
            // 
            this.gbUtseende.Controls.Add(this.lbThemes);
            this.gbUtseende.Controls.Add(this.btnSelectTheme);
            this.gbUtseende.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbUtseende.Location = new System.Drawing.Point(16, 47);
            this.gbUtseende.Name = "gbUtseende";
            this.gbUtseende.Size = new System.Drawing.Size(253, 105);
            this.gbUtseende.TabIndex = 7;
            this.gbUtseende.TabStop = false;
            this.gbUtseende.Text = "Endre Utseende";
            // 
            // Frm_CP_EndreUtseende
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.Controls.Add(this.gbUtseende);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Frm_CP_EndreUtseende";
            this.Text = "frm_S_LoggInn";
            this.Load += new System.EventHandler(this.Frm_CP_EndeUtseende_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gbUtseende.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox lbThemes;
        private System.Windows.Forms.Button btnSelectTheme;
        private System.Windows.Forms.GroupBox gbUtseende;
    }
}