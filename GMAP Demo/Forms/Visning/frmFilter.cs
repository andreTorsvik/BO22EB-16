using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMAP_Demo.Database.DataTypes;
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


            DatabaseCommunication db = new DatabaseCommunication();
            var RessursList = db.ListAllRessursFromDb();

            foreach (var item in RessursList)
            {
                Form1.instance.LRessurs.Add(item);
            }

            txtAntall.Text = Form1.instance.LRessurs.Count.ToString();
        }

        private void btnRessurs_Click(object sender, EventArgs e)
        {
            int tag = 0;
            GMapMarker marker;
            foreach (var item in Form1.instance.LRessurs)
            {
                PointLatLng punkt = item.GiPunktet();


                if (sjekkOmKategoriHarBilde(item))
                {
                    marker = new GMarkerGoogle(punkt, oppdaterBildeForMarkør(item));
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
            Form1.reff();
        }

        private bool sjekkOmKategoriHarBilde(Ressurs item)
        {
            DatabaseCommunication db = new DatabaseCommunication();
            List<Kategorier_Bilde> kategorier_Bilde = new List<Kategorier_Bilde>();
            kategorier_Bilde = db.GetBildeForKategoriFromDbKategorier_Bilde(item.Kategori);

            if (kategorier_Bilde[0].Bilde != null)
            {
                kategorier_Bilde.Clear();

                return true;
            }
            else
            {
                kategorier_Bilde.Clear();

                return false;
            }
        }

        private Bitmap oppdaterBildeForMarkør(Ressurs item)
        {
            DatabaseCommunication db = new DatabaseCommunication();
            Bildebehandling bildebehandling = new Bildebehandling();

            List<Kategorier_Bilde> kategorier_Bilde = new List<Kategorier_Bilde>();
            kategorier_Bilde = db.GetBildeForKategoriFromDbKategorier_Bilde(item.Kategori);

            if (kategorier_Bilde[0] != null) 
            {
                Image image = bildebehandling.byteArrayToImage(kategorier_Bilde[0].Bilde);

                Bitmap bitmap = new Bitmap(image);

                bitmap = bildebehandling.ResizeBitmap(bitmap, 20, 25);

                kategorier_Bilde.Clear();

                return bitmap;
            }
            else
            {
                kategorier_Bilde.Clear();

                return null;
            }
        }




        private void txtAntall_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            Form1.instance.map.Overlays.Clear();
            //Form1.map.Overlays.Remove("test1");
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

            DatabaseCommunication db = new DatabaseCommunication();
            var OmrådeListe = db.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                Form1.instance.LOmråde.Add(item);
            }

            txtAntallOmråder.Text = Form1.instance.LOmråde.Count.ToString();
        }

        private void btnLeggTilOmrådet_Click(object sender, EventArgs e)
        {

            int Tag = 0;
            foreach (var item in Form1.instance.LOmråde)
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
            Form1.reff();
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
    }
}
