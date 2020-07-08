using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
	// 추상 클래스
	// 인스턴스를 가질 수 없다.(구현(메소드)만 가진다)
	// 자식 추상 클래스에서 부모 추상 메소드의 구현을 할 필요는 없다.
	// 기본 접근 한정자는 private이다.
	abstract class AbstractBase
	{
		protected void PrivateMethodA()
		{
			Console.WriteLine("AbstractBase.PrivateMethodA()");
		}

		public void PublicMethodA()
		{
			Console.WriteLine("AbstractBase.PublicMethodA()");
		}

		public abstract void AbstractMethodA();
	}

	class Derived : AbstractBase
	{
		// 추상 메서드를 상속할 때는 override를 무조건 사용하여야 한다.
		public override void AbstractMethodA()
		{
			Console.WriteLine("Derived.AbstractMethodA()");
			PrivateMethodA();
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			// AbstractBase는 추상클래스이므로 new로 사용할 수 없다.
			// 위의 클래스를 상속받은 Derived 클래스를 사용한다.
			AbstractBase obj = new Derived();
			obj.AbstractMethodA();
			obj.PublicMethodA();
		}
	}
}
