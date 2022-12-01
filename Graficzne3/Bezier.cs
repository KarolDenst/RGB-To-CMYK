namespace Graficzne3
{
    internal class CMYK
    {
        public Dictionary<Color, BezierCurve> BezierCurves;
        public Dictionary<Color, double[]> Values;
        public int Height;
        public int Width;

        public CMYK(int height, int width)
        {
            BezierCurves = new Dictionary<Color, BezierCurve>
            {
                { Color.Cyan, new BezierCurve(Color.Cyan, height) },
                { Color.Magenta, new BezierCurve(Color.Magenta, height) },
                { Color.Yellow, new BezierCurve(Color.Yellow, height) },
                { Color.Black, new BezierCurve(Color.Black, height) },
            };
            Height = height;
            Width = width;
        }

        public void Draw(Color color, Graphics graphics)
        {
            BezierCurves[color].Draw(graphics);
        }

        public void DrawAll(Graphics graphics)
        {
            foreach (var curve in BezierCurves.Values)
            {
                curve.Draw(graphics);
            }
        }

        public BezierCurve this[Color color]
        {
            get => BezierCurves[color];
            set => BezierCurves[color] = value;
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
            foreach (BezierCurve curve in BezierCurves.Values)
            {
                for (int i = 0; i < curve.Points.Count; i++)
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

        public void UpdateValues()
        {
            Values = new Dictionary<Color, double[]>
            {
                { Color.Cyan, GetValues(Color.Cyan) },
                { Color.Magenta, GetValues(Color.Magenta) },
                { Color.Yellow, GetValues(Color.Yellow) },
                { Color.Black, GetValues(Color.Black) }
            };
        }

        public (double Cyan, double Magenta, double Yellow, double Black) GetCMYK(Color color)
        {
            double cyan = 1 - color.R / 255.0;
            double magenta = 1 - color.G / 255.0;
            double yellow = 1 - color.B / 255.0;
            double black = new[] { cyan, magenta, yellow }.Min();

            cyan = cyan - black + Values[Color.Cyan][(int)(black * Width)];
            cyan = Math.Min(cyan, 1);
            magenta = magenta - black + Values[Color.Magenta][(int)(black * Width)];
            magenta = Math.Min(magenta, 1);
            yellow = yellow - black + Values[Color.Yellow][(int)(black * Width)];
            yellow = Math.Min(yellow, 1);
            black = Values[Color.Black][(int)(black * Width)];
            black = Math.Min(black, 1);

            return (cyan, magenta, yellow, black);
        }

        public Color GetColor(Color color, Color selectedColor)
        {
            var intensities = GetCMYK(color);

            if(selectedColor == Color.Cyan) return ToRGB(intensities.Cyan, 0, 0, intensities.Black);
            if (selectedColor == Color.Magenta) return ToRGB(0, intensities.Magenta, 0, intensities.Black);
            if (selectedColor == Color.Yellow) return ToRGB(0, 0, intensities.Yellow, intensities.Black);
            return ToRGB(0, 0, 0, intensities.Black);
        }

        public Color ToRGB(double cyan, double magenta, double yellow, double black)
        {
            int r = (int)(255 * (1 - cyan) * (1 - black));
            int g = (int)(255 * (1 - magenta) * (1 - black));
            int b = (int)(255 * (1 - yellow) * (1 - black));

            return Color.FromArgb(r, g, b);
        }

        public void SetUp0Backtrack()
        {
            BezierCurves[Color.Cyan].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), (int)(1.8 / 3.0 * Height)),
                new Point((int)( 2 / 3.0 * Width), (int)(0.8/ 3.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), (int)(0 / 3.0 * Height)),
            };

            BezierCurves[Color.Magenta].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), (int)(2 / 3.0 * Height)),
                new Point((int)( 2 / 3.0 * Width), (int)(1/ 3.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), (int)(0 / 3.0 * Height)),
            };

            BezierCurves[Color.Yellow].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), (int)(1.9 / 3.0 * Height)),
                new Point((int)( 2 / 3.0 * Width), (int)(0.9/ 3.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), (int)(0 / 3.0 * Height)),
            };

            BezierCurves[Color.Black].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), Height),
                new Point((int)( 2 / 3.0 * Width), Height),
                new Point((int)( 3 / 3.0 * Width), Height),
            };
        }

        public void SetUp100Backtrack()
        {
            BezierCurves[Color.Cyan].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), Height),
                new Point((int)( 2 / 3.0 * Width), Height),
                new Point((int)( 3 / 3.0 * Width), Height),
            };

            BezierCurves[Color.Magenta].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), Height),
                new Point((int)( 2 / 3.0 * Width), Height),
                new Point((int)( 3 / 3.0 * Width), Height),
            };

            BezierCurves[Color.Yellow].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), Height),
                new Point((int)( 2 / 3.0 * Width), Height),
                new Point((int)( 3 / 3.0 * Width), Height),
            };

            BezierCurves[Color.Black].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), (int)(2 / 3.0 * Height)),
                new Point((int)( 2 / 3.0 * Width), (int)(1/ 3.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), (int)(0 / 3.0 * Height)),
            };
        }

        public void SetUpUCR()
        {
            BezierCurves[Color.Cyan].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), (int)(1.8 / 3.0 * Height)),
                new Point((int)( 2 / 3.0 * Width), (int)(0.1/ 3.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), (int)(0.4 / 3.0 * Height)),
            };

            BezierCurves[Color.Magenta].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), (int)(2 / 3.0 * Height)),
                new Point((int)( 2 / 3.0 * Width), (int)(0.2/ 3.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), (int)(0.5 / 3.0 * Height)),
            };

            BezierCurves[Color.Yellow].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), (int)(1.9 / 3.0 * Height)),
                new Point((int)( 2 / 3.0 * Width), (int)(0.1/ 3.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), (int)(0.6 / 3.0 * Height)),
            };

            BezierCurves[Color.Black].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 5 / 8.0 * Width), Height),
                new Point((int)( 7 / 8.0 * Width), (int)(1 / 2.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), 0),
            };
        }

        public void SetUpGCR()
        {
            BezierCurves[Color.Cyan].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), (int)(1.8 / 3.0 * Height)),
                new Point((int)( 2 / 3.0 * Width), (int)(0.8/ 3.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), (int)(0.4 / 3.0 * Height)),
            };

            BezierCurves[Color.Magenta].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), (int)(2 / 3.0 * Height)),
                new Point((int)( 2 / 3.0 * Width), (int)(1/ 3.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), (int)(0.5 / 3.0 * Height)),
            };

            BezierCurves[Color.Yellow].Points = new List<Point>
            {
                new Point(0, Height),
                new Point((int)( 1 / 3.0 * Width), (int)(1.9 / 3.0 * Height)),
                new Point((int)( 2 / 3.0 * Width), (int)(0.9/ 3.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), (int)(0.6 / 3.0 * Height)),
            };

            BezierCurves[Color.Black].Points = new List<Point>
            {
                 new Point(0, Height),
                new Point((int)( 2 / 4.0 * Width), Height),
                new Point((int)( 3.9 / 4.0 * Width), (int)( 3.9 / 4.0 * Height)),
                new Point((int)( 3 / 3.0 * Width), 0),
            };
        }
    }
}
