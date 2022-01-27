using System;

namespace SchleifeAB8
{
    class Program
    {
        static void Main(string[] args)
        {
            int Versuche = 0;



            int e;




            do

            {



                Versuche++;



                Console.WriteLine("Geben Sie den Pin ein");

                e = Convert.ToInt32(Console.ReadLine());



            }

            while (e != 1234);




            Console.WriteLine(Versuche);


        }
    }
}
