using System;

namespace savarankiskasNr2
{
    class Program
    {
        static void Main(string[] args)
        {





























            double izambineKvadratu = Math.Pow(10, 2) + Math.Pow(15, 2);
            double izambine = Math.Sqrt(izambineKvadratu);

            Console.WriteLine("Viso Kintamuju: ");
            Console.WriteLine($"zemes plotas - {zemesPlotas}");
            Console.WriteLine($"zemes turis - {zemesTuris}");
            Console.WriteLine($"izambines ilgis - {izambine}");
            Console.WriteLine($"suma kintamuju - {zemesPlotas + zemesTuris + izambine}");
            Console.WriteLine($"vidurkis - {(zemesPlotas + zemesTuris + izambine) / 3}");
        }
    }
}
