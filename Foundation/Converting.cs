using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Converting
    {
        public static void DoIt()
        {
            // casting and converting
            // implicit conversion
            int num = 12345;
            long lnum = num;
            var c = 'C';
            Console.WriteLine("var: {0}", c.GetType());
        }
    }
}
