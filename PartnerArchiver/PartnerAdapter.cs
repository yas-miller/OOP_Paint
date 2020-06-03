using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerArchiver
{
    internal class PartnerAdapter : Archiver, IPlugin, ICloneable
    {
        public void Create(string path)
        {
            new Archiver().CreateArchive(path);
        }
        
        public void Read(string zipPath)
        {
            new Archiver().ReadArchive(zipPath);
        }
        public override string ToString()
        {
            return "Archiver";
        }

        public object Clone()
        {
            return new PartnerAdapter();
        }
    }
}
