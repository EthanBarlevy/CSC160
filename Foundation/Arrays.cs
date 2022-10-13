using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Arrays
    {
        public static void Showcase()
        {
            int[] myarr1 = new int[3]; // arrays default to zero / null
            myarr1[0] = 23; // basic standard easy way
            myarr1[1] = 33;
            myarr1.SetValue(26, 2); // gross long way

            int[] myarr2 = { 1, 2, 3, 4 }; // initalizer list
            int[] myarr3 = new int[] { 1, 2, 3, 4 }; // gross long way

            for (int i = 0; i < myarr1.Length; i++)
            {
                //Console.Write("{0} ", myarr1[i]);
            }

            foreach (int num in myarr2)
            {
                //Console.Write("{0} ", num);
                //break; // exit the loop
                //continue; // skip the rest of the code but keep going through the loop
            }

            string[,] alphabet = new string[2, 2] { { "A", "B" }, { "C", "D" } };

            for (int i = 0; i < alphabet.GetLength(0); i++)
            {
                for (int j = 0; j < alphabet.GetLength(1); j++)
                {
                    Console.Write($"{alphabet[i, j]} ");
                }
                Console.WriteLine();
            }

            object[] things = new object[] { 10, "owo", 1.5f }; // everything is an object so this works


        }
    }
}
