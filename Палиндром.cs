using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string a = Console.ReadLine();
            a = a.Replace(" ", "");
            a = a.ToLower();
            string k = "";

            for (int i = a.Length - 1; i >= 0; i--)
                k += a[i];

            if (k == a)
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");

            Console.ReadKey();
        }
    }
}
