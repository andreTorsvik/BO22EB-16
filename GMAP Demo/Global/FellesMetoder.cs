using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public class FellesMetoder
    {
        public static void OppdaterListe_området()
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
            if (GlobaleLister.tag_ListeVises.Count != 0)
            {
                // Finner ut hvilket filter man skal bruke 
                bool OR = GlobaleVariabler.filterOR;
                bool AND = GlobaleVariabler.filterAND;

                if (OR && !AND) // OR
                {
                    if (GlobaleLister.kategoriListeSkjult.Count != 0 || GlobaleLister.tag_ListeSkjult.Count != 0)
                    {
                        FilterBehandling.filtrereBaserPåTagsOR(ref GlobaleLister.LOmråde, GlobaleLister.tag_ListeVises.ToList());
                    }
                }
                else if (AND && !OR) // AND
                    FilterBehandling.filtrereBaserPåTagsAND(ref GlobaleLister.LOmråde, GlobaleLister.tag_ListeVises.ToList());
            }
            else // Ingen valgte tags 
            {
                GlobaleLister.LOmråde.Clear();
            }

        }

        public static void OppdaterListe_Objekt()
        {
            // Tømmer listen 
            if (GlobaleLister.LObjekt.Count > 0) GlobaleLister.LObjekt.Clear();

            // Henter alle objekter
            var objektList = DBComObjekt.ListAllObjektFromDb(InnloggetBruker.Sikkerhetsklarering);

            // Legger til i den globale listen, men basert på kategorilisten 
            foreach (var item in objektList)
            {
                foreach (var item2 in GlobaleLister.kategoriListeVises)
                {
                    if (item.Kategori.ToString() == item2.Kategorinavn.ToString())
                    {
                        GlobaleLister.LObjekt.Add(item);
                        break;
                    }
                }
            }

            // Filtrering ut objekter baser på tag
            if (GlobaleLister.kategoriListeVises.Count != 0 || GlobaleLister.tag_ListeVises.Count != 0)
            {
                // Finner ut hvilket filter man skal bruke 
                bool OR = GlobaleVariabler.filterOR;
                bool AND = GlobaleVariabler.filterAND;

                if (OR && !AND) // OR
                {
                    if (GlobaleLister.kategoriListeSkjult.Count != 0 || GlobaleLister.tag_ListeSkjult.Count != 0)
                    {
                        FilterBehandling.filtrereBaserPåTagsOR(ref GlobaleLister.LObjekt, GlobaleLister.tag_ListeVises.ToList());
                    }
                }
                else if (AND && !OR) // AND
                    FilterBehandling.filtrereBaserPåTagsAND(ref GlobaleLister.LObjekt, GlobaleLister.tag_ListeVises.ToList());
            }
            else // Ingen valgte tags 
            {
                GlobaleLister.LObjekt.Clear();
            }
        }

        public static void OppdaterTag_Liste()
        {
            // Metoden oppdaterer Taglistene, "tag_ListeVises" og "tag_ListeSkjult" 
            // Hvis en tag har blitt fjernet, vil den forsvinne fra listene med denne metoden 
            // Hvis en tag er blitt lagt til, vil den bli lagt til i "tag_ListeVises"

            // Oppdatere Vises tagliste 

            // Tømmer hvis den har innhold 
            if (GlobaleLister.tag_ListeVises.Count > 0) GlobaleLister.tag_ListeVises.Clear();

            // Henter alle tags fra databasen
            HashSet<string> tag_ListeAlle = FellesMetoder.FåAlleTags();

            // Henter alle "skjulte" tags 
            List<string> ListskjultTags = GlobaleLister.tag_ListeSkjult.ToList();

            // Sorter ut alle de "skjulte" fra alle tags  
            List<string> ListeVisteTags = tag_ListeAlle.Except(ListskjultTags).ToList();

            // Oppdatere TagVisteListe
            foreach (var item in ListeVisteTags)
            {
                GlobaleLister.tag_ListeVises.Add(item);
            }

            // Oppdatere  skjulte taglisten:

            // Tømmer listen 
            if (GlobaleLister.tag_ListeSkjult.Count > 0) GlobaleLister.tag_ListeSkjult.Clear();

            // Sorter ut alle de "synlige" fra alle tags 
            ListskjultTags = tag_ListeAlle.Except(ListeVisteTags).ToList();

            // Legger dem til 
            if (ListskjultTags.Count != 0)
            {
                foreach (var item in ListskjultTags)
                {
                    GlobaleLister.tag_ListeSkjult.Add(item);
                }
            }
        }

        public static void OppdaterKategoriListe()
        {
            // Metoden oppdataer kategorilistenen, "kategoriListeVises" og "kategoriListeSkjult" 
            // Hvis en kategori har blitt fjernet, vil den forsvinne fra listene med denne metoden 
            // Hvis en kategori er blitt lagt til, vil den bli lagt til i "kategoriListeVises"

            // Oppdatere kategoriListeVises

            // Fjerner innhold i VistListe
            if (GlobaleLister.kategoriListeVises.Count > 0) GlobaleLister.kategoriListeVises.Clear();

            // Henter alle kategoriene 
            List<Kategorier_Bilde> kategoriListeAlle = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();

            // Henter sjulte
            List<Kategorier_Bilde> ListeSkjulteKategori = GlobaleLister.kategoriListeSkjult.ToList();

            // Sorter ut alle de "skjulte" fra alle kateogirene  
            List<Kategorier_Bilde> ListeVisteKategorier = new List<Kategorier_Bilde>(kategoriListeAlle);
            FjernLikeForekomster(ref ListeVisteKategorier, ListeSkjulteKategori);

            // Legger til etter sortering
            foreach (var item in ListeVisteKategorier)
            {
                GlobaleLister.kategoriListeVises.Add(item);
            }

            // Oppdatere kategoriListeSkjult 

            ListeSkjulteKategori.Clear();
            ListeSkjulteKategori = new List<Kategorier_Bilde>(kategoriListeAlle);

            if (GlobaleLister.kategoriListeSkjult.Count > 0) GlobaleLister.kategoriListeSkjult.Clear();

            // Sorter ut det som er i "viste" 
            FjernLikeForekomster(ref ListeSkjulteKategori, ListeVisteKategorier);

            // Legger til igjen etter sortering 
            foreach (var item in ListeSkjulteKategori)
            {
                GlobaleLister.kategoriListeSkjult.Add(item);
            }
        }

        public static void FjernLikeForekomster(ref List<Kategorier_Bilde> Hovedliste, List<Kategorier_Bilde> filtreringsListe)
        {
            // Fjern alle like forkomster mellom listene, fra hovedlisten 

            for (int i = 0; i < Hovedliste.Count; i++)
            {
                foreach (var item in filtreringsListe)
                {
                    if (item.Kategorinavn == Hovedliste[i].Kategorinavn)
                    {
                        Hovedliste.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

        }

        public static HashSet<string> FåAlleTags()
        {
            HashSet<string> AlleTag = new HashSet<string>();

            try
            {
                // Henter alle tags som er knyttet til områder 
                var TagOListe = DBComTag_Område.ListAllTag_OmrådeFromDb();
                foreach (var item in TagOListe)
                {
                    AlleTag.Add(item.Tag.ToString());
                }

                // Henter alle tags som er knyttet til objekter 
                var TagRListe = DBComTag_Objekt.ListAllTag_ObjektFromDb();
                foreach (var item in TagRListe)
                {
                    AlleTag.Add(item.Tag.ToString());
                }

            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(typeof(FellesMetoder).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }

            return AlleTag;

        }

        public static bool MeldingsboksYesNo(string Tittel, string tekst)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Viser messageBox
            result = MessageBox.Show(tekst, Tittel, buttons);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        

    }
}
