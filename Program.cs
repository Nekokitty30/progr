using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, chet, nechet;
            /*scanf("a,", &n);*/
            chet = 0; // четные
            nechet = 0; // нечет.
            while (n > 0)
            {
                if (n % 2 == 0) chet += 1;
                else nechet += 1;
                n = n / 10;
            }
            Console.WriteLine("четных - a, нечетных - b\n", chet, nechet);
        }
    }
}