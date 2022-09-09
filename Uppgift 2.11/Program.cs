using System;
namespace Uppgift_2._11
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur långt meter har Elin hoppat?");
            string x =Console.ReadLine();
            Console.WriteLine("Hur långt meter har Alma hoppat?");
            string y= Console.ReadLine();
            int z = int.Parse(x);
            
            Console.WriteLine("Elin hoppade "+x );
            
        }
    }
}