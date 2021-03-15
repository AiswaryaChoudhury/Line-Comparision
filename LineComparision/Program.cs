using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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

            if (m == n)
                Console.WriteLine("Length of two lines are equal");
            else if(m > n)
                Console.WriteLine("Length of line 1 is greater than Line 2");
            else
                Console.WriteLine("Length of line 1 is less than line 2");
=======
            Console.WriteLine("Welcome to Line Comparision Computation Program");
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
