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
<<<<<<< HEAD
            int startpoint1 = Convert.ToInt32(Console.ReadLine());                
            int endpoint1 = Convert.ToInt32(Console.ReadLine()); 
            int startpoint2 = Convert.ToInt32(Console.ReadLine());
            int endpoint2 = Convert.ToInt32(Console.ReadLine());
            double length;
            length = Math.Sqrt(Math.Pow(endpoint1 - startpoint1, 2) + Math.Pow(endpoint2 - startpoint2, 2));
            Console.WriteLine("Length of two Co-ordinates :" + length);
>>>>>>> UC1-CalculateLength
=======
            Console.WriteLine("Enter the Co -ordinates of 1st line:");
            Length line1 = new Length();
            Console.WriteLine("Enter the Co -ordinates of 2nd line:");
            Length line2 = new Length();
            double lengthLine1, lengthLine2;
            lengthLine1= Math.Sqrt(Math.Pow(line1.endpoint1 - line1.startpoint1, 2) + Math.Pow(line1.endpoint2 - line1.startpoint2, 2));       
            lengthLine2= Math.Sqrt(Math.Pow(line2.endpoint1 - line2.startpoint1, 2) + Math.Pow(line2.endpoint2 - line2.startpoint2, 2));
            if (lengthLine1.Equals(lengthLine2))
                Console.WriteLine("Length of two lines are equal");
            else
                Console.WriteLine("Length of two lines are not equal");
>>>>>>> UC2-CheckEqualityOf2Lines
        }
    }
}
