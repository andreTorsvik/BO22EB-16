using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    public class FellesMetoder
    {
        public static HashSet<string> FåAlleTags()
        {
            HashSet<string> AlleOverlay = new HashSet<string>();

            try
            {
                var OverlayOListe = DatabaseCommunication.ListAllTags_OmrådeFromDb();
                foreach (var item in OverlayOListe)
                {
                    AlleOverlay.Add(item.Tag.ToString());
                }

                var OverlayRListe = DatabaseCommunication.ListAllTags_RessursFromDb();
                foreach (var item in OverlayRListe)
                {
                    AlleOverlay.Add(item.Tag.ToString());
                }

            }
            catch (Exception feilmelding)
            {

            }
            return AlleOverlay;
        }


    }
}
