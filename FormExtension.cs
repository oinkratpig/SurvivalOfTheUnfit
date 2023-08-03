using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public static class FormExtension
    {
        public static bool Exists(this Form form)
        {
            return (form != null && !form.IsDisposed);
        }

    } // end class FormExtension

} // end namespace