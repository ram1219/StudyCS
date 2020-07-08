using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCasting
{
	class Mammal
	{
		public void Nurse()
		{
			Console.WriteLine("Nurse()");
		}
	}

	class Dog : Mammal
	{
		public void Bark()
		{
			Console.WriteLine("Bark()");
		}
	}

	class Cat : Mammal
	{
		public void Meow()
		{
			Console.WriteLine("Meow()");
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			Mammal mammal = new Dog();
			Dog dog;

			if(mammal is Dog)
			{
				dog = mammal as Dog;                    // 클래스 사이의 형 변환은 as를 쓰는 것이 낫다
				dog.Bark();
			}

			Mammal mammal2 = new Cat();

			Cat cat = mammal as Cat;
			if (cat != null) cat.Meow();

			Cat cat2 = mammal as Cat;
			if (cat2 != null) cat2.Meow();
			else Console.WriteLine("cat2 is not a Cat");
		}
	}
}
