using PluginBase;

namespace PluginPie
{
    public class Pie : AbstractPlugin
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int startAngle { get; set; }
        public int sweepAngle { get; set; }

        public Pie()
        {

        }

        public Pie(int x1, int y1, int w, int h, int stA, int swA)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.Width = w;
            this.Height = h;
            this.startAngle = stA;
            this.sweepAngle = swA;
        }

        public override void Create()
        {
            base.Create();
            GraphicsPath.StartFigure();
            GraphicsPath.AddPie(X1, Y1, Width, Height, startAngle, sweepAngle);
            GraphicsPath.CloseFigure();
        }

        public override string ToString()
        {
            return "Pie";
        }

        public override object Clone()
        {
            return new Pie(X1, Y1, Width, Height, startAngle, sweepAngle);
        }
    }
}
