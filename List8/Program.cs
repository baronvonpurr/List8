using System;

namespace List8
{
    class Program
    {
        static void Main(string[] args)
        {
            int error = 0;
            int loop = 0;
            string actinp;
            string message;
            string actcode;
            Console.WriteLine("Hur många koder vill du skriva in?");
            loop = int.Parse(Console.ReadLine());
            string[] codes = new string[loop];
            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("Skriv in kod");
                actinp = Console.ReadLine();
                codes[i] = actinp;
            }
            Console.WriteLine("Skriv in ditt hemliga medellande");
            message = Console.ReadLine();
            for (int i = 0;i < message.Length; i++)
            {
                Console.WriteLine("check 1");
                while (true)
                {
                    for (int j = 0; j < codes[i].Length; j++)
                    {
                        actcode = codes[j];
                        if (message[i] == actcode[1])
                        {
                            message = actcode[3] + message.Substring(1);
                            error = 0;
                            Console.WriteLine("Check 2");
                        }
                        else
                        {
                            error++;
                        }
                        if(error == codes[i].Length)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(message);
        }
    }
}