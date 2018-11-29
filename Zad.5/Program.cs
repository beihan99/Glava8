
//  Да се напише програма, която преобразува двоично число в десе­тично.

using System;


namespace Zad._5
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            string n = Console.ReadLine();
            int m = Convert.ToInt32(n, 2);
            Console.WriteLine(" {0}(2) ---> {1}(10)", n, m);
        }
    }
}
