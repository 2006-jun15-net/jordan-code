using System;

namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            String input = Console.ReadLine();
            int q = int.Parse(input);
            for (int i = 0; i < q; i++)
            {
                for(int t = 0; t <= i; t++)
                {
                Console.Write("#");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
