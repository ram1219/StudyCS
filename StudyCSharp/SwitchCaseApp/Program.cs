using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseApp
{
	class Program
	{
		static void Main(string[] args)
		{
			object obj = null;
			string s = Console.ReadLine();

			if (int.TryParse(s, out int out_i))
				obj = out_i;
			else if (float.TryParse(s, out float out_f))
				obj = out_f;
			else
				obj = s;

			switch (obj)
			{
				case int i:
					Console.WriteLine($"{i}는 int 형식");
					break;
				case float f when f >= 0:						// when 키워드를 사용하여 분기를 한 번 더 할 수 있다.
					Console.WriteLine($"{f}는 float 형식");
					break;
				default:
					Console.WriteLine($"{s}는 string 형식");
					break;
			}
		}
	}
}
