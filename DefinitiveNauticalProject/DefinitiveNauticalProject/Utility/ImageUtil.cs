using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace DefinitiveNauticalProject.Utility
{
    static class ImageUtil
    {
        public static string ConvertImageToString(string path)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(path);
            return Convert.ToBase64String(imageArray);
        }

        public static Image GetImageFromString(string B64image)
        {
            if (B64image != null)
            {
                return Image.FromStream(new MemoryStream(Convert.FromBase64String(B64image)));
            }
            else
            {
                return null;
            }
            
        }
    }
}
