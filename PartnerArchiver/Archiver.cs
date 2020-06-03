using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace PartnerArchiver
{
    internal class Archiver
    {
        public void CreateArchive(string path)
        {
            string zipPath = path + ".zip";
            if (File.Exists(zipPath))
            {
                File.Delete(zipPath);
            }
            ZipFile.CreateFromDirectory(path, zipPath);
            MessageBox.Show("Папка успешно заархивирована");
        }

        public void ReadArchive(string zipPath)
        {
            string extractPath = zipPath.Replace(".zip", "");
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            MessageBox.Show("Папка успешно разархивирована");
        }
    }
}
