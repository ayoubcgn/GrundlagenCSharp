using System;

namespace SchleifeAB7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie eine Zahl ein ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Ergebnis: " + sum);
        }
    }
}
