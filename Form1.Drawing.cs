using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24521736_BTLT03
{
    public partial class Form1
    {
        private enum ShapeType
        {
            Line,
            Rectangle,
            Text,
            Ellipse, 
            Trianle
        }
        private Bitmap _canvasBitmap;
        private bool _isDrawing = false;
        private Point _startPoint, _endPoint;
        private ShapeType _currentShape = ShapeType.Line;
        private Color _currentColor = Color.Black;
        private int _currentThickness = 2;

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;
            _startPoint = e.Location;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _endPoint = e.Location;
                picCanvas.Invalidate(); // Yêu cầu PictureBox vẽ lại
            }
        }
        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _isDrawing = false;
                _endPoint = e.Location;

                if (_currentShape == ShapeType.Trianle)
                {
                    MessageBox.Show(
                    "Chức năng vẽ tam giác sẽ được cập nhật sau!",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    using (Graphics g = Graphics.FromImage(_canvasBitmap))
                    {
                        DrawShape(g, _startPoint, _endPoint);
                    }
                }
            }
            picCanvas.Invalidate(); 
        }
        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (_isDrawing)
            {
                DrawShape(e.Graphics, _startPoint, _endPoint);
            }
        }
        private Rectangle getRectangle(Point p1,Point p2)
        {
            return new Rectangle
                (
                    Math.Min(p1.X, p2.X),
                    Math.Min(p1.Y, p2.Y),
                    Math.Abs(p1.X - p2.X), 
                    Math.Abs(p1.Y - p2.Y)
                ); 
        }
        private void DrawShape(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(_currentColor, _currentThickness))
            {
                switch (_currentShape)
                {
                    case ShapeType.Line:
                        g.DrawLine(pen, start, end);
                        break;
                    case ShapeType.Rectangle:
                        Rectangle rect = getRectangle(start, end);
                        g.DrawRectangle(pen, rect);
                        break;
                    case ShapeType.Ellipse:
                        Rectangle ell = getRectangle(start, end);
                        g.DrawEllipse(pen, ell); 
                        break;
                    case ShapeType.Text:
                        FontStyle style = FontStyle.Regular;

                        if (chkBold.Checked) style |= FontStyle.Bold;
                        if (chkItalic.Checked) style |= FontStyle.Italic;
                        if (chkUnderline.Checked) style |= FontStyle.Underline;

                        using (Brush brush = new SolidBrush(_currentColor))
                        using (Font font = new Font("Arial", _currentThickness, style))
                        {
                            g.DrawString(txtTextToDraw.Text, font, brush, start);
                        }
                        break; 
                    case ShapeType.Trianle:
                        {
                        // sẽ cập nhật sau. 
                        }
                        break;
                }
            }
        }


    }
}
