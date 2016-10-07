using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class UserInterface : Form
    {
        private Bitmap mandelnumberList;
        private const int SCALEMULTIPLIER = 250; 
        private List<Preset> presets = new List<Preset>();
        private Coordinates coordinates;

        public UserInterface()
        {
            InitializeComponent();
            InitializePresets();
            SetTabIndex();
            splitContainer.IsSplitterFixed = true;
            SetCoordinates();
            DrawMandelbrot();
        }
        
        private void InitializePresets() // list of preset values and names
        {
            presets.Add(new Preset("Purple Lagoon", 6, 3, 10, 100, 0.325, 0.5, 4E-5));
            presets.Add(new Preset("Bolt", 9, 9, 2, 100, -0.125, -0.8, 8E-4));
            presets.Add(new Preset("Snowflake", 1, 2, 4, 100, -0.1, -0.96, 1E-4));
            foreach (Preset p in presets)
            {
                presetBox.Items.Add(p.name);
            }
        }

        private void SetTabIndex() // Change inputtextbox with tab
        {
            scaleTextBox.TabIndex = 0;
            maxTextBox.TabIndex = 1;
            centerXTextBox.TabIndex = 2;
            centerYTextBox.TabIndex = 3;
            redMultiplierTextBox.TabIndex = 4;
            greenMultiplierTextBox.TabIndex = 5;
            blueMultiplierTextBox.TabIndex = 6;
            runButton.TabIndex = 7;
        }

        public int GetPanelWidth()
        {
            return splitContainer.Panel1.Width;
        }

        public int GetPanelHeight()
        {
            return splitContainer.Panel1.Height;
        }

        public int GetMaxNumber()
        {
            return Convert.ToInt16(maxTextBox.Text);
        }

        public int GetRedMultiplier()
        {
            return Convert.ToInt16(redMultiplierTextBox.Text);
        }

        public int GetGreenMultiplier()
        {
            return Convert.ToInt16(greenMultiplierTextBox.Text);
        }

        public int GetBlueMultiplier()
        {
            return Convert.ToInt16(blueMultiplierTextBox.Text);
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            DrawMandelbrot();
        }

        private void Mandelbrot_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(mandelnumberList, Point.Empty);
        }

        private void DrawResizedMandelbrot(object sender, EventArgs e)
        {
            DrawMandelbrot();
        }

        private void DrawMandelbrot()
        {
            SetCoordinates();
            mandelnumberList = new MandelDrawer(
                                   coordinates,
                                   this
                              ).toBitmap();
            splitContainer.Panel1.Invalidate();
        }

        private void LoadPresetValues(object sender, EventArgs e)
        {
            foreach (Preset p in presets)
            {
                if (p.name == presetBox.SelectedItem.ToString())
                {
                    maxTextBox.Text = p.max.ToString();
                    scaleTextBox.Text = p.scale.ToString();
                    centerXTextBox.Text = p.centerX.ToString();
                    centerYTextBox.Text = p.centerY.ToString();
                    redMultiplierTextBox.Text = p.r.ToString();
                    greenMultiplierTextBox.Text = p.g.ToString();
                    blueMultiplierTextBox.Text = p.b.ToString();
                    DrawMandelbrot();
                }
            }
        }

        private void SetCoordinates()
        {
            coordinates = new Coordinates(
                            Convert.ToDouble(centerXTextBox.Text),
                            Convert.ToDouble(centerYTextBox.Text),
                            Convert.ToDouble(scaleTextBox.Text) * SCALEMULTIPLIER,
                            this
                          );
        }

        private void Zoom(object sender, MouseEventArgs e)
        {
            centerXTextBox.Text = Convert.ToString(coordinates.GetXLocation(e.X));
            centerYTextBox.Text = Convert.ToString(coordinates.GetYLocation(e.Y));
            scaleTextBox.Text = Convert.ToString(Convert.ToDouble(scaleTextBox.Text) / 2);
            DrawMandelbrot();
        }
    }
}
