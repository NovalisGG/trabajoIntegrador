using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_registro_de_alumnos.Clases
{
    public static class Dibujar
    {
        public static GraphicsPath RoundedRectanglePath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            //Top left arc
            path.AddArc(arc, 180, 90);

            //Top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            //bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 90, 90);

            //bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle bounds, int cornerRadius, GraphicsPath path)
        {
            graphics.DrawPath(pen, path);
        }

        public static void FillRoundedRectangle(this Graphics graphics, SolidBrush brush, GraphicsPath path)
        {
            graphics.FillPath(brush, path);
        }

    }
}
