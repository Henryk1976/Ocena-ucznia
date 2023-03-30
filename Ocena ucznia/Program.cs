using System;

namespace Ocena_ucznia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz ocenę");

            string a = Console.ReadLine();
            int ax = int.Parse(a);

            if (ax == 6)
            {
                Console.WriteLine("Celujący");

            }
            if (ax == 5)
            {
                Console.WriteLine("Bardzo dobry");

            }
            if (ax == 4)
            {
                Console.WriteLine("Dobry");

            }
            if (ax == 3)
            {
                Console.WriteLine("Dostateczny");


            }
            if(ax == 2) 
            {
                Console.WriteLine("Dopuszczający");

            }
            if (ax == 1) 
            {
                Console.WriteLine("Niedostateczny");

            }


        }
    }
}
