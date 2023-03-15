using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here :");
            string line_input = Console.ReadLine();

            Console.WriteLine("Enter a character here :");
            string character_input = Console.ReadLine();
            char character = character_input[0];

            char[] modifiedString = new char[line_input.Length];
            int currentIndex = 0;

            foreach (char c in line_input)
            {
                if (char.ToLower(c) != char.ToLower(character))
                {
                    modifiedString[currentIndex] = c;
                    currentIndex++;
                }
            }

            string output = new string(modifiedString, 0, currentIndex);

            Console.WriteLine(output);
        }
    }
}
