
// Да се напише програма, която преобразува двоично число в десетично по схемата на Хорнер.

using System;


namespace Zad._10
{
    class Program
    {
        static void Main()
        {
            int deci = 0;

            Console.Write(" Въведи число(2): ");
            string binary = Console.ReadLine();
            int length = binary.Length;
            int power = length - 1;

            for (int i = 0; i < length; i++)
            {
                deci += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
                power--;
            }

            Console.WriteLine(" {0}(2) ---> {1}(10)", binary, deci);
        }
    }
}