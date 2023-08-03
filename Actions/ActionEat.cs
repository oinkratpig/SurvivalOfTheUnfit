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

        public override void OnActionUpdated(object sender, EventArgs args)
        {
            Enabled = false;
            if (Inventory.HasEnough(new ItemMysteryMeat(), 1))
                Enabled = true;
        
        } // end OnActionUpdated

        public override void OnActionPerformed(string[] args)
        {
            Inventory.UseItemAndRemove(new ItemMysteryMeat(), 1);

        } // end OnUpdateAction

    } // end class ActionEat

} // end namesapce