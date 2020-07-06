using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
	class enumApp
	{
		class Program
		{
			// enum은 상수이므로 대문자로 사용(공식 룰)
			enum DialogResult
			{
				YES,				// 따로 숫자를 지정하지 않을 경우 처음부터 차례대로 0
				NO,					// 1
				CANCEL,				// 2
				CONFIRM,			// 3
				OK					// 4
			}

			static void Main(string[] args)
			{
				Console.WriteLine(DialogResult.OK);
				Console.WriteLine((int)DialogResult.OK);

				DialogResult result = DialogResult.YES;

				if (result == DialogResult.YES)
					Console.WriteLine("YES를 선택했습니다.");
			}
		}
	}
}
