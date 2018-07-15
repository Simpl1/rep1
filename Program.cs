using System;

namespace ConsoleApp1
{
    class Program
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

            switch (volba)
            {
                case 1:
                    Console.WriteLine("Soucet vami dvou zadanych cisel je: " + (x + y));
                    break;
                case 2:
                    Console.WriteLine("Rozdil vami dvou zadanych cisel je: " + (x - y));
                    break;
                case 3:
                    Console.WriteLine("Soucin vami dvou zadanych cisel je: " + (x * y));
                    break;
                case 4:
                    Console.WriteLine("Podil vami dvou zadanych cisel je: " + (x / y));
                    break;

                default: Console.WriteLine("Error. Ujistete se, ze zadavate jednu ze zminenych moznosti.");
                    break;
            }
            Console.WriteLine("Program ukoncite stisknutim libovolne klavesy");
            Console.ReadKey();
        }
    }
}
