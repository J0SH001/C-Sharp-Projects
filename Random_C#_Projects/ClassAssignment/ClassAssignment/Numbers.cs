using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Numbers
    {
        public void Divide(int dividend)
        {
            int result = dividend / 2;
            Console.WriteLine(result);
        }
        public void Add(int dividend, out int remainder)
        {
            remainder = dividend % 2;
        }

        public int Add(int i)
        {
            i = i + 5;
            return i;
        }
    }
}
