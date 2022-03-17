using System;

namespace savarankiskasNr2
{
    class Program
    {
        static void Main(string[] args)
        {
        double Spindulyskvadratu = Math.Pow(6731, 2);
        double ZemesPlotas = 4 * 3.14 * Spindulyskvadratu;
        Console.WriteLine($"Zemes plotas - {ZemesPlotas}");
        }

    }
}
