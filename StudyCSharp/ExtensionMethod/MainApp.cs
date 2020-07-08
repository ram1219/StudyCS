using MyExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 확장 메소드를 담는 클래스의 네임스페이스
namespace MyExtension
{
	// 확장 메소드를 담는 클래스
	public static class IntegerExtension
	{
		// 1. 확장 메소드는 static으로 선언해야 한다.
		// 2. 메소드의 첫 번째 매개 변수는 반드시 this 키워드와 함께 확장하고자 하는 클래스의 인스턴스여야 한다.
		// 3. 그 뒤의 매개 변수가 실제로 확장 메소드를 호출할 때 입력되는 매개 변수이다.
		public static int Square(this int Int)
		{
			return Int * Int;
		}

		public static int Power(this int myInt, int exponent)
		{
			int result = myInt;
			for (int i = 1; i < exponent; i++)
				result = result * myInt;

			return result;
		}
	}
}
namespace ExtensionMethod
{
	class MainApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"3^2 : {3.Square()}");
			Console.WriteLine($"3^4 : {3.Power(4)}");
			Console.WriteLine($"2^10 : {2.Power(10)}");
		}
	}
}
