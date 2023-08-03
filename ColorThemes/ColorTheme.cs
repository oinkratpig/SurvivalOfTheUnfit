using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurvivalOfTheUnfit
{
    public abstract class ColorTheme
    {
        public static ColorTheme CurrentTheme;

        public delegate void ThemeUpdateHandler(object sender, EventArgs args);
        public static event ThemeUpdateHandler ThemeUpdated;

        public static void UpdateFormThemes()
        {
            ThemeUpdated(null, EventArgs.Empty);

        } // end OnThemeUpdated

        public static void ApplyFormTheme(Form form, ColorTheme theme)
        {
            form.BackColor = theme.ColorMain;

            foreach (Control component in form.Controls)
            {
                if (component is MenuStrip)
                {
                    MenuStrip menuStrip = (MenuStrip)component;
                    ToolStripItemCollection items = menuStrip.Items;
                    foreach (ToolStripMenuItem item in items)
                        foreach (ToolStripMenuItem childItem in item.DropDownItems)
                        {
                            childItem.BackColor = theme.ColorControl;
                            childItem.ForeColor = theme.ColorText;

                        }
                }
                foreach (Control childCompoennt in component.Controls)
                {
                    childCompoennt.BackColor = theme.ColorControl;
                    childCompoennt.ForeColor = theme.ColorText;
                }
                component.BackColor = theme.ColorControl;
                component.ForeColor = theme.ColorText;
            }

        } // end ApplyFormTheme

        protected static Color ColorFromHex(string hex)
        {
            return ColorTranslator.FromHtml(hex);

        } // end ColorFromHex

        public Color ColorMain { get; protected set; }
        public Color ColorControl { get; protected set; }
        public Color ColorText { get; protected set; }

    } // end class ColorTheme

} // end namespace