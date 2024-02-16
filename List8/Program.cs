using System;

namespace List8
{
    class Program
    {
        static char decodechar(char letter, Dictionary<char, char> translation)
        {
            while (true)
            {
                if (translation.ContainsKey(letter))
                {
                    letter = translation[letter];
                }
                else
                {
                    break;
                }
            }
            return letter;
        }
        static void Main(string[] args)
        {
            Dictionary<char, char> converter = new Dictionary<char, char>();
            int koder;
            string read;
            string input;
            string output = "";
            Console.WriteLine("Hur många koder vill du ha?");
            koder = int.Parse(Console.ReadLine());
            for (int i = 0; i < koder; i++)
            {
                read = Console.ReadLine();
                converter[read[0]] = read[2];
            }
            Console.WriteLine("Skriv in det du vill översätta");
            input = Console.ReadLine();
            foreach (char key in input)
            {
                output += decodechar(key, converter);
            }
            Console.WriteLine(output);
        }
    }
}