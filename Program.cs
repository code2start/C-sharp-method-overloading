using System;

namespace methodoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.Foo("xx", 33);
        }
    }
    class ClassA
    {
        public void Foo()
        {
            Console.WriteLine("I'm foo with no parameters");
        }
        public void Foo(int x)
        {
            Console.WriteLine("I'm foo with x parameters");
        }
        public void Foo(int x, string y)
        {
            Console.WriteLine("I'm foo with int x, string y parameters");
        }
        public void Foo(string x, int y)
        {
            Console.WriteLine("I'm foo with string x, int y parameters");
        }
    }
}
