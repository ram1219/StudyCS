using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForeachApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// strings 이름의 리스트 생성
			List<string> strings = new List<string>();
			// 리스트 원소를 하나씩 추가
			strings.Add("Hello");
			strings.Add("Bye");

			// subs 이름의 리스트 생성 후 값 초기화
			List<string> subs = new List<string> { "Banana", "Strawberry" };
			// subs 리스트 원소를 한번에 strings 리스트에 추가
			strings.AddRange(subs);

			var i = 0;

			foreach(var item in strings)
			{
				Console.WriteLine($"{++i} 번째 item : {item}");
			}
		}
	}
}
