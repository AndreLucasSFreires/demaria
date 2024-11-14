using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting
{
    public static class ExtensionMethods
    {
        public static double ToDouble(this object obj)
        {
            double.TryParse(obj.ToString(), out double value);
            return value;
        }
        public static int ToInt(this object obj)
        {
            int.TryParse(obj.ToString(), out int value);
            return value;
        }
    }
}
