using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public class ColorThemeLight : ColorTheme
    {
        public ColorThemeLight()
        {
            ColorMain = Color.White;
            ColorControl = ColorFromHex("#f7f9fb");
            ColorText = ColorFromHex("#34343d");

        } // end ColorThemeLight

    } // end class ColorThemeLight

} // end namesapce
