using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public class FellesMetoder
    {
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
        public static bool MeldingsboksYesNo(string Tittle, string tekst)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(tekst, Tittle, buttons);
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
