using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
	delegate int Compare(int a, int b);

	class MainApp
	{
		static void BubbleSort(int[] dataSet, Compare Comparer)
		{
			int temp = 0;

			for(int i = 0; i < dataSet.Length - 1; i++)
			{
				for(int j = 0; j < dataSet.Length - (i + 1); j++)
				{
					if(Comparer(dataSet[j], dataSet[j + 1]) > 0)
					{
						temp = dataSet[j + 1];
						dataSet[j + 1] = dataSet[j];
						dataSet[j] = temp;
					}
				}
			}
		}

		static void Main(string[] args)
		{
			int[] array = { 3, 7, 4, 2, 10 };

			Console.WriteLine("Sorting ascending...");
			BubbleSort(array, delegate (int a, int b){
				 if (a > b) return 1;
				 else if (a == b) return 0;
				 else return -1;
			 });

			foreach (var item in array)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
		}
	}
}
