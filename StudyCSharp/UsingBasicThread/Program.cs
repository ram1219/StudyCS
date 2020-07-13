using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingBasicThread
{
	class Program
	{
		static void DoSomething()
		{
			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine($"DoSomething : {i}");
				Thread.Sleep(1000);
			}
		}

		static void Main(string[] args)
		{
			Thread thread = new Thread(new ThreadStart(DoSomething));

			Console.WriteLine("Starting thread...");
			thread.Start();			// 스레드 시작(DoSomething 호출)

			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine($"Main : {i}");
				Thread.Sleep(500);
			}

			Console.WriteLine("Waiting until thread stop...");
			thread.Join();

			Console.WriteLine("Finished");
		}
	}
}
