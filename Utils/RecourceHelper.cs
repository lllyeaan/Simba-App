using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MaterialOrderingApp.Utils
{
    public static class ResourceHelper
    {
        /// <summary>
        /// Loads an image from the Resources folder in the application's base directory.
        /// </summary>
        /// <param name="fileName">Image file name (with extension, e.g. "btn_close.png")</param>
        /// <returns>Image if found; null otherwise</returns>
        public static Image LoadImageFromResources(string fileName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(basePath, "Resources", fileName);

            if (File.Exists(imagePath))
            {
                using (MemoryStream stream = new MemoryStream(File.ReadAllBytes(imagePath)))
                {
                    return Image.FromStream(stream);
                }
            }
            else
            {
                MessageBox.Show($"Gambar '{fileName}' tidak ditemukan di folder Resources.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
