using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Co -ordinates of 1st line:");
            Length line1 = new Length();
            Console.WriteLine("Enter the Co -ordinates of 2nd line:");
            Length line2 = new Length();
            double lengthLine1, lengthLine2;
            lengthLine1 = Math.Sqrt(Math.Pow(line1.endpoint1 - line1.startpoint1, 2) + Math.Pow(line1.endpoint2 - line1.startpoint2, 2));
            lengthLine2 = Math.Sqrt(Math.Pow(line2.endpoint1 - line2.startpoint1, 2) + Math.Pow(line2.endpoint2 - line2.startpoint2, 2));
            if (lengthLine1.Equals(lengthLine2))
                Console.WriteLine("Length of two lines are equal");
            if (lengthLine1 > lengthLine2)
                Console.WriteLine("Length of line 1 is greater than Line 2");
            else
                Console.WriteLine("Length of line 1 is less than line 2");
        }
    }
}