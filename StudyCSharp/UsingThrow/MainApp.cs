using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingThrow
{
	class MainApp
	{
		static void Main(string[] args)
		{
			try
			{
				DoSomething(10);
			}
			catch(Exception ex)
			{
				Console.WriteLine($"에외발생 : {ex.Message}");
				Console.WriteLine($"도움말 링크 : {ex.HelpLink}");
			}
		}

		private static void DoSomething(int arg)
		{
			if (arg < 10)
				Console.WriteLine($"arg : {arg}");
			else
				throw new Exception("arg가 10보다 큽니다.")
				{
					HelpLink = "http://www.naver.com",
					Source = "UsingThrow line32"
				};
		}
	}
}
