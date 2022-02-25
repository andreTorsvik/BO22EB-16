﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GMap.NET.MapProviders;

namespace GMAP_Demo
{
    public partial class Form1 : Form
    {
        public static PointLatLng Punkt_til_neste_kart = new PointLatLng(60.36893643470203, 5.350878781967968);
        public Form1()
        {
            InitializeComponent();
            //pnlNav.Hide();
            
            //start form Posisjon
            this.PnlFormLoader.Controls.Clear();
            frmPosisjon frmPosisjon_vrb = new frmPosisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
            frmPosisjon_vrb.Show();

            //sette Blåpanel til vesntre for Posisjonknapp 
            pnlNav.Height = btnPosisjon.Height;
            pnlNav.Top = btnPosisjon.Top;
            pnlNav.Left = btnPosisjon.Left;
            btnPosisjon.BackColor = Color.FromArgb(46, 51, 73);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setupkart();
        }

        private void Setupkart()
        {
            //start posisjon kart
            map.MapProvider = GMapProviders.OpenStreetMap;
            
            map.Position = Punkt_til_neste_kart; //PointLatLng(60.36893643470203, 5.350878781967968);

            //settings for kart
            map.MinZoom = 0; // min zoom level
            map.MaxZoom = 27; // maximum
            map.Zoom = 17; //
            map.DragButton = MouseButtons.Left;
            map.ShowCenter = true; // false om man vil ha den bort
        }

        private void btnPoisjon_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            
            pnlNav.Height = btnPosisjon.Height;
            pnlNav.Top = btnPosisjon.Top;
            pnlNav.Left = btnPosisjon.Left;
            btnPosisjon.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmPosisjon frmPosisjon_vrb = new frmPosisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
            frmPosisjon_vrb.Show();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            
            pnlNav.Height = btnFilter.Height;
            pnlNav.Top = btnFilter.Top;
            btnFilter.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmFilter frmPosisjon_vrb = new frmFilter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
            frmPosisjon_vrb.Show();

        }

        private void btnOppdater_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            
            pnlNav.Height = btnOppdater.Height;
            pnlNav.Top = btnOppdater.Top;
            btnOppdater.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnRediger_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            
            pnlNav.Height = btnRediger.Height;
            pnlNav.Top = btnRediger.Top;
            btnRediger.BackColor = Color.FromArgb(46, 51, 73);

            Punkt_til_neste_kart = map.Position;
            //prøvde å sende zoom level også men opplevde et par bugs da

            //for å åpne Fjern/rediger form
            this.Hide();
            frmRediger frmRediger = new frmRediger(); // instance 
            frmRediger.Show();



        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        

        void AlleKnapperTilStandarfarge()
        {
            //setter alle knappen til standarfarge
            btnPosisjon.BackColor = Color.FromArgb(24, 30, 54);
            btnFilter.BackColor = Color.FromArgb(24, 30, 54);
            btnOppdater.BackColor = Color.FromArgb(24, 30, 54);
            btnRediger.BackColor = Color.FromArgb(24, 30, 54);
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //uten denne funskjone vil programmet forsatt være i debugging 
            //når man trykker "X"

        }
    }
}
