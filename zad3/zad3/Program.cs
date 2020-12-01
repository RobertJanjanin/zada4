using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int bezPDV;
            int PDV;
            Console.WriteLine("Unesi cijenu bez PDVa: ");
            bezPDV =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(bezPDV + bezPDV * 0.25);
            Console.WriteLine("Unesi cijenu s PDVom: ");
            PDV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PDV * 0.80);
            Console.ReadKey();
        }
    }
}
