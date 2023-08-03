using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    internal class GameEvents
    {
        public delegate void ActionHandler(object sender, EventArgs args);
        public event ActionHandler ActionUpdate;

        /* Constructor / initialize events */
        public GameEvents()
        {
            ActionUpdate += new ActionEat().OnActionUpdated;
            ActionUpdate += new ActionInventory().OnActionUpdated;
            ActionUpdate += new ActionHunt().OnActionUpdated;
            ActionUpdate += new ActionGather().OnActionUpdated;

        } // end GameEvents

        /* Update actions so they may become enabled/disabled/etc depending on the situation. */
        public void UpdateActions()
        {
            ActionUpdate(this, EventArgs.Empty);

            // Create nodes for tree

            Dictionary<string, List<string>> treeNodes = new();

            Delegate[] actions = ActionUpdate.GetInvocationList();
            foreach (Delegate action in actions)
            {
                Action? target = action.Target as Action;
                if (target == null) continue;

                if (target.Enabled)
                {
                    string category = target.Category.ToString().ToLower();

                    if (!treeNodes.ContainsKey(category))
                        treeNodes.Add(category, new List<string>());

                    treeNodes[category].Add(target.ActionName);
                }
            }

            // Update tree view display

            FormMain.TreeViewActions.Nodes.Clear();
            foreach (KeyValuePair<string, List<string>> node in treeNodes)
            {
                TreeNode category = FormMain.TreeViewActions.Nodes.Add(node.Key.ToLower());
                foreach (string action in node.Value)
                    category.Nodes.Add(action);
            }
            FormMain.TreeViewActions.ExpandAll();

        } // end UpdateActions

        /* Performs the specified action if it is enabled. */
        public void PerformAction(string actionName, string[] args)
        {
            Delegate[] actions = ActionUpdate.GetInvocationList();
            foreach (Delegate action in actions)
            {
                Action? target = action.Target as Action;
                if (target == null) continue;

                if(target.Enabled && target.ActionName == actionName)
                    target.OnActionPerformed(args);
            }
            
        } // end PerformAction

    } // end class GameEvents

} // end namespace