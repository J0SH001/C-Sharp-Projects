using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class Numbers
    {
        public static int Add(int i)
        {
            i = i + 5;
            return i;
        }

        public static int Multiply(int i)
        {
            i = i * 5;
            return i;
        }

        public static int Subtract(int i)
        {
            i = i - 5;
            return i;
        }
        public int i { get; set; }
    }
}
