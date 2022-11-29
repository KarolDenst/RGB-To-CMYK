using System.Globalization;
using System.Text;

namespace Graficzne3
{
    internal class BezierCurve
    {
        public List<Point> Points;
        public Color Color;

        public BezierCurve(Color color, int height)
        {
            Points = new List<Point>
            {
                new Point(0, height)
            };

            Color = color;
        }

        public BezierCurve(Color color, string path)
        {
            Points = new List<Point>();

            foreach(string line in File.ReadAllLines(path))
            {
                string[] xy = line.Split(' ');
                int x = int.Parse(xy[0], CultureInfo.InvariantCulture);
                int y = int.Parse(xy[1], CultureInfo.InvariantCulture);

                Points.Add(new Point(x, y));
            }

            Color = color;
        }

        public void AddPoint(Point p, int width)
        {
            if (Points.Count >= 4) return;
            if (Points.Count == 3)
            {
                Point newPoint= new Point(width, p.Y);
                Points.Add(newPoint);
                return;
            }
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

            foreach(Point p in Points)
            {
                Rectangle rectangle = new Rectangle(p.X - 7, p.Y - 1, 6, 6);
                using (Pen pen = new Pen(Color)) g.DrawEllipse(pen, rectangle);
            }
        }

        public void SaveCurve(string path)
        {
            StringBuilder stringBuilder= new StringBuilder();
            foreach(Point point in Points)
            {
                stringBuilder.AppendLine(point.X.ToString() + " " + point.Y.ToString());
            }
            File.WriteAllText(path, stringBuilder.ToString());
        }

        public double[] GetGraph(int width, int height)
        {
            if (Points.Count < 4) return new double[width];

            double[] y = new double[width];

            double i = 0.02;
            Point prev = GetP(0.0);
            Point current = GetP(0.01);

            for(int x = 0; x < width; x++)
            {
                if(x > current.X)
                {
                    prev = current;
                    current = GetP(i);
                    i += 0.01;
                }

                double diff = -prev.X + current.X;
                double d1 = (x - prev.X) / diff;
                double d2 = (current.X - x) / diff;

                y[x] = (height - (d2 * prev.Y + d1 * current.Y)) / height;
            }

            return y;
        }

        public void SetFull(int width, int height)
        {
            Points = new List<Point>
            {
                new Point(0, height),
                new Point((int)( 1 / 3.0 * width), (int)( 2 / 3.0 * height)),
                new Point((int)( 2 / 3.0 * width), (int)( 1 / 3.0 * height)),
                new Point((int)( 3 / 3.0 * width), 0)
            };
        }

        public void SetZero(int width, int height)
        {
            Points = new List<Point>
            {
                new Point(0, height),
                new Point((int)( 1 / 3.0 * width), height),
                new Point((int)( 2 / 3.0 * width), height),
                new Point((int)( 3 / 3.0 * width), height),
            };
        }

        public void SetUCR(int width, int height)
        {
            Points = new List<Point>
            {
                new Point(0, height),
                new Point((int)( 5 / 8.0 * width), height),
                new Point((int)( 7 / 8.0 * width), (int)(1 / 2.0 * height)),
                new Point((int)( 3 / 3.0 * width), 0),
            };
        }

        public void SetGCR(int width, int height)
        {
            Points = new List<Point>
            {
                new Point(0, height),
                new Point((int)( 2 / 4.0 * width), height),
                new Point((int)( 3.9 / 4.0 * width), (int)( 3.9 / 4.0 * height)),
                new Point((int)( 3 / 3.0 * width), 0),
            };
        }
    }
}
