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
            Console.WriteLine("Enter the Co -ordinates of 1st line:");
            Program line1 = new Program();
            Console.WriteLine("Enter the Co -ordinates of 2nd line:");
            Program line2 = new Program();
            double lengthLine1, lengthLine2;
            lengthLine1= Math.Sqrt(Math.Pow(line1.endpoint1 - line1.startpoint1, 2) + Math.Pow(line1.endpoint2 - line1.startpoint2, 2));       
            lengthLine2= Math.Sqrt(Math.Pow(line2.endpoint1 - line2.startpoint1, 2) + Math.Pow(line2.endpoint2 - line2.startpoint2, 2));
            if (lengthLine1.Equals(lengthLine2))
                Console.WriteLine("Length of two lines are equal");
            else
                Console.WriteLine("Length of two lines are not equal");
        }
    }
}
