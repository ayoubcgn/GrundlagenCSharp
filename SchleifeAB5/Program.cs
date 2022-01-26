using System;

namespace SchleifeAB5
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.WriteLine("Geben sie einen Wert x ein");
           
            int x = Convert.ToInt32(Console.ReadLine());
            

            
            for (int i = -x; i <= x; i = i + 2) 
            {
                Console.Write("{0,4}", i);
            }


        }
    }
}
