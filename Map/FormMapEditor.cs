using SurvivalOfTheUnfit.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurvivalOfTheUnfit
{
    public partial class FormMapEditor : Form
    {
        private World? _world;
        private Tile? _selectedTile;
        private readonly int _marginX;
        private readonly int _marginY;
        private readonly int _width;
        private readonly int _height;
        private readonly int _cursorOffsetX;
        private readonly int _cursorOffsetY;
        private int _selectedX;
        private int _selectedY;

        public FormMapEditor()
        {
            InitializeComponent();

            _width = 64;
            _height = 64;

            _selectedX = 0;
            _selectedY = 0;

            // Position marker
            pictureBoxX.Parent = pictureBoxMap;
            _cursorOffsetX = -10;
            _cursorOffsetY = -10;

            // Map margins
            _marginX = 20;
            _marginY = 20;
            pictureBoxMap.Size = new Size(pictureBoxMap.Size.Width + _marginX * 2, pictureBoxMap.Size.Height + _marginY * 2);
            pictureBoxMap.Location = new Point(pictureBoxMap.Location.X - _marginX, pictureBoxMap.Location.Y - _marginY);

        } // end constructor

        /* Create new, empty map */
        private void buttonNewEmptyMap_Click(object sender, EventArgs e)
        {
            _world = new World(_width, _height);
            UpdateSelectedTile();

        } // end buttonNewEmptyMap_Click

        /* Generate map from pixel image */
        private void buttonGenerateMap_Click(object sender, EventArgs e)
        {
            Bitmap pixelMap = Resources.sprPixelWorldMap;
            _world = new World(_width, _height);

            for (int x = 0; x < _world.Map.GetLength(0); x++)
                for (int y = 0; y < _world.Map.GetLength(1); y++)
                {
                    Tile newTile = new Tile(_world, x, y);
                    Color pixelColor = pixelMap.GetPixel(x, y);
                    foreach (Biome.Types biomeType in Enum.GetValues(typeof(Biome.Types)))
                        if (Biome.GetColor(biomeType) == pixelColor)
                        {
                            newTile.biomeType = biomeType;
                            break;
                        }
                    _world.Map[x, y] = newTile;
                }

            UpdateSelectedTile();

        } // end buttonGenerateMap_Click

        /* Set the selected tile to given position */
        private void UpdateSelectedTile()
        {
            if (_world != null && _world.Map != null)
            {
                _selectedX = Math.Clamp(_selectedX, 0, _width - 1);
                _selectedY = Math.Clamp(_selectedY, 0, _height - 1);
                _selectedTile = _world.Map[_selectedX, _selectedY];

                textBoxBiomeName.Text = Biome.GetName(_selectedTile.biomeType);

                Color color = Biome.GetColor(_selectedTile.biomeType);
                textBoxColor.Text = $"rgb({color.R},{color.G},{color.B})";

                UpdatePositionMarker();
            }

        } // end UpdateSelectedTile

        /* Update position of the X to match the selection tile */
        private void UpdatePositionMarker()
        {
            int x = _marginX + (int)((float)_selectedX / _width * (pictureBoxMap.Width - _marginX * 2)) + _cursorOffsetX;
            int y = _marginY + (int)((float)_selectedY / _height * (pictureBoxMap.Height - _marginY * 2)) + _cursorOffsetY;

            pictureBoxX.Location = new Point(x, y);

        } // end UpdatePositionMarker

        /* X position changed */
        private void textBoxSelectedTileX_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxSelectedTileX.Text, out _selectedX);
            _selectedX = Math.Clamp(_selectedX, 0, Width - 1);
            UpdateSelectedTile();

        } // end textBoxSelectedTileX_TextChanged

        /* Y position changed */
        private void textBoxSelectedTileY_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxSelectedTileY.Text, out _selectedY);
            _selectedY = Math.Clamp(_selectedY, 0, Height - 1);
            UpdateSelectedTile();

        } // end textBoxSelectedTileY_TextChanged

    } // end class FormMapEditor

} // end namespace
