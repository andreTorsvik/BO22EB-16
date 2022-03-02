namespace GMAP_Demo
{
    partial class frmDatabaseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabaseView));
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.listBoxDatabaseView = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnDbRessursView = new System.Windows.Forms.Button();
            this.btnTilbake = new System.Windows.Forms.Button();
            this.btnDbPunkter_områdeView = new System.Windows.Forms.Button();
            this.btnDbOverlay_RessursView = new System.Windows.Forms.Button();
            this.btnDbOverlay_OmrådeView = new System.Windows.Forms.Button();
            this.btnDbMålingView = new System.Windows.Forms.Button();
            this.btnDbKategorier_BildeView = new System.Windows.Forms.Button();
            this.btnDbBrukerView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlFormLoader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlFormLoader.Controls.Add(this.label1);
            this.PnlFormLoader.Controls.Add(this.listBoxDatabaseView);
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormLoader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlFormLoader.Location = new System.Drawing.Point(237, 0);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(2);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(1027, 681);
            this.PnlFormLoader.TabIndex = 4;
            // 
            // listBoxDatabaseView
            // 
            this.listBoxDatabaseView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDatabaseView.FormattingEnabled = true;
            this.listBoxDatabaseView.Location = new System.Drawing.Point(5, 12);
            this.listBoxDatabaseView.Name = "listBoxDatabaseView";
            this.listBoxDatabaseView.Size = new System.Drawing.Size(1010, 641);
            this.listBoxDatabaseView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnDbRessursView);
            this.panel1.Controls.Add(this.btnTilbake);
            this.panel1.Controls.Add(this.btnDbPunkter_områdeView);
            this.panel1.Controls.Add(this.btnDbOverlay_RessursView);
            this.panel1.Controls.Add(this.btnDbOverlay_OmrådeView);
            this.panel1.Controls.Add(this.btnDbMålingView);
            this.panel1.Controls.Add(this.btnDbKategorier_BildeView);
            this.panel1.Controls.Add(this.btnDbBrukerView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 681);
            this.panel1.TabIndex = 3;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 612);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(2, 68);
            this.pnlNav.TabIndex = 1;
            // 
            // btnDbRessursView
            // 
            this.btnDbRessursView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDbRessursView.FlatAppearance.BorderSize = 0;
            this.btnDbRessursView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbRessursView.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbRessursView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDbRessursView.Location = new System.Drawing.Point(0, 408);
            this.btnDbRessursView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDbRessursView.Name = "btnDbRessursView";
            this.btnDbRessursView.Size = new System.Drawing.Size(237, 68);
            this.btnDbRessursView.TabIndex = 1;
            this.btnDbRessursView.Text = "Ressurs";
            this.btnDbRessursView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDbRessursView.UseVisualStyleBackColor = true;
            this.btnDbRessursView.Click += new System.EventHandler(this.btnDbRessursView_Click);
            // 
            // btnTilbake
            // 
            this.btnTilbake.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTilbake.FlatAppearance.BorderSize = 0;
            this.btnTilbake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTilbake.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTilbake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTilbake.Location = new System.Drawing.Point(0, 613);
            this.btnTilbake.Margin = new System.Windows.Forms.Padding(2);
            this.btnTilbake.Name = "btnTilbake";
            this.btnTilbake.Size = new System.Drawing.Size(237, 68);
            this.btnTilbake.TabIndex = 1;
            this.btnTilbake.Text = "Tilbake";
            this.btnTilbake.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTilbake.UseVisualStyleBackColor = true;
            this.btnTilbake.Click += new System.EventHandler(this.btnTilbake_Click);
            // 
            // btnDbPunkter_områdeView
            // 
            this.btnDbPunkter_områdeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDbPunkter_områdeView.FlatAppearance.BorderSize = 0;
            this.btnDbPunkter_områdeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbPunkter_områdeView.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbPunkter_områdeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDbPunkter_områdeView.Location = new System.Drawing.Point(0, 340);
            this.btnDbPunkter_områdeView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDbPunkter_områdeView.Name = "btnDbPunkter_områdeView";
            this.btnDbPunkter_områdeView.Size = new System.Drawing.Size(237, 68);
            this.btnDbPunkter_områdeView.TabIndex = 1;
            this.btnDbPunkter_områdeView.Text = "Punkter_område";
            this.btnDbPunkter_områdeView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDbPunkter_områdeView.UseVisualStyleBackColor = true;
            this.btnDbPunkter_områdeView.Click += new System.EventHandler(this.btnDbPunkter_områdeView_Click);
            // 
            // btnDbOverlay_RessursView
            // 
            this.btnDbOverlay_RessursView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDbOverlay_RessursView.FlatAppearance.BorderSize = 0;
            this.btnDbOverlay_RessursView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbOverlay_RessursView.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbOverlay_RessursView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDbOverlay_RessursView.Location = new System.Drawing.Point(0, 272);
            this.btnDbOverlay_RessursView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDbOverlay_RessursView.Name = "btnDbOverlay_RessursView";
            this.btnDbOverlay_RessursView.Size = new System.Drawing.Size(237, 68);
            this.btnDbOverlay_RessursView.TabIndex = 1;
            this.btnDbOverlay_RessursView.Text = "Overlay_Ressurs";
            this.btnDbOverlay_RessursView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDbOverlay_RessursView.UseVisualStyleBackColor = true;
            this.btnDbOverlay_RessursView.Click += new System.EventHandler(this.btnDbOverlay_RessursView_Click);
            // 
            // btnDbOverlay_OmrådeView
            // 
            this.btnDbOverlay_OmrådeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDbOverlay_OmrådeView.FlatAppearance.BorderSize = 0;
            this.btnDbOverlay_OmrådeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbOverlay_OmrådeView.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbOverlay_OmrådeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDbOverlay_OmrådeView.Location = new System.Drawing.Point(0, 204);
            this.btnDbOverlay_OmrådeView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDbOverlay_OmrådeView.Name = "btnDbOverlay_OmrådeView";
            this.btnDbOverlay_OmrådeView.Size = new System.Drawing.Size(237, 68);
            this.btnDbOverlay_OmrådeView.TabIndex = 1;
            this.btnDbOverlay_OmrådeView.Text = "Overlay_Område";
            this.btnDbOverlay_OmrådeView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDbOverlay_OmrådeView.UseVisualStyleBackColor = true;
            this.btnDbOverlay_OmrådeView.Click += new System.EventHandler(this.btnDbOverlay_OmrådeView_Click);
            // 
            // btnDbMålingView
            // 
            this.btnDbMålingView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDbMålingView.FlatAppearance.BorderSize = 0;
            this.btnDbMålingView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbMålingView.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbMålingView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDbMålingView.Location = new System.Drawing.Point(0, 136);
            this.btnDbMålingView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDbMålingView.Name = "btnDbMålingView";
            this.btnDbMålingView.Size = new System.Drawing.Size(237, 68);
            this.btnDbMålingView.TabIndex = 1;
            this.btnDbMålingView.Text = "Måling";
            this.btnDbMålingView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDbMålingView.UseVisualStyleBackColor = true;
            this.btnDbMålingView.Click += new System.EventHandler(this.btnDbMålingView_Click);
            // 
            // btnDbKategorier_BildeView
            // 
            this.btnDbKategorier_BildeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDbKategorier_BildeView.FlatAppearance.BorderSize = 0;
            this.btnDbKategorier_BildeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbKategorier_BildeView.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbKategorier_BildeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDbKategorier_BildeView.Location = new System.Drawing.Point(0, 68);
            this.btnDbKategorier_BildeView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDbKategorier_BildeView.Name = "btnDbKategorier_BildeView";
            this.btnDbKategorier_BildeView.Size = new System.Drawing.Size(237, 68);
            this.btnDbKategorier_BildeView.TabIndex = 1;
            this.btnDbKategorier_BildeView.Text = "Kategorier_Bilde";
            this.btnDbKategorier_BildeView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDbKategorier_BildeView.UseVisualStyleBackColor = true;
            this.btnDbKategorier_BildeView.Click += new System.EventHandler(this.btnDbKategorier_BildeView_Click);
            // 
            // btnDbBrukerView
            // 
            this.btnDbBrukerView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDbBrukerView.FlatAppearance.BorderSize = 0;
            this.btnDbBrukerView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbBrukerView.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbBrukerView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDbBrukerView.Location = new System.Drawing.Point(0, 0);
            this.btnDbBrukerView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDbBrukerView.Name = "btnDbBrukerView";
            this.btnDbBrukerView.Size = new System.Drawing.Size(237, 68);
            this.btnDbBrukerView.TabIndex = 1;
            this.btnDbBrukerView.Text = "Bruker";
            this.btnDbBrukerView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDbBrukerView.UseVisualStyleBackColor = true;
            this.btnDbBrukerView.Click += new System.EventHandler(this.btnDbBrukerView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // frmDatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDatabaseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database sjekk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.PnlFormLoader.ResumeLayout(false);
            this.PnlFormLoader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnTilbake;
        private System.Windows.Forms.Button btnDbOverlay_OmrådeView;
        private System.Windows.Forms.Button btnDbMålingView;
        private System.Windows.Forms.Button btnDbKategorier_BildeView;
        private System.Windows.Forms.Button btnDbBrukerView;
        private System.Windows.Forms.Button btnDbPunkter_områdeView;
        private System.Windows.Forms.Button btnDbOverlay_RessursView;
        private System.Windows.Forms.Button btnDbRessursView;
        private System.Windows.Forms.ListBox listBoxDatabaseView;
        private System.Windows.Forms.Label label1;
    }
}