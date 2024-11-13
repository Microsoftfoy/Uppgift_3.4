using System;
using System.Reflection.Metadata.Ecma335;
namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är din låt?");
            Console.WriteLine("Min: 2 min och 45 sek Max: 4 min och 20 sek");

            Console.WriteLine("Skriv in låtens längd (MED: ,");

            double Låt = double.Parse(Console.ReadLine());
                      
            if(Låt <= 2.45 && Låt >= 4.20)
            {
                Console.WriteLine("Bra, skriv in nu sekunderna");
            }
            else 
            {
                Console.WriteLine("Låten är för kort eller lång"); Environment.Exit(0);
            }
          
            Console.WriteLine("Bra, Din låt är okej att användas");

            Console.ReadKey();

        }

    }
}