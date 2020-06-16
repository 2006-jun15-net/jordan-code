using System;

namespace CollatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number: ");
            String input = Console.ReadLine();
            int n = int.Parse(input);
            while ( n > 1)
            {   Console.WriteLine(n);
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = (n*3) + 1;
                }
                
            }
        }
    }
}
