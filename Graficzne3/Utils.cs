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
    }
}
