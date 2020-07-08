using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
	class MainApp
	{
		static void Main(string[] args)
		{
			// 명명되지 않은 튜플
			var a = ("슈퍼맨", 56);
			Console.WriteLine($"{a.Item1}, {a.Item2}");

			// 명명된 튜플
			var b = (Name: "김가람", Age: 25);
			Console.WriteLine($"{b.Name}, {b.Age}");

			// 분해
			var (name, age) = b;						// (var name, var age) = b;
			Console.WriteLine($"{name}, {age}");

			// 명명된 튜플 = 명명되지 않은 튜플
			b = a;
			// b.Name = a.Item1, b.Age = a.Item2
			Console.WriteLine($"{b.Name}, {b.Age}");

			// 아래에서 생성한 함수를 사용하여 tuple값 가져오기
			var (name2, age2, from) = GetInfo();
			Console.WriteLine($"{name2}, {age2}, {from}");
		}
		// Tuple을 함수로 생성
		static new Tuple<string, int, string> GetInfo(){
			return new Tuple<string, int, string>("김가람", 25, "창원");
		}
	}
}
