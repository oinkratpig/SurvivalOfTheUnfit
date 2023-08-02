using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public static class Inventory
    {
        private static Dictionary<Item, int> _contents = new();
        public static Dictionary<Item, int> Contents {
            get { return _contents; }
            private set { _contents = value; }
        }

        public static bool AddToInventory(Item? item, int count)
        {
            if (item == null) return false;

            // Item is stackable
            if (!item.Unique)
            {
                Type type = item.GetType();
                foreach (KeyValuePair<Item, int> invItem in Contents)
                    if (invItem.Key.GetType() == item.GetType())
                    {
                        Contents[invItem.Key] += count;
                        for (int i = 0; i < count; i++)
                            item.OnObtain();
                        return true;
                    }
                for (int i = 0; i < count; i++)
                    item.OnObtain();
                Contents.Add(item, count);
            }
            // Item is not stackable
            else
            {
                Contents.Add(item, 1);
                item.OnObtain();
            }

            return true;

        } // end AddToInventory

        public static bool AddToInventory(Item? item)
        {
            return AddToInventory(item, 1);

        } // end AddToInventory

        public static bool RemoveFromInventory(Item? item, int count)
        {
            if (item == null) return false;

            Type type = item.GetType();
            foreach (KeyValuePair<Item, int> invItem in Contents)
                if (invItem.Key.GetType() == item.GetType())
                {
                    int newCount = Math.Min(count, invItem.Value);
                    Contents[invItem.Key] -= newCount;
                    if (Contents[invItem.Key] <= 0)
                        Contents.Remove(invItem.Key);
                    for (int i = 0; i < newCount; i++)
                        item.OnLost();
                    return true;
                }

            return false;

        } // end RemoveFromInventory

        public static bool HasEnough(Item? item, int count)
        {
            if (item == null) return false;

            foreach (KeyValuePair<Item, int> invItem in Contents)
                if (invItem.Key.GetType() == item.GetType() && invItem.Value >= count)
                    return true;

            return false;

        } // end HasEnough

    } // end class Inventory

} // end namespace
