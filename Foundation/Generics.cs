using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Generics 
    {
        public static void start()
        {
            /*int first = 20;
            int second = 43;

            swap(ref first, ref second);
            Console.WriteLine($"first: {first}\nsecond: {second}");*/

            /*float owo = 432.1f;
            float uwu = 123.4f;

            swap<float>(ref owo, ref uwu);
            Console.WriteLine($"first: {owo}\nsecond: {uwu}");*/

            //Console.WriteLine(getNumber<float>("enter a number", 0, 10));

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

        class stack<T>
        {
            int index = 0;
            T[] elements = new T[100];

            // add data to stack
            public void Push(T element)
            {
                elements[index++] = element;
            }

            public T Pop()
            {
                if (index > 0)
                { 
                    // decrement index before pop
                    return elements[--index];
                }
                return default (T);
            }
        }    

        static G getNumber<G>(string message, double min, double max)
        {
            bool success = false;
            double entry;
            do
            {
                Console.WriteLine(message);
                success = double.TryParse(Console.ReadLine(), out entry);
                success = success && entry >= min && entry <= max;
                if (!success)
                {
                    Console.WriteLine($"Incorrect value. Please enter a value from {min} to {max}.");
                }
            }
            while (!success);
            return (G)Convert.ChangeType(entry, typeof(G));
        }

        static void swap(ref int first, ref int second)
        { 
            int temp = first;
            first = second;
            second = temp;
        }

        // basically just templated but streamlined 
        static void swap<G>(ref G first, ref G second)
        {
            G temp = first;
            first = second;
            second = temp;
        }
    }
}
