using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemIdeiasPics.Classes.Manipuladores
{
    public static class ManipulaImagem
    {
        public static string ConverteImagemParaBase64(string caminho)
        {
            using (Image image = Image.FromFile(caminho))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        public static Image ConverteBase64ParaImagem(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        public static Region ImagemRedonda(int w, int h)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(5, 5, w - 15, h - 5);
            return new Region(gp);
        }

        public static byte[] ConverteImagemParaByte(Image img)
        {
            Bitmap copy = new Bitmap(img);
            using (var ms = new MemoryStream())
            {
                copy.Save(ms,ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image ConverteByteParaImage(byte[] img)
        {
            using (var ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }

        public static bool ConverteImagensParaZip(string zipPath, params Image[] images)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var zip = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    foreach (Image img in images)
                    {
                        var file = zip.CreateEntry($"{Guid.NewGuid()}-{DateTime.Now:ddMMyyhhmmss}.jpg");
                        using (var entryStream = file.Open())
                        {
                            byte[] vs = ConverteImagemParaByte(img);
                            entryStream.Write(vs, 0, vs.Length);
                        }
                    }
                }
                using (var final = new FileStream(zipPath, FileMode.Create))
                {
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    memoryStream.CopyTo(final);
                }
            }
            return File.Exists(zipPath);
        }
    }
}
