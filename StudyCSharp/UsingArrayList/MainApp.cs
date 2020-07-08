using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArrayList
{
	class MainApp
	{
		static void Main(string[] args)
		{
			ArrayList list = new ArrayList();
			for (int i = 0; i < 10; i++)
				// 리스트의 제일 마지막에 데이터 삽입
				list.Add(i);

			foreach (var item in list)
				Console.Write($"{item}, ");
			Console.WriteLine();

			// 리스트의 2번째 위치(인덱스 위치)의 데이터 삭제
			list.RemoveAt(2);
			foreach (var item in list)
				Console.Write($"{item}, ");
			Console.WriteLine();

			// 리스트의 5번째 위치에 데이터 4 삽입
			list.Insert(5, 4);
			foreach (var item in list)
				Console.Write($"{item}, ");
			Console.WriteLine();

			// 리스트 전체 삭제
			list.Clear();
			foreach (var item in list)
				Console.Write($"{item}, ");
			Console.WriteLine();
		}
	}
}
