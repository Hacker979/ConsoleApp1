using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"c= {c}"); // Fixed the typo from Writeline to WriteLine
            Console.Read(); // Added missing semicolon
        }
    }
}
