using PluginBase;

namespace PluginBezie
{
    public class Bezie : AbstractPlugin
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }
        public int X4 { get; set; }
        public int Y4 { get; set; }

        public Bezie()
        {

        }

        public Bezie(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.X3 = x3;
            this.X4 = x4;
            this.Y1 = y1;
            this.Y2 = y2;
            this.Y3 = y3;
            this.Y4 = y4;
        }

        public override void Create()
        {
            base.Create();
            GraphicsPath.StartFigure();
            GraphicsPath.AddBezier(X1, Y1, X2, Y2, X3, Y3, X4, Y4);
            GraphicsPath.CloseFigure();
        }

        public override string ToString()
        {
            return "Bezie";
        }

        public override object Clone()
        {
            return new Bezie(X1, Y1, X2, Y2, X3, Y3, X4, Y4);
        }
    }
}
