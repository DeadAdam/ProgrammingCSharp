using System;


namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
           double t;
            const double g = 9.83;
            double h;
            double V;

            Console.WriteLine("Enter Height: ");
             h =  Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Enter current speed: ");
            V = Convert.ToDouble(Console.ReadLine());
            t = Convert.ToDouble(Math.Sqrt((2 * (h - V)) / g));

            
            Console.WriteLine("Time of falling: " + t);

            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
