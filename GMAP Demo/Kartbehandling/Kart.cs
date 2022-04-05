using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    internal class Kart
    {
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

        public static void Visning_OppdaterListeOgKart()
        {
            //FrmVisning.instance.OppdaterKart();
            frmFilter.instance.OppdaterKart();
        }

        public static void Redigering_OppdaterListeOgKart()
        {
            //bruker listene i FrmVisning, så visning_oppdaterkart må kjører først 
            frmRediger.instance.OppdaterKart();
        }

    }
}
