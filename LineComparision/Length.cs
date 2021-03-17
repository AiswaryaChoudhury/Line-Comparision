using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class Length
    {
        public int startpoint1, endpoint1, startpoint2, endpoint2;
        public Length()
        {
            startpoint1 = Convert.ToInt32(Console.ReadLine());
            endpoint1 = Convert.ToInt32(Console.ReadLine());
            startpoint2 = Convert.ToInt32(Console.ReadLine());
            endpoint2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
