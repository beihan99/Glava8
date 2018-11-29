
// Превърнете числото 1111010110011110(2) в шестнадесетична и в десе­тична бройна система.

using System;


namespace Zad._2
{
    class Program
    {
        static void Main()
        {
            decimal n = 1111010110011110;

            double m = Convert.ToInt64("1111010110011110", 2);
            Console.WriteLine(" {0}(2) ---> {1}(10)",n,m);

            Console.WriteLine(" {0}(2) ---> {1}(16)", n, Convert.ToInt64("1111010110011110", 2).ToString("X"));

        }
    }
}
