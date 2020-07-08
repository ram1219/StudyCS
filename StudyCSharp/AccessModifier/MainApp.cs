using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AccessModifier
{
	class WaterHeater
	{
		protected int temperature;

		// temperature은 protected로 수식되어 외부에서 직접적으로 접근할 수 없다.
		// 아래와 같이 temperture에 접근할 메소드를 public으로 생성한다.
		public void SetTemperature(int temperature)
		{
			if(temperature < -5 || temperature > 42)
			{
				throw new Exception("Out of temperature range");
			}

			this.temperature = temperature;
		}

		// internal 접근 지겅자 -> 같은 어셈블리에 있는 코드에서만 public으로 접근 가능.
		// 다른 어셈블리에서는 private와 같은 수준의 접근성을 가짐.
		internal void TurnOnWater()
		{
			Console.WriteLine($"Turn On water : {temperature}");
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			try
			{
				WaterHeater heater = new WaterHeater();
				heater.SetTemperature(20);
				heater.TurnOnWater();

				heater.SetTemperature(-2);
				heater.TurnOnWater();

				heater.SetTemperature(50);
				heater.TurnOnWater();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
