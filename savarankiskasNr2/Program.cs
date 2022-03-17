using System;

namespace grupine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            double spindulyskvadratu = Math.Pow(6731, 2);
            double zemesPlotas = 4 * 3.14 * spindulyskvadratu;

            double spindulysKubu = Math.Pow(6371, 2);
            double zemesTuris = 3.14 * (4 / 3) * spindulysKubu;

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
