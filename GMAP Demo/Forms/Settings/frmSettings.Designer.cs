﻿namespace GMAP_Demo
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnTilbake = new System.Windows.Forms.Button();
            this.btnFjernKategori = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnStartPosisjon = new System.Windows.Forms.Button();
            this.btnLoggUt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormLoader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlFormLoader.Location = new System.Drawing.Point(316, 0);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(967, 674);
            this.PnlFormLoader.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnTilbake);
            this.panel1.Controls.Add(this.btnFjernKategori);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnStartPosisjon);
            this.panel1.Controls.Add(this.btnLoggUt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 674);
            this.panel1.TabIndex = 3;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 318);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 1;
            // 
            // btnTilbake
            // 
            this.btnTilbake.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTilbake.FlatAppearance.BorderSize = 0;
            this.btnTilbake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTilbake.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTilbake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.btnTilbake.Location = new System.Drawing.Point(0, 590);
            this.btnTilbake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTilbake.Name = "btnTilbake";
            this.btnTilbake.Size = new System.Drawing.Size(316, 84);
            this.btnTilbake.TabIndex = 1;
            this.btnTilbake.Text = "Tilbake";
            this.btnTilbake.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTilbake.UseVisualStyleBackColor = true;
            this.btnTilbake.Click += new System.EventHandler(this.btnTilbake_Click);
            // 
            // btnFjernKategori
            // 
            this.btnFjernKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFjernKategori.FlatAppearance.BorderSize = 0;
            this.btnFjernKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFjernKategori.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFjernKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.btnFjernKategori.Location = new System.Drawing.Point(0, 252);
            this.btnFjernKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFjernKategori.Name = "btnFjernKategori";
            this.btnFjernKategori.Size = new System.Drawing.Size(316, 84);
            this.btnFjernKategori.TabIndex = 1;
            this.btnFjernKategori.Text = "Fjern kategori";
            this.btnFjernKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFjernKategori.UseVisualStyleBackColor = true;
            this.btnFjernKategori.Click += new System.EventHandler(this.btnBrukerInfo_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.btnAdmin.Location = new System.Drawing.Point(0, 168);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(316, 84);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnStartPosisjon
            // 
            this.btnStartPosisjon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartPosisjon.FlatAppearance.BorderSize = 0;
            this.btnStartPosisjon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPosisjon.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPosisjon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.btnStartPosisjon.Location = new System.Drawing.Point(0, 84);
            this.btnStartPosisjon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartPosisjon.Name = "btnStartPosisjon";
            this.btnStartPosisjon.Size = new System.Drawing.Size(316, 84);
            this.btnStartPosisjon.TabIndex = 1;
            this.btnStartPosisjon.Text = "Start Posisjon";
            this.btnStartPosisjon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStartPosisjon.UseVisualStyleBackColor = true;
            this.btnStartPosisjon.Click += new System.EventHandler(this.btnStartPosisjon_Click);
            // 
            // btnLoggUt
            // 
            this.btnLoggUt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoggUt.FlatAppearance.BorderSize = 0;
            this.btnLoggUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoggUt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggUt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(82)))), ((int)(((byte)(222)))));
            this.btnLoggUt.Location = new System.Drawing.Point(0, 0);
            this.btnLoggUt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoggUt.Name = "btnLoggUt";
            this.btnLoggUt.Size = new System.Drawing.Size(316, 84);
            this.btnLoggUt.TabIndex = 1;
            this.btnLoggUt.Text = "Logg ut";
            this.btnLoggUt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoggUt.UseVisualStyleBackColor = true;
            this.btnLoggUt.Click += new System.EventHandler(this.btnLoggInn_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 674);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1286, 668);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnTilbake;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnStartPosisjon;
        private System.Windows.Forms.Button btnLoggUt;
        private System.Windows.Forms.Button btnFjernKategori;
    }
}