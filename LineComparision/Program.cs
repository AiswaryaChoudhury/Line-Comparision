using System;

namespace LineComparision
{
    class Program
    {
        int startpoint1, endpoint1, startpoint2, endpoint2;
        public Program()
        {
            startpoint1 = Convert.ToInt32(Console.ReadLine());
            endpoint1 = Convert.ToInt32(Console.ReadLine());
            startpoint2 = Convert.ToInt32(Console.ReadLine());
            endpoint2 = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Enter the Co -ordinates of 1st line:");
            Program line1 = new Program();
            Console.WriteLine("Enter the Co -ordinates of 2nd line:");
<<<<<<< HEAD
<<<<<<< HEAD
            int x3 = Convert.ToInt32(Console.ReadLine());
            int x4= Convert.ToInt32(Console.ReadLine());
            int y3= Convert.ToInt32(Console.ReadLine());
            int y4= Convert.ToInt32(Console.ReadLine());

            double m, n;
            m = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
            n = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            if (m == n)
=======
            Program line2 = new Program();
            double lengthLine1, lengthLine2;
            lengthLine1= Math.Sqrt(Math.Pow(line1.endpoint1 - line1.startpoint1, 2) + Math.Pow(line1.endpoint2 - line1.startpoint2, 2));       
            lengthLine2= Math.Sqrt(Math.Pow(line2.endpoint1 - line2.startpoint1, 2) + Math.Pow(line2.endpoint2 - line2.startpoint2, 2));
            if (lengthLine1.Equals(lengthLine2))
>>>>>>> UC2-CheckEqualityOf2Lines
=======
            Program line2 = new Program();
            double lengthLine1, lengthLine2;
            lengthLine1 = Math.Sqrt(Math.Pow(line1.endpoint1 - line1.startpoint1, 2) + Math.Pow(line1.endpoint2 - line1.startpoint2, 2));
            lengthLine2 = Math.Sqrt(Math.Pow(line2.endpoint1 - line2.startpoint1, 2) + Math.Pow(line2.endpoint2 - line2.startpoint2, 2));
            if (lengthLine1.Equals(lengthLine2))
>>>>>>> UC3-Compare2Lines
                Console.WriteLine("Length of two lines are equal");
            if (lengthLine1>lengthLine2)
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
