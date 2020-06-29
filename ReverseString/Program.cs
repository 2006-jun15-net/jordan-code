using System;
namespace ReverseString 
{
    class Program 
    {

        public static void Main (string [] args)
        {
            String input = Console.ReadLine();
            int length = input.Length;
            char [] characters = input.ToCharArray();
            for(int i = length -1; i >= 0 ; i--) {

                Console.Write(characters[i]);
                
                
            }
            
        }
    }
}

