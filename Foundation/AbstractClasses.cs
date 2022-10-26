using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    //abstract classes cannot be instanciated by themselves.
    abstract class AbstractClasses
    {
        //abstract methods cannot be defined either.
        public abstract void Example();
    }
    //abstract classes provide the framework for its child classes to define the declared methods
    class ChildClass : AbstractClasses
    {
        //the child class must provide override methods that define the declared methods of its parent class.
        public override void Example()
        {
            Console.WriteLine("HEY EVERY    !");
        }
        //child classes of abstract classes can declare and define their own methods independently of its parent
        public void Example2()
        {
            Console.WriteLine("IT'S ME, SPAMTON G. SPAMTON!");
        }
    }
}
