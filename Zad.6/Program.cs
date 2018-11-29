
// Да се напише програма, която преобразува десетично число в шестнадесетично.

using System;


namespace Zad._6
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            string m = Convert.ToString(n, 16);
            Console.WriteLine(" {0}(10) ---> {1}(16)", n, m);
        }
    }
}