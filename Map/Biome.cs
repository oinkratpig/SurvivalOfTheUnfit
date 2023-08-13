using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public static class Biome
    {
        public enum Types
        {
            Unknown = -1,
            Empty = 0,
            Area0 = 1,
            Area1 = 2,
            Area2 = 3,
            Area3 = 4,
            Area4 = 5
        }

        /* Get name of biome from type */
        public static string GetName(Types biomeType)
        {
            switch(biomeType)
            {
                case Types.Empty:   return "Empty";
                case Types.Area0:   return "Drooling Forest";
                case Types.Area1:   return "The Seeps";
                case Types.Area2:   return "Chalks";
                case Types.Area3:   return "Settled Nothings";
                case Types.Area4:   return "Hidden Consternations";
                default:            return "Unknown";
            }

        } // end GetName

        /* Get tile color from biome type */
        public static Color GetColor(Types biomeType)
        {
            switch (biomeType)
            {
                case Types.Empty:   return Color.White;
                case Types.Area0:   return ColorTranslator.FromHtml("#3c776d");
                case Types.Area1:   return ColorTranslator.FromHtml("#73945b");
                case Types.Area2:   return ColorTranslator.FromHtml("#abbd9f");
                case Types.Area3:   return ColorTranslator.FromHtml("#585f53"); 
                case Types.Area4:   return ColorTranslator.FromHtml("#131319");
                default:            return Color.Pink;
            }

        } // end GetColor

    } // end class Biome

} // end namespace