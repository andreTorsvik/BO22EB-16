﻿namespace GMAP_Demo
{
    partial class frmPosisjon
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
            this.txtLand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtByKommune = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.btnSøk = new System.Windows.Forms.Button();
            this.txtFra = new System.Windows.Forms.TextBox();
            this.txtTil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSlutt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            txtLong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            txtLat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posisjon";
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(20, 110);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(261, 22);
            this.txtLand.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(17, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Land";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(17, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "By/Kommune";
            // 
            // txtByKommune
            // 
            this.txtByKommune.Location = new System.Drawing.Point(20, 169);
            this.txtByKommune.Name = "txtByKommune";
            this.txtByKommune.Size = new System.Drawing.Size(261, 22);
            this.txtByKommune.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(17, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(20, 226);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(261, 22);
            this.txtAdresse.TabIndex = 7;
            // 
            // btnSøk
            // 
            this.btnSøk.Location = new System.Drawing.Point(20, 263);
            this.btnSøk.Name = "btnSøk";
            this.btnSøk.Size = new System.Drawing.Size(96, 34);
            this.btnSøk.TabIndex = 9;
            this.btnSøk.Text = "Søk";
            this.btnSøk.UseVisualStyleBackColor = true;
            this.btnSøk.Click += new System.EventHandler(this.btnSøk_Click);
            // 
            // txtFra
            // 
            this.txtFra.Location = new System.Drawing.Point(229, 539);
            this.txtFra.Multiline = true;
            this.txtFra.Name = "txtFra";
            this.txtFra.ReadOnly = true;
            this.txtFra.Size = new System.Drawing.Size(154, 107);
            this.txtFra.TabIndex = 10;
            // 
            // txtTil
            // 
            this.txtTil.Location = new System.Drawing.Point(229, 670);
            this.txtTil.Multiline = true;
            this.txtTil.Name = "txtTil";
            this.txtTil.ReadOnly = true;
            this.txtTil.Size = new System.Drawing.Size(154, 107);
            this.txtTil.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(225, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(225, 647);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Til";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 539);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 44);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Bruk som start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnSlutt
            // 
            this.btnSlutt.Location = new System.Drawing.Point(21, 670);
            this.btnSlutt.Name = "btnSlutt";
            this.btnSlutt.Size = new System.Drawing.Size(102, 44);
            this.btnSlutt.TabIndex = 15;
            this.btnSlutt.Text = "Bruk som Mål";
            this.btnSlutt.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 767);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "Finn Rute";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(17, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Long";
            // 
            // txtLong
            // 
            txtLong.Location = new System.Drawing.Point(20, 428);
            txtLong.Name = "txtLong";
            txtLong.ReadOnly = true;
            txtLong.Size = new System.Drawing.Size(261, 22);
            txtLong.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(17, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lat";
            // 
            // txtLat
            // 
            txtLat.Location = new System.Drawing.Point(20, 371);
            txtLat.Name = "txtLat";
            txtLat.ReadOnly = true;
            txtLat.Size = new System.Drawing.Size(261, 22);
            txtLat.TabIndex = 17;
            // 
            // frmPosisjon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(408, 872);
            this.Controls.Add(this.label7);
            this.Controls.Add(txtLong);
            this.Controls.Add(this.label8);
            this.Controls.Add(txtLat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSlutt);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTil);
            this.Controls.Add(this.txtFra);
            this.Controls.Add(this.btnSøk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtByKommune);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPosisjon";
            this.Text = "frmPosisjon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtByKommune;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Button btnSøk;
        private System.Windows.Forms.TextBox txtFra;
        private System.Windows.Forms.TextBox txtTil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSlutt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        static public System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label8;
        static public System.Windows.Forms.TextBox txtLat;
    }
}