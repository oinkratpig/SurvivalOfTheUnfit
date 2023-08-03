using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public class ActionEat : Action
    {
        public ActionEat()
        {
            Enabled = true;
            ActionName = "eat";
            Category = CategoryType.Character;

        } // end constructor

        public override void OnActionUpdated(object sender, EventArgs args) { }

        public override void OnActionPerformed(string[] args)
        {
            if (!Inventory.UseItemAndRemove(new ItemMysteryMeat(), 1))
            {
                FormMain.AddText("you tried to eat some food.");
                FormMain.AddText("...if only you had some.");
            }

        } // end event OnUpdateAction

    } // end class ActionEat

} // end namesapce