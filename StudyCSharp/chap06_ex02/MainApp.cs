using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap06_ex02
{
	class MainApp
	{
		public static void Mean(double a, double b, double c, double d, double e, out double mean)
		{
			mean = (a + b + c + d + e) / 5;
		}
		static void Main(string[] args)
		{

			double mean = 0;

			Mean(1, 2, 3, 4, 5, out mean);
			Console.WriteLine($"평균 : {mean}");
		}
	}
}
