
//  Да се напише програма, която преобразува шестнадесетично число в десетично.

using System;


namespace Zad._7
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            string n = Console.ReadLine();
            int m = Convert.ToInt32(n, 16);
            Console.WriteLine(" {0}(16) ---> {1}(10)", n, m);
        }
    }
}