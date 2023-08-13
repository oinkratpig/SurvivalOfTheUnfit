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

            // Map
            pictureBoxMap.Size = new Size(pictureBoxMap.Size.Width + MARGIN_H * 2, pictureBoxMap.Size.Height + MARGIN_V * 2);
            pictureBoxMap.Location = new Point(pictureBoxMap.Location.X - MARGIN_H, pictureBoxMap.Location.Y - MARGIN_V);
            pictureBoxPositionMarker.Parent = pictureBoxMap;
            World.TileUpdated += OnTileChanged;
            OnTileChanged(this, EventArgs.Empty);

            this.Select();

        } // end FormWorldMap

        /* Whenever the color theme is changed */
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
            int width = pictureBoxMap.Width - MARGIN_H * 2;
            int height = pictureBoxMap.Height - MARGIN_V * 2;
            int x = (int)(MARGIN_H + width * ((float)World.CurrentLocation.X / World.CurrentWorld.Width));
            int y = (int)(MARGIN_V + height * ((float)World.CurrentLocation.Y / World.CurrentWorld.Height));

            // Center marker
            x += POSITION_MARKER_OFFSET_X;
            y += POSITION_MARKER_OFFSET_Y;

            pictureBoxPositionMarker.Location = new Point(x, y);

        } // end UpdatePositionMarker

        /* On dispose */
        public void OnDispose(object sender, EventArgs e)
        {
            World.TileUpdated -= OnTileChanged;

        } // end OnDispose

        /* Whenever a tile is changed */
        private void OnTileChanged(object? sender, EventArgs e)
        {
            UpdatePositionMarker();
            labelBiome.Text = Biome.GetName(World.CurrentTile.BiomeType);

        } // end OnTileChanged

        /* Move up/north */
        private void buttonNorth_Click(object sender, EventArgs e)
        {
            World.SetCurrentTile(World.CurrentLocation.X, World.CurrentLocation.Y - 1);

        } // end buttonNorth_Click

        /* Move right/east */
        private void buttonEast_Click(object sender, EventArgs e)
        {
            World.SetCurrentTile(World.CurrentLocation.X + 1, World.CurrentLocation.Y);

        } // end buttonEast_Click

        /* Move down/south */
        private void buttonSouth_Click(object sender, EventArgs e)
        {
            World.SetCurrentTile(World.CurrentLocation.X, World.CurrentLocation.Y + 1);

        } // end buttonSouth_Click

        /* Move left/west */
        private void buttonWest_Click(object sender, EventArgs e)
        {
            World.SetCurrentTile(World.CurrentLocation.X - 1, World.CurrentLocation.Y);

        } // end buttonWest_Click

    } // end class FormWorldMap

} // end namespace