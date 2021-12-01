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
			while (true)
			{
				Console.Write("Введите сторону a: ");
				int a = int.Parse(Console.ReadLine());
				Console.Write("Введите сторону b: ");
				int b = int.Parse(Console.ReadLine());
				Console.Write("Введите сторону c: ");
				int c = int.Parse(Console.ReadLine());

				Perimetr(a, b, c);
			}
		}

		static void Perimetr(int a, int b, int c)
		{
			int p = a + b + c;
			Console.WriteLine(p);
		}
	}
}
