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

			float tmp_delimiter, tmp_denominator;

			while ((float)Math.Abs(delimiter_1 / denominator_1 - delimiter_2 / denominator_2) > .001)
			{
				tmp_delimiter = delimiter_1 + delimiter_2;
				tmp_denominator = denominator_1 + denominator_2;
				
				delimiter_2 = delimiter_1;
				delimiter_1 = tmp_delimiter;

				denominator_2 = denominator_1;
				denominator_1 = tmp_denominator;
			}
			Console.WriteLine(delimiter_1 / denominator_1);
			Console.ReadKey();
		}
	}
}