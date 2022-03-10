using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            fraction a = new fraction(2, 3);
            fraction b = new fraction(2, 6);
            fraction c = a + b;

            //Console.WriteLine(a);
            //Console.WriteLine(a.ToString());



            Console.WriteLine(c);


            Console.WriteLine("test");
        }
    }
}
