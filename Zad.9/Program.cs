
// Да се напише програма, която преобразува двоично число в шестна­десетично.

using System;


namespace Zad._9
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            string n = Console.ReadLine();
            int m1 = Convert.ToInt32(n, 2);
            string m2 = Convert.ToString(m1, 16);
            Console.WriteLine(" {0}(2) ---> {1}(16)", n, m2);
        }
    }
}