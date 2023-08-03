using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public class ActionGather : Action
    {
        public ActionGather()
        {
            Enabled = true;
            ActionName = "gather";
            Category = CategoryType.Scavenging;

        } // end constructor

        public override void OnActionUpdated(object sender, EventArgs args) { }

        public override void OnActionPerformed(string[] args)
        {
            Inventory.AddToInventory(new ItemStick());
            Inventory.AddToInventory(new ItemRock());
            FormMain.AddText("found some sticks and rocks.");

        } // end event OnUpdateAction

    } // end class ActionGather

} // end namespace