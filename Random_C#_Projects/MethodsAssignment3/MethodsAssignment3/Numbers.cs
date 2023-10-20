using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment3
{
    class Numbers
    {
        public int Add(int i, string i2 = "1")
        {
            int i3 = Convert.ToInt32(i2);
            int i4 = (i * i3) + 34;
            return i4;
        }
    }
}
