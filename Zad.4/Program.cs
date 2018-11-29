
// Да се напише програма, която преобразува десетично число в дво­ично.

using System;


namespace Zad._4
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            string m = Convert.ToString(n, 2);
            Console.WriteLine(" {0}(10) ---> {1}(2)", n, m);
        }
    }
}
