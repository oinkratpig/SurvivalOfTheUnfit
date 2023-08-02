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

        public override void OnActionPerformed()
        {
            if(Inventory.UseItemAndRemove(new ItemMysteryMeat(), 1))
                FormMain.AddText("Ate some yummy something-meat!");
            else
                FormMain.AddText("You tried to eat some food. If only you had any.");

        } // end event OnUpdateAction

    } // end class ActionEat

} // end namesapce