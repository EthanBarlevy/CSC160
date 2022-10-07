using System;
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
            //Console.WriteLine("value type v1: {0}", v1);
            //Console.WriteLine("value type v2: {0}", v2);

            // reference types
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = arr1;
            //Console.WriteLine("ref type v1: {0}", String.Join(", ", arr1));
            //Console.WriteLine("ref type v2: {0}", String.Join(", ", arr2));

            arr1[0] = 5;
            Console.WriteLine("ref type v1: {0}", String.Join(", ", arr1));
            Console.WriteLine("ref type v2: {0}", String.Join(", ", arr2));

            // stucts count as data types so they will be copied but classes will be reference
            Point p1 = new Point(1, 2);
            Point p2 = p1;

            p1.Write();
            p2.Write();

            p1.x = 200;
            p1.Write();
            p2.Write();
        }

        struct Point // structs are different from classes
        {
            public int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Write() 
            {
                Console.WriteLine("{0} - {1}", x, y);
            }
        }
    }
}
