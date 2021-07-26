using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Halo, ini adalah koding tertanggal : " + DateTime.Now);
            // input
            int a = 0;

            //output
            Console.WriteLine(a??3);
            Console.ReadKey();
        }
    }
}
