namespace Graficzne3
{
    public partial class Form1 : Form
    {
        private CMYK bezier;
        private Graphics graphics;
        private Bitmap bitmap;
        private DirectBitmap mainBitmap;
        private DirectBitmap colorBitmap;

        private (Color, int) selectedPoint = (Color.White, -1);

        public Form1()
        {
            InitializeComponent();
            SetUpBezierCanvas();
            SetUpBezierCurves();
            SetUpBitmaps();
        }

        private void SetUpBezierCanvas()
        {
            bitmap = new Bitmap(bezierCanvas.Width, bezierCanvas.Height);
            bezierCanvas.Image = bitmap;
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Constants.CanvasBackground);
        }

        private void SetUpBezierCurves()
        {
            bezier = new CMYK(bezierCanvas.Height, bezierCanvas.Width);
        }

        private void SetUpBitmaps()
        {
            mainBitmap = new DirectBitmap(mainPictureBox.Width, mainPictureBox.Height);
            mainBitmap.LoadImage(Constants.DefaultPictureLocation);
            mainPictureBox.Image = mainBitmap.Bitmap;
            mainPictureBox.Refresh();

            colorBitmap = new DirectBitmap(colorPictureBox.Width, colorPictureBox.Height);
            colorPictureBox.Image = colorBitmap.Bitmap;
        }

        private void DrawColorPicture(Color color)
        {
            colorBitmap.DrawColor(color, mainBitmap, bezier);
            colorPictureBox.Refresh();
        }

        private void Draw()
        {
            DrawBezierCurves();

            try
            {
                DrawColorPicture(GetSelectedColor());
            }
            catch
            {
                using (Graphics g = Graphics.FromImage(colorPictureBox.Image)) g.Clear(Color.White);
                colorPictureBox.Refresh();
            }
        }

        private void DrawBezierCurves()
        {
            graphics.Clear(Constants.CanvasBackground);

            if (showAllCheckBox.Checked) DrawAllBezierCurves();
            else
            {
                Color color = GetSelectedColor();
                bezier.Draw(color, graphics);
            }

            bezierCanvas.Refresh();
        }

        private void DrawAllBezierCurves()
        {
            graphics.Clear(Constants.CanvasBackground);

            bezier.DrawAll(graphics);

            bezierCanvas.Refresh();
        }

        private void bezierCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            bezier[GetSelectedColor()].AddPoint(e.Location, bezierCanvas.Width);
            Draw();
        }

        private Color GetSelectedColor()
        {
            if (cyanRadioButton.Checked) return Color.Cyan;
            if (magentaRadioButton.Checked) return Color.Magenta;
            if (yellowRadioButton.Checked) return Color.Yellow;
            if (blackRadioButton.Checked) return Color.Black;

            return Color.Black;
        }

        private void cyanRadioButton_CheckedChanged(object sender, EventArgs e) => Draw();

        private void magentaRadioButton_CheckedChanged(object sender, EventArgs e) => Draw();

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e) => Draw();

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e) => Draw();

        private void showAllCheckBox_CheckedChanged(object sender, EventArgs e) => Draw();

        private void SaveCurveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Curve File|*" + Constants.CurveFormat;
                saveFileDialog.Title = "Save a Curve File";
                saveFileDialog.InitialDirectory = Path.GetFullPath(Constants.CurvesLocation);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bezier[GetSelectedColor()].SaveCurve(saveFileDialog.FileName);
                }
            }
        }

        private void loadCurveButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Curve File|*" + Constants.CurveFormat;
                openFileDialog.Title = "Load a Curve File";
                openFileDialog.InitialDirectory = Path.GetFullPath(Constants.CurvesLocation);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bezier[GetSelectedColor()] = new BezierCurve(GetSelectedColor(), openFileDialog.FileName);
                    Draw();
                }
            }
        }

        private void changePictureButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
                openFileDialog.Title = "Load a Picture";
                openFileDialog.InitialDirectory = Path.GetFullPath(Constants.PicturesLocation);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mainBitmap.LoadImage(openFileDialog.FileName);
                    mainPictureBox.Refresh();
                }
            }
        }

        private void saveAllPicturesButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
                saveFileDialog.Title = "Save pictures";
                saveFileDialog.InitialDirectory = Path.GetFullPath(Constants.CMYKPicturesLocation);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Utils.SaveBitmaps(bezier, mainBitmap, saveFileDialog.FileName);
                }
            }
        }

        private void backtrack0Button_Click(object sender, EventArgs e)
        {
            bezier.SetUp0Backtrack();
            Draw();
        }

        private void backtrack100Button_Click(object sender, EventArgs e)
        {
            bezier.SetUp100Backtrack();
            Draw();
        }

        private void ucrButton_Click(object sender, EventArgs e)
        {
            bezier.SetUpUCR();
            Draw();
        }

        private void gcrButton_Click(object sender, EventArgs e)
        {
            bezier.SetUpGCR();
            Draw();
        }

        private void showAllPicturesButton_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(bezier, mainBitmap);
            form2.Show();
        }

        private void bezierCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            selectedPoint = bezier.SelectPoint(e.Location);
        }

        private void bezierCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            selectedPoint.Item2 = -1;
        }

        private void bezierCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedPoint.Item2 != -1)
            {
                bezier.MovePoint(e.Location, selectedPoint.Item1, selectedPoint.Item2);
                Draw();
            }
        }
    }
}