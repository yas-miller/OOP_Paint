using System.Drawing;
using System.Windows.Forms;
using PluginBase;

namespace BaseProject
{
    static class DrawTool
    {
        public static void DrawFigure(PictureBox pictureBox, IPlugin shape)
        {
            const int BmpWidth = 500;
            const int BmpHeight = 529;

            Bitmap bitmap = pictureBox.Image != null
                ? new Bitmap(pictureBox.Image, pictureBox.Image.Width, pictureBox.Image.Height)
                : new Bitmap(BmpWidth, BmpHeight);

            Graphics graphics = Graphics.FromImage(bitmap);
            shape.Create();
            graphics.DrawPath(shape.Pen, shape.GraphicsPath);

            pictureBox.Image = bitmap;
        }
    }
}
