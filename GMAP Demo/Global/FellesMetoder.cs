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
                bool OR = Frm_V_Filter.instance.filterOR;
                bool AND = Frm_V_Filter.instance.filterAND;

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
            else // ingen valgte tags 
            {
                GlobaleLister.LOmråde.Clear();
            }

        }

        public static void OppdaterListe_ressurs()
        {
            // Tømmerlisten 
            if (GlobaleLister.LRessurs.Count > 0) GlobaleLister.LRessurs.Clear();

            // Henter alle ressurser
            var RessursList = DBComRessurs.ListAllRessursFromDb(InnloggetBruker.Sikkerhetsklarering);

            // Legger til i den globale listen, men basert på kategorilisten 
            foreach (var item in RessursList)
            {
                foreach (var item2 in GlobaleLister.kategoriListeVises)
                {
                    if (item.Kategori.ToString() == item2.Kategorinavn.ToString())
                    {
                        GlobaleLister.LRessurs.Add(item);
                        break;
                    }
                }
            }

            // Filtrering ut objekter baser på tag
            if (GlobaleLister.kategoriListeVises.Count != 0 || GlobaleLister.tag_ListeVises.Count != 0)
            {
                // Finner ut hvilket filter man skal bruke 
                bool OR = Frm_V_Filter.instance.filterOR;
                bool AND = Frm_V_Filter.instance.filterAND;

                if (OR && !AND) // OR
                {
                    if (GlobaleLister.kategoriListeSkjult.Count != 0 || GlobaleLister.tag_ListeSkjult.Count != 0)
                    {
                        FilterBehandling.filtrereBaserPåTagsOR(ref GlobaleLister.LRessurs, GlobaleLister.tag_ListeVises.ToList());
                    }
                }
                else if (AND && !OR) // AND
                    FilterBehandling.filtrereBaserPåTagsAND(ref GlobaleLister.LRessurs, GlobaleLister.tag_ListeVises.ToList());
            }
            else // Ingen valgte tags 
            {
                GlobaleLister.LRessurs.Clear();
            }
        }

        public static void OppdaterTag_Liste()
        {
            //oppdatere Vises tagliste 

            // Tømer hvis den har innhold 
            if (GlobaleLister.tag_ListeVises.Count > 0) GlobaleLister.tag_ListeVises.Clear();

            // Henter alle tags fra databasen
            HashSet<string> tag_ListeAlle = FellesMetoder.FåAlleTags();

            // Henter alle "skjulte" tags 
            List<string> ListskjultTags = GlobaleLister.tag_ListeSkjult.ToList();

            // Sorter ut alle de "skjulte" fra alle tags  
            List<string> ListeVisteTags = tag_ListeAlle.Except(ListskjultTags).ToList();

            //oppdatere TagVisteListe
            foreach (var item in ListeVisteTags)
            {
                GlobaleLister.tag_ListeVises.Add(item);
            }

            //oppdatere  skjulte taglisten:

            //tømer listen 
            if (GlobaleLister.tag_ListeSkjult.Count > 0) GlobaleLister.tag_ListeSkjult.Clear();

            // Sorter ut alle de "synlige" fra alle tags 
            ListskjultTags = tag_ListeAlle.Except(ListeVisteTags).ToList();

            //legger dem til 
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
            GlobaleLister.kategoriListeVises.Clear();

            // Henter alle kategoriene 
            List<Kategorier_Bilde> kategoriListeAlle = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();

            // Henter sjulte
            List<Kategorier_Bilde> ListeSkjulteKategori = GlobaleLister.kategoriListeSkjult.ToList();

            // Sorter ut alle de "skjulte" fra alle kateogirene  
            List<Kategorier_Bilde> ListeVisteKategorier = new List<Kategorier_Bilde>( kategoriListeAlle);
            for (int i = 0; i < ListeVisteKategorier.Count; i++)
            {
                foreach (var item in ListeSkjulteKategori)
                {
                    if(item.Kategorinavn == ListeVisteKategorier[i].Kategorinavn)
                    {
                        ListeVisteKategorier.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            //legger til etter sortering
            foreach (var item in ListeVisteKategorier)
            {
                GlobaleLister.kategoriListeVises.Add(item);
            }

            // oppdatere skjultListe 

            ListeSkjulteKategori.Clear();
            ListeSkjulteKategori = new List<Kategorier_Bilde>(kategoriListeAlle);

            GlobaleLister.kategoriListeSkjult.Clear();

            //Sorter ut det som er i "viste" 
            //med denne metoden å gjøre det på, fjern man eventuelle kategorier, som 
            //har blitt slettet fra databasen men ikke i programmet enda 

            for (int i = 0; i < ListeSkjulteKategori.Count; i++)
            {
                foreach (var item in ListeVisteKategorier)
                {
                    if (item.Kategorinavn == ListeSkjulteKategori[i].Kategorinavn)
                    {
                        ListeSkjulteKategori.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            // Legger til igjen etter sortering 
            foreach (var item in ListeSkjulteKategori)
            {
                GlobaleLister.kategoriListeSkjult.Add(item);
            }
            

        }

        public static HashSet<string> FåAlleTags()
        {
            HashSet<string> AlleTag = new HashSet<string>();

            try
            {
                var TagOListe = DBComTag_Område.ListAllTag_OmrådeFromDb();
                foreach (var item in TagOListe)
                {
                    AlleTag.Add(item.Tag.ToString());
                }

                var TagRListe = DBComTag_Ressurs.ListAllTag_RessursFromDb();
                foreach (var item in TagRListe)
                {
                    AlleTag.Add(item.Tag.ToString());
                }

            }
            catch (Exception)
            {

            }

            return AlleTag;

        }

        public static bool MeldingsboksYesNo(string Tittel, string tekst)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
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
