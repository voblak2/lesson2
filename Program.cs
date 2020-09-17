using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var isSleepy = true;
            var isLibraryClosed = false;
            var isBatteryDead = false;

            if (isSleepy || isLibraryClosed || isBatteryDead)
            {
                Console.WriteLine("You should leave now.");
            }   else 
            {
                Console.WriteLine("Keep on studying.");
            }
            
        }
    }
}
