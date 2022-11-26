using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficzne3
{
    internal partial class Form2 : Form
    {
        internal Form2(Bezier bezier, DirectBitmap mainBitmap)
        {
            InitializeComponent();
            SetUpImages(bezier, mainBitmap);
        }

        private void SetUpImages(Bezier bezier, DirectBitmap mainBitmap)
        {
            var cyanBitmap = new DirectBitmap(cyanCanvas.Width, cyanCanvas.Height);
            cyanCanvas.Image = cyanBitmap.Bitmap;
            DrawColorPicture(Color.Cyan, bezier, mainBitmap, cyanBitmap, cyanCanvas);

            var magentaBItmap = new DirectBitmap(magentaCanvas.Width, magentaCanvas.Height);
            magentaCanvas.Image = magentaBItmap.Bitmap;
            DrawColorPicture(Color.Magenta, bezier, mainBitmap, magentaBItmap, cyanCanvas);

            var yellowBitmap = new DirectBitmap(yellowCanvas.Width, yellowCanvas.Height);
            yellowCanvas.Image = yellowBitmap.Bitmap;
            DrawColorPicture(Color.Yellow, bezier, mainBitmap, yellowBitmap, yellowCanvas);

            var blackBitmap = new DirectBitmap(blackCanvas.Width, blackCanvas.Height);
            blackCanvas.Image = blackBitmap.Bitmap;
            DrawColorPicture(Color.Black, bezier, mainBitmap, blackBitmap, blackCanvas);
        }

        private void DrawColorPicture(Color color, Bezier bezier, DirectBitmap mainBitmap, DirectBitmap colorBitmap, PictureBox colorPictureBox)
        {
            try
            {
                var values = bezier.GetValues(color);
                colorBitmap.DrawColor(color, mainBitmap, bezier);
            }
            catch
            {
                using (Graphics g = Graphics.FromImage(colorPictureBox.Image)) g.Clear(Color.White);
            }
            colorPictureBox.Refresh();
        }
    }
}
