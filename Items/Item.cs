using Newtonsoft.Json;
using SurvivalOfTheUnfit.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public abstract class Item
    {
        public enum CategoryType
        {
            Unknown = -1,
            Misc = 0,
            Crafting = 1,
            Food = 2
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryType Category { get; set; }
        public bool Unique { get; set; }

        private Bitmap? _sprite = GetSprite("sprItemUnknown");
        public Bitmap Sprite {
            get { return _sprite; }
            protected set { _sprite = value; }
        }

        public static Bitmap? GetSprite(string spriteName)
        {
            return (Bitmap?) Resources.ResourceManager.GetObject(spriteName);

        } // end GetSprite

        /* Called when the item is used */
        public abstract void OnUse();

        /* Called when the item is obtained through any means */
        public abstract void OnObtain();

        /* Called when the item is lost or removed from inventory through any means */
        public abstract void OnLost();

    } // end class Item

} // end SurvivalOfTheUnfit
