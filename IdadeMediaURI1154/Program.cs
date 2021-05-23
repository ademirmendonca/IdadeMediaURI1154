using System;
using System.Globalization;

namespace IdadeMediaURI1154
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade;
            double idadeTotal = 0;
            int cont = 0;
            double media = 0;

            idade = double.Parse(Console.ReadLine());
            while (idade >= 0)
            {
                cont = cont + 1;
                idadeTotal = idadeTotal + idade;
                idade = double.Parse(Console.ReadLine());                
            }

            
            media = idadeTotal / cont;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
