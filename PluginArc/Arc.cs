using PluginBase;

namespace PluginArc
{
    public class Arc : AbstractPlugin
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int StartAngle { get; set; }
        public int SweepAngle { get; set; }

        public Arc()
        {

        }

        public Arc(int x1, int y1, int w, int h, int stA, int swA)
        {
            this.Width = w;
            this.Height = h;
            this.StartAngle = stA;
            this.SweepAngle = swA;
        }

        public override void Create()
        {
            base.Create();
            GraphicsPath.StartFigure();
            GraphicsPath.AddArc(X1, Y1, Width, Height, StartAngle, SweepAngle);
            GraphicsPath.CloseFigure();
        }

        public override string ToString()
        {
            return "Arc";
        }

        public override object Clone()
        {
            return new Arc(X1, Y1, Width, Height, StartAngle, SweepAngle);
        }
    }
}
