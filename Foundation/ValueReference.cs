﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class ValueReference
    {
        public static void Engage()
        {
            // value types
            int v1 = 10;
            int v2 = v1;
            v1 = 5;
            Console.WriteLine("value type v1: {0}", v1);
            Console.WriteLine("value type v2: {0}", v2);

            // reference types
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = arr1;
            Console.WriteLine("ref type v1: {0}", String.Join(", ", arr1));
            Console.WriteLine("ref type v2: {0}", String.Join(", ", arr2));
        }
    }
}
