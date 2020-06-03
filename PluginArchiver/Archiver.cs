using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using PluginBase;

namespace PluginArchiver
{
    public class Archiver: AbstractPlugin
    {
        public void Create(string path)
        {
            string zipPath = path + ".zip";
            if (File.Exists(zipPath))
            {
                File.Delete(zipPath);
            }
            ZipFile.CreateFromDirectory(path, zipPath);
            MessageBox.Show("Папка успешно заархивирована");
        }

        public void Read(string zipPath)
        {
            string extractPath = zipPath.Replace(".zip", "");
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            MessageBox.Show("Папка успешно разархивирована");
        }

        public override string ToString()
        {
            return "Archiver";
        }

        public override object Clone()
        {
            return new Archiver();
        }
    }
}
