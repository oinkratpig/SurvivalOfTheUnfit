using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public class ActionInventory : Action
    {
        public ActionInventory()
        {
            Enabled = true;
            ActionName = "inventory";
            Category = CategoryType.Character;

        } // end constructor

        public override void OnActionUpdated(object sender, EventArgs args) { }

        public override void OnActionPerformed(string[] args)
        {
            FormMain.AddText("current inventory:");

            foreach (KeyValuePair<Item, int> item in Inventory.Contents)
                FormMain.AddText($"{item.Key.Name} x{item.Value}");

        } // end event OnUpdateAction

    } // end class ActionDebug

} // end namesapce