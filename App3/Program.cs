using System;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 52.24F;
            double num2 = 52.24;
            decimal num3 = 52.24M;
            Console.WriteLine("{0} {1} {2}", num1, num2, num3);

            /* Float --> 7 dígitos -- 32bits
             * Double --> 15-16 dígitos -- 64bits
             * Decimal --> 28-29 dígitos -- 128bits
             */
        }
    }
}
