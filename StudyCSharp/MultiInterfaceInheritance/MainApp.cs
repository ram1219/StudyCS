using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInterfaceInheritance
{
	interface IRunnable
	{
		void Run();
	}

	interface IFlyable
	{
		void Fly();
	}

	public class Vehicle
	{
		public string Year;
		public string Company;
		public float HorsePower;
	}
	
	// Vehicle, IRunnable, IFlyable을 다중 상속받는 FlyingCar 클래스
	class FlyingCar : Vehicle, IRunnable, IFlyable
	{
		public void Run()
		{
			Console.WriteLine("Run! Run!");
		}

		public void Fly()
		{
			Console.WriteLine("Fly! Fly!");
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			// 다중 상속받은 클래스
			FlyingCar car = new FlyingCar();
			car.Run();
			car.Fly();
			car.Company = "현대";

			// 부모 인터페이스 
			// 부모연산자인 IRunnable에 as 연산자를 사용하여 자식 클래스인 car에 캐스팅 하였다.
			IRunnable runnable = car as IRunnable;
			runnable.Run();

			IFlyable flyable = car as IFlyable;
			flyable.Fly();
		}
	}
}
