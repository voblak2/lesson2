using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 71;
            string grade = "";

            if (score > 90)
            {
                grade = "A";
            } 
            else if (score > 80) 
            {
                grade = "B";
            } 
            else if (score > 70) 
            {
                grade = "C";
            }
            Console.WriteLine(grade);
        }
    }
}
