using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExMember
{
	class FriendList
	{
		private List<string> list = new List<string>();

		public void Add(string name) => list.Add(name);
		public void Remove(string name) => list.Remove(name);
		public void PrintAll()
		{
			foreach (var item in list)
				Console.WriteLine(item);
		}

		public FriendList() => Console.WriteLine("FriendList()");
	}

	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
