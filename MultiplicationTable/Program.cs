using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            Console.Write("Sisesta number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} X {1} = {2} \n", n, i, n * i);


            }
        }
    }


}
