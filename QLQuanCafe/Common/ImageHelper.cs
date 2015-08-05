using System;
using System.IO;

namespace QLQuanCafe.Common
{
    public static class ImageHelper
    {
        public static string CreateImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                string localData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                localData += "\\DoyledWorldCafe";
                if (!Directory.Exists(localData))
                    Directory.CreateDirectory(localData);

                string newFileName = localData + "\\" + Guid.NewGuid() + Path.GetExtension(imagePath);

                //if (newFileName != imagePath)
                //{
                //    File.Copy(MenuItemToSave.ImagePath, newFileName, true);
                //    MenuItemToSave.ImagePath = newFileName;
                //}

                File.Copy(imagePath, newFileName, true);
                return newFileName;
            }
            return "";
        }
    }
}
