using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
	class MainApp
	{
		class Global
		{
			public static int Count = 0;
		}

		class ClassA
		{
			// 생성자
			public ClassA()
			{
				Global.Count++;
			}
		}

		class ClassB
		{
			public ClassB()
			{
				Global.Count++;
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine($"Global.Count : {Global.Count}");

			new ClassA();
			new ClassB();
			new ClassA();
			new ClassB();

			Console.WriteLine($"Global.Count : {Global.Count}");
		}
	}
}
