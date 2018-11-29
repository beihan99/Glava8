
// Превърнете числата 151, 35, 43 и 251 в двоична бройна система.

using System;


namespace Zad._1
{
    class Program
    {
        static void Main()
        {
            int [] arr = {151,35,43,251};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" {0}(16) ---> {1}(10)", arr[i], Convert.ToString(arr[i], 2));
                Console.WriteLine(" ");
            }
        }
    }
}
