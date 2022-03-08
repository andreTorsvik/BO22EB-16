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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.map.Location = new System.Drawing.Point(725, 0);
            this.map.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.map.Size = new System.Drawing.Size(971, 897);
            this.map.TabIndex = 5;
            this.map.Zoom = 0D;
            this.map.OnMapDoubleClick += new GMap.NET.WindowsForms.MapDoubleClick(this.map_MouseDoubleClick);
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(map_OnMarkerClick);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlFormLoader.Location = new System.Drawing.Point(316, 0);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(409, 897);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 897);
            this.panel1.TabIndex = 3;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 316);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnTilbake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTilbake.Location = new System.Drawing.Point(0, 813);
            this.btnTilbake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTilbake.Name = "btnTilbake";
            this.btnTilbake.Size = new System.Drawing.Size(316, 84);
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
            this.btnFjern_obj_områ.Location = new System.Drawing.Point(0, 585);
            this.btnFjern_obj_områ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFjern_obj_områ.Name = "btnFjern_obj_områ";
            this.btnFjern_obj_områ.Size = new System.Drawing.Size(316, 84);
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
            this.btnRedigerOmråde.Location = new System.Drawing.Point(0, 501);
            this.btnRedigerOmråde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRedigerOmråde.Name = "btnRedigerOmråde";
            this.btnRedigerOmråde.Size = new System.Drawing.Size(316, 84);
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
            this.btnRediger_obj_områ.Location = new System.Drawing.Point(0, 417);
            this.btnRediger_obj_områ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRediger_obj_områ.Name = "btnRediger_obj_områ";
            this.btnRediger_obj_områ.Size = new System.Drawing.Size(316, 84);
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
            this.btnOmråde.Location = new System.Drawing.Point(0, 333);
            this.btnOmråde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOmråde.Name = "btnOmråde";
            this.btnOmråde.Size = new System.Drawing.Size(316, 84);
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
            this.btnObjekt.Location = new System.Drawing.Point(0, 249);
            this.btnObjekt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObjekt.Name = "btnObjekt";
            this.btnObjekt.Size = new System.Drawing.Size(316, 84);
            this.btnObjekt.TabIndex = 1;
            this.btnObjekt.Text = "Legg til objekt";
            this.btnObjekt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnObjekt.UseVisualStyleBackColor = true;
            this.btnObjekt.Click += new System.EventHandler(this.btnObjekt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 249);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(61, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Some User text here";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(95, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(85, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 127);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmRediger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1696, 897);
            this.Controls.Add(this.map);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1710, 861);
            this.Name = "frmRediger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rediger ressurser ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRediger_FormClosing);
            this.Load += new System.EventHandler(this.frmRediger_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFjern_obj_områ;
    }
}