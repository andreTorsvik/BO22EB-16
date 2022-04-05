using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMAP_Demo
{
    
    public partial class frmFilter : Form
    {
        public static frmFilter instance;


        public frmFilter()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnLeggTil_Click(object sender, EventArgs e)
        {
            
            if(Form1.instance.LRessurs.Count >0) Form1.instance.LRessurs.Clear();


            var RessursList = DatabaseCommunication.ListAllRessursFromDb();

            foreach (var item in RessursList)
            {
                Form1.instance.LRessurs.Add(item);
            }

            txtAntall.Text = Form1.instance.LRessurs.Count.ToString();
        }

        private void btnRessurs_Click(object sender, EventArgs e)
        {
            LeggTilRessurs(Form1.instance.LRessurs);
            Form1.reff();
        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
                Form1.instance.map.Overlays.Clear();
                Form1.reff();
                txtNavn.Text = "";
                txtKategori.Text = "";
                txtDato_opprettet.Text = "";
                txtOpprettetAvBruker.Text = "";
                txtSikkerhetsklarering.Text = "";
                txtKommentar.Text = "";
        }

        private void btnHentOmråde_Click(object sender, EventArgs e)
        {
            Form1.instance.LOmråde.Clear();

            var OmrådeListe = DatabaseCommunication.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                Form1.instance.LOmråde.Add(item);
            }

            txtAntallOmråder.Text = Form1.instance.LOmråde.Count.ToString();
        }

        private void btnLeggTilOmrådet_Click(object sender, EventArgs e)
        {
            LeggTilOmråde(Form1.instance.LOmråde);
            Form1.reff();
        }
        //burde ta listen som agrument 
        public void LeggTilRessurs(List<Ressurs> Rlist)
        {
            Bildebehandling bildebehandling = new Bildebehandling();
            int tag = 0;
            GMapMarker marker;
            foreach (var item in Rlist)
            {
                PointLatLng punkt = item.GiPunktet();

                if (bildebehandling.sjekkOmKategoriHarBilde(item))
                {
                    marker = new GMarkerGoogle(punkt, bildebehandling.oppdaterBildeForMarkør(item));
                }
                else
                {
                    marker = new GMarkerGoogle(punkt, GMarkerGoogleType.green);
                }

                marker.ToolTipText = String.Format("{0}", item.Navn);
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);
                marker.Tag = tag;
                tag++;

                GMapOverlay markers = new GMapOverlay("test1");
                markers.Markers.Add(marker);
                Form1.instance.map.Overlays.Add(markers);
            }
        }

        //burde ta listen som argument 
        public void LeggTilOmråde( List<Område> Olist)
        {
            int Tag = 0;
            foreach (var item in Olist)
            {
                List<PointLatLng> Lpunkter = item.HentPunkter();

                GMapPolygon polygon = BestemFarge(Lpunkter, item.Farge);

                polygon.Tag = Tag;
                Tag++;
                polygon.IsHitTestVisible = true; // nødvendig for å kunne trykke på Polygonet
                GMapOverlay polygons = new GMapOverlay("Polygons");
                polygons.Polygons.Add(polygon);
                Form1.instance.map.Overlays.Add(polygons);
            }

        }

        public enum MuligeFarger { Rød, Oransje, Grønn, Blå, Gul, Lilla };
        public GMapPolygon BestemFarge(List<PointLatLng> Lpunkter,string Farge)
        {
            GMapPolygon polygon;

            switch (Farge)
            {
                case "Rødt":
                    polygon = new GMapPolygon(Lpunkter, "My area")
                    {
                        Stroke = new Pen(Color.Red, 2),
                        Fill = new SolidBrush(Color.FromArgb(50, Color.Red))
                    };
                    break;

                case "Oransje":
                    polygon = new GMapPolygon(Lpunkter, "My area")
                    {
                        Stroke = new Pen(Color.Orange, 2),
                        Fill = new SolidBrush(Color.FromArgb(50, Color.Orange))
                    };
                    break;

                case "Grønn":
                         polygon = new GMapPolygon(Lpunkter, "My area")
                         {
                             Stroke = new Pen(Color.Green, 2),
                             Fill = new SolidBrush(Color.FromArgb(50, Color.Green))
                         };
                    break;

                case "Blå":
                    polygon = new GMapPolygon(Lpunkter, "My area")
                    {
                        Stroke = new Pen(Color.Blue, 2),
                        Fill = new SolidBrush(Color.FromArgb(50, Color.Blue))
                    };
                    break;

                case "Gul":
                    polygon = new GMapPolygon(Lpunkter, "My area")
                    {
                        Stroke = new Pen(Color.Yellow, 2),
                        Fill = new SolidBrush(Color.FromArgb(50, Color.Yellow))
                    };
                    break;

                case "Lilla":
                    polygon = new GMapPolygon(Lpunkter, "My area")
                    {
                        Stroke = new Pen(Color.Purple, 2),
                        Fill = new SolidBrush(Color.FromArgb(50, Color.Purple))
                    };
                    break;

                default:
                    polygon = new GMapPolygon(Lpunkter, "My area")
                    {
                        Stroke = new Pen(Color.Green, 2),
                        Fill = new SolidBrush(Color.FromArgb(50, Color.Green))
                    };
                    break;
            }

            return polygon;
        }

        private void frmFilter_Load(object sender, EventArgs e)
        {
            Kart.InitializekategoriListeVises();
            Kart.InitializekategoriListeSkjult();
            
            lbKategorierVises.DataSource = Kart.kategoriListeVises;
            lbKategorierVises.DisplayMember = "Kategorinavn";
            lbKategorierSkjult.DataSource = Kart.kategoriListeSkjult;
            lbKategorierSkjult.DisplayMember ="Kategorinavn";
        }

        private void lbKategorierVises_DoubleClick(object sender, EventArgs e)
        {
            if (lbKategorierVises.Items.Count > 0)
            {
                Kart.kategoriListeSkjult.Add((Kategorier_Bilde)lbKategorierVises.SelectedItem);
                Kart.kategoriListeVises.Remove((Kategorier_Bilde)lbKategorierVises.SelectedItem);
                OppdaterKart();
            }
        }
        private void lbKategorierSkjult_DoubleClick(object sender, EventArgs e)
        {
            if (lbKategorierSkjult.Items.Count > 0)
            {
                Kart.kategoriListeVises.Add((Kategorier_Bilde)lbKategorierSkjult.SelectedItem);
                Kart.kategoriListeSkjult.Remove((Kategorier_Bilde)lbKategorierSkjult.SelectedItem);
                OppdaterKart();
            }
        }

        private void OppdaterKart()
        {
            Form1.instance.map.Overlays.Clear();
            if (Form1.instance.LRessurs.Count > 0) Form1.instance.LRessurs.Clear();

            var RessursList = DatabaseCommunication.ListAllRessursFromDb();

            // Er dette en tungvindt måte å gjøre det på? Kan dette forbedres?
            foreach (var item in RessursList)
            {
                foreach (var item2 in Kart.kategoriListeVises)
                {
                    if (item.Kategori.ToString() == item2.Kategorinavn.ToString())
                    {
                        Form1.instance.LRessurs.Add(item);
                        break;
                    }
                }
            }

            LeggTilRessurs(Form1.instance.LRessurs);
            Form1.reff();
        }

        private void lbKategorierVises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
