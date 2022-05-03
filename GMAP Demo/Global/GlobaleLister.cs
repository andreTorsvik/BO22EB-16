using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    internal class GlobaleLister
    {
        public static List<Ressurs> LRessurs = new List<Ressurs>();
        public static  List<Område> LOmråde = new List<Område>();
        public static  List<Kategorier_Bilde> LKategori = new List<Kategorier_Bilde>();

        // Lister for filtrering på kategorier:
        // BindingList for lbKategorierVises REF: https://stackoverflow.com/questions/17615069/how-to-refresh-datasource-of-a-listbox, https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.bindinglist-1?view=net-6.0
        public static BindingList<Kategorier_Bilde> kategoriListeVises = new BindingList<Kategorier_Bilde>();
        public static BindingList<Kategorier_Bilde> kategoriListeSkjult = new BindingList<Kategorier_Bilde>();

        // Lister for filtrering på Tags:
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
                FellesMetoder.OppdaterKategoriListe();
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
                FellesMetoder.OppdaterTag_Liste();
            }
        }

        internal static void InitializeTag_RessursListeSkjult()
        {
            tag_ListeSkjult.AllowNew = true;
            tag_ListeSkjult.AllowRemove = true;
            tag_ListeSkjult.RaiseListChangedEvents = true;
        }


    }
}
