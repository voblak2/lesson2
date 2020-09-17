using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var userAge = 22;

            if (userAge < 18)
            {
                Console.WriteLine("Sorry, you are too young to purchase tickets for this movie.");
            }   else if (userAge >= 18)
            {
                Console.WriteLine("Here are your tickets. Enjoy the movie.");
            }
        }
    }
}
