using System;

namespace ConsoleApp13
{
    class Program
    {
        abstract class Animal
        {
            protected int age{ get; set; }
            protected string name { get; set; }
            protected readonly static bool cute = true;
    }
    class Fox : Animal
        {
            public Fox(int age, string name)
            { 
                this.age = age;
                this.name = name;
            }
            public void makenoise()
            {
                Console.WriteLine(String.Format("*Foxnoise from {0}", get_name()));
                Console.WriteLine(String.Format("Is it cute ?: {0}", cute.ToString()));
            }
            public string get_name()
            {
                return name;
            }
        }
        class Cat : Animal
        {
            public Cat(int age, string name)
            {
                this.age = age;
                this.name = name;
            }
            public void makenoise()
            {
                Console.WriteLine(String.Format("*Catnoise from {0}",get_name()));
                Console.WriteLine(String.Format("Is it cute ?: {0}",cute.ToString()));
            }
            public string get_name()
            {
                return name;
            }
        }
        static void Main(string[] args)
        {
            Cat Catto = new Cat(4,"catname");
            Catto.makenoise();
        }
    }
}
