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

        public static void OppdaterTag_Liste() // Vurdere å flyttet
        {
            //oppdatere Vises tagliste 

            // Tømer hvis den har innhold 
            if (tag_ListeVises.Count > 0) tag_ListeVises.Clear();
           
            // Henter alle tags fra databasen
            HashSet<string> tag_ListeAlle = new HashSet<string>();
            tag_ListeAlle = FellesMetoder.FåAlleTags();

            // Henter alle "skjulte" tags 
            List<string> ListsjultTags = tag_ListeSkjult.ToList();

            // Sorter ut alle de "skjulte" fra alle tags  
            List<string> ListeVisteTags = tag_ListeAlle.Except(ListsjultTags).ToList();

            //oppdatere TagVisteListe
            foreach (var item in ListeVisteTags)
            {
                tag_ListeVises.Add(item);
            }

            //oppdatere  skjulte taglisten:

            //tømer listen 
            if (tag_ListeSkjult.Count > 0) tag_ListeSkjult.Clear();

            // Sorter ut alle de "synlige" fra alle tags 
            ListsjultTags = tag_ListeAlle.Except(ListeVisteTags).ToList();

            //legger dem til 
            if (ListsjultTags.Count != 0)
            {
                foreach (var item in ListsjultTags)
                {
                    tag_ListeSkjult.Add(item);
                }
            }



        }

        public static void Setup(MuligKart kart, PointLatLng Startpunkt)
        {
            // Min zoomlevel
            int minZoom = 0;

            // Maks zoomlevel
            int maksZoom = 27;

            // Behagelig zoomlevel
            int Zoom = 17;

            // Hvilket kart som blir brukt 
            GMapProvider Valgtkart = GMapProviders.OpenStreetMap; 

            switch (kart)
            {
                case MuligKart.Visning:
                    frmVisning.instance.map.MapProvider = Valgtkart;

                    //start posisjon kart
                    frmVisning.instance.map.Position = Startpunkt; 

                    //settings for kart: zoom
                    frmVisning.instance.map.MinZoom = minZoom; 
                    frmVisning.instance.map.MaxZoom = maksZoom; 
                    frmVisning.instance.map.Zoom = Zoom; 

                    // Gjør det mulig å "dra" kartet 
                    frmVisning.instance.map.DragButton = System.Windows.Forms.MouseButtons.Left;
                    break;

                case MuligKart.Redigering:
                    // Hvilket kart 
                    FrmRediger.instance.map.MapProvider = Valgtkart;

                    // Start posisjon kart
                    FrmRediger.instance.map.Position = Startpunkt; 

                    // Settings for kart: zoom
                    FrmRediger.instance.map.MinZoom = minZoom;
                    FrmRediger.instance.map.MaxZoom = maksZoom;
                    FrmRediger.instance.map.Zoom = Zoom;

                    // Gjør det mulig å "dra" kartet 
                    FrmRediger.instance.map.DragButton = System.Windows.Forms.MouseButtons.Left;
                    break;

                case MuligKart.Begge:
                    Setup(MuligKart.Visning, Startpunkt);
                    Setup(MuligKart.Redigering, Startpunkt);
                    break;
            }
        }

        public static void OppdaterListe_området() // Vurdere å flyttet
        {
            // Tømmer listen
            GlobaleLister.LOmråde.Clear();

            // Henter alle områdene
            var OmrådeListe = DBComOmråde.ListAllOmrådeFromDb();

            // Legger dem til i den globale listen 
            foreach (var item in OmrådeListe)
            {
                GlobaleLister.LOmråde.Add(item);
            }

            // Filterer ut områder basert på tag 
            if (tag_ListeVises.Count != 0)
            {
                // Finner ut hvilket filter man skal bruke 
                bool OR = frmFilter.instance.filterOR;
                bool AND = frmFilter.instance.filterAND;

                if (OR && !AND) // OR
                {
                    if (kategoriListeSkjult.Count != 0 || tag_ListeSkjult.Count != 0)
                    {
                        FilterBehandling.filtrereBaserPåTagsOR(ref GlobaleLister.LOmråde, tag_ListeVises.ToList());
                    }
                }
                else if (AND && !OR) // AND
                    FilterBehandling.filtrereBaserPåTagsAND(ref GlobaleLister.LOmråde, tag_ListeVises.ToList());
            }
            else // ingen valgte tags 
            {
                GlobaleLister.LOmråde.Clear();
            }

        }

        public static void OppdaterListe_ressurs() // Vurdere å flyttet
        {
            // Tømmerlisten 
            if (GlobaleLister.LRessurs.Count > 0) GlobaleLister.LRessurs.Clear();

            // Henter alle ressurser
            var RessursList = DBComRessurs.ListAllRessursFromDb(InnloggetBruker.Sikkerhetsklarering);

            // Legger til i den globale listen, men basert på kategorilisten 
            foreach (var item in RessursList)
            {
                foreach (var item2 in Kart.kategoriListeVises)
                {
                    if (item.Kategori.ToString() == item2.Kategorinavn.ToString())
                    {
                        GlobaleLister.LRessurs.Add(item);
                        break;
                    }
                }
            }

            // Filtrering ut objekter baser på tag
            if (kategoriListeVises.Count != 0 || tag_ListeVises.Count != 0)
            {
                // Finner ut hvilket filter man skal bruke 
                bool OR = frmFilter.instance.filterOR;
                bool AND = frmFilter.instance.filterAND;

                if (OR && !AND) // OR
                {
                    if (kategoriListeSkjult.Count != 0 || tag_ListeSkjult.Count != 0)
                    {
                        FilterBehandling.filtrereBaserPåTagsOR(ref GlobaleLister.LRessurs, tag_ListeVises.ToList());
                    }
                }
                else if (AND && !OR) // AND
                    FilterBehandling.filtrereBaserPåTagsAND(ref GlobaleLister.LRessurs, tag_ListeVises.ToList());
            }
            else // Ingen valgte tags 
            {
                GlobaleLister.LRessurs.Clear();
            }
        }

        public static void OppdaterKart(MuligKart kart, List<Ressurs> Lressurs, List<Område> Lområde)
        {
            switch (kart)
            {
                case MuligKart.Visning:
                    // Fjerne alt på kartet, programmet har lagt til
                    frmVisning.instance.map.Overlays.Clear(); 
                    break;
                case MuligKart.Redigering:
                    // Fjerne alt på kartet, programmet har lagt til
                    FrmRediger.instance.map.Overlays.Clear();
                    break;
                case MuligKart.Begge:
                    OppdaterKart(MuligKart.Visning, Lressurs, Lområde);
                    OppdaterKart(MuligKart.Redigering, Lressurs, Lområde);
                    return;
                    //break;
            }
            // Legger til objektene 
            LeggTilRessurs(Lressurs, kart);

            // Legger til områdene, hvis man "checked" i filter 
            if (ViseOmrådePåKart) LeggTilOmråde(Lområde, kart);

            // Må oppdatere kartet etter man har lagt til 
            reff(kart); 
        }

        public static void LeggTilRessurs(List<Ressurs> Rlist, MuligKart kart)
        {
            int tag = 0; // Index i listen 
            GMapMarker marker;
            GMapOverlay markers = new GMapOverlay(Globalekonstanter.NavnObjekter);

            foreach (var item in Rlist)
            {
                // Henter koordinater  
                PointLatLng punkt = item.GiPunktet();

                // Sjekker om objekte/ressurs har et bilde knyttet til seg
                if (Bildebehandling.sjekkOmKategoriHarBilde(item)) // Bilde
                {
                    marker = new GMarkerGoogle(punkt, Bildebehandling.oppdaterBildeForMarkør(item));
                }
                else // Ingen bilde
                {
                    marker = new GMarkerGoogle(punkt, GMarkerGoogleType.green);
                }

                //tooltip info 
                marker.ToolTipText = String.Format("{0}", item.Navn);
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);

                //tag = plassering i den globalelisten listen 
                marker.Tag = tag;
                tag++;

                markers.Markers.Add(marker);
            }

            //legger til i riktig kart 
            if (MuligKart.Visning == kart) frmVisning.instance.map.Overlays.Add(markers);
            else if (MuligKart.Redigering == kart) FrmRediger.instance.map.Overlays.Add(markers);
            else if (MuligKart.Begge == kart)
            {
                frmVisning.instance.map.Overlays.Add(markers);
                FrmRediger.instance.map.Overlays.Add(markers);
            }

            //oppdatere antall objekter i formFilter hvis den er åpen 
            if (frmFilter.instance != null)
            {
                frmFilter.instance.OppdaterAntall();
            }
        }

        public static void LeggtilMarkør(MuligKart kart, PointLatLng punkt, int Rekkefølge, string områdeId)
        {
            //Rekkefølge = -1, da vil man ikke få tooltip tekst,- 
            //Det blir brukt som dobbelttrykk (gul markør) på redigeringsformen. 

            //Blå markør er for å visse hjørnene til eksisterende områder/polygon og rekkefølgen på de
            //for enklere kunne gjøre endringer 

            GMapMarker marker;
            GMapOverlay markers = new GMapOverlay(områdeId);

            if (områdeId == Globalekonstanter.NavnHjelpeMarkør)
            {
                //gulmarkør
                marker = new GMarkerGoogle(punkt, GMarkerGoogleType.yellow);
            }
            else
            {
                //blåmarkør 
                marker = new GMarkerGoogle(punkt, GMarkerGoogleType.blue);
            }

            if (Rekkefølge != -1)
            {
                //tooltip info 
                marker.ToolTipText = String.Format("{0}", Rekkefølge);
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);

            }
            // For at den ikke skal kunne bli trykket på setter man tag til -1. 
            marker.Tag = -1; 

            markers.Markers.Add(marker);

            //legger til på riktig kart
            if (MuligKart.Visning == kart) frmVisning.instance.map.Overlays.Add(markers);
            else if (MuligKart.Redigering == kart) FrmRediger.instance.map.Overlays.Add(markers);

        }

        public static void LeggTilOmråde(List<Område> Olist, MuligKart kart)
        {

            int Tag = 0; // index i listen 
            foreach (var item in Olist)
            {
                // Henter punktene i de aktuelle område, metoen sortere også punktene i riktig rekkfølge
                List<PointLatLng> Lpunkter = item.HentPunkter();

                // Farge på polygonet 
                GMapPolygon polygon = BestemFarge(Lpunkter, item.Farge);

                // Legge til tag og øker
                polygon.Tag = Tag;
                Tag++;

                // Nødvendig for å kunne trykke på Polygonet
                polygon.IsHitTestVisible = true;

                // Legger til polygonet som overlay på kartet 
                GMapOverlay polygons = new GMapOverlay(Globalekonstanter.NavnOmråde);
                polygons.Polygons.Add(polygon);

                // Legger til på riktig kart
                if (MuligKart.Visning == kart) frmVisning.instance.map.Overlays.Add(polygons);
                else if (MuligKart.Redigering == kart) FrmRediger.instance.map.Overlays.Add(polygons);
                else if (MuligKart.Begge == kart)
                {
                    frmVisning.instance.map.Overlays.Add(polygons);
                    FrmRediger.instance.map.Overlays.Add(polygons);
                }
            }
        }

        public enum MuligeFarger { Rød, Oransje, Grønn, Blå, Gul, Lilla, Rosa, Turkis, Hvit, Svart }; // listen er kun for å vise hva som er tilgjenglig i "BestemFarge", må legge inn manuelt 
        public static GMapPolygon BestemFarge(List<PointLatLng> Lpunkter, string Farge)
        {
            //Når man legger til en ny farge må man legge til navne på fargen i enum "MuligeFarger"
            //hvis ikke vil den ikke komme opp som et alternativ 

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

        public static void LeggTilRute(PointLatLng Start, PointLatLng Mål)
        {
            // Bruker google-API
            // Denne metoden er kun for visningskaret


            // Henter rute fra googlemap
            var route = GoogleMapProvider.Instance.GetRoute(Start, Mål, false, false, 14);

            // Tegner rute
            var r = new GMapRoute(route.Points, "My rute")
            {
                Stroke = new Pen(Color.Red, 5)
            };

            // Legger til i overlays på kartet
            var routes = new GMapOverlay(Globalekonstanter.NavnRute);
            routes.Routes.Add(r);
            frmVisning.instance.map.Overlays.Add(routes);

            // Plasser kartet i starten av ruten 
            frmVisning.instance.map.Position = Start;

            // Legger inn avstanden 
            if(frmPosisjon.instance != null)
                frmPosisjon.instance.lblDistanse.Text = route.Distance.ToString() + " Km";
        }

        public static void TegnHjelpeOmråde_rediger(PointLatLng klikket, List<PointLatLng> Lpunkt)
        {
            // Metoden blir kun brukt i redigering  
            // Metoden tegner et "hjelpeområde" underveis, for å vise brukeren hvordan område kommer til å se ut
            // Det er 2 "TegnHjelpeOmråde_rediger" den metoden tar et ekstra argument: der brukern har dobbeltklikket på kartet 
            // Dette for å gjøre "hjelpeområdet" blir mer dynamisk og tydeligere hvordan område kommer til å se ut 

            // Må lagre antallet for seinere bruk
            int antallPunkter = Lpunkt.Count; 

            if (antallPunkter >= 1)
            {
                // Legger til punktet bruker har klikket
                Lpunkt.Add(klikket);

                // Legger til de første punkte igjen, for å tegne området slik det vil se ut 
                if (antallPunkter != 1)
                    Lpunkt.Add(Lpunkt[0]);

                // Tegner området
                var r = new GMapRoute(Lpunkt, Globalekonstanter.NavnHjelpeOmråde)
                {
                    Stroke = new Pen(Color.Magenta, 3)
                };

                // Legger til som overlay
                var routes = new GMapOverlay(Globalekonstanter.NavnHjelpeOmråde);
                routes.Routes.Add(r);
                FrmRediger.instance.map.Overlays.Add(routes);

                // Oppdatere kartet 
                reff(MuligKart.Redigering);
            }
        }

        public static void TegnHjelpeOmråde_rediger(List<PointLatLng> Lpunkt)
        {
            // Metoden blir kun brukt i redigering
            // Metoden tegner et "hjelpeområde" underveis, for å vise brukeren hvordan område kommer til å se ut
            // Det er 2 "TegnHjelpeOmråde_rediger" den metoden tar kun område/polygon punktene og tegner området 

            // Må lagre antallet for seinere bruk
            int antallPunkter = Lpunkt.Count; 

            if (antallPunkter >= 1)
            {
                // Legger til de første punkte igjen, for å tegne området slik det vil se ut
                if (antallPunkter != 1)
                    Lpunkt.Add(Lpunkt[0]);

                // Tegner området
                var r = new GMapRoute(Lpunkt, Globalekonstanter.NavnHjelpeOmråde) // "HjelpeOmråde"
                {
                    Stroke = new Pen(Color.Magenta, 3)
                };

                // Legger til som overlay
                var routes = new GMapOverlay(Globalekonstanter.NavnHjelpeOmråde);
                routes.Routes.Add(r);
                FrmRediger.instance.map.Overlays.Add(routes);

                // Oppdatere kartet 
                reff(MuligKart.Redigering);
            }
        }

        public static void reff(MuligKart kart)
        {
            //Enkleste måte å oppdatere kartet på, er å zoom inn og ut.
            //Zoomer inn og ut så lite at det ikke merkes

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

                    FrmRediger.instance.map.Zoom = FrmRediger.instance.map.Zoom + PlussMinus;
                    FrmRediger.instance.map.Zoom = FrmRediger.instance.map.Zoom - PlussMinus;

                    break;
                case MuligKart.Begge:
                    frmVisning.instance.map.Zoom = frmVisning.instance.map.Zoom + PlussMinus;
                    frmVisning.instance.map.Zoom = frmVisning.instance.map.Zoom - PlussMinus;

                    FrmRediger.instance.map.Zoom = FrmRediger.instance.map.Zoom + PlussMinus;
                    FrmRediger.instance.map.Zoom = FrmRediger.instance.map.Zoom - PlussMinus;
                    break;
            }
        }

        public static void FinnLokasjon(string Land, string ByKommune, string Adresse)
        {
            //setter sammen strengene til rett format
            string sammenSlått = Tekstbehandling.AdresseTekstfelt(Land, ByKommune, Adresse);

            //Posisjon før flytting
            PointLatLng PosisjonFør = frmVisning.instance.map.Position;

            //setter kartet til posisjon bassert på tekst 
            frmVisning.instance.map.SetPositionByKeywords(sammenSlått);

            //finne nåværende punkt 
            PointLatLng PosisjonNå = frmVisning.instance.map.Position;

            //hvis kartet har flyttet seg
            if (PosisjonFør != PosisjonNå)
            {
                //fyller in kordinater
                frmPosisjon.instance.FyllKoordinater(PosisjonNå.Lat, PosisjonNå.Lng);

                int ZoomLevel = 18;  
                
                //zoomlevel baser på hva du har fylt ut
                if (!string.IsNullOrWhiteSpace(Adresse)) ZoomLevel = 18;
                else if (!string.IsNullOrWhiteSpace(ByKommune)) ZoomLevel = 11;
                else if (!string.IsNullOrWhiteSpace(Land)) ZoomLevel = 5;

                frmVisning.instance.map.Zoom = ZoomLevel;
            }
        }

        public static List<string> FåAddress(PointLatLng point)
        {
            // Må bruke google API  for denne delen av koden
            // Hvis man ikke har google API vil denne delen ikke virke
            // Metoden henter adresse(hvis finnes) basert på koordinatene  

            try
            {
                List<Placemark> Info = null;
                //henter info baser på kordinater 
                var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out Info);
                //var statusCode = GMapProviders.OpenStreetMap.GetPlacemarks(point,out Info); // OpenStreetMap
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
            // Fjern en enkelt rute 
            for (int i = 0; i < frmVisning.instance.map.Overlays.Count; i++)
            {
                if (frmVisning.instance.map.Overlays[i].Id == Globalekonstanter.NavnRute)
                {
                    frmVisning.instance.map.Overlays.RemoveAt(i);
                    reff(MuligKart.Visning);
                    if (frmPosisjon.instance != null)
                        frmPosisjon.instance.lblDistanse.Text = "[Distanse i Km]";
                    break;
                }
            }
        }

        public static void FjernAlleMarkører_redigier(string områdeId)
        {
            // Fjerner alle hjelpemarkør i redigeringskartet
            for (int i = 0; i < FrmRediger.instance.map.Overlays.Count; i++)
            {
                if (FrmRediger.instance.map.Overlays[i].Id == områdeId)
                {
                    FrmRediger.instance.map.Overlays.RemoveAt(i);
                    i--;
                }
            }
            // Oppdatere kartet 
            reff(MuligKart.Redigering);
        }

        public static bool SjekkKartHarHjelpemarkør_redigier(string områdeId)
        {
            // Sjekker om kartet har en hjelpemakør ute nå
            bool svar = false;

            for (int i = 0; i < FrmRediger.instance.map.Overlays.Count; i++)
            {
                if (FrmRediger.instance.map.Overlays[i].Id == områdeId)
                {
                    svar = true;
                    break;
                }
            }

            return svar;
        }

        public static void FjernHjelpeOmråde()
        {
            // Fjerner "Hjelpeområdet"
            // Er kun et Hjelpeområde av gangen 

            for (int i = 0; i < FrmRediger.instance.map.Overlays.Count; i++)
            {
                if (FrmRediger.instance.map.Overlays[i].Id == Globalekonstanter.NavnHjelpeOmråde)
                {
                    FrmRediger.instance.map.Overlays.RemoveAt(i);
                    break;
                }
            }
        }

        public static void AlleOmrådeTilgjenlighet(bool klikkBar)
        {
            //Metode for å gjøre polygoner/områder klikkbare eller uklikkbare 

            foreach (var item in FrmRediger.instance.map.Overlays)
            {
                if (item.Id == Globalekonstanter.NavnOmråde)
                {
                    item.IsHitTestVisible = klikkBar;
                }
            }
        }
    }
}
