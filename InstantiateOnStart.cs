using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public class InstantiateOnStart : Attribute
    {
        /* Instantiate all classes marked as InstantiateOnStart. */
        public static void InstantiateAll()
        {
            Type[] newInstances = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.GetCustomAttribute<InstantiateOnStart>() != null)
                .ToArray();
            foreach (Type instance in newInstances)
                Activator.CreateInstance(instance);

        } // end InstantiateAll

    } // end class InstantiateOnStart

} // end namespace
