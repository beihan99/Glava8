
// Да се напише програма, която преобразува шестнадесетично число в двоично.

using System;


namespace Zad._8
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            string n = Console.ReadLine();
            int m1 = Convert.ToInt32(n, 16);
            string m2 = Convert.ToString(m1, 2);
            Console.WriteLine(" {0}(16) ---> {1}(2)", n, m2);
        }
    }
}