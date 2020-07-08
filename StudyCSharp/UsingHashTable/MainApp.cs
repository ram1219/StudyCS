using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingHashTable
{
	class MainApp
	{
		static void Main(string[] args)
		{
			Hashtable ht = new Hashtable();
			ht["이름"] = "김가람";
			ht["주소"] = "부산광역시 남구";
			ht["전화번호"] = "010-9291-4413";
			ht["키"] = "166.7cm";
			ht["결혼여부"] = false;

			Console.WriteLine($"{ht["키"]}");
		}
	}
}
