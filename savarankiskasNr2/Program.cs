

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
        }
    }
}
