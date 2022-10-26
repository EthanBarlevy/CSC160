using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class VirtualMeathods
    {

        public static void virtualMeathods()
        {
            Parent parent = new Parent();
            Child child = new Child();

            parent.Talk(); //  will result in "Parent talks"
            child.Talk(); //   will result in "Child talks"
            parent.Speak(); // will result in "Parent speaks"
            child.Speak(); //  will result in "Parent speaks"
        }

        class Parent
        {
            // declaring a meathod as virtual means that it is able to be overriden by children
            public virtual void Talk() 
            {
                Console.WriteLine("Parent talks");
            }

            public virtual void Speak()
            {
                Console.WriteLine("Parent speaks");
            }
        }

        class Child : Parent
        {
            public override void Talk()
            {
                Console.WriteLine("Child talks");
            }
            // if you do not override the meathod it will call the parent's meathod
        }
    }
}
