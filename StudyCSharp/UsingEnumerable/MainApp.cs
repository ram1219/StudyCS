using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingEnumerable
{
	class MyList : IEnumerable, IEnumerator
	{
		private int[] array;
		int position = -1;

		public MyList()
		{
			array = new int[3];
		}

		public int this[int index]
		{
			get { return array[index]; }
			set
			{
				if (index >= array.Length)
				{
					// 배열의 사이즈를 늘인다.
					// ref로 배열의 주소값을 가져오고, +1만큼 늘인다
					Array.Resize(ref array, index + 1);
					Console.WriteLine($"Array Resized : {array.Length}");
				}
				array[index] = value;
			}
		}

		public object Current
		{
			get { return array[position]; }
		}

		public bool MoveNext()
		{
			if (position == array.Length - 1)
			{
				Reset();
				return false;
			}

			position++;
			return true;
		}

		public void Reset()
		{
			position = -1;
		}

		public IEnumerator GetEnumerator()
		{
			for (int i = 0; i < array.Length; i++)
				yield return (array[i]);
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			MyList list = new MyList();
			for (int i = 0; i < 5; i++)
				list[i] = i;

			foreach (int e in list)
				Console.WriteLine(e);
		}
	}
}
