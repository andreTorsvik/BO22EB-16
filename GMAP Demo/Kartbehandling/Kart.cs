using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace GMAP_Demo
{
    internal class Kart
    {
        public enum MuligKart { Visning, Redigering, Begge };
        public static PointLatLng PunktFraForrige =  new PointLatLng(60.36893643470203, 5.350878781967968); // skal hente Posisjon fra fil 

        // Lister for filtrering på kategorier:
        // BindingList for lbKategorierVises REF: https://stackoverflow.com/questions/17615069/how-to-refresh-datasource-of-a-listbox, https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.bindinglist-1?view=net-6.0
        public static BindingList<Kategorier_Bilde> kategoriListeVises = new BindingList<Kategorier_Bilde>();
        internal static void InitializekategoriListeVises()
        {      
            kategoriListeVises.AllowNew = true;
            kategoriListeVises.AllowRemove = true;
            kategoriListeVises.RaiseListChangedEvents = true;

            // Add items to the empty list.
            if ((kategoriListeVises.Count == 0) && (kategoriListeSkjult.Count == 0))
            {
                List<Kategorier_Bilde> kategoriListeAlle = new List<Kategorier_Bilde>();
                kategoriListeAlle = DatabaseCommunication.ListAllKategorier_BildeFromDb();
                foreach (var item in kategoriListeAlle)
                {
                    kategoriListeVises.Add(item);
                }
                // OppdatertKart();
            }

        }
        // BindingList for lbKategorierSkjult
        public static BindingList<Kategorier_Bilde> kategoriListeSkjult = new BindingList<Kategorier_Bilde>();
        internal static void InitializekategoriListeSkjult()
        {        
            kategoriListeSkjult.AllowNew = true;
            kategoriListeSkjult.AllowRemove = true;
            kategoriListeSkjult.RaiseListChangedEvents = true;
        }

        public static void Setup(MuligKart kart ,PointLatLng p)
        {
            switch (kart)
            {
                case MuligKart.Visning:
                    frmVisning.instance.map.MapProvider = GMapProviders.OpenStreetMap;

                    frmVisning.instance.map.Position = p; //PointLatLng(60.36893643470203, 5.350878781967968);

                    //settings for kart
                    frmVisning.instance.map.MinZoom = 0; // min zoom level
                    frmVisning.instance.map.MaxZoom = 27; // maximum
                    frmVisning.instance.map.Zoom = 17; // Behagelig Zoom level 
                    frmVisning.instance.map.DragButton = System.Windows.Forms.MouseButtons.Left;
                    break;
                case MuligKart.Redigering:

                    //start posisjon kart
                    frmRediger.instance.map.MapProvider = GMapProviders.OpenStreetMap;

                    frmRediger.instance.map.Position = p;

                    //settings for kart
                    frmRediger.instance.map.MinZoom = 0; // min zoom level
                    frmRediger.instance.map.MaxZoom = 27; // maximum
                    frmRediger.instance.map.Zoom = 17;
                    frmRediger.instance.map.DragButton = System.Windows.Forms.MouseButtons.Left;

                    break;
                case MuligKart.Begge:
                    break;
                default:
                    break;
            }
            //start posisjon kart
            
        }

        public static void Visning_OppdaterListeOgKart()
        {
            //FrmVisning.instance.OppdaterKart();
            //
            //frmFilter.instance.OppdaterKart()

            frmVisning.instance.map.Overlays.Clear();
            if (frmVisning.instance.LRessurs.Count > 0) frmVisning.instance.LRessurs.Clear();

            var RessursList = DatabaseCommunication.ListAllRessursFromDb();

            // Er dette en tungvindt måte å gjøre det på? Kan dette forbedres?
            foreach (var item in RessursList)
            {
                foreach (var item2 in Kart.kategoriListeVises)
                {
                    if (item.Kategori.ToString() == item2.Kategorinavn.ToString())
                    {
                        frmVisning.instance.LRessurs.Add(item);
                        break;
                    }
                }
            }

            LeggTilRessurs(frmVisning.instance.LRessurs, MuligKart.Visning);
            reff(MuligKart.Visning);
        }

        public static void Redigering_OppdaterKart()
        {
            //bruker listene i FrmVisning, så visning_oppdaterkart må kjører først 
         
            frmRediger.instance.map.Overlays.Clear();
            LeggTilRessurs(frmVisning.instance.LRessurs, MuligKart.Redigering);
            LeggTilOmråde(frmVisning.instance.LOmråde, MuligKart.Redigering);
            Setup(MuligKart.Redigering,PunktFraForrige);
        }

        public static  void LeggTilRessurs(List<Ressurs> Rlist,MuligKart kart)
        {
            // HvilketKart Visning = Visning.map
            // HvilketKart Redigering = Redigerings.map
            // Hvilketkart Begge = Begge 
            // Alt annet: ingen ting
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
                if(MuligKart.Visning == kart) frmVisning.instance.map.Overlays.Add(markers);
                if(MuligKart.Redigering == kart) frmRediger.instance.map.Overlays.Add(markers);
                if(MuligKart.Begge == kart)
                {
                    frmVisning.instance.map.Overlays.Add(markers);
                    frmRediger.instance.map.Overlays.Add(markers);
                }

            }
        }

        public static void LeggTilOmråde(List<Område> Olist, MuligKart kart)
        {
            // HvilketKart Visning = Visning.map
            // HvilketKart Redigering = Redigerings.map
            // Hvilketkart begge = Begge 
            // Alt annet: ingen ting
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
                frmVisning.instance.map.Overlays.Add(polygons);

                if (MuligKart.Visning == kart) frmVisning.instance.map.Overlays.Add(polygons);
                if (MuligKart.Redigering == kart) frmRediger.instance.map.Overlays.Add(polygons);
                if (MuligKart.Begge == kart)
                {
                    frmVisning.instance.map.Overlays.Add(polygons);
                    frmRediger.instance.map.Overlays.Add(polygons);
                }
            }

        }

        public enum MuligeFarger { Rød, Oransje, Grønn, Blå, Gul, Lilla };
        public static GMapPolygon BestemFarge(List<PointLatLng> Lpunkter, string Farge)
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

        public static void LeggTilRute(PointLatLng fra, PointLatLng til)
        {
            //bruker google API
            //Denne metoden er kun for visning
            var route = GoogleMapProvider.Instance.GetRoute(fra, til, false, false, 14);

            var r = new GMapRoute(route.Points, "My rute")
            {
                Stroke = new Pen(Color.Red, 5)
            };
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            frmVisning.instance.map.Overlays.Add(routes);
            frmVisning.instance.map.Position = fra;

            frmPosisjon.instance.LbDistanse.Text = route.Distance.ToString() + " Km";
        }

        public static void reff(MuligKart kart)
        {
            switch (kart)
            {
                case MuligKart.Visning:
                    frmVisning.instance.map.Zoom++;
                    frmVisning.instance.map.Zoom--;
                    break;
                case MuligKart.Redigering:
                    frmRediger.instance.map.Zoom++;
                    frmRediger.instance.map.Zoom--;
                    break;
                case MuligKart.Begge:
                    frmVisning.instance.map.Zoom++;
                    frmVisning.instance.map.Zoom--;

                    frmRediger.instance.map.Zoom++;
                    frmRediger.instance.map.Zoom--;
                    break;
            }
        }
    }
}
