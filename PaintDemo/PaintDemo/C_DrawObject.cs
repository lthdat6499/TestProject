using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintDemo
{
    public abstract class C_DrawObject
    {
        public bool isFill = false;
        public Point p1;
        public Point p2;
        public List<Point> point = new List<Point>();
        public Pen pen = new Pen(Color.Black);
        public SolidBrush brush = new SolidBrush(Color.Black);
        public abstract void Draw(Graphics g);
        public abstract void Fill(Graphics g);
    }
    public class C_Line : C_DrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, p1, p2);
        }

        public override void Fill(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
    public class C_Ellipse : C_DrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
        }

        public override void Fill(Graphics g)
        {
            g.FillEllipse(brush, p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
        }
    }
    public class C_Rectangle : C_DrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
        }

        public override void Fill(Graphics g)
        {
            g.FillRectangle(brush, p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
        }
    }
    public class C_Square : C_DrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.X - p1.X));
        }

        public override void Fill(Graphics g)
        {
            g.FillRectangle(brush, p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.X - p1.X));
        }
    }
    public class C_Circle : C_DrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.X - p1.X));
        }

        public override void Fill(Graphics g)
        {
            g.FillEllipse(brush, p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.X - p1.X));
        }
    }
    public class C_Curve : C_DrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawCurve(pen, point.ToArray());
        }

        public override void Fill(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
    public class C_Polygon : C_DrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawPolygon(pen, point.ToArray());
        }

        public override void Fill(Graphics g)
        {
            g.FillPolygon(brush, point.ToArray());
        }
    }
}
