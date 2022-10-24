using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Inheritence
    {
        public static void go()
        { 
            //Animal animal = new Animal();
            //animal.name = "koji bajoji";
            Animal animal2 = new Animal("koji", 12, false);
            animal2.speak();
            Mammal mammal = new Mammal("bob", 32, false, true, false);
            mammal.speak();
            Animal bart = new Mammal("bart", 6, false, true, true);
            bart.speak(); // this for some reason doesnt work which makes inheritence and therefore object oriented useless
        }

        class Animal
        {
            private int lifespan;

            public string name;

            public bool IsNocturnal;

            public Animal() { }

            public Animal(string Name, int Lifespan, bool noctunrnal)
            {
                name = Name;
                lifespan = Lifespan;
                IsNocturnal = noctunrnal;
            }

            public void speak()
            {
                Console.WriteLine(name + " speak (animal)");
            }

        }

        class Mammal : Animal
        {
            public bool carnivore { get; set; }
            public bool onLand { get; set; }

            public Mammal(string name, int lifespan, bool iscarnivore, bool liveonland, bool isnocturnal = false) : base(name, lifespan, isnocturnal)
            {
                carnivore = iscarnivore;
                onLand = liveonland;
            }

            public void speak()
            {
                Console.WriteLine(name + " speak (mammal)");
            }
        }

        class Fish : Animal 
        { 
            public bool canspeak { get; set; }

            public Fish(string name, int lifespan, bool canspeak, bool isnocturnal = false) : base(name, lifespan, isnocturnal)
            {
                this.canspeak = canspeak;
            }

            public void speak()
            {
                if (canspeak)
                {
                    Console.WriteLine(name + " speak (fish)");
                }
                else
                {
                    Console.WriteLine("glug glug glug");
                }
            }
        }
    }
}
