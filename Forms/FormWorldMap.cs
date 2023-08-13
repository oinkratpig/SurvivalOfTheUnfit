using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurvivalOfTheUnfit
{
    public partial class FormWorldMap : Form
    {
        private const int MARGIN_H = 20; // horizontal margin for left and right
        private const int MARGIN_V = 20; // vertical margin for top and bottom

        private const int POSITION_MARKER_OFFSET_X = -17;
        private const int POSITION_MARKER_OFFSET_Y = -14;

        public FormWorldMap()
        {
            InitializeComponent();

            // Theme
            ColorTheme.ThemeUpdated += OnThemeUpdated;
            ColorTheme.UpdateFormThemes();

            // Add margins to map
            pictureBoxMap.Size = new Size(pictureBoxMap.Size.Width + MARGIN_H * 2, pictureBoxMap.Size.Height + MARGIN_V * 2);
            pictureBoxMap.Location = new Point(pictureBoxMap.Location.X - MARGIN_H, pictureBoxMap.Location.Y - MARGIN_V);

            // Position Marker
            pictureBoxPositionMarker.Parent = pictureBoxMap;
            UpdatePositionMarker();

            this.Select();

        } // end FormWorldMap

        /* Whenever the color theme is changed. */
        public void OnThemeUpdated(object sender, EventArgs e)
        {
            ColorTheme.ApplyFormTheme(this, ColorTheme.CurrentTheme);
            pictureBoxMap.BackColor = Color.Transparent;
            pictureBoxPositionMarker.BackColor = Color.Transparent;

        } // end OnThemeUpdated

        /* Update position of position marker */
        public void UpdatePositionMarker()
        {
            // Position of marker
            int x = MARGIN_H + pictureBoxMap.Width * (World.CurrentLocation.X / World.CurrentWorld.Width);
            int y = MARGIN_V + pictureBoxMap.Height * (World.CurrentLocation.Y / World.CurrentWorld.Height);

            // Center marker
            x += POSITION_MARKER_OFFSET_X;
            y += POSITION_MARKER_OFFSET_Y;

            pictureBoxPositionMarker.Location = new Point(x, y);

        } // end UpdatePositionMarker

    } // end class FormWorldMap

} // end namespace