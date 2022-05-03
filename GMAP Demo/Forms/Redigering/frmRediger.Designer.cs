﻿namespace GMAP_Demo
{
    partial class FrmRediger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRediger));
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnTilbake = new System.Windows.Forms.Button();
            this.btnFjern = new System.Windows.Forms.Button();
            this.btnLeggTilBilde = new System.Windows.Forms.Button();
            this.btnRedigerOmråde = new System.Windows.Forms.Button();
            this.btnRediger_objekt = new System.Windows.Forms.Button();
            this.btnLeggTilOmråde = new System.Windows.Forms.Button();
            this.btnLeggTilObjekt = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.cbOmråde = new System.Windows.Forms.CheckBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnZoomMinus = new System.Windows.Forms.Button();
            this.btnZoomPluss = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlUser.SuspendLayout();
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
            this.map.Size = new System.Drawing.Size(1722, 1384);
            this.map.TabIndex = 5;
            this.map.Zoom = 0D;
            this.map.OnMapDoubleClick += new GMap.NET.WindowsForms.MapDoubleClick(this.map_MouseDoubleClick);
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
            this.map.OnPolygonClick += new GMap.NET.WindowsForms.PolygonClick(this.map_OnPolygonClick);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlFormLoader.Location = new System.Drawing.Point(356, 0);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(460, 1384);
            this.PnlFormLoader.TabIndex = 4;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.pnlNav);
            this.pnlMenu.Controls.Add(this.btnTilbake);
            this.pnlMenu.Controls.Add(this.btnFjern);
            this.pnlMenu.Controls.Add(this.btnLeggTilBilde);
            this.pnlMenu.Controls.Add(this.btnRedigerOmråde);
            this.pnlMenu.Controls.Add(this.btnRediger_objekt);
            this.pnlMenu.Controls.Add(this.btnLeggTilOmråde);
            this.pnlMenu.Controls.Add(this.btnLeggTilObjekt);
            this.pnlMenu.Controls.Add(this.pnlUser);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(356, 1384);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 395);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 125);
            this.pnlNav.TabIndex = 1;
            // 
            // btnTilbake
            // 
            this.btnTilbake.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTilbake.FlatAppearance.BorderSize = 0;
            this.btnTilbake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTilbake.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTilbake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btnTilbake.Location = new System.Drawing.Point(0, 1289);
            this.btnTilbake.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTilbake.Name = "btnTilbake";
            this.btnTilbake.Size = new System.Drawing.Size(356, 95);
            this.btnTilbake.TabIndex = 1;
            this.btnTilbake.Text = "Tilbake";
            this.btnTilbake.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTilbake.UseVisualStyleBackColor = true;
            this.btnTilbake.Click += new System.EventHandler(this.btnTilbake_Click);
            // 
            // btnFjern
            // 
            this.btnFjern.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFjern.FlatAppearance.BorderSize = 0;
            this.btnFjern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFjern.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFjern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btnFjern.Image = global::GMAP_Demo.Properties.Resources.icons8_trash_can_40;
            this.btnFjern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFjern.Location = new System.Drawing.Point(0, 786);
            this.btnFjern.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(356, 95);
            this.btnFjern.TabIndex = 1;
            this.btnFjern.Text = "Fjern obj/område";
            this.btnFjern.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.btnFjern_Click);
            // 
            // btnLeggTilBilde
            // 
            this.btnLeggTilBilde.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeggTilBilde.FlatAppearance.BorderSize = 0;
            this.btnLeggTilBilde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeggTilBilde.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeggTilBilde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btnLeggTilBilde.Image = global::GMAP_Demo.Properties.Resources.icons8_change_40;
            this.btnLeggTilBilde.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeggTilBilde.Location = new System.Drawing.Point(0, 691);
            this.btnLeggTilBilde.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLeggTilBilde.Name = "btnLeggTilBilde";
            this.btnLeggTilBilde.Size = new System.Drawing.Size(356, 95);
            this.btnLeggTilBilde.TabIndex = 1;
            this.btnLeggTilBilde.Text = "Endre objektsymbol";
            this.btnLeggTilBilde.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLeggTilBilde.UseVisualStyleBackColor = true;
            this.btnLeggTilBilde.Click += new System.EventHandler(this.BtnLeggTilBilde_Click);
            // 
            // btnRedigerOmråde
            // 
            this.btnRedigerOmråde.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRedigerOmråde.FlatAppearance.BorderSize = 0;
            this.btnRedigerOmråde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedigerOmråde.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedigerOmråde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btnRedigerOmråde.Image = global::GMAP_Demo.Properties.Resources.icons8_edit_40__1_;
            this.btnRedigerOmråde.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedigerOmråde.Location = new System.Drawing.Point(0, 596);
            this.btnRedigerOmråde.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRedigerOmråde.Name = "btnRedigerOmråde";
            this.btnRedigerOmråde.Size = new System.Drawing.Size(356, 95);
            this.btnRedigerOmråde.TabIndex = 1;
            this.btnRedigerOmråde.Text = "Rediger område";
            this.btnRedigerOmråde.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRedigerOmråde.UseVisualStyleBackColor = true;
            this.btnRedigerOmråde.Click += new System.EventHandler(this.BtnRedigerOmråde_Click);
            // 
            // btnRediger_objekt
            // 
            this.btnRediger_objekt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRediger_objekt.FlatAppearance.BorderSize = 0;
            this.btnRediger_objekt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRediger_objekt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRediger_objekt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btnRediger_objekt.Image = global::GMAP_Demo.Properties.Resources.icons8_edit_40__1_;
            this.btnRediger_objekt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRediger_objekt.Location = new System.Drawing.Point(0, 501);
            this.btnRediger_objekt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRediger_objekt.Name = "btnRediger_objekt";
            this.btnRediger_objekt.Size = new System.Drawing.Size(356, 95);
            this.btnRediger_objekt.TabIndex = 1;
            this.btnRediger_objekt.Text = "Rediger objekt";
            this.btnRediger_objekt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRediger_objekt.UseVisualStyleBackColor = true;
            this.btnRediger_objekt.Click += new System.EventHandler(this.BtnRediger_objekt_Click);
            // 
            // btnLeggTilOmråde
            // 
            this.btnLeggTilOmråde.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeggTilOmråde.FlatAppearance.BorderSize = 0;
            this.btnLeggTilOmråde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeggTilOmråde.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeggTilOmråde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btnLeggTilOmråde.Image = global::GMAP_Demo.Properties.Resources.icons8_add_40__1_;
            this.btnLeggTilOmråde.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeggTilOmråde.Location = new System.Drawing.Point(0, 406);
            this.btnLeggTilOmråde.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLeggTilOmråde.Name = "btnLeggTilOmråde";
            this.btnLeggTilOmråde.Size = new System.Drawing.Size(356, 95);
            this.btnLeggTilOmråde.TabIndex = 1;
            this.btnLeggTilOmråde.Text = "Legg til område";
            this.btnLeggTilOmråde.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLeggTilOmråde.UseVisualStyleBackColor = true;
            this.btnLeggTilOmråde.Click += new System.EventHandler(this.BtnOmråde_Click);
            // 
            // btnLeggTilObjekt
            // 
            this.btnLeggTilObjekt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeggTilObjekt.FlatAppearance.BorderSize = 0;
            this.btnLeggTilObjekt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeggTilObjekt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeggTilObjekt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btnLeggTilObjekt.Image = global::GMAP_Demo.Properties.Resources.icons8_add_40__1_;
            this.btnLeggTilObjekt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeggTilObjekt.Location = new System.Drawing.Point(0, 311);
            this.btnLeggTilObjekt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLeggTilObjekt.Name = "btnLeggTilObjekt";
            this.btnLeggTilObjekt.Size = new System.Drawing.Size(356, 95);
            this.btnLeggTilObjekt.TabIndex = 1;
            this.btnLeggTilObjekt.Text = "Legg til objekt";
            this.btnLeggTilObjekt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLeggTilObjekt.UseVisualStyleBackColor = true;
            this.btnLeggTilObjekt.Click += new System.EventHandler(this.BtnObjekt_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.cbOmråde);
            this.pnlUser.Controls.Add(this.lblUserName);
            this.pnlUser.Controls.Add(this.pictureBox1);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(356, 311);
            this.pnlUser.TabIndex = 1;
            // 
            // cbOmråde
            // 
            this.cbOmråde.AutoSize = true;
            this.cbOmråde.CausesValidation = false;
            this.cbOmråde.Checked = true;
            this.cbOmråde.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOmråde.ForeColor = System.Drawing.Color.Lime;
            this.cbOmråde.Location = new System.Drawing.Point(14, 263);
            this.cbOmråde.Name = "cbOmråde";
            this.cbOmråde.Size = new System.Drawing.Size(281, 24);
            this.cbOmråde.TabIndex = 89;
            this.cbOmråde.Text = "Kan klikke på eksisterende område";
            this.cbOmråde.UseVisualStyleBackColor = true;
            this.cbOmråde.CheckedChanged += new System.EventHandler(this.cbOmråde_CheckedChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lblUserName.Location = new System.Drawing.Point(-40, 203);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(429, 31);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "username.username@stud.hvl.no";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = global::GMAP_Demo.Properties.Resources.icons8_person_64;
            this.pictureBox1.Location = new System.Drawing.Point(98, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.btnZoomMinus.Location = new System.Drawing.Point(2490, 1346);
            this.btnZoomMinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(30, 31);
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
            this.btnZoomPluss.Location = new System.Drawing.Point(2490, 1306);
            this.btnZoomPluss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZoomPluss.Name = "btnZoomPluss";
            this.btnZoomPluss.Size = new System.Drawing.Size(30, 31);
            this.btnZoomPluss.TabIndex = 6;
            this.btnZoomPluss.Text = "+";
            this.btnZoomPluss.UseVisualStyleBackColor = false;
            this.btnZoomPluss.Click += new System.EventHandler(this.btnZoomPluss_Click);
            // 
            // frmRediger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(2538, 1384);
            this.Controls.Add(this.btnZoomMinus);
            this.Controls.Add(this.btnZoomPluss);
            this.Controls.Add(this.map);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(2560, 1440);
            this.Name = "frmRediger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rediger ressurser ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRediger_FormClosing);
            this.Load += new System.EventHandler(this.FrmRediger_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnTilbake;
        private System.Windows.Forms.Button btnRedigerOmråde;
        private System.Windows.Forms.Button btnRediger_objekt;
        private System.Windows.Forms.Button btnLeggTilOmråde;
        private System.Windows.Forms.Button btnLeggTilObjekt;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLeggTilBilde;
        private System.Windows.Forms.Button btnZoomMinus;
        private System.Windows.Forms.Button btnZoomPluss;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnFjern;
        public System.Windows.Forms.CheckBox cbOmråde;
    }
}