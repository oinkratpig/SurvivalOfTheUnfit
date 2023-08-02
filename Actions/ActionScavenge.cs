using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public class ActionScavenge : Action
    {
        public ActionScavenge()
        {
            Enabled = true;
            ActionName = "scavenge";
            Category = CategoryType.Misc;

        } // end constructor

        public override void OnActionUpdated(object sender, EventArgs args) { }

        public override void OnActionPerformed()
        {
            Inventory.AddToInventory(new ItemMysteryMeat());
            FormMain.AddText("found some meat!");

        } // end event OnUpdateAction

    } // end class ActionScavenge

} // end namesapce