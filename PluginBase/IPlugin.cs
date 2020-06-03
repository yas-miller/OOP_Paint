using System.Drawing;
using System.Drawing.Drawing2D;

namespace PluginBase
{
    public interface IPlugin
    {
        GraphicsPath GraphicsPath { get; }

        void Create();

        Pen Pen { get; }

        string ToString();

        object Clone();
    }
}
