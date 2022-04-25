using System;

namespace _19_04_22_OOP_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( DateTime.Today.ToLongDateString());
            Console.WriteLine(DateTime.Today.ToShortDateString());
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today.Month + DateTime.Today.Day);
            Console.WriteLine(DateTime.Today.Month +"T"+ DateTime.Today.Day + DateTimeKind.Local);
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine($"Jaar= {DateTime.Today.Year} Maand= {DateTime.Today.Month}");
        }
    }
}
