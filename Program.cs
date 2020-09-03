using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var isHungry = true;
            var isRestaurantOpen = true;

            if (isHungry && isRestaurantOpen)
            {
                Console.WriteLine("Go to the restaurant!");
            } else {
                Console.WriteLine("Don't go to the restaurant.");
            }
        }
    }
}
