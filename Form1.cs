using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24521736_BTLT03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbShapes.DataSource = Enum.GetValues(typeof(ShapeType)); 
            cmbShapes.SelectedIndex = 0;

            _canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(_canvasBitmap))
            {
                g.Clear(Color.White);   
            }
            picCanvas.Image = _canvasBitmap;
        }
        private void cmbShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentShape = (ShapeType)cmbShapes.SelectedItem;

            if (_currentShape == ShapeType.Text)
            {
                gbTextOptions.Visible = true;
                _currentThickness = 10; 
            }
            else
            {
                gbTextOptions.Visible = false;
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _currentColor = colorDialog1.Color;
                btnColor.BackColor = _currentColor; 
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
                _currentThickness = (int)numThickness.Value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _isDrawing = false;
            using (Graphics graphics = Graphics.FromImage(_canvasBitmap))
            {
                graphics.Clear(Color.White);
            }

            picCanvas.Invalidate();
        }
    }
}
