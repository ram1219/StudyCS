using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericList
{
	class MainApp
	{
		static void Main(string[] args)
		{
			/*
			List<int> list = new List<int>();
			for (int i = 0; i < 5; i++)
				list.Add(i);

			foreach (var item in list) { Console.Write($"{item} "); }
			Console.WriteLine();

			list.RemoveAt(2);

			foreach (var item in list){ Console.Write($"{item} "); }
			Console.WriteLine();

			list.Insert(2, 2);

			foreach (var item in list) { Console.Write($"{item} "); }
			Console.WriteLine();
			*/

			// 큐 형식의 리스트 -> FIFO(First In First Out)
			Queue<double> q = new Queue<double>();

			// Enqueue -> In
			q.Enqueue(11.1);
			q.Enqueue(22.2);
			q.Enqueue(33.3);
			q.Enqueue(44.4);

			while (q.Count > 0)
			{
				// Dequeue -> Out
				Console.WriteLine(q.Dequeue());
			}
			Console.WriteLine();

			// 스택 형식의 리스트 -> LIFO(Last In First Out)
			Stack<int> s = new Stack<int>();

			s.Push(1);
			s.Push(2);
			s.Push(3);
			s.Push(4);

			while(s.Count > 0)
			{
				Console.WriteLine(s.Pop());
			}
		}
	}
}
