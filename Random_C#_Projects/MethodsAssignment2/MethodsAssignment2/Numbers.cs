using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment2
{
    class Numbers
    {
        public static int Add(int i)
        {
            i = i + 5;
            return i;
        }
        public static int Add(decimal i2)
        {
            int newi2 = Convert.ToInt32(i2 - 5);
            return newi2;
        }

        public static int Add(string i3)
        {
            int newi3 = Convert.ToInt32(i3) * 5;
            return newi3;
        }
    }
}
