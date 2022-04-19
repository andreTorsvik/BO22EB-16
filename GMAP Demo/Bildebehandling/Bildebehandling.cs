using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    internal class Bildebehandling
    {
        // Metode hentet fra: //https://www.codeproject.com/Questions/872267/store-image-in-a-variable-in-csharp-Please-Help-me
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        // Metode hentet fra: //https://www.codeproject.com/Questions/872267/store-image-in-a-variable-in-csharp-Please-Help-me
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        internal static bool sjekkOmKategoriHarBilde(Ressurs item) // Mottar en ressurs og ser om ressursens kategori har et tilhørende bilde.
        {
            List<Kategorier_Bilde> kategorier_Bilde = new List<Kategorier_Bilde>();
            kategorier_Bilde = DatabaseCommunication.GetBildeForKategoriFromDbKategorier_Bilde(item.Kategori);

            if (kategorier_Bilde[0].Bilde != null)
            {
                kategorier_Bilde.Clear();

                return true;
            }
            else
            {
                kategorier_Bilde.Clear();

                return false;
            }
        }

        internal static Bitmap oppdaterBildeForMarkør(Ressurs item)
        {
            DatabaseCommunication db = new DatabaseCommunication();

            List<Kategorier_Bilde> kategorier_Bilde = new List<Kategorier_Bilde>();
            kategorier_Bilde = DatabaseCommunication.GetBildeForKategoriFromDbKategorier_Bilde(item.Kategori);

            if (kategorier_Bilde[0] != null)
            {
                Image image = byteArrayToImage(kategorier_Bilde[0].Bilde);

                Bitmap bitmap = new Bitmap(image);

                bitmap = AutoScaleBitmap(bitmap);

                kategorier_Bilde.Clear();

                return bitmap;
            }
            else
            {
                kategorier_Bilde.Clear();

                return null;
            }
        }


        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }

        // Skalerer Bitmap basert på en faktor og tilnærmet beholder "Aspect Ratio". Basert på ResizeBitmap()
        public static Bitmap ScaleBitmap(Bitmap bmp, double scalar)
        {
            double Width = bmp.Width;
            double Height = bmp.Height;
            int newWidth = Convert.ToInt32(System.Math.Round(Width * scalar));
            int newHeight = Convert.ToInt32(System.Math.Round(Height * scalar));

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.DrawImage(bmp, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }


        public static Bitmap AutoScaleBitmap(Bitmap bmp) // Autoskalerer Bitmap og tilnærmet beholder "Aspect Ratio". Basert på ScaleBitmap()
        {
            double MaxWidth = 40.0; // Max bredde i pixler
            double MaxHeight = 70.0; // Max Høyde i pixler
            double Increments = 0.9; // (0 < Increments < 1) Oppløsning for Autoskalering. Større tall = større oppløsning, og mer krevende for programmet.
            double Width = bmp.Width;
            double Height = bmp.Height;
            int newWidth;
            int newHeight;

            while ((Width > MaxWidth) || (Height > MaxHeight))
            {
                Width = Width * Increments;
                Height = Height * Increments;
            }

            newWidth = Convert.ToInt32(System.Math.Round(Width));
            newHeight = Convert.ToInt32(System.Math.Round(Height));

            Bitmap newBmp = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newBmp))
            {
                g.DrawImage(bmp, 0, 0, newWidth, newHeight);
            }

            return newBmp;
        }

    }
}
