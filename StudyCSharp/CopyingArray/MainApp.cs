using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CopyingArray
{
	class MainApp
	{
		// 일반화
		// 구조가 같고 데이터의 형식이 다른경우 일반화 <>를 사용한다.
		static void CopyArray<T>(T[] source, T[] target)
		{
			for (int i = 0; i < source.Length; i++)
				target[i] = source[i];
		}

		static void Main(string[] args)
		{
			int[] source = { 1, 3, 5, 7, 9 };
			int[] target = new int[source.Length];

			// int형으로 사용하는 경우
			CopyArray<int>(source, target);

			foreach(var item in target)
			{
				Console.Write($"{item}, ");
			}
			Console.WriteLine();

			string[] source2 = { "삼", "육", "구" };
			string[] target2 = new string[source2.Length];

			// string형으로 사용하는 경우
			CopyArray<string>(source2, target2);
			foreach (var item in target2)
			{
				Console.Write($"{item}, ");
			}
			Console.WriteLine();
		}
	}
}
