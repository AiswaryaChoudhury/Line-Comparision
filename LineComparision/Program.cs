using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Co -ordinates of 1st line:");
            int x1 = Convert.ToInt32(Console.ReadLine());                
            int x2 = Convert.ToInt32(Console.ReadLine()); 
            int y1 = Convert.ToInt32(Console.ReadLine()); 
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co -ordinates of 2nd line:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int x4= Convert.ToInt32(Console.ReadLine());
            int y3= Convert.ToInt32(Console.ReadLine());
            int y4= Convert.ToInt32(Console.ReadLine());

            double m, n;
            m = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
            n = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            if (m .Equals(n))
                Console.WriteLine("Length of two lines are equal");
            else
                Console.WriteLine("Length of two lines are not equal");
        }
    }
}
