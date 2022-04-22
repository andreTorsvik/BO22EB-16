namespace GMAP_Demo
{
    partial class frmVisning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisning));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRediger = new System.Windows.Forms.Button();
            this.btnOppdater = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnPosisjon = new System.Windows.Forms.Button();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.btnZoomPluss = new System.Windows.Forms.Button();
            this.btnZoomMinus = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 311);
            this.panel2.TabIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnHelp.Location = new System.Drawing.Point(4, 5);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(37, 39);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblUserName.Location = new System.Drawing.Point(-40, 202);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(429, 31);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "username.username@stud.hvl.no";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = global::GMAP_Demo.Properties.Resources.icons8_person_64;
            this.pictureBox1.Location = new System.Drawing.Point(98, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 395);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 125);
            this.pnlNav.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnRediger);
            this.panel1.Controls.Add(this.btnOppdater);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnPosisjon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 1055);
            this.panel1.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::GMAP_Demo.Properties.Resources.settings_40px;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(0, 950);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(356, 105);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRediger
            // 
            this.btnRediger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRediger.FlatAppearance.BorderSize = 0;
            this.btnRediger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRediger.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRediger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnRediger.Image = global::GMAP_Demo.Properties.Resources.map_editing_40px;
            this.btnRediger.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRediger.Location = new System.Drawing.Point(0, 626);
            this.btnRediger.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRediger.Name = "btnRediger";
            this.btnRediger.Size = new System.Drawing.Size(356, 105);
            this.btnRediger.TabIndex = 1;
            this.btnRediger.Text = "Rediger";
            this.btnRediger.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRediger.UseVisualStyleBackColor = true;
            this.btnRediger.Click += new System.EventHandler(this.btnRediger_Click);
            // 
            // btnOppdater
            // 
            this.btnOppdater.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOppdater.FlatAppearance.BorderSize = 0;
            this.btnOppdater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOppdater.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOppdater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnOppdater.Image = global::GMAP_Demo.Properties.Resources.refresh_40px;
            this.btnOppdater.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOppdater.Location = new System.Drawing.Point(0, 521);
            this.btnOppdater.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOppdater.Name = "btnOppdater";
            this.btnOppdater.Size = new System.Drawing.Size(356, 105);
            this.btnOppdater.TabIndex = 1;
            this.btnOppdater.Text = "Oppdater Kart";
            this.btnOppdater.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOppdater.UseVisualStyleBackColor = true;
            this.btnOppdater.Click += new System.EventHandler(this.btnOppdater_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnFilter.Image = global::GMAP_Demo.Properties.Resources.filter_40px;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.Location = new System.Drawing.Point(0, 416);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(356, 105);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPosisjon
            // 
            this.btnPosisjon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPosisjon.FlatAppearance.BorderSize = 0;
            this.btnPosisjon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosisjon.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosisjon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnPosisjon.Image = global::GMAP_Demo.Properties.Resources.location_40px;
            this.btnPosisjon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPosisjon.Location = new System.Drawing.Point(0, 311);
            this.btnPosisjon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPosisjon.Name = "btnPosisjon";
            this.btnPosisjon.Size = new System.Drawing.Size(356, 105);
            this.btnPosisjon.TabIndex = 1;
            this.btnPosisjon.Text = "Posisjon";
            this.btnPosisjon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPosisjon.UseVisualStyleBackColor = true;
            this.btnPosisjon.Click += new System.EventHandler(this.btnPoisjon_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlFormLoader.Location = new System.Drawing.Point(356, 0);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(460, 1055);
            this.PnlFormLoader.TabIndex = 1;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(816, 0);
            this.map.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.ViewCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1092, 1055);
            this.map.TabIndex = 2;
            this.map.Zoom = 0D;
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
            this.map.OnPolygonClick += new GMap.NET.WindowsForms.PolygonClick(this.map_OnPolygonClick);
            this.map.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.map_OnMapZoomChanged);
            this.map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseDoubleClick);
            // 
            // btnZoomPluss
            // 
            this.btnZoomPluss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomPluss.BackColor = System.Drawing.SystemColors.Control;
            this.btnZoomPluss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomPluss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomPluss.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZoomPluss.Location = new System.Drawing.Point(824, 941);
            this.btnZoomPluss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZoomPluss.Name = "btnZoomPluss";
            this.btnZoomPluss.Size = new System.Drawing.Size(37, 39);
            this.btnZoomPluss.TabIndex = 0;
            this.btnZoomPluss.Text = "+";
            this.btnZoomPluss.UseVisualStyleBackColor = false;
            this.btnZoomPluss.Click += new System.EventHandler(this.btnZoomPluss_Click);
            // 
            // btnZoomMinus
            // 
            this.btnZoomMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btnZoomMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomMinus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZoomMinus.Location = new System.Drawing.Point(824, 989);
            this.btnZoomMinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(37, 39);
            this.btnZoomMinus.TabIndex = 3;
            this.btnZoomMinus.Text = "-";
            this.btnZoomMinus.UseVisualStyleBackColor = false;
            this.btnZoomMinus.Click += new System.EventHandler(this.btnZoomMinus_Click);
            // 
            // frmVisning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1908, 1055);
            this.Controls.Add(this.btnZoomMinus);
            this.Controls.Add(this.btnZoomPluss);
            this.Controls.Add(this.map);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1444, 979);
            this.Name = "frmVisning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gmap Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPosisjon;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnOppdater;
        private System.Windows.Forms.Button btnRediger;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlFormLoader;
        public GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button btnZoomPluss;
        private System.Windows.Forms.Button btnZoomMinus;
        private System.Windows.Forms.Button btnHelp;
    }
}

