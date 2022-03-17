

using System;

namespace grupine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            float r;
            float pi = 3.1415926535f;


            r = 6371;

            Console.WriteLine(4 * pi * (r * r));

            Console.WriteLine(4f / 3f * pi * (r * r * r));

            double Spindulyskvadratu = Math.Pow(6731, 2);
            double ZemesPlotas = 4 * 3.14 * Spindulyskvadratu;
            Console.WriteLine($"Zemes plotas - {ZemesPlotas}");


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
