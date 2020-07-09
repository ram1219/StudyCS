using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericEnumerable
{
	class MyList<T> : IEnumerable<T>, IEnumerator<T>
	{
		private T[] array;
		private int position = -1;

		public MyList()
		{
			array = new T[3];
		}

		public T this[int index]
		{
			get { return array[index]; }
			set
			{
				if(index >= array.Length)
				{
					Array.Resize<T>(ref array, index + 1);
					Console.WriteLine($"Array Resized : {array.Length}");
				}

				array[index] = value;
			}
		}

		public int Length 
		{ 
			get { return array.Length; } 
		}

		public T Current => throw new NotImplementedException();

		object IEnumerator.Current => throw new NotImplementedException();

		public IEnumerator<T> GetEnumerator()
		{
			for(int i=0;i<array.Length;i++)
				yield return array[i];
		}

		public IEnumerable<T> GetEnumerable()
		{
			for (int i = 0; i < array.Length; i++)
				yield return array[i];
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public bool MoveNext()
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}
	}
	class MainApp
	{
		static void Main(string[] args)
		{
			MyList<string> strList = new MyList<string>();
			strList[0] = "abc";
			strList[1] = "def";
			strList[2] = "ghi";
			strList[3] = "jkl";
			strList[4] = "mno";

			foreach (var item in strList)
			{
				Console.WriteLine($"'{item}'");
			}
			Console.WriteLine();
		}
	}
}
