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
			// 자식 클래스를 부모 클래스로 형식으로 생성한다.
			Mammal mammal = new Dog();
			Dog dog;

			// is -> 형변환이 가능할 경우 true, 불가능할 경우 false를 반환
			if(mammal is Dog)
			{
				// 클래스의 캐스팅(형변환)을 as를 사용하여 한다.
				// Dog는 Mammal을 상속받은 자식 클래스이다.
				// mammal as Dog는 (Dog)mammal 과 같은 의미이지만 (Dog)mammal로 사용할 경우 에러가 날 수 있다.
				dog = mammal as Dog;                    
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
