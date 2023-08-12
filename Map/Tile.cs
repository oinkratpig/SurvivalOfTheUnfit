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

        public World? map;
        public int x;
        public int y;
        public Biome.Types biomeType;

        public Tile(World? map, int x, int y)
        {
            this.map = map;
            this.x = x;
            this.y = y;

            biomeType = Biome.Types.Empty;

        } // end constructor

        /* Set biome of tile */
        public void SetBiome(Biome.Types biomeType)
        {
            BiomeType = biomeType;
            Color = Biome.GetColor(BiomeType);

        } // end SetBiome

    } // end class Tile

} // end namespace