using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            int x1 = Convert.ToInt32(Console.ReadLine());                
            int x2 = Convert.ToInt32(Console.ReadLine()); 
            int y1 = Convert.ToInt32(Console.ReadLine()); 
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) +
                      Math.Pow(y2 - y1, 2)));


        }
    }
}
