using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Graficzne3
{
    internal class DirectBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        public Int32[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new Int32[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }

        public void SetPixel(int x, int y, Color colour)
        {
            int index = x + (y * Width);
            int col = colour.ToArgb();

            Bits[index] = col;
        }

        public Color GetPixel(int x, int y)
        {
            int index = x + (y * Width);
            int col = Bits[index];
            System.Drawing.Color result = System.Drawing.Color.FromArgb(col);

            return result;
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }

        public void LoadImage(string path)
        {
            using (Bitmap bitmap = new Bitmap(path))
            {
                for (int i = 0; i < Width; i++)
                {
                    for (int j = 0; j < Height; j++)
                    {
                        SetPixel(i, j, bitmap.GetPixel(i, j));
                    }
                }
            }
        }

        public void DrawColor(Color selectedColor, DirectBitmap bitmap, CMYK bezier)
        {
            bezier.UpdateValues();
            int bitmapWidth = Math.Min(bitmap.Width, Width);
            int bitmapHeight = Math.Min(bitmap.Height, Height);
            
            for(int i = 0; i < bitmapWidth; i++)
            {
                for (int j = 0; j < bitmapHeight; j++)
                {
                    Color color = bitmap.GetPixel(i, j);

                    Color set = bezier.GetColor(color, selectedColor); // Change this
                    SetPixel(i, j, set);
                }
            }
        }

        public void Clear(Color color)
        {
            for(int x = 0; x < Width; x++)
            {
                for(int y = 0; y < Height; y++)
                {
                    SetPixel(x, y, color);
                }
            }
        }

        public void DrawSquare(Color color)
        {
            using(Graphics g = Graphics.FromImage(Bitmap))
            {
                using(Pen pen = new Pen(color))
                {
                    Rectangle rectangle = new Rectangle(5, 5, Width - 10, Height - 10);
                    g.DrawRectangle(pen, rectangle);
                }
            }
        }

        public void DrawBar(int x, int y, int width, int height, double s, double v)
        {
            for (int i = y; i < y + height; i++)
            {
                int h = (int)((i - y) / (double)height * 255);
                for (int j = x; j < x + width; j++)
                {
                    Color color = Utils.HsvToRgb(h, s, v);
                    SetPixel(j, i, color);
                }
            }
        }

        public void Generate(double v)
        {
            Clear(Color.White);
            //int height = Height - 10;
            int width = Width - 10;

            int numberOfBars = 16;
            for(int i = 0; i < numberOfBars; i++)
            {
                int start = width * i / (numberOfBars) + 3;
                int end = width * (i + 1) / (numberOfBars) - 3;
                double s = i / (double)numberOfBars;

                DrawBar(start + 5, 8, end - start, Height - 13, s, v);
            }

            DrawSquare(Color.Black);


        }
    }
}
