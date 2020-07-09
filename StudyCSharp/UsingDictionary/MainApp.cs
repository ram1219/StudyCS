using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDictionary
{
	class MainApp
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> dic = new Dictionary<string, int>();

			dic["하나"] = 100;
			dic["둘"] = 200;
			dic["셋"] = 300;
			dic["넷"] = 400;
			dic["다섯"] = 500;

			foreach (var item in dic)
			{
				Console.WriteLine(item);
			}
		}
	}
}
