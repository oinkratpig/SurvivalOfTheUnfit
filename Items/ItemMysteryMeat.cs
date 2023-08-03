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
            Name = "Mystery Meat";
            Description = "Meat from... something?";
            Category = CategoryType.Food;

            Unique = false;

        } // end constructor

        public override void OnUse() { FormMain.AddText("eated da meat"); }

        public override void OnObtain() { FormMain.AddText("got da meat"); }

        public override void OnLost() { FormMain.AddText("lost da meat"); }

    } // end class ItemMeat

} // end namespace