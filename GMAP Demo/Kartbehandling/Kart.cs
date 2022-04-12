using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace GMAP_Demo
{
    internal class Kart
    {
        public enum MuligKart { Visning, Redigering, Begge };
        public static PointLatLng PunktFraForrige = new PointLatLng(60.36893643470203, 5.350878781967968); // skal hente Posisjon fra fil 

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
                OppdaterKategoriListe();
                // OppdatertKart();
            }
        }

        public static void OppdaterKategoriListe()
        {
            kategoriListeVises.Clear();

            List<Kategorier_Bilde> kategoriListeAlle = new List<Kategorier_Bilde>();
            kategoriListeAlle = DatabaseCommunication.ListAllKategorier_BildeFromDb();
            foreach (var item in kategoriListeAlle)
            {
                kategoriListeVises.Add(item);
            }
            // OppdatertKart();
        }
        // BindingList for lbKategorierSkjult
        public static BindingList<Kategorier_Bilde> kategoriListeSkjult = new BindingList<Kategorier_Bilde>();
        internal static void InitializekategoriListeSkjult()
        {
            kategoriListeSkjult.AllowNew = true;
            kategoriListeSkjult.AllowRemove = true;
            kategoriListeSkjult.RaiseListChangedEvents = true;
        }

        public static void Setup(MuligKart kart, PointLatLng p)
        {
            int minZoom = 0;
            int maksZoom = 27;
            int Zoom = 17;
            GMapProvider Valgtkart = GMapProviders.OpenStreetMap;

            switch (kart)
            {
                case MuligKart.Visning:
                    frmVisning.instance.map.MapProvider = Valgtkart;

                    //start posisjon kart
                    frmVisning.instance.map.Position = p; //PointLatLng(60.36893643470203, 5.350878781967968);

                    //settings for kart
                    frmVisning.instance.map.MinZoom = minZoom; // min zoom level
                    frmVisning.instance.map.MaxZoom = maksZoom; // maximum
                    frmVisning.instance.map.Zoom = Zoom; // Behagelig Zoom level 
                    frmVisning.instance.map.DragButton = System.Windows.Forms.MouseButtons.Left;
                    break;
                case MuligKart.Redigering: 
                    frmRediger.instance.map.MapProvider = Valgtkart;

                    frmRediger.instance.map.Position = p;  //start posisjon kart

                    //settings for kart
                    frmRediger.instance.map.MinZoom = minZoom;
                    frmRediger.instance.map.MaxZoom = maksZoom;
                    frmRediger.instance.map.Zoom = Zoom; 
                    frmRediger.instance.map.DragButton = System.Windows.Forms.MouseButtons.Left;
                    break;
                case MuligKart.Begge:
                    //Denne vil aldri bli brukt  
                    break;
            }
        }

        



        public static void OppdaterListe_området()
        {
            frmVisning.instance.LOmråde.Clear();

            var OmrådeListe = DatabaseCommunication.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                frmVisning.instance.LOmråde.Add(item);
            }
        }

        public static void OppdaterListe_ressurs()
        {
            //Må oppdatere område liste også 
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
        }
        public static void OppdaterKart(MuligKart kart, List<Ressurs> Lressurs, List<Område> Lområde)
        {
            switch (kart)
            {
                case MuligKart.Visning:
                    frmVisning.instance.map.Overlays.Clear();
                    break;
                case MuligKart.Redigering:
                    frmRediger.instance.map.Overlays.Clear();
                    break;
                case MuligKart.Begge:
                    OppdaterKart(MuligKart.Visning, Lressurs, Lområde);
                    OppdaterKart(MuligKart.Redigering, Lressurs, Lområde);
                    return;
                    //break;
            }
            LeggTilRessurs(Lressurs, kart);
            LeggTilOmråde(Lområde, kart);
            reff(kart);
        }

        public static void LeggTilRessurs(List<Ressurs> Rlist, MuligKart kart)
        {
            // HvilketKart Visning = Visning.map
            // HvilketKart Redigering = Redigerings.map
            // Hvilketkart Begge = Begge 
            // Alt annet: ingen ting
            Bildebehandling bildebehandling = new Bildebehandling();
            int tag = 0;
            GMapMarker marker;
            GMapOverlay markers = new GMapOverlay("Objekter");
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

                //GMapOverlay markers = new GMapOverlay("Objekter");
                markers.Markers.Add(marker);
                //tidligere var if-setningen inni 
            }
            if (MuligKart.Visning == kart) frmVisning.instance.map.Overlays.Add(markers);
            else if (MuligKart.Redigering == kart) frmRediger.instance.map.Overlays.Add(markers);
            else if (MuligKart.Begge == kart) // begge funkere ikke 
            {
                frmVisning.instance.map.Overlays.Add(markers);
                frmRediger.instance.map.Overlays.Add(markers);
            }
        }
        //public static void LeggtilMarkør(List<Markør> Lm, MuligKart kart)
        //{
        //    // HvilketKart Visning = Visning.map
        //    // HvilketKart Redigering = Redigerings.map
        //    // Hvilketkart Begge = Begge 
        //    // Alt annet: ingen ting
        //    foreach (var item in Lm)
        //    {
        //        GMapMarker marker;
        //        GMapOverlay markers = new GMapOverlay("MarkørForOmråde");

        //        marker = new GMarkerGoogle(item.giPunkt(), GMarkerGoogleType.green);

        //        marker.ToolTipText = String.Format("{0}", item.Rekkefølge);
        //        marker.ToolTip.Fill = Brushes.Black;
        //        marker.ToolTip.Foreground = Brushes.White;
        //        marker.ToolTip.Stroke = Pens.Black;
        //        marker.ToolTip.TextPadding = new Size(20, 20);
        //        marker.Tag = item.Rekkefølge;


        //        //GMapOverlay markers = new GMapOverlay("Objekter");
        //        markers.Markers.Add(marker);
        //        //tidligere var if-setningen inni 
        //        if (MuligKart.Visning == kart) frmVisning.instance.map.Overlays.Add(markers);
        //        else if (MuligKart.Redigering == kart) frmRediger.instance.map.Overlays.Add(markers);
        //        else if (MuligKart.Begge == kart) // begge funkere ikke 
        //        {
        //            frmVisning.instance.map.Overlays.Add(markers);
        //            frmRediger.instance.map.Overlays.Add(markers);
        //        }

        //    }

        //}

        public static void LeggtilMarkør(MuligKart kart,PointLatLng point,int Rekkefølge )
        {
            // HvilketKart Visning = Visning.map
            // HvilketKart Redigering = Redigerings.map
          
                GMapMarker marker;
                GMapOverlay markers = new GMapOverlay("MarkørForOmråde");

                marker = new GMarkerGoogle(point, GMarkerGoogleType.blue);

                marker.ToolTipText = String.Format("{0}", Rekkefølge);
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);
                marker.Tag = Rekkefølge;

                markers.Markers.Add(marker);

                if (MuligKart.Visning == kart) frmVisning.instance.map.Overlays.Add(markers);
                else if (MuligKart.Redigering == kart) frmRediger.instance.map.Overlays.Add(markers);
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
                //frmVisning.instance.map.Overlays.Add(polygons);

                if (MuligKart.Visning == kart) frmVisning.instance.map.Overlays.Add(polygons);
                else if (MuligKart.Redigering == kart) frmRediger.instance.map.Overlays.Add(polygons);
                else if (MuligKart.Begge == kart)
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

        public static void FinnLokasjon(string Land, string ByKommune, string Adresse)
        {
            //setter sammen strengene til rett format
            string sammenSlått = Tekstbehandling.SammenSlåingTekstfelt(Land, ByKommune, Adresse);

            PointLatLng PosisjonFør = frmVisning.instance.map.Position;
            frmVisning.instance.map.SetPositionByKeywords(sammenSlått);

            //finne nåværende punkt 
            PointLatLng PosisjonNå = frmVisning.instance.map.Position;


            if (PosisjonFør != PosisjonNå)
            {
                frmPosisjon.instance.txtLat.Text = PosisjonNå.Lat.ToString();
                frmPosisjon.instance.txtLong.Text = PosisjonNå.Lng.ToString();
                int ZoomLevel = 18;

                if (!string.IsNullOrWhiteSpace(Adresse)) ZoomLevel = 18;
                else if (!string.IsNullOrWhiteSpace(ByKommune)) ZoomLevel = 11;
                else if (!string.IsNullOrWhiteSpace(Land)) ZoomLevel = 5;

                frmVisning.instance.map.Zoom = ZoomLevel;
            }
        }

        public static List<string> FåAddress(PointLatLng point)
        {
            //må bruke google API  for denne delen av koden
            //hvis man ikke har google API vil denne delen ikke virke
            try
            {
                List<Placemark> Info = null;
                var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out Info);
                //var statusCode = GMapProviders.OpenStreetMap.GetPlacemarks(point,out Info);
                if (statusCode == GeoCoderStatusCode.OK && Info != null)
                {
                    List<string> addresse = new List<string>();
                    addresse.Add(Info[0].Address);
                    return addresse;
                }
            }
            catch (Exception feilmelding)
            {
                DatabaseCommunication.LogFeil(typeof(Kart).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }
            return null;
        }

        public static void FjernRute()
        {
            for (int i = 0; i < frmVisning.instance.map.Overlays.Count; i++)
            {
                if (frmVisning.instance.map.Overlays[i].Id == "routes")
                {
                    frmVisning.instance.map.Overlays.RemoveAt(i);
                    reff(MuligKart.Visning);
                    frmPosisjon.instance.LbDistanse.Text = "[Distanse i Km]";
                    break;
                }
            }
        }

        public static void FjernAlleMarkører_redigier()
        {
            for (int i = 0; i < frmRediger.instance.map.Overlays.Count; i++)
            {
                if (frmRediger.instance.map.Overlays[i].Id == "MarkørForOmråde")
                {
                    frmRediger.instance.map.Overlays.RemoveAt(i);
                    i--;

                }
            }

            reff(MuligKart.Redigering);
        }

        //public static void FjernMarkør_redigier(int FjernTag)
        //{
        //    for (int i = 0; i < frmRediger.instance.map.Overlays.Count; i++)
        //    {
        //        if (frmRediger.instance.map.Overlays[i].Id == "MarkørForOmråde")
        //        {
        //            //if(frmRediger.instance.map.Overlays[i]. == FjernTag)
        //            frmRediger.instance.map.Overlays.RemoveAt(i);
        //            i--;

        //        }
        //    }
        //    reff(MuligKart.Redigering);
        //}
    }
}
