using System;
namespace uppgift6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tal 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: ");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine(StörstaTal(tal1, tal2));
            Console.ReadKey();
        }
        static int StörstaTal(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else if (tal2>tal1)
            {
                return tal2;
            }
            else
            {
                return tal1+tal2;
            }
        }
    }
}