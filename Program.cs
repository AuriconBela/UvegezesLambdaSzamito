namespace UvegezesLambdaSzamito
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Üvegezés vastagsága (d)
                Console.Write("Add meg az üvegezés vastagságát (mm): ");
                if (!double.TryParse(Console.ReadLine(), out double d) || d <= 0)
                {
                    Console.WriteLine("Hiba: Csak pozitív szám adható meg vastagságként!");
                    Environment.Exit(1);
                }
                d /= 1000; // mm-ről m-re konvertálás

                // Ug érték
                Console.Write("Add meg az üvegezés Ug értékét (W/m2K): ");
                if (!double.TryParse(Console.ReadLine(), out double Ug) || Ug <= 0)
                {
                    Console.WriteLine("Hiba: Csak pozitív szám adható meg Ug értékként!");
                    Environment.Exit(1);
                }

                // Rsi érték (alapértelmezett: 0.04)
                Console.Write("Add meg az Rsi értékét [alapértelmezett: 0.04 m2K/W]: ");
                string? rsiInput = Console.ReadLine();
                double Rsi = 0.04;
                if (!string.IsNullOrWhiteSpace(rsiInput))
                {
                    if (!double.TryParse(rsiInput, out Rsi) || Rsi <= 0)
                    {
                        Console.WriteLine("Hiba: Csak pozitív szám adható meg Rsi értékként!");
                        Environment.Exit(1);
                    }
                }

                // Rse érték (alapértelmezett: 0.13)
                Console.Write("Add meg az Rse értékét [alapértelmezett: 0.13 m2K/W]: ");
                string? rseInput = Console.ReadLine();
                double Rse = 0.13;
                if (!string.IsNullOrWhiteSpace(rseInput))
                {
                    if (!double.TryParse(rseInput, out Rse) || Rse <= 0)
                    {
                        Console.WriteLine("Hiba: Csak pozitív szám adható meg Rse értékként!");
                        Environment.Exit(1);
                    }
                }

                // l számítása
                double l = -(d / (Rse + Rsi - 1 / Ug));
                Console.WriteLine($"\nA számított lambda érték: {l}");

                Console.Write("\nSzeretnél új számítást végezni? (i/n): ");
                var valasz = Console.ReadLine();
                if (valasz == null || !valasz.Trim().StartsWith("i", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nKilépéshez nyomj meg egy gombot...");
            Console.ReadKey();
        }
    }
}
