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
            bezierCurves = new Dictionary<CMYK, BezierCurve>();
            bezierCurves.Add(CMYK.Cyan, new BezierCurve(Color.Cyan));
            bezierCurves.Add(CMYK.Magenta, new BezierCurve(Color.Magenta));
            bezierCurves.Add(CMYK.Yellow, new BezierCurve(Color.Yellow));
            bezierCurves.Add(CMYK.Black, new BezierCurve(Color.Black));
        }

        private void DrawBezierCurves()
        {
            graphics.Clear(Color.White);
            bezierCurves[CMYK.Black].Draw(graphics);
            bezierCanvas.Refresh();
        }

        private void bezierCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            bezierCurves[CMYK.Black].AddPoint(e.Location);
            DrawBezierCurves();
        }
    }
}