namespace ЛБ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*((-1) ^ 1 * 5 ^ 1) / 1! + ...
			 *        _       _    _
			 * [1 .. 6]
			 */
			float s = 0;
			for (int number = 1; number < 7; number++)
			{
				int factorial = 1;
				for (int i = 1; i <= number; i++)
					factorial *= i;

				int negative = -1;
				int five = 5;
				for (int power = 1; power <= number; power++)
				{
					negative *= negative;
					five *= five;
				}
				s += (negative * five) / factorial;
			}
			Console.WriteLine(s);
			Console.ReadLine();
		}
	}
}