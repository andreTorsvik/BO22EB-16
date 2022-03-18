namespace GMAP_Demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPosisjon = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnOppdater = new System.Windows.Forms.Button();
            this.btnRediger = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 202);
            this.panel2.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUserName.Location = new System.Drawing.Point(-27, 132);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(286, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "username.username@stud.hvl.no";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(65, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 103);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPosisjon
            // 
            this.btnPosisjon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPosisjon.FlatAppearance.BorderSize = 0;
            this.btnPosisjon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosisjon.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosisjon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPosisjon.Location = new System.Drawing.Point(0, 202);
            this.btnPosisjon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPosisjon.Name = "btnPosisjon";
            this.btnPosisjon.Size = new System.Drawing.Size(237, 68);
            this.btnPosisjon.TabIndex = 1;
            this.btnPosisjon.Text = "Posisjon";
            this.btnPosisjon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPosisjon.UseVisualStyleBackColor = true;
            this.btnPosisjon.Click += new System.EventHandler(this.btnPoisjon_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnFilter.Location = new System.Drawing.Point(0, 270);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(237, 68);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnOppdater
            // 
            this.btnOppdater.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOppdater.FlatAppearance.BorderSize = 0;
            this.btnOppdater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOppdater.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOppdater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOppdater.Location = new System.Drawing.Point(0, 338);
            this.btnOppdater.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOppdater.Name = "btnOppdater";
            this.btnOppdater.Size = new System.Drawing.Size(237, 68);
            this.btnOppdater.TabIndex = 1;
            this.btnOppdater.Text = "Oppdater Kart";
            this.btnOppdater.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOppdater.UseVisualStyleBackColor = true;
            this.btnOppdater.Click += new System.EventHandler(this.btnOppdater_Click);
            // 
            // btnRediger
            // 
            this.btnRediger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRediger.FlatAppearance.BorderSize = 0;
            this.btnRediger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRediger.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRediger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRediger.Location = new System.Drawing.Point(0, 406);
            this.btnRediger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRediger.Name = "btnRediger";
            this.btnRediger.Size = new System.Drawing.Size(237, 68);
            this.btnRediger.TabIndex = 1;
            this.btnRediger.Text = "Fjern/rediger";
            this.btnRediger.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRediger.UseVisualStyleBackColor = true;
            this.btnRediger.Click += new System.EventHandler(this.btnRediger_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Location = new System.Drawing.Point(0, 625);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(237, 68);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 257);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(2, 81);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 693);
            this.panel1.TabIndex = 0;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlFormLoader.Location = new System.Drawing.Point(237, 0);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(307, 693);
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
            this.map.Location = new System.Drawing.Point(544, 0);
            this.map.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.map.Size = new System.Drawing.Size(728, 693);
            this.map.TabIndex = 2;
            this.map.Zoom = 0D;
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
            this.map.OnPolygonClick += new GMap.NET.WindowsForms.PolygonClick(this.map_OnPolygonClick);
            this.map.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.map_OnMapZoomChanged);
            this.map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseDoubleClick);
            // 
            // btnZoomPluss
            // 
            this.btnZoomPluss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomPluss.Location = new System.Drawing.Point(1240, 635);
            this.btnZoomPluss.Name = "btnZoomPluss";
            this.btnZoomPluss.Size = new System.Drawing.Size(20, 20);
            this.btnZoomPluss.TabIndex = 0;
            this.btnZoomPluss.Text = "+";
            this.btnZoomPluss.UseVisualStyleBackColor = true;
            this.btnZoomPluss.Click += new System.EventHandler(this.btnZoomPluss_Click);
            // 
            // btnZoomMinus
            // 
            this.btnZoomMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomMinus.Location = new System.Drawing.Point(1240, 661);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(20, 20);
            this.btnZoomMinus.TabIndex = 3;
            this.btnZoomMinus.Text = "-";
            this.btnZoomMinus.UseVisualStyleBackColor = true;
            this.btnZoomMinus.Click += new System.EventHandler(this.btnZoomMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.btnZoomMinus);
            this.Controls.Add(this.btnZoomPluss);
            this.Controls.Add(this.map);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(968, 656);
            this.Name = "Form1";
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
    }
}

