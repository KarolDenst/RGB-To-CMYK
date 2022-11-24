using System.Drawing;
using System.Windows.Forms;

namespace Graficzne3
{
    public partial class Form1 : Form
    {
        private Dictionary<CMYK, BezierCurve> bezierCurves;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            SetUpBezierCanvas();
            SetUpBezierCurves();
        }

        private void SetUpBezierCanvas()
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            bezierCanvas.Image = bitmap;
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
        }

        private void SetUpBezierCurves()
        {
            bezierCurves = new Dictionary<CMYK, BezierCurve>
            {
                { CMYK.Cyan, new BezierCurve(Color.Cyan) },
                { CMYK.Magenta, new BezierCurve(Color.Magenta) },
                { CMYK.Yellow, new BezierCurve(Color.Yellow) },
                { CMYK.Black, new BezierCurve(Color.Black) }
            };
        }

        private void DrawBezierCurves()
        {
            graphics.Clear(Color.White);

            if (showAllCheckBox.Checked) DrawAllBezierCurves();
            else bezierCurves[GetSelectedColor()].Draw(graphics);

            bezierCanvas.Refresh();
        }

        private void DrawAllBezierCurves()
        {
            graphics.Clear(Color.White);
            
            foreach(var curve in bezierCurves.Values)
            {
                curve.Draw(graphics);
            }

            bezierCanvas.Refresh();
        }

        private void bezierCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            bezierCurves[GetSelectedColor()].AddPoint(e.Location);
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