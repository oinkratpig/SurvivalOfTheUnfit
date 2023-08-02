using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public abstract class Action
    {
        public enum CategoryType
        {
            Unknown = -1,
            Misc = 0,
            Character = 1,
            Crafting = 2
        }

        protected string actionName;
        public string ActionName { get { return actionName; } }

        protected CategoryType category;
        public CategoryType Category { get { return category; } }

        private bool _enabled = false;
        public bool Enabled { get { return _enabled; } protected set { _enabled = value;  } }

        /* When the action is updated. Should set what criteria makes it visble/invisible. */
        public abstract void OnActionUpdated(object sender, EventArgs args);

        /* When the action is typed in the act textbox and the button is pressed. */
        public abstract void OnActionPerformed();

    } // end class Action

} // end namespace
