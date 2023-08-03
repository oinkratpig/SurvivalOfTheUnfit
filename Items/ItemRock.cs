using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    internal class ItemRock : Item
    {
        public ItemRock()
        {
            Name = "rock";
            Description = "this item rocks.";
            Category = CategoryType.Crafting;

            Unique = false;

            Sprite = GetSprite("sprItemRocks");

        } // end constructor

        public override void OnUse() { }

        public override void OnObtain() { }

        public override void OnLost() { }

    } // end class ItemRock

} // end namespace