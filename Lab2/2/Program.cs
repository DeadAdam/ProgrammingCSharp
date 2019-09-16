using System;

namespace _2
{
    class Program
    {
        static void Main()
        {
            double k,n,a,N;

            Console.WriteLine("Enter n:");

            do
            {
                n = Convert.ToDouble(Console.ReadLine());
                if (n < 0)
                 {
                    Console.WriteLine("Error");
                 }
            } while (n < 0);

            k = n * n;
            N = n * k;
            a = 0;

            for (; k <= N; k++)
            {
                a = Convert.ToDouble( a + (((Math.Pow(k,2)- (Math.Pow(-1, Math.Pow(k,2)+1))*k))/(Math.Pow(k,2)+2)));

            }

            Console.WriteLine("S = " + a);

            Console.WriteLine();
            Console.ReadLine();

        }



    }

}