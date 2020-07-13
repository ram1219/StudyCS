using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UsingCallback
{
	// 대리자 선언
	// 대리자의 생성자의 매개변수로 사용할 함수를 넣어 사용 가능하다.
	delegate int Compare(int a, int b);

	class MainApp
	{
		// 일반화를 사용한 경우
		// 오름차순 정렬 함수
		// CompareTo 를 가진 IComparable 인터페이스를 구현
		static int AscendCompare<T>(T a, T b) where T : IComparable<T>
		{
			// if (a > b) return 1;
			// else if (a == b) return 0;
			// else return -1;
			// 위와 같이 반환된다.
			return a.CompareTo(b);
		}

		static int DescendCompare(int a, int b)
		{
			if (a < b) return 1;
			else if (a == b) return 0;
			else return -1;
		} 

		// 배열과 대리자를 매개변수로 가지는 함수 생성
		static void BubbleSort(int[] DataSet, Compare comparer)
		{
			int temp = 0;

			for(int i = 0; i < DataSet.Length - 1; i++)
			{
				for(int j = 0; j < DataSet.Length - (i + 1); j++)
				{
					if (comparer(DataSet[j], DataSet[j + 1]) > 0)
					{
						temp = DataSet[j + 1];
						DataSet[j + 1] = DataSet[j];
						DataSet[j] = temp;
					}
				}
			}
		}

		static void Main(string[] args)
		{
			// 오름차순 정렬
			int[] array = { 3, 7, 4, 2, 10 };
			Console.WriteLine("sorting ascending...");

			BubbleSort(array, new Compare(AscendCompare));
			foreach (var item in array)
				Console.Write($"{item} ");
			Console.WriteLine();

			// 내림차순 정렬
			int[] array2 = { 3, 7, 4, 2, 10 };
			Console.WriteLine("sorting descending...");


			BubbleSort(array2, new Compare(DescendCompare));
			foreach (var item in array2)
				Console.Write($"{item} ");
			Console.WriteLine();
		}
	}
}
