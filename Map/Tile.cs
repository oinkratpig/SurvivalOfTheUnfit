using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    /* Represents a tile in the world map */
    public class Tile
    {
        public Color Color { get; private set; }
        public Biome.Types BiomeType { get; private set; }
        public Point Location { get; private set; }
        public World? World { get; private set; }

        public Tile(World? world, int x, int y)
        {
            World = world;
            Location = new Point(x, y);
            BiomeType = Biome.Types.Empty;

        } // end constructor

        /* Set biome of tile */
        public void SetBiome(Biome.Types biomeType)
        {
            BiomeType = biomeType;
            Color = Biome.GetColor(BiomeType);

        } // end SetBiome

    } // end class Tile

} // end namespace