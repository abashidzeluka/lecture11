using System;

namespace Assignment1
{
    internal class Array : IOutput2
    {
        public void ShowEven(int[] array)
        {
            Console.Write("Even numbers: ");
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " " );
                }
            }
            Console.WriteLine(); 
        }

        public void ShowOdd(int[] array)
        {
            Console.Write("Odd numbers: ");
            foreach (var item in array)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
