using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficzne3
{
    internal class BezierCurve
    {
        public List<Point> Points;
        public Color Color;

        public BezierCurve(Color color)
        {
            Points = new List<Point>();
            Points.Add(new Point(0, 0));

            Color = color;
        }

        public void AddPoint(Point p)
        {
            if (Points.Count >= 4) return;
            Points.Add(p);
        }

        public Point GetP(double t)
        {
            double px = 0;
            double py = 0;
            int n = Points.Count - 1;
            for(int i = 0; i <= n; i++)
            {
                double b = GetB(i, n, t);
                px += Points[i].X * b;
                py += Points[i].Y * b;
            }

            return new Point((int)px, (int)py);
        }

        public static double GetB(int i, int n, double t)
        {
            return Utils.Binom(n, i) * Math.Pow(t, i) * Math.Pow(1 - t, n - i);
        }

        public void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color))
            {
                Point prev = GetP(0);

                for (double i = 0.01; i <= 1; i += 0.01)
                {
                    Point p = GetP(i);
                    g.DrawLine(pen, prev, p);
                    prev = p;
                }
            }
        }
    }
}
