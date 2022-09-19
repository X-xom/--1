using System;

namespace ЛБ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			float delimiter_1 = 2;
			float delimiter_2 = 1;

			float denominator_1 = 1;
			float denominator_2 = 1;

			float addition_del, addition_den;
			int counter = 0;

			while (Math.Abs(delimiter_1 / denominator_1 - delimiter_2 / denominator_2) > 0.001)
			{
			    counter+=1;
				addition_del = delimiter_1 + delimiter_2;
				addition_den = denominator_1 + denominator_2;
				
				delimiter_2 = delimiter_1;
				delimiter_1 = addition_del;

				denominator_2 = denominator_1;
				denominator_1 = addition_den;
				//Console.WriteLine(delimiter_1 / denominator_1);
			}
			Console.WriteLine(counter);
			Console.ReadKey();
		}
	}
}
