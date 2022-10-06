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

            // explicit conversion
            // must explicitly define if you can loose data (double to float)
            double d = 12.12345;
            int i = (int)d;
            Console.WriteLine(i);

            //int wasstr = "5";
            string strnum = "5";
            int wasstr = 0;// = int.Parse(strnum);
            Console.WriteLine("parsed {1}: {0}", wasstr, wasstr.GetType());

            bool b = int.TryParse(strnum, out wasstr);
            Console.WriteLine(strnum + " converts to int? " + b);

            Console.WriteLine(IsNumeric("owo"));



        }
        /// <summary>
        /// tests if a string is a number
        /// </summary>
        /// <param name="num">the string to test</param>
        /// <returns>true or fase</returns>
        public static bool IsNumeric(string num)
        {
            double dNum;
            return double.TryParse(num, out dNum);
        }

    }
}
