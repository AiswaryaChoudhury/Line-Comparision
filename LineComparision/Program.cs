using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
<<<<<<< HEAD
        { 
            Console.WriteLine("Welcome To Line Comparision Computation Program");
=======
        {
            int startpoint1 = Convert.ToInt32(Console.ReadLine());                
            int endpoint1 = Convert.ToInt32(Console.ReadLine()); 
            int startpoint2 = Convert.ToInt32(Console.ReadLine());
            int endpoint2 = Convert.ToInt32(Console.ReadLine());
            double length;
            length = Math.Sqrt(Math.Pow(endpoint1 - startpoint1, 2) + Math.Pow(endpoint2 - startpoint2, 2));
            Console.WriteLine("Length of two Co-ordinates :" + length);
>>>>>>> UC1-CalculateLength
        }
    }
}
