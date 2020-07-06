using System;
using static System.Console;		// Console class 안의 데이터를 사용할 때, Consol. 없이 바로 사용 가능 

namespace HelloApp
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("ex: HelloApp.exe <이름>");
				return;
			}
			else
			{															// Consol.WriteLine("Hello, {0}!", args[0]);	--> 이전형식
				WriteLine($"Hello, {args[0]}!");						// $를 사용하여 {}안에 받을 데이터를 바로 입력한다.
				// cmd 창에서 HelloApp.exe 가있는 폴더의 경로로 이동  ->  실행
				// 속성 -> 디버그 -> 명령줄 인쇄에 입력 -> 실행
			}
		}
	}
}
