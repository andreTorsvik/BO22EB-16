using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GMAP_Demo
{
    internal class Kart
    {
        public enum MuligKart { Visning, Redigering, Begge };
        public static PointLatLng PunktFraForrige = new PointLatLng();
        public static bool VisOmrådePåKart = true;
        public static int RutePåkartet = 0;

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
                    FrmVisning.instance.map.MapProvider = Valgtkart;

                    //start posisjon kart
                    FrmVisning.instance.map.Position = Startpunkt; 

                    //settings for kart: zoom
                    FrmVisning.instance.map.MinZoom = minZoom; 
                    FrmVisning.instance.map.MaxZoom = maksZoom; 
                    FrmVisning.instance.map.Zoom = Zoom; 

                    // Gjør det mulig å "dra" kartet 
                    FrmVisning.instance.map.DragButton = System.Windows.Forms.MouseButtons.Left;
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

        public static void OppdaterKart(MuligKart kart, List<Ressurs> Lressurs, List<Område> Lområde)
        {           
            if(kart == MuligKart.Visning)
            {
                // Lagre ruter, hvis de finnes
                List<GMapOverlay> Lroutes = new List<GMapOverlay>();
                if (RutePåkartet > 0)
                    Lroutes = LagreRuteVisning();

                // Fjerne alt på kartet, som programmet har lagt til
                FrmVisning.instance.map.Overlays.Clear();

                // Objekter til ikke tegnet inn, hvis zoomlevel er utenfor grense
                if (!GlobaleVariabler.UtenforZoomGrense)
                    LeggTilRessurs(Lressurs, kart);

                // Legger til rute, hvis noen
                LeggTilOverlayRute(Lroutes);
            }
            else if(kart == MuligKart.Redigering)
            {
                // Fjerne alt på kartet som programmet har lagt til
                FrmRediger.instance.map.Overlays.Clear();

                //Tar ikke hensyn til zoom level 
                LeggTilRessurs(Lressurs, kart);
            }
            else if(kart == MuligKart.Begge)
            {
                OppdaterKart(MuligKart.Visning, Lressurs, Lområde);
                OppdaterKart(MuligKart.Redigering, Lressurs, Lområde);
                return;
            }

            // Legger til områdene, hvis man ikke har "checked" i filter 
            if (VisOmrådePåKart) 
                LeggTilOmråde(Lområde, kart);

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
            if (kart == MuligKart.Visning) FrmVisning.instance.map.Overlays.Add(markers);
            else if (kart == MuligKart.Redigering ) FrmRediger.instance.map.Overlays.Add(markers);
            else if (kart ==MuligKart.Begge)
            {
                FrmVisning.instance.map.Overlays.Add(markers);
                FrmRediger.instance.map.Overlays.Add(markers);
            }

            //oppdatere antall objekter i formFilter hvis den er åpen 
            if (Frm_V_Filter.instance != null)
            {
                Frm_V_Filter.instance.OppdaterAntall();
            }
        }

        public static void LeggtilMarkør(MuligKart kart, PointLatLng punkt, int Rekkefølge, string MarkørID)
        {
            //Rekkefølge = -1, da vil man ikke få tooltip tekst,- 
            //Det blir brukt som dobbelttrykk (gul markør) på redigeringsformen. 

            //Blå markør er for å visse hjørnene til eksisterende områder/polygon og rekkefølgen på de
            //for enklere kunne gjøre endringer 

            GMapMarker marker;
            GMapOverlay markers = new GMapOverlay(MarkørID);

            if (MarkørID == Globalekonstanter.NavnHjelpeMarkør)
            {
                // Gulmarkør / dobbelt trykket
                marker = new GMarkerGoogle(punkt, GMarkerGoogleType.yellow);
            }
            else
            {
                // Blåmarkør / Hjørnet på et området
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
            // metode "Map_OnMarkerClick" i "FrmRediger" sjekker om tag != -1 
            marker.Tag = -1;

            markers.Markers.Add(marker);

            //legger til på riktig kart
            if (kart == MuligKart.Visning ) FrmVisning.instance.map.Overlays.Add(markers);
            else if (kart == MuligKart.Redigering ) FrmRediger.instance.map.Overlays.Add(markers);

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

            // Legg til på visnings kartet            
            FrmVisning.instance.map.Overlays.Add(routes);

            //Lagrer at man har en rute på kartet 
            RutePåkartet++;

            // Plasser kartet i starten av ruten 
            FrmVisning.instance.map.Position = Start;

            // Legger inn avstanden 
            if (Frm_V_Posisjon.instance != null)
                Frm_V_Posisjon.instance.lblDistanse.Text = route.Distance.ToString() + " Km";
        }

        public static List<GMapOverlay> LagreRuteVisning()
        {
            // Lagrer kun rute fra visning-kart 
            List<GMapOverlay> Lroutes = new List<GMapOverlay>();

            for (int i = 0; i < FrmVisning.instance.map.Overlays.Count; i++)
            {
                if (FrmVisning.instance.map.Overlays[i].Id == Globalekonstanter.NavnRute)
                {
                    Lroutes.Add(FrmVisning.instance.map.Overlays[i]);

                }
            }

            return Lroutes;
        }

        public static void LeggTilOverlayRute(List<GMapOverlay> Lroutes)
        {
            if (Lroutes.Count > 0)
            {
                foreach (var item in Lroutes)
                {
                    FrmVisning.instance.map.Overlays.Add(item);
                }
            }
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
                if ( kart == MuligKart.Visning) FrmVisning.instance.map.Overlays.Add(polygons);
                else if ( kart == MuligKart.Redigering) FrmRediger.instance.map.Overlays.Add(polygons);
                else if ( kart == MuligKart.Begge)
                {
                    FrmVisning.instance.map.Overlays.Add(polygons);
                    FrmRediger.instance.map.Overlays.Add(polygons);
                }
            }
        }

        public enum MuligeFarger { Rød, Oransje, Grønn, Blå, Gul, Lilla, Rosa, Turkis, Hvit, Svart };  // Listen er kun for å vise hva som er tilgjenglig i "BestemFarge", må legge inn manuelt
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
   
        public static void TegnHjelpeOmråde_rediger(PointLatLng klikket, List<PointLatLng> Lpunkt)
        {
            // Metoden blir kun brukt i redigering  
            // Metoden tegner et "hjelpeområde" underveis, for å vise brukeren hvordan område kommer til å se ut
            // Det er 2 "TegnHjelpeOmråde_rediger" den metoden tar et ekstra argument: der brukern har dobbeltklikket på kartet 
            // Dette for å gjøre "hjelpeområdet" mer dynamisk og tydeligere hvordan område kommer til å se ut 

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

                // Legger til som overlay på redigeringskartet 
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
            // Det er 2 "TegnHjelpeOmråde_rediger" den metoden, tar kun punktene til område/polygon og tegner området 

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

                // Legger til som overlay på redigeringskartet
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

            GlobaleVariabler.KartOppdatere = true;
            const double PlussMinus = 0.01;
            switch (kart)
            {
                case MuligKart.Visning:
                    FrmVisning.instance.map.Zoom = FrmVisning.instance.map.Zoom + PlussMinus;
                    FrmVisning.instance.map.Zoom = FrmVisning.instance.map.Zoom - PlussMinus;
                    break;
                case MuligKart.Redigering:
                    FrmRediger.instance.map.Zoom = FrmRediger.instance.map.Zoom + PlussMinus;
                    FrmRediger.instance.map.Zoom = FrmRediger.instance.map.Zoom - PlussMinus;
                    break;
                case MuligKart.Begge:
                    FrmVisning.instance.map.Zoom = FrmVisning.instance.map.Zoom + PlussMinus;
                    FrmVisning.instance.map.Zoom = FrmVisning.instance.map.Zoom - PlussMinus;

                    FrmRediger.instance.map.Zoom = FrmRediger.instance.map.Zoom + PlussMinus;
                    FrmRediger.instance.map.Zoom = FrmRediger.instance.map.Zoom - PlussMinus;
                    break;
            }
            GlobaleVariabler.KartOppdatere = false;
        }

        public static void FinnLokasjon(string Land, string ByKommune, string Adresse)
        {
            // Setter sammen strengene til rett format
            string sammenSlått = Tekstbehandling.AdresseTekstfelt(Land, ByKommune, Adresse);

            // Posisjon før flytting
            PointLatLng PosisjonFør = FrmVisning.instance.map.Position;

            // Setter kartet til posisjon bassert på tekst 
            FrmVisning.instance.map.SetPositionByKeywords(sammenSlått);

            // Finne nåværende punkt 
            PointLatLng PosisjonNå = FrmVisning.instance.map.Position;

            // Hvis kartet har flyttet seg
            if (PosisjonFør != PosisjonNå)
            {
                // Fyller in kordinater
                Frm_V_Posisjon.instance.FyllKoordinater(PosisjonNå.Lat, PosisjonNå.Lng);

                int ZoomLevel = 18;

                // Zoomlevel baser på hvilke tekstfelt som er fylt ut
                if (!string.IsNullOrWhiteSpace(Adresse)) ZoomLevel = 18;
                else if (!string.IsNullOrWhiteSpace(ByKommune)) ZoomLevel = 11;
                else if (!string.IsNullOrWhiteSpace(Land)) ZoomLevel = 5;

                FrmVisning.instance.map.Zoom = ZoomLevel;
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
                // Henter info baser på kordinater med hjelp av googlemap 
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
            // Fjern alle rutene 
            for (int i = 0; i < FrmVisning.instance.map.Overlays.Count; i++)
            {
                if (FrmVisning.instance.map.Overlays[i].Id == Globalekonstanter.NavnRute)
                {
                    FrmVisning.instance.map.Overlays.RemoveAt(i);
                    i--;            
                }
            }

            if (Frm_V_Posisjon.instance != null)
                Frm_V_Posisjon.instance.lblDistanse.Text = "[Distanse i Km]";

            RutePåkartet = 0;
            reff(MuligKart.Visning);
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
            // Sjekker om kartet har en hjelpemakør ute nå, i redigerings kartet 

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
            // Fjerner "Hjelpeområdet" på redigerings kartet 
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
