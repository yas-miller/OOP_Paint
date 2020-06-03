using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginBase;

namespace PluginRectangle
{
    public class MyRectangle : AbstractPlugin
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public MyRectangle()
        {

        }

        public MyRectangle(int x1, int y1, int w, int h)
        {
            X1 = x1;
            Y1 = y1;
            Width = w;
            Height = h;
        }

        public override void Create()
        {
            base.Create();
            GraphicsPath.StartFigure();
            GraphicsPath.AddRectangle(new Rectangle(X1, Y1, Width, Height));
            GraphicsPath.CloseFigure();
        }

        public override string ToString()
        {
            return "Rectangle";
        }

        public override object Clone()
        {
            return new MyRectangle(X1, Y1, Width, Height);
        }
    }
}
