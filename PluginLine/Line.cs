using System.Drawing;
using System.Drawing.Drawing2D;
using PluginBase;

namespace PluginLine
{
    public class Line : AbstractPlugin
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public Line()
        {

        }

        public Line(int x1, int y1, int x2, int y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }

        public override void Create()
        {
            base.Create();
            this.GraphicsPath.StartFigure();
            this.GraphicsPath.AddLine(this.X1, this.Y1, this.X2, this.Y2);
            this.GraphicsPath.CloseFigure();
        }

        public override string ToString()
        {
            return "Line";
        }

        public override object Clone()
        {
            return new Line(this.X1, this.Y1, this.X2, this.Y2);
        }
    }
}
