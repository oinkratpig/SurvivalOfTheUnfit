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
            actionName = "eat";
            category = CategoryType.Character;

        } // end constructor

        public override void OnActionUpdated(object sender, EventArgs args) { }

        public override void OnActionPerformed()
        {
            FormMain.AddText("eat test");

        } // end event OnUpdateAction

    } // end class ActionEat

} // end namesapce