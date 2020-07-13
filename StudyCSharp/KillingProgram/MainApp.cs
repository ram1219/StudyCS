using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillingProgram
{
	class MainApp
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3 };
			int x = 100, y = 0;

			try
			{
				for (int i = 0; i < 5; i++)
					Console.WriteLine(arr[i]);

				Console.WriteLine($"{x / y}");
			}
			catch(IndexOutOfRangeException ex)
			{
				Console.WriteLine($"에외 발생 : {ex.Message}");
			}
			catch(DivideByZeroException ex)
			{
				Console.WriteLine($"딴예외발생 : {ex.Message}");
			}
			catch(Exception ex)
			{
				Console.WriteLine($"모든 예외 상황을 받는다. ");
			}
		}
	}
}
