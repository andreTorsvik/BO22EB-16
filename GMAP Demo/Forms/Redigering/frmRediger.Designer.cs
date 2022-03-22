namespace GMAP_Demo
{
    partial class frmRediger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRediger));
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnTilbake = new System.Windows.Forms.Button();
            this.btnFjern_obj_områ = new System.Windows.Forms.Button();
            this.btnRedigerOmråde = new System.Windows.Forms.Button();
            this.btnRediger_obj_områ = new System.Windows.Forms.Button();
            this.btnOmråde = new System.Windows.Forms.Button();
            this.btnObjekt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnZoomMinus = new System.Windows.Forms.Button();
            this.btnZoomPluss = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.map.TabIndex = 5;
            this.map.Zoom = 0D;
            this.map.OnMapDoubleClick += new GMap.NET.WindowsForms.MapDoubleClick(this.map_MouseDoubleClick);
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(map_OnMarkerClick);
            this.map.OnPolygonClick += new GMap.NET.WindowsForms.PolygonClick(this.map_OnPolygonClick);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlFormLoader.Location = new System.Drawing.Point(237, 0);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(307, 693);
            this.PnlFormLoader.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnTilbake);
            this.panel1.Controls.Add(this.btnFjern_obj_områ);
            this.panel1.Controls.Add(this.btnRedigerOmråde);
            this.panel1.Controls.Add(this.btnRediger_obj_områ);
            this.panel1.Controls.Add(this.btnOmråde);
            this.panel1.Controls.Add(this.btnObjekt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 693);
            this.panel1.TabIndex = 3;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 257);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btnTilbake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTilbake.Location = new System.Drawing.Point(0, 625);
            this.btnTilbake.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTilbake.Name = "btnTilbake";
            this.btnTilbake.Size = new System.Drawing.Size(237, 68);
            this.btnTilbake.TabIndex = 1;
            this.btnTilbake.Text = "Tilbake";
            this.btnTilbake.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTilbake.UseVisualStyleBackColor = true;
            this.btnTilbake.Click += new System.EventHandler(this.btnTilbake_Click);
            // 
            // btnFjern_obj_områ
            // 
            this.btnFjern_obj_områ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFjern_obj_områ.FlatAppearance.BorderSize = 0;
            this.btnFjern_obj_områ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFjern_obj_områ.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFjern_obj_områ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFjern_obj_områ.Location = new System.Drawing.Point(0, 474);
            this.btnFjern_obj_områ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFjern_obj_områ.Name = "btnFjern_obj_områ";
            this.btnFjern_obj_områ.Size = new System.Drawing.Size(237, 68);
            this.btnFjern_obj_områ.TabIndex = 1;
            this.btnFjern_obj_områ.Text = "Fjern obj/område";
            this.btnFjern_obj_områ.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFjern_obj_områ.UseVisualStyleBackColor = true;
            this.btnFjern_obj_områ.Click += new System.EventHandler(this.btnFjern_obj_områ_Click);
            // 
            // btnRedigerOmråde
            // 
            this.btnRedigerOmråde.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRedigerOmråde.FlatAppearance.BorderSize = 0;
            this.btnRedigerOmråde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedigerOmråde.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedigerOmråde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRedigerOmråde.Location = new System.Drawing.Point(0, 406);
            this.btnRedigerOmråde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRedigerOmråde.Name = "btnRedigerOmråde";
            this.btnRedigerOmråde.Size = new System.Drawing.Size(237, 68);
            this.btnRedigerOmråde.TabIndex = 1;
            this.btnRedigerOmråde.Text = "Rediger område";
            this.btnRedigerOmråde.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRedigerOmråde.UseVisualStyleBackColor = true;
            this.btnRedigerOmråde.Click += new System.EventHandler(this.btnRedigerOmråde_Click);
            // 
            // btnRediger_obj_områ
            // 
            this.btnRediger_obj_områ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRediger_obj_områ.FlatAppearance.BorderSize = 0;
            this.btnRediger_obj_områ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRediger_obj_områ.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRediger_obj_områ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRediger_obj_områ.Location = new System.Drawing.Point(0, 338);
            this.btnRediger_obj_områ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRediger_obj_områ.Name = "btnRediger_obj_områ";
            this.btnRediger_obj_områ.Size = new System.Drawing.Size(237, 68);
            this.btnRediger_obj_områ.TabIndex = 1;
            this.btnRediger_obj_områ.Text = "Rediger objekt";
            this.btnRediger_obj_områ.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRediger_obj_områ.UseVisualStyleBackColor = true;
            this.btnRediger_obj_områ.Click += new System.EventHandler(this.btnRediger_obj_områ_Click);
            // 
            // btnOmråde
            // 
            this.btnOmråde.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOmråde.FlatAppearance.BorderSize = 0;
            this.btnOmråde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOmråde.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOmråde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOmråde.Location = new System.Drawing.Point(0, 270);
            this.btnOmråde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOmråde.Name = "btnOmråde";
            this.btnOmråde.Size = new System.Drawing.Size(237, 68);
            this.btnOmråde.TabIndex = 1;
            this.btnOmråde.Text = "Legg til område";
            this.btnOmråde.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOmråde.UseVisualStyleBackColor = true;
            this.btnOmråde.Click += new System.EventHandler(this.btnOmråde_Click);
            // 
            // btnObjekt
            // 
            this.btnObjekt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnObjekt.FlatAppearance.BorderSize = 0;
            this.btnObjekt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjekt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjekt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnObjekt.Location = new System.Drawing.Point(0, 202);
            this.btnObjekt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnObjekt.Name = "btnObjekt";
            this.btnObjekt.Size = new System.Drawing.Size(237, 68);
            this.btnObjekt.TabIndex = 1;
            this.btnObjekt.Text = "Legg til objekt";
            this.btnObjekt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnObjekt.UseVisualStyleBackColor = true;
            this.btnObjekt.Click += new System.EventHandler(this.btnObjekt_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(64, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnZoomMinus
            // 
            this.btnZoomMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btnZoomMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomMinus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZoomMinus.Location = new System.Drawing.Point(1240, 661);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(20, 20);
            this.btnZoomMinus.TabIndex = 7;
            this.btnZoomMinus.Text = "-";
            this.btnZoomMinus.UseVisualStyleBackColor = false;
            this.btnZoomMinus.Click += new System.EventHandler(this.btnZoomMinus_Click);
            // 
            // btnZoomPluss
            // 
            this.btnZoomPluss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomPluss.BackColor = System.Drawing.SystemColors.Control;
            this.btnZoomPluss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomPluss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomPluss.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZoomPluss.Location = new System.Drawing.Point(1240, 635);
            this.btnZoomPluss.Name = "btnZoomPluss";
            this.btnZoomPluss.Size = new System.Drawing.Size(20, 20);
            this.btnZoomPluss.TabIndex = 6;
            this.btnZoomPluss.Text = "+";
            this.btnZoomPluss.UseVisualStyleBackColor = false;
            this.btnZoomPluss.Click += new System.EventHandler(this.btnZoomPluss_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUserName.Location = new System.Drawing.Point(-27, 132);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(286, 20);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "username.username@stud.hvl.no";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRediger
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
            this.MinimumSize = new System.Drawing.Size(968, 653);
            this.Name = "frmRediger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rediger ressurser ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRediger_FormClosing);
            this.Load += new System.EventHandler(this.frmRediger_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnTilbake;
        private System.Windows.Forms.Button btnRedigerOmråde;
        private System.Windows.Forms.Button btnRediger_obj_områ;
        private System.Windows.Forms.Button btnOmråde;
        private System.Windows.Forms.Button btnObjekt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFjern_obj_områ;
        private System.Windows.Forms.Button btnZoomMinus;
        private System.Windows.Forms.Button btnZoomPluss;
        private System.Windows.Forms.Label lblUserName;
    }
}