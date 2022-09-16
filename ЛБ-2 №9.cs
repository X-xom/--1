using System;

namespace ЛБ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			double l = 0.1;
			double atom = Math.Pow(10, -10);
			Console.WriteLine(atom);
			int cuts = 0;
			while (l > atom)
			{
				l /= 2;
				cuts++;
			}
			Console.WriteLine(cuts);
			Console.ReadLine();
		}
	}
}