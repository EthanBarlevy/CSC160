using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Interfaces
    {
        // An Interface in C# is a type of definition similar to a class
        // except an interface purely represents a contact between
        // an object and it's user, an interface is a collection of methods
        // and property declarations

        // A convention used in the .NET Framework is to place an "I" at the
        // beginning of an interface
        
        // This is an example of an Interface
        interface IShape
        {
            double X { get; set; }
            double Y { get; set; }
            void Draw();
        }

        // An Interface can niether be directly instantiated as an object nor
        // can data members be defined

        // Implementing an interface is simply done by inheriting off it and defining
        // all the methods and properties declared by the interface after that,
        // For Example:

        class Square : IShape
        {
            private double _mX, _mY;

            public void Draw() {}

            public double X
            {
                set { _mX = value; }
                get { return _mX; }
            }

            public double Y
            {
                set { _mY = value; }
                get { return _mY; }
            }
        }
    }
}
