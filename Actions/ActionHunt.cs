using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public class ActionHunt : Action
    {
        public ActionHunt()
        {
            Enabled = true;
            ActionName = "hunt";
            Category = CategoryType.Scavenging;

        } // end constructor

        public override void OnActionUpdated(object sender, EventArgs args) { }

        public override void OnActionPerformed(string[] args)
        {
            Inventory.AddToInventory(new ItemMysteryMeat());
            FormMain.AddText("found some meat!");

        } // end event OnUpdateAction

    } // end class ActionHunt

} // end namespace