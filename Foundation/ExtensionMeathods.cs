using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class ExtensionMeathods
    {
        public static void owo()
        {
            string strmsg = "cheese";

            Console.WriteLine("size of {0} is {1}", strmsg, strmsg.Length);

            Console.WriteLine($"is fist letter of {strmsg} capital? {strmsg.isFirstCap()}");
        }
    }

    public static class stringHelper
    {
        public static bool isFirstCap(this string strincoming)
        { 
            return char.IsUpper(strincoming[0]);
        }

        public static string AppendToEnd(this string incoming, string append) 
        {
            return incoming + append;
        }
    }
}
