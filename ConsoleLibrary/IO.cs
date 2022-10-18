using System;
using System.Threading.Channels;

namespace ConsoleLibrary
{
    public static class IO
    {
        /// <summary>
        /// Can a tring be converted to a number
        /// </summary>
        /// <param name="str"></param>
        /// <returns>True if it contains a valid number</returns>
        public static bool IsNumeric(string str)
        {
            double db;
            return double.TryParse(str, out db);
        }

        public static void Print(string str)
        {
            Console.WriteLine(str);
        }

        public static int GetConsoleInt(string str, int min, int max)
        {
            bool valid;
            int value;
            Print(str);
            do
            {
                valid = int.TryParse(Console.ReadLine(), out value);
                valid = valid && value >= min && value <= max;

                if (!valid)
                {
                    Print($"Incorrect value, please enter an integer from {min} to {max}.");
                }
            } while (!valid);

            return value;
        }

        public static float GetConsoleFloat(string str, float min, float max)
        {
            bool valid;
            float value;
            Print(str);
            do
            {
                valid = float.TryParse(Console.ReadLine(), out value);
                valid = valid && value >= min && value <= max;

                if (!valid)
                {
                    Print($"Incorrect value, please enter a float from {min} to {max}.");
                }
            } while (!valid);

            return value;
        }

        public static bool GetConsoleBool(string str)
        {
            bool valid;
            bool value;
            Print(str);
            do
            {
                valid = bool.TryParse(Console.ReadLine(), out value);
                
                if (!valid)
                {
                    Print($"Incorrect value, please enter a boolean value.");
                }
            } while (!valid);

            return value;
        }

        public static char GetConsoleChar(string str)
        {
            bool valid;
            char value;
            Print(str);
            do
            {
                valid = char.TryParse(Console.ReadLine(), out value);

                if (!valid)
                {
                    Print($"Incorrect value, please enter a character.");
                }
            } while (!valid);

            return value;
        }

        public static string GetConsoleString(string str)
        {
            bool valid = false;
            string value;
            Print(str);
            do
            { 
                value = Console.ReadLine();
                if (value != null && value != "") { valid = true; }
                else { Console.WriteLine("Invalid string"); }
            } while (!valid);

            return value;
        }

        public static int GetConsoleMenu(string[] options)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Print($"{i+1} {options[i]}");
            }
            int selection = GetConsoleInt("Enter a selection:", 1, options.Length);
            return selection;
        }
    }
}