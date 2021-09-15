using System;


namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            if (EsPrimo(num))
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
            }
        }
        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    // No es primo :(
                    return false;
                }
            }
            // Es primo :)
            return true;

        }
    }
}
