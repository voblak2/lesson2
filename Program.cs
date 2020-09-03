using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var isSleepy = false;
            var isLibraryClosed = true;

            if (isSleepy || isLibraryClosed)
            {
                Console.WriteLine("You should leave now.");
            }
            else
            {
                Console.WriteLine("Keep on studying.");
            }
        }
    }
}
