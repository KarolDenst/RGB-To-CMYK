using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

        public void DrawColor(Color selectedColor, DirectBitmap bitmap, Bezier bezier)
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
    }
}
