using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Parameters
    {
        public static void DoIt()
        {
            int iref = 7;
            int[] arr = new int[] { 5, 6 };
            string str = "fred";
            Reftest clsrt = new Reftest();
            clsrt.x = 1;
            int ival = 66;
            int[] arr2 = new int[2];
            arr.CopyTo(arr2, 0);

            byvalreftest(ref iref, str, arr, clsrt, ival);
            // iref will be 49 because its a reference
            //Console.WriteLine("iref: {0}", iref);
            // str will be fred because its not a reference
            //Console.WriteLine("str: {0}", str);
            // arr[0] will be 10 because the variable holds a pointer
            //Console.WriteLine("arr: {0}", arr[0]);
            // arr2[0] will be 5 because we copied from 1 to 2
            //Console.WriteLine("arr2: {0}", arr2[0]);
            // clsrt.x will be 88 because we sent a class which is always reference
            //Console.WriteLine("clsrt: {0}", clsrt.x);
            // ival will be 66 because its not a reference;
            //Console.WriteLine("ival: {0}", ival);

            // wow. amazing. so original. never been seen before.
            DefaultParam();
            DefaultParam(86);

            NamedFunc(1, 5);
            NamedFunc(y: 60, x: 20); // ew this is gross why
        }

        public static void byvalreftest(ref int xref, string sval, int[] arr, Reftest clsreftest, int intval)
        {
            xref *= xref;
            sval = "fanny";
            arr[0] = 10;
            clsreftest.x = 88;
            intval = 42;
        }

        public class Reftest
        {
            public int x;
        }

        static void DefaultParam(int n = 20) // same as c++
        {
            Console.WriteLine("default param: {0}", n);
        }

        static void NamedFunc(int x, int y)
        {
            Console.WriteLine("named param: {0} - {1}", x, y);
        }
    }
}
