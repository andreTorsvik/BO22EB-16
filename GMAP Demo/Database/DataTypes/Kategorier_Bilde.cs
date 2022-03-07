using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo.Database.DataTypes
{
    public class Kategorier_Bilde
    {
        public string Kategorinavn { get; set; }
        public byte[] Bilde { get; set; }


        // Mulig måte å håndtere bilder til array(Byte) //https://www.codeproject.com/Questions/872267/store-image-in-a-variable-in-csharp-Please-Help-me
        /*
        
        // Image to Byte[]
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        // Byte[] to Image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        */


        public string kategorier_BildeDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({Kategorinavn})";
            }
        }



    }
}