using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegate
{
	// 대리자 선언
	delegate int MyDelegate(int a, int b);

	class Calculator
	{
		public int Plus(int a, int b) { return a + b; }
		// 대리자는 정적 메소드도 참조할 수 있다.
		public static int Minus(int a, int b) { return a - b; }
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			// 보통 방식
			Calculator calc = new Calculator();
			Console.WriteLine(calc.Plus(3, 4));

			// 대리자를 사용한 경우
			MyDelegate CallBack = new MyDelegate(calc.Plus);
			Console.WriteLine(CallBack(3, 5));

			// Minus는 정적 메소드이모로 calc이 아닌 Calcurator를 직접 참조한다.
			CallBack = new MyDelegate(Calculator.Minus);
		}
	}
}
