using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Programm
    {
        static void Main(string[] args)
        {
            int minI = 100000000;
            int maxI = -1000000000;
            MinMaxSeq(ref minI, ref maxI);
            Console.ReadKey();
        }

        static void MinMaxSeq(ref int minI, ref int maxI)
        {
            int i = 1;
            while (i != 0)
            {
                i = int.Parse(Console.ReadLine());
                if (i != 0 && i > maxI) maxI = i;
                if (i != 0 && i < minI) minI = i;
            }
            Console.WriteLine($"Минимальное: {minI}, Максимальное: {maxI}");
        }
    }
}
	
