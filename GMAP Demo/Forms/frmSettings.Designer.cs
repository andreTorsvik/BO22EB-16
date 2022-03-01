namespace GMAP_Demo
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
            this.btnEkstra = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnTilbake = new System.Windows.Forms.Button();
            this.btnDatabaseView = new System.Windows.Forms.Button();
            this.btnBrukerInfo = new System.Windows.Forms.Button();
            this.btnEndreBilde = new System.Windows.Forms.Button();
            this.btnLeggTilBilde = new System.Windows.Forms.Button();
            this.btnStartPosisjon = new System.Windows.Forms.Button();
            this.btnLoggInn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormLoader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlFormLoader.Location = new System.Drawing.Point(237, 0);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(2);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(973, 708);
            this.PnlFormLoader.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnEkstra);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnTilbake);
            this.panel1.Controls.Add(this.btnDatabaseView);
            this.panel1.Controls.Add(this.btnBrukerInfo);
            this.panel1.Controls.Add(this.btnEndreBilde);
            this.panel1.Controls.Add(this.btnLeggTilBilde);
            this.panel1.Controls.Add(this.btnStartPosisjon);
            this.panel1.Controls.Add(this.btnLoggInn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 708);
            this.panel1.TabIndex = 3;
            // 
            // btnEkstra
            // 
            this.btnEkstra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEkstra.FlatAppearance.BorderSize = 0;
            this.btnEkstra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkstra.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkstra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEkstra.Location = new System.Drawing.Point(0, 408);
            this.btnEkstra.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkstra.Name = "btnEkstra";
            this.btnEkstra.Size = new System.Drawing.Size(237, 68);
            this.btnEkstra.TabIndex = 2;
            this.btnEkstra.Text = "Hvis vi trenger mer";
            this.btnEkstra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEkstra.UseVisualStyleBackColor = true;
            this.btnEkstra.Click += new System.EventHandler(this.btnEkstra_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 258);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(2, 81);
            this.pnlNav.TabIndex = 1;
            // 
            // btnTilbake
            // 
            this.btnTilbake.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTilbake.FlatAppearance.BorderSize = 0;
            this.btnTilbake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTilbake.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTilbake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTilbake.Location = new System.Drawing.Point(0, 640);
            this.btnTilbake.Margin = new System.Windows.Forms.Padding(2);
            this.btnTilbake.Name = "btnTilbake";
            this.btnTilbake.Size = new System.Drawing.Size(237, 68);
            this.btnTilbake.TabIndex = 1;
            this.btnTilbake.Text = "Tilbake";
            this.btnTilbake.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTilbake.UseVisualStyleBackColor = true;
            this.btnTilbake.Click += new System.EventHandler(this.btnTilbake_Click);
            // 
            // btnDatabaseView
            // 
            this.btnDatabaseView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatabaseView.FlatAppearance.BorderSize = 0;
            this.btnDatabaseView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatabaseView.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatabaseView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDatabaseView.Location = new System.Drawing.Point(0, 340);
            this.btnDatabaseView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatabaseView.Name = "btnDatabaseView";
            this.btnDatabaseView.Size = new System.Drawing.Size(237, 68);
            this.btnDatabaseView.TabIndex = 1;
            this.btnDatabaseView.Text = "Database sjekk";
            this.btnDatabaseView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDatabaseView.UseVisualStyleBackColor = true;
            this.btnDatabaseView.Click += new System.EventHandler(this.btnDatabaseView_Click);
            // 
            // btnBrukerInfo
            // 
            this.btnBrukerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrukerInfo.FlatAppearance.BorderSize = 0;
            this.btnBrukerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrukerInfo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrukerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBrukerInfo.Location = new System.Drawing.Point(0, 272);
            this.btnBrukerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrukerInfo.Name = "btnBrukerInfo";
            this.btnBrukerInfo.Size = new System.Drawing.Size(237, 68);
            this.btnBrukerInfo.TabIndex = 1;
            this.btnBrukerInfo.Text = "Bruker info";
            this.btnBrukerInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBrukerInfo.UseVisualStyleBackColor = true;
            this.btnBrukerInfo.Click += new System.EventHandler(this.btnBrukerInfo_Click);
            // 
            // btnEndreBilde
            // 
            this.btnEndreBilde.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEndreBilde.FlatAppearance.BorderSize = 0;
            this.btnEndreBilde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndreBilde.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndreBilde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEndreBilde.Location = new System.Drawing.Point(0, 204);
            this.btnEndreBilde.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndreBilde.Name = "btnEndreBilde";
            this.btnEndreBilde.Size = new System.Drawing.Size(237, 68);
            this.btnEndreBilde.TabIndex = 1;
            this.btnEndreBilde.Text = "Endre lagret bilde";
            this.btnEndreBilde.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEndreBilde.UseVisualStyleBackColor = true;
            this.btnEndreBilde.Click += new System.EventHandler(this.btnEndreBilde_Click);
            // 
            // btnLeggTilBilde
            // 
            this.btnLeggTilBilde.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeggTilBilde.FlatAppearance.BorderSize = 0;
            this.btnLeggTilBilde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeggTilBilde.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeggTilBilde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLeggTilBilde.Location = new System.Drawing.Point(0, 136);
            this.btnLeggTilBilde.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeggTilBilde.Name = "btnLeggTilBilde";
            this.btnLeggTilBilde.Size = new System.Drawing.Size(237, 68);
            this.btnLeggTilBilde.TabIndex = 1;
            this.btnLeggTilBilde.Text = "Legg til Bilde";
            this.btnLeggTilBilde.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLeggTilBilde.UseVisualStyleBackColor = true;
            this.btnLeggTilBilde.Click += new System.EventHandler(this.btnLeggTilBilde_Click);
            // 
            // btnStartPosisjon
            // 
            this.btnStartPosisjon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartPosisjon.FlatAppearance.BorderSize = 0;
            this.btnStartPosisjon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPosisjon.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPosisjon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStartPosisjon.Location = new System.Drawing.Point(0, 68);
            this.btnStartPosisjon.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartPosisjon.Name = "btnStartPosisjon";
            this.btnStartPosisjon.Size = new System.Drawing.Size(237, 68);
            this.btnStartPosisjon.TabIndex = 1;
            this.btnStartPosisjon.Text = "Start Posisjon ";
            this.btnStartPosisjon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStartPosisjon.UseVisualStyleBackColor = true;
            this.btnStartPosisjon.Click += new System.EventHandler(this.btnStartPosisjon_Click);
            // 
            // btnLoggInn
            // 
            this.btnLoggInn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoggInn.FlatAppearance.BorderSize = 0;
            this.btnLoggInn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoggInn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggInn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLoggInn.Location = new System.Drawing.Point(0, 0);
            this.btnLoggInn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoggInn.Name = "btnLoggInn";
            this.btnLoggInn.Size = new System.Drawing.Size(237, 68);
            this.btnLoggInn.TabIndex = 1;
            this.btnLoggInn.Text = "Logg inn/endre bruker";
            this.btnLoggInn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoggInn.UseVisualStyleBackColor = true;
            this.btnLoggInn.Click += new System.EventHandler(this.btnLoggInn_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 708);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnTilbake;
        private System.Windows.Forms.Button btnEndreBilde;
        private System.Windows.Forms.Button btnLeggTilBilde;
        private System.Windows.Forms.Button btnStartPosisjon;
        private System.Windows.Forms.Button btnLoggInn;
        private System.Windows.Forms.Button btnDatabaseView;
        private System.Windows.Forms.Button btnBrukerInfo;
        private System.Windows.Forms.Button btnEkstra;
    }
}