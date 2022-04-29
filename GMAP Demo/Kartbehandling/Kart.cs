using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace GMAP_Demo
{
    internal class Kart
    {
        public enum MuligKart { Visning, Redigering, Begge };
        public static PointLatLng PunktFraForrige = new PointLatLng();
        public static bool ViseOmrådePåKart = true;

        // Lister for filtrering på kategorier:
        // BindingList for lbKategorierVises REF: https://stackoverflow.com/questions/17615069/how-to-refresh-datasource-of-a-listbox, https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.bindinglist-1?view=net-6.0
        public static BindingList<Kategorier_Bilde> kategoriListeVises = new BindingList<Kategorier_Bilde>();
        // BindingList for lbKategorierSkjult
        public static BindingList<Kategorier_Bilde> kategoriListeSkjult = new BindingList<Kategorier_Bilde>();
        public static BindingList<string> tag_ListeVises = new BindingList<string>();
        public static BindingList<string> tag_ListeSkjult = new BindingList<string>();

        internal static void InitializekategoriListeVises()
        {
            kategoriListeVises.AllowNew = true;
            kategoriListeVises.AllowRemove = true;
            kategoriListeVises.RaiseListChangedEvents = true;

            // Add items to the empty list.
            if ((kategoriListeVises.Count == 0) && (kategoriListeSkjult.Count == 0))
            {
                OppdaterKategoriListe();
            }
        }
        internal static void InitializekategoriListeSkjult()
        {
            kategoriListeSkjult.AllowNew = true;
            kategoriListeSkjult.AllowRemove = true;
            kategoriListeSkjult.RaiseListChangedEvents = true;
        }
        internal static void InitializeTag_RessursListeVises()
        {
            tag_ListeVises.AllowNew = true;
            tag_ListeVises.AllowRemove = true;
            tag_ListeVises.RaiseListChangedEvents = true;

            // Add items to the empty list.
            if ((tag_ListeVises.Count == 0) && (tag_ListeSkjult.Count == 0))
            {
                OppdaterTag_Liste();
            }
        }

        internal static void InitializeTag_RessursListeSkjult()
        {
            tag_ListeSkjult.AllowNew = true;
            tag_ListeSkjult.AllowRemove = true;
            tag_ListeSkjult.RaiseListChangedEvents = true;
        }

        public static void OppdaterKategoriListe()
        {
            kategoriListeVises.Clear();

            List<Kategorier_Bilde> kategoriListeAlle = new List<Kategorier_Bilde>();
            kategoriListeAlle = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();
            foreach (var item in kategoriListeAlle)
            {
                kategoriListeVises.Add(item);
            }
        }

        public static void OppdaterTag_Liste()
        {
            tag_ListeVises.Clear();

            HashSet<string> tag_ListeAlle = new HashSet<string>();
            tag_ListeAlle = FellesMetoder.FåAlleTags();

            foreach (var item in tag_ListeAlle)
            {
                tag_ListeVises.Add(item);
            }
        }
    

        public static void Setup(MuligKart kart, PointLatLng p)
        {
            int minZoom = 0;
            int maksZoom = 27; 
            int Zoom = 17; // behagelig zoom level 
            GMapProvider Valgtkart = GMapProviders.OpenStreetMap; // hvilket kart som blir brukt 

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
            GlobaleLister.LOmråde.Clear();

            var OmrådeListe = DBComOmråde.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                GlobaleLister.LOmråde.Add(item);
            }

            bool OR = frmFilter.instance.filterOR;
            bool AND = frmFilter.instance.filterAND;

            if (OR && !AND) //OR
                FilterBehandling.filtrereBaserPåTagsOR(ref GlobaleLister.LOmråde, tag_ListeVises.ToList());
            else if (AND && !OR) //AND
                FilterBehandling.filtrereBaserPåTagsAND(ref GlobaleLister.LOmråde, tag_ListeVises.ToList());
        }

        public static void OppdaterListe_ressurs()
        {
            //Må oppdatere område liste også 
            if (GlobaleLister.LRessurs.Count > 0) GlobaleLister.LRessurs.Clear();

            var RessursList = DBComRessurs.ListAllRessursFromDb(InnloggetBruker.Sikkerhetsklarering);

            // Er dette en tungvindt måte å gjøre det på? Kan dette forbedres?
            foreach (var item in RessursList)
            {
                foreach (var item2 in Kart.kategoriListeVises)
                {
                    if ((item.Kategori.ToString() == item2.Kategorinavn.ToString()) /*&& (item.Tag.ToString() == item3.Tag.ToString())*/) // Har kommentert ut delen som venter på Ressurs.Tag
                    {
                        GlobaleLister.LRessurs.Add(item);
                        break;
                    }                 
                }
            }

            bool OR = frmFilter.instance.filterOR;
            bool AND = frmFilter.instance.filterAND;

            if(OR && !AND) //OR
                FilterBehandling.filtrereBaserPåTagsOR(ref GlobaleLister.LRessurs, tag_ListeVises.ToList()) ;
            else if(AND && !OR) //AND
                FilterBehandling.filtrereBaserPåTagsAND(ref GlobaleLister.LRessurs, tag_ListeVises.ToList());
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
            if(ViseOmrådePåKart) LeggTilOmråde(Lområde, kart);
            reff(kart);
        }

        public static void LeggTilRessurs(List<Ressurs> Rlist, MuligKart kart)
        {
            int tag = 0;
            GMapMarker marker;
            GMapOverlay markers = new GMapOverlay("Objekter");
            foreach (var item in Rlist)
            {
                PointLatLng punkt = item.GiPunktet();

                if (Bildebehandling.sjekkOmKategoriHarBilde(item))
                {
                    marker = new GMarkerGoogle(punkt, Bildebehandling.oppdaterBildeForMarkør(item));
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

                markers.Markers.Add(marker);
            }
            if (MuligKart.Visning == kart) frmVisning.instance.map.Overlays.Add(markers);
            else if (MuligKart.Redigering == kart) frmRediger.instance.map.Overlays.Add(markers);
            else if (MuligKart.Begge == kart) // begge funkere ikke 
            {
                frmVisning.instance.map.Overlays.Add(markers);
                frmRediger.instance.map.Overlays.Add(markers);
            }
        }
       
        public static void LeggtilMarkør(MuligKart kart, PointLatLng point, int Rekkefølge, string områdeId)
        {
            // HvilketKart Visning = Visning.map
            // HvilketKart Redigering = Redigerings.map
            //-1 da vil man ikke få tooltip tekst 
            GMapMarker marker;
            GMapOverlay markers = new GMapOverlay(områdeId);

            marker = new GMarkerGoogle(point, GMarkerGoogleType.blue);
            if (Rekkefølge != -1)
            {
                marker.ToolTipText = String.Format("{0}", Rekkefølge);
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);
                marker.Tag = Rekkefølge;
            }
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

        public enum MuligeFarger { Rød, Oransje, Grønn, Blå, Gul, Lilla, Rosa, Turkis, Hvit,Svart }; // listen er kun for å vise hva som er tilgjenglig i "BestemFarge" 
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
                case "Rosa":
                    polygon = new GMapPolygon(Lpunkter, "My area")
                    {
                        Stroke = new Pen(Color.Pink, 2),
                        Fill = new SolidBrush(Color.FromArgb(50, Color.Pink))
                    };
                    break;
                case "Turkis":
                    polygon = new GMapPolygon(Lpunkter, "My area")
                    {
                        Stroke = new Pen(Color.Cyan, 2),
                        Fill = new SolidBrush(Color.FromArgb(50, Color.Cyan))
                    };
                    break;
                case "Hvit":
                    polygon = new GMapPolygon(Lpunkter, "My area")
                    {
                        Stroke = new Pen(Color.White, 2),
                        Fill = new SolidBrush(Color.FromArgb(50, Color.White))
                    };
                    break;
                case "Svart":
                    polygon = new GMapPolygon(Lpunkter, "My area")
                    {
                        Stroke = new Pen(Color.Black, 2),
                        Fill = new SolidBrush(Color.FromArgb(50, Color.Black))
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
            //oppdatere kart med å zoom inn og ut 
            //zoomer inn så lite at det ikke merkes
            double PlussMinus = 0.01;
            switch (kart)
            {
                case MuligKart.Visning:
                    frmVisning.instance.KartOppdatere = true;

                    frmVisning.instance.map.Zoom = frmVisning.instance.map.Zoom + PlussMinus;
                    frmVisning.instance.map.Zoom = frmVisning.instance.map.Zoom - PlussMinus;

                    frmVisning.instance.KartOppdatere = false;
                    break;
                case MuligKart.Redigering:

                    frmRediger.instance.map.Zoom = frmRediger.instance.map.Zoom + PlussMinus;
                    frmRediger.instance.map.Zoom = frmRediger.instance.map.Zoom - PlussMinus;

                    break;
                case MuligKart.Begge:
                    frmVisning.instance.map.Zoom = frmVisning.instance.map.Zoom + PlussMinus;
                    frmVisning.instance.map.Zoom = frmVisning.instance.map.Zoom - PlussMinus;

                    frmRediger.instance.map.Zoom = frmRediger.instance.map.Zoom + PlussMinus;
                    frmRediger.instance.map.Zoom = frmRediger.instance.map.Zoom - PlussMinus;
                    break;
            }
        }

        public static void FinnLokasjon(string Land, string ByKommune, string Adresse)
        {
            //setter sammen strengene til rett format
            string sammenSlått = Tekstbehandling.AdresseTekstfelt(Land, ByKommune, Adresse);

            PointLatLng PosisjonFør = frmVisning.instance.map.Position;

            //setter kartet til posisjon bassert på tekst 
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
                DBComLog_feil.LogFeil(typeof(Kart).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
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
                    if( frmPosisjon.instance != null)
                        frmPosisjon.instance.LbDistanse.Text = "[Distanse i Km]";
                    break;
                }
            }
        }

        public static void FjernAlleMarkører_redigier(string områdeId)
        {
            
            for (int i = 0; i < frmRediger.instance.map.Overlays.Count; i++)
            {
                if (frmRediger.instance.map.Overlays[i].Id == områdeId)
                {
                    frmRediger.instance.map.Overlays.RemoveAt(i);
                    i--;
                }
            }
            reff(MuligKart.Redigering);
        }
    }
}
