using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
	class Cat
	{
		public string Name;
		public Color Color;							// Color 구조체 사용.

		public Cat()
		{
			Name = "";
			Color = Color.Transparent;
		}

		/// <summary>
		/// 파라미터 생성자
		/// </summary>
		/// <param name="name">고양이 이름</param>
		/// <param name="color">고양이 털색</param>
		public Cat(string name, Color color)
		{
			Name = name;
			Color = color;
		}

		public void Meow()
		{
			Console.WriteLine($"{Name}, 야옹~!");
		}
	}
	class MainApp
	{
		static void Main(string[] args)
		{
			// 기본 생성자를 사용한 인스턴스화
			Cat kitty = new Cat();                  // 인스턴스 화
			kitty.Name = "키티";
			kitty.Color = Color.White;
			kitty.Meow();
			Console.WriteLine($"{kitty.Name} : {kitty.Color}");

			// 파라미터 생성자를 사용한 인스턴스화
			Cat nero = new Cat("네로", Color.Black);
			nero.Meow();
			Console.WriteLine($"{nero.Name} : {nero.Color}");
		}
	}
}
