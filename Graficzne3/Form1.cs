using System.Drawing;
using System.Windows.Forms;

namespace Graficzne3
{
    public partial class Form1 : Form
    {
        private Dictionary<CMYK, BezierCurve> bezierCurves;
        private Graphics graphics;
        private DirectBitmap mainBitmap;
        private DirectBitmap cyanBitmap;
        private DirectBitmap magentaBitmap;
        private DirectBitmap yellowBitmap;
        private DirectBitmap blackBitmap;

        public Form1()
        {
            InitializeComponent();
            SetUpBezierCanvas();
            SetUpBezierCurves();
            SetUpBitmaps();
        }

        private void SetUpBezierCanvas()
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            bezierCanvas.Image = bitmap;
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Constants.CanvasBackground);
        }

        private void SetUpBezierCurves()
        {
            bezierCurves = new Dictionary<CMYK, BezierCurve>
            {
                { CMYK.Cyan, new BezierCurve(Color.Cyan, bezierCanvas.Height) },
                { CMYK.Magenta, new BezierCurve(Color.Magenta, bezierCanvas.Height) },
                { CMYK.Yellow, new BezierCurve(Color.Yellow, bezierCanvas.Height) },
                { CMYK.Black, new BezierCurve(Color.Black, bezierCanvas.Height) }
            };
        }

        private void SetUpBitmaps()
        {
            mainBitmap = new DirectBitmap(mainPictureBox.Width, mainPictureBox.Height);
            cyanBitmap = new DirectBitmap(cyanPictureBox.Width, cyanPictureBox.Height);
            magentaBitmap = new DirectBitmap(magentaPictureBox.Width, magentaPictureBox.Height);
            yellowBitmap = new DirectBitmap(yellowPictureBox.Width, yellowPictureBox.Height);
            blackBitmap = new DirectBitmap(blackPictureBox.Width, blackPictureBox.Height);
        }

        private void DrawBezierCurves()
        {
            graphics.Clear(Constants.CanvasBackground);

            if (showAllCheckBox.Checked) DrawAllBezierCurves();
            else bezierCurves[GetSelectedColor()].Draw(graphics);

            bezierCanvas.Refresh();
        }

        private void DrawAllBezierCurves()
        {
            graphics.Clear(Constants.CanvasBackground);
            
            foreach(var curve in bezierCurves.Values)
            {
                curve.Draw(graphics);
            }

            bezierCanvas.Refresh();
        }

        private void bezierCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            bezierCurves[GetSelectedColor()].AddPoint(e.Location, bezierCanvas.Width);
            DrawBezierCurves();
        }

        private CMYK GetSelectedColor()
        {
            if (cyanRadioButton.Checked) return CMYK.Cyan;
            if (magentaRadioButton.Checked) return CMYK.Magenta;
            if (yellowRadioButton.Checked) return CMYK.Yellow;
            if (blackRadioButton.Checked) return CMYK.Black;

            return CMYK.Black;
        }

        private void cyanRadioButton_CheckedChanged(object sender, EventArgs e) => DrawBezierCurves();

        private void magentaRadioButton_CheckedChanged(object sender, EventArgs e) => DrawBezierCurves();

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e) => DrawBezierCurves();

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e) => DrawBezierCurves();

        private void showAllCheckBox_CheckedChanged(object sender, EventArgs e) => DrawBezierCurves();
    }
}