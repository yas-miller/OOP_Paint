using System.Drawing;
using System.Drawing.Drawing2D;
using PluginBase;

namespace PluginCircle
{
    public class Circle : AbstractPlugin
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int R { get; set; }

        public Circle()
        {

        }

        public Circle(int x1, int y1, int r)
        {
            this.R = r;
            this.X1 = x1;
            this.Y1 = y1;
        }

        public override void Create()
        {
            base.Create();
            this.GraphicsPath.StartFigure();
            this.GraphicsPath.AddEllipse(X1, Y1, 2 * R, 2 * R);
            this.GraphicsPath.CloseFigure();
        }

        public override string ToString()
        {
            return "Circle";
        }

        public override object Clone()
        {
            return new Circle(this.X1, this.Y1, this.R);
        }
    }
}
