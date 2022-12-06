namespace Graficzne3
{
    internal static class Utils
    {
        public static int Binom(int n, int k)
        {
            int numerator = 1;
            int denumerator = 1;

            for(int i = 1; i <= k; i++)
            {
                numerator *= n + 1 - i;
                denumerator *= i;
            }

            return numerator / denumerator;
        }

        public static double GetDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public static void SaveBitmaps(CMYK bezier, DirectBitmap mainBitmap, string path)
        {
            var cyanBitmap = new DirectBitmap(mainBitmap.Width, mainBitmap.Height);
            cyanBitmap.DrawColor(Color.Cyan, mainBitmap, bezier);
            cyanBitmap.Bitmap.Save(path.Replace(".", @".cyan."));

            var magentaBitmap = new DirectBitmap(mainBitmap.Width, mainBitmap.Height);
            magentaBitmap.DrawColor(Color.Magenta, mainBitmap, bezier);
            magentaBitmap.Bitmap.Save(path.Replace(".", @".magenta."));

            var yellowBitmap = new DirectBitmap(mainBitmap.Width, mainBitmap.Height);
            yellowBitmap.DrawColor(Color.Yellow, mainBitmap, bezier);
            yellowBitmap.Bitmap.Save(path.Replace(".", @".yellow."));

            var blackBitmap = new DirectBitmap(mainBitmap.Width, mainBitmap.Height);
            blackBitmap.DrawColor(Color.Black, mainBitmap, bezier);
            blackBitmap.Bitmap.Save(path.Replace(".", @".black."));
        }

        //https://stackoverflow.com/questions/1335426/is-there-a-built-in-c-net-system-api-for-hsv-to-rgb
        public static Color HsvToRgb(double h, double S, double V)
        {
            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // The color is not defined, we should throw an error.

                    default:
                        //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                        R = G = B = V; // Just pretend its black/white
                        break;
                }
            }
            int r = Clamp((int)(R * 255.0));
            int g = Clamp((int)(G * 255.0));
            int b = Clamp((int)(B * 255.0));

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Clamp a value to 0-255
        /// </summary>
        public static int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }
    }
}
