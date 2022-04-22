namespace GMAP_Demo
{
    partial class frm_S_LoggUt
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
            this.btnLoggUt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Logg Ut";
            // 
            // btnLoggUt
            // 
            this.btnLoggUt.FlatAppearance.BorderSize = 0;
            this.btnLoggUt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggUt.ForeColor = System.Drawing.Color.Black;
            this.btnLoggUt.Location = new System.Drawing.Point(24, 95);
            this.btnLoggUt.Name = "btnLoggUt";
            this.btnLoggUt.Size = new System.Drawing.Size(144, 105);
            this.btnLoggUt.TabIndex = 5;
            this.btnLoggUt.Text = "Logg ut";
            this.btnLoggUt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoggUt.UseVisualStyleBackColor = true;
            this.btnLoggUt.Click += new System.EventHandler(this.btnLoggUt_Click);
            // 
            // frm_S_LoggUt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1440, 1031);
            this.Controls.Add(this.btnLoggUt);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_S_LoggUt";
            this.Text = "frm_S_LoggInn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoggUt;
    }
}