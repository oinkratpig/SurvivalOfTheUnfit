using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SurvivalOfTheUnfit
{
    public abstract class Action
    {
        public enum CategoryType
        {
            Unknown = -1,
            Misc = 0,
            Character = 1,
            Crafting = 2,
            Scavenging = 3
        }

        public string ActionName { get; protected set; }
        public CategoryType Category { get; protected set; }
        public bool Enabled { get; protected set; }

        public Action()
        {
            ActionName = string.Empty;
            GameEvents.ActionUpdate += OnActionUpdated;

        } // end constructor

        /* When the action is updated. Should set what criteria makes it enabled/disabled. */
        public abstract void OnActionUpdated(object sender, EventArgs args);

        /* When the action is typed in the act textbox and the button is pressed. */
        public abstract void OnActionPerformed(string[] args);

    } // end class Action

} // end namespace
