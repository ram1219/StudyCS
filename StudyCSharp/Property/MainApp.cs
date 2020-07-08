using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
	class BirthdatInfo
	{
		private string name;
		private DateTime birthday;

		/*
		// 이전 방식
		public void SetName(string name) { this.name = name; }
		public string GetName() { return this.name; }
		public void SetBirthday(DateTime birth) { this.birthday = birth; }
		public DateTime GetBirthday() { return this.birthday; }
		*/

		/*
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		*/

		// 위와 같이 논리적인 로직이 따로 없다면 아래와 같이 사용할 수 있다.
		public string Name { get; set; } 

		public DateTime Birthday
		{
			get { return birthday; }
			set 
			{ 
				if(value.Year >= DateTime.Now.Year) { birthday = DateTime.Now; }
				else { birthday = value; }
			}
		}

		public int Age
		{
			get { return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year; }
		}
	}
	class MainApp
	{
		static void Main(string[] args)
		{
			BirthdatInfo info = new BirthdatInfo();

			/*
			// 이전 방식
			info.SetName("김가람");
			info.SetBirthday(new DateTime(1996, 12, 19));

			Console.WriteLine($"{info.GetName()}, {info.GetBirthday()}");
			*/

			info.Name = "김가람";
			info.Birthday = new DateTime(1996, 12, 19);

			Console.WriteLine($"{info.Name},{info.Birthday.ToShortDateString()}");
			Console.WriteLine($"Age : {info.Age}세");
		}
	}
}
