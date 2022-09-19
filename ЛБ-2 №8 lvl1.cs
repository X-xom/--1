using System;

namespace ЛБ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			float bank = 10000;
			float percent = 0.08f;
			int months = 0;
			while (bank < 20000)
			{
				months++;
				bank += bank * percent;
			}
			Console.WriteLine(months);
			Console.ReadLine();
		}
	}
}
