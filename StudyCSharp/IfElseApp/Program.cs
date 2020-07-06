using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("숫자를 입력하세요 : ");
			string input = Console.ReadLine();
			int number;

			// TryParse -> 숫자를 구분하는 메서드
			// input값이 숫자인 경우 number에 저장하고 true 반환
			// int가 아닌 경우 number에 0을 저장하고 false 반환
			if(int.TryParse(input, out number))
			{
				if(number > 0)
				{
					if (number % 2 == 0)
						Console.WriteLine("짝수");
					else
						Console.WriteLine("홀수");
				}
			}
			else
			{
				Console.WriteLine("입력값이 숫자가 아닙니다.");
				return;
			}
		}
	}
}
