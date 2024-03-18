using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatengHotel.Helper
{
    public static class Validations
    {
        public static bool ValidationString(List<string> strgs)
        {
            foreach (string str in strgs)
            {
                if (String.IsNullOrEmpty(str))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
