using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var isDaytime = false;
            var isHungry = false;
            if (!(isDaytime && isHungry))
            {
                Console.WriteLine("Don't eat.");
            
            } else {
                Console.WriteLine("Time to eat.");
            }
            
        }
    }
}
