using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficzne3
{
    internal class Bezier
    {
        public Dictionary<Color, BezierCurve> BezierCurves;
        private int Height;
        private int Width;

        public Bezier(int height, int width)
        {
            BezierCurves = new Dictionary<Color, BezierCurve>
            {
                { Color.Cyan, new BezierCurve(Color.Cyan, height) },
                { Color.Magenta, new BezierCurve(Color.Magenta, height) },
                { Color.Yellow, new BezierCurve(Color.Yellow, height) },
            };
            Height = height;
            Width = width;
        }

        public void Draw(Color color, Graphics graphics)
        {
            BezierCurves[color].Draw(graphics);
        }

        public void DrawAll(Graphics graphics, Bitmap bitmap, BlackMode blackMode)
        {
            foreach (var curve in BezierCurves.Values)
            {
                curve.Draw(graphics);
            }
            DrawBlack(bitmap, blackMode);
        }

        public BezierCurve this[Color color]
        {
            get => BezierCurves[color];
            set => BezierCurves[color] = value;
        }

        public void DrawBlack(Bitmap bitmap, BlackMode blackMode)
        {
            double[] y = GetBlack(blackMode);

            for(int x = 0; x < y.Length; x++)
            {
                bitmap.SetPixel(x, bitmap.Height - (int)y[x] - 1, Color.Black);
            }
        }

        public double[] GetBlack(BlackMode blackMode)
        {
            switch (blackMode)
            {
                case BlackMode.Zero:
                    return new double[Width];
                case BlackMode.Full:
                    return GetFullBlack();
                default: return new double[Width]; // CHange

            }
        }

        public double[] GetFullBlack()
        {
            double[] y = new double[Width];
            for(int x = 0; x < Width; x++)
            {
                y[x] = x * (double)Height / Width;
            }

            return y;
        }

        public static int GetColorComponent(Color color, Color source)
        {
            if (color == Color.Cyan) return source.R;
            else if (color == Color.Magenta) return source.G;
            else if (color == Color.Yellow) return source.B;

            return -1;
        }

        public double[] GetValues(Color color)
        {
            return BezierCurves[color].GetGraph(Width, Height);
        }

        public (Color, int) SelectPoint(Point click)
        {
            foreach(BezierCurve curve in BezierCurves.Values)
            {
                for(int i = 0; i < curve.Points.Count; i++)
                {
                    if (Utils.GetDistance(curve.Points[i], click) < Constants.PointDistance)
                    {
                        return (curve.Color, i);
                    }
                }
            }

            return (Color.White, -1);
        }

        public void MovePoint(Point point, Color color, int index)
        {
            BezierCurves[color].Points[index] = point;
        }
    }
}
