using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Classes
    {
        public static void go() 
        { 
            ExampleProperties ep = new ExampleProperties();
            ep.prop2 = "owo";
            ep.GetProp3 = "uwu";
            string s3 = ep.GetProp3;

            //Math mat = new Math(); 
            float diam = Math.CalcCircumference(4);

            Student millie = new Student();
            millie.Name = "millie"; // uses getter
            Console.WriteLine($"name is: {millie.Name}");
        }
    }

    class ExampleProperties
    {
        public string prop2; // not validated
        private string prop3; // able to be validated

        public string GetProp3 //getters and setters are kinda weird
        {
            get { return prop3; }
            set { prop3 = value; }
        }
    }

    static class Math // all meathods must be static and cannot instanciate class
    {
        public const float PI = 3.1415926535f;

        public static float CalcCircumference(float radius)
        {
            return 2 * PI * radius;
        }
    }

    class Student
    {
        protected string name;
        protected int cohort = 37;
        protected float gpa;
        static int numberofstudents;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float GPA
        {
            get { return gpa; }
            set { if (value >= 0 && value <= 4.0) gpa = value; }
        }

        // auto-implemented properties
        // creates a private field
        // could remove get or set to have a read only or write only;
        public int Age { get; set; } = 18;

        public Student()
        {
            Age = 18;
            name = "bob";
            Console.WriteLine("student constructor 0 params");
            numberofstudents++;
        }

        public Student(string name, int cohort, float gpa, float gPA, int age)
        {
            Name = name;
            this.cohort = cohort;
            this.gpa = gpa;
            GPA = gPA;
            Age = age;
            Console.WriteLine("student constructor all params");
        }

        public void HowManyStudents() 
        {
            Console.WriteLine($"number of students: {numberofstudents}");
        }
    }
}
