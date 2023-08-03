using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    internal class ItemStick : Item
    {
        public ItemStick()
        {
            Name = "stick";
            Description = "some sticky, woody sticks.";
            Category = CategoryType.Crafting;

            Unique = false;

            Sprite = GetSprite("sprItemStick");

        } // end constructor

        public override void OnUse() { }

        public override void OnObtain() { }

        public override void OnLost() { }

    } // end class ItemStick

} // end namespace