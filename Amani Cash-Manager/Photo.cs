using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Amani_Cash_Manager
{
    #region la classe photo

    public static class Photo
    {
        public static void SaveInFile(Image image)
        {
            using (var ms = new MemoryStream())
            {
                string fileName = "photo.png";
                image.Save(ms, ImageFormat.Png);
                var img = Image.FromStream(ms);
                img.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + fileName, ImageFormat.Png);
            }
        }

        public static Image GetImageDataFromFolder()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                string fileName = "photo.png";
                Image image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + fileName);
                image.Save(ms, ImageFormat.Png);
                return Image.FromStream(ms);
            }
        }

        public static byte[] GetConvertedImageFromFiles(Image photo)
        {
            #region conversion de l'image

            using (MemoryStream memory = new MemoryStream())
            {
                byte[] image;
                if (photo != null)
                {
                    string fileName = "photo.png";
                    Image imageF = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + fileName);
                    imageF.Save(memory, imageF.RawFormat);
                    image = memory.ToArray();
                }
                else
                {
                    image = null;
                }

                return image;
            }

            #endregion conversion de l'image
        }
    }

    #endregion la classe photo
}