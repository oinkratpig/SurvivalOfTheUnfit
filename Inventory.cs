﻿using System;
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

        /* Adds an item instance to the inventory. */
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

        /* Adds a single item instance to the inventory. */
        public static bool AddToInventory(Item? item)
        {
            return AddToInventory(item, 1);

        } // end AddToInventory

        /* Removes an item instance from the inventory. */
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

        /* Uses and removes an item from the inventory. */
        public static bool UseItemAndRemove(Item? item, int count, bool useMultiple)
        {
            if (item == null) return false;

            Type type = item.GetType();
            foreach (KeyValuePair<Item, int> invItem in Contents)
                if (invItem.Key.GetType() == item.GetType())
                {
                    if(invItem.Value >= count)
                    {
                        RemoveFromInventory(invItem.Key, count);
                        if (useMultiple)
                            for (int i = 0; i < count; i++)
                                item.OnUse();
                        else
                            item.OnUse();
                        return true;
                    }
                    return false;
                }
            return false;

        } // end UseItemAndRemove

        /* Uses and removes an item from the inventory. */
        public static bool UseItemAndRemove(Item? item, int count)
        {
            return UseItemAndRemove(item, count, true);

        } // end UseItemAndRemove

        /* Uses an item from the inventory. */
        public static bool UseFromInventory(Item? item)
        {
            if (item == null) return false;

            Type type = item.GetType();
            foreach (KeyValuePair<Item, int> invItem in Contents)
                if (invItem.Key.GetType() == item.GetType())
                {
                    item.OnUse();
                    return true;
                }

            return false;

        } // end RemoveFromInventory

        /* Returns true if you have enough of an item in the inventory. */
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
