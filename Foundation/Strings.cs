using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Strings
    {
        public static void Start()
        {
            //string strname = Console.ReadLine();
            //Console.WriteLine("hi " + strname + ". whats up"); // concatination
            //Console.WriteLine("hello {0}, you cool", strname); // interpolation
            //Console.WriteLine($"hoi {strname} uwu"); // injection

            String strRandom = "nccs";
            Console.WriteLine("length: {0}", strRandom.Length); // length in characters
            Console.WriteLine("contains 'cs' : {0}", strRandom.Contains("cs")); // boolean 

            int indexof = strRandom.IndexOf("cs");
            Console.WriteLine("IndexOf pos: {0}", indexof != -1 ? indexof.ToString() : "not found");

            Console.WriteLine("Remove: {0}", strRandom.Remove(indexof, 2));
            Console.WriteLine(strRandom);

            // string builder faster way to manage strings becasue it doesnt make a copy every time
            StringBuilder sb = new StringBuilder();
            sb.Append("owo ");
            sb.Append("wats ");
            sb.Append("dis ");
            Console.WriteLine($"String builder: {sb.ToString()}");
        }
    }
}
