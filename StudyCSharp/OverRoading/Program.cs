using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OverRoading
{
	class Program
	{
		static int Plus(int a, int b, int c)
		{
			return a + b + c;
		}

		/// <summary>
		/// double 형식의 세 수를 더한다.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		static double Plus(double a, double b, double c)
		{
			return a + b + c;
		}

		// Sum 함수에 입력값의 갯수가 정해져 있지 않다. 
		static int Sum(params int[] args)
		{
			int result = 0;
			foreach (var item in args)
			{
				result += item;
			}

			return result;
		}

		static void MyMethod(string arg1 = "", string arg2 = "")
		{
			Console.WriteLine("MyMethod A");
		}

		static void MyMethod()
		{
			Console.WriteLine("MyMethod B");
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Plus(3.14, 23, 33.0));

			int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
			Console.WriteLine($"sum = {sum}");

			MyMethod();             // MyMethod B
			MyMethod("", "");       // MyMethod A
		}
	}
}
