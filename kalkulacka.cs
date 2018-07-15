using System;

namespace ConsoleApp1
{
    class kalkulacka
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vitej v kalkulacce. Vyber si prosim matematickou operaci.");
            Console.WriteLine("[1] Scitani");
            Console.WriteLine("[2] Odcitani");
            Console.WriteLine("[3] Nasobeni");
            Console.WriteLine("[4] Deleni");
            int volba = int.Parse(Console.ReadLine());

            Console.Write("Zadej prvni cislo: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Zadej druhe cislo: ");
            int y = int.Parse(Console.ReadLine());

            if (volba == 1)
            {
                Console.WriteLine("Soucet vami dvou zadanych cisel je: " + (x + y));
            }
            else if (volba == 2)
            {
                Console.WriteLine("Rozdil vami dvou zadanych cisel je: " + (x - y));
            }
            else if (volba == 3)
            {
                Console.WriteLine("Soucin vami dvou zadanych cisel je: " + (x * y));
            }
            else if (volba == 4)
            {
                Console.WriteLine("Soucin vami dvou zadanych cisel je: " + (x / y));
            }

            Console.WriteLine("Program ukoncis stiknutim libovolne klavesy.");
            Console.ReadKey();
        }
    }
}
