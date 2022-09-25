// Определить, сколько раз нужно разрезать пополам металлическую нить длиной L = 0,1 м, чтобы ее длина уменьшилась до атома (размер атома D А считать равным 10 -10 м).

using System;

namespace ЛБ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			double l = 0.1;
			double atom = Math.Pow(10, -10);
			int counter = 0;
			while (l > atom)
			{
				l /= 2;
				counter++;
			}
			Console.WriteLine(counter);
			Console.ReadLine();
		}
	}
}
