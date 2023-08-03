using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    [InstantiateOnStart]
    public class ActionDrink : Action
    {
        public ActionDrink()
        {
            Enabled = true;
            ActionName = "drink";
            Category = CategoryType.Character;

        } // end constructor

        public override void OnActionUpdated(object sender, EventArgs args) { }

        public override void OnActionPerformed(string[] args)
        {
            FormMain.AddText("drank some watuh.");

        } // end OnActionPerformed

    } // end class ActionDrink

} // end namespace