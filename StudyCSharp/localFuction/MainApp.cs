using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localFuction
{
	class MainApp
	{
		static string ToLowerString(string input)
		{
			var arr = input.ToCharArray();

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = ToLowerChar(i);
			}

			// 모든 문자가 소문자로 변환된 arr을 리턴
			return new string(arr);

			// 지역(local) 함수 생성
			char ToLowerChar(int i)
			{
				// 소문자일 경우 
				if (arr[i] < 65 || arr[i] > 90)
					return arr[i];
				// 대문자일 경우
				else
					return (char)(arr[i] + 32);

			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine(ToLowerString("HelLo!"));
		}
	}
}
