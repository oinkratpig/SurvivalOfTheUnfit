using SurvivalOfTheUnfit.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    internal class ItemMysteryMeat : Item
    {
        public ItemMysteryMeat()
        {
            Name = "mystery meat";
            Description = "meat from... something?";
            Category = CategoryType.Food;

            Unique = false;

            Sprite = GetSprite("sprItemMeat");

        } // end constructor

        public override void OnUse()
        {
            FormMain.AddText("ate some yummy something-meat!");

        } // end OnUse

        public override void OnObtain() { }

        public override void OnLost() { }

    } // end class ItemMeat

} // end namespace