using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	// 부모 클래스
	class Parent
	{
		protected string Name { get; set; }

		public Parent(string name)
		{
			Name = name;
			Console.WriteLine($"{Name}.Base()");
		}

		public void BaseMethod()
		{
			Console.WriteLine($"{Name}.BaseMethod()");
		}
	}

	// 자식 클래스
	class Child : Parent
	{
		public Child(string name) : base(name)
		{
			Console.WriteLine($"{this.Name}.Child()");
		}

		public void DeriveMethod()
		{
			base.BaseMethod();
			Console.WriteLine($"{Name}.DeriveMethod()");
		}
	}
	class MainApp
	{
		static void Main(string[] args)
		{
			Parent p = new Parent("p");
			p.BaseMethod();
			Child c = new Child("c");
			c.BaseMethod();

			Console.WriteLine("-----------------------------------");
			c.DeriveMethod();
		}
	}
}
