
//  Превърнете шестнайсетичните числа 2A3E, FA, FFFF, 5A0E9 в двоична и десетична бройна система.

using System;


namespace Zad._3
{
    class Program
    {
        static void Main()
        {
            string[] arr = { "2A3E", "FA", "FFFF", "5A0E9" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" {0}(16) ---> {1}(10)", arr[i], Convert.ToInt32(arr[i], 16));
                Console.WriteLine(" {0}(16) ---> {1}(2)", arr[i], Convert.ToString(Convert.ToInt32(arr[i], 16), 2));
                Console.WriteLine(" ");
            }
       
        }
    }
}