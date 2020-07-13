using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambda
{
	class Program
	{
		// 람다식은 익명 메소드이다.
		// 익명 메소드를 만들기위해서는 대리자를 사용해야 한다.
		delegate int Calculate(int a, int b);
		delegate string Concatenate(string[] args);

		//static int Plus(int a, int b) { return a + b; }
		

		static void Main(string[] args)
		{
			// 왼쪽에는 매개변수 오른쪽에는 (연산)식
			// 람다식을 사용하면 위 처럼 따로 함수를 생성할 필요가 없이 아래와 같이 사용 가능하다.
			Calculate calc = (a, b) => a + b;

			Console.WriteLine(calc(3, 4));

			#region 불필요한 부분 주석처리
			/*
			// 문 형식의 람다식
			Concatenate concat = 
				(arr) =>
				{
					string result = "";
					foreach (var item in arr)
						result += item;
					return result;
				};

			// 속성 -> 디버그 -> 문자열 입력을 하면 출력을 한다.
			Console.WriteLine(concat(args));
			*/
			#endregion

		}

	}
}
