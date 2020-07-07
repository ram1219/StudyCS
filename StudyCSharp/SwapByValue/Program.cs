using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapByValue
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 3;
			int y = 4;

			Console.WriteLine($"x = {x}, y = {y}");

			// 값을 복사하여 Swapvalue() 함수에 넘기므로 SwapValue() 함수의 안에서만 x와 y의 값이 변하고,
			// main에서의 x, y 값은 변하지 않는다.
			SwapValue(x, y);
			Console.WriteLine($"x = {x}, y = {y}");

			// ref 예약어를 사용하면 변수의 주소값을 직접 참조하므로 SwapReference() 함수에서 변경된 x, y의 값이
			// main에서도 변경이 된다.
			SwapReference(ref x, ref y);
			Console.WriteLine($"x = {x}, y = {y}");
		}

		private static void SwapReference(ref int x, ref int y)
		{
			int temp = y;
			y = x;
			x = temp;
		}

		private static void SwapValue(int x, int y)
		{
			int temp = y;
			y = x;
			x = temp;
		}
	}
}
