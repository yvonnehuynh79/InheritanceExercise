using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
			Age = 2;
			LegCount = 2;
			CanWalk = true;
			EatsFood = "worms";
		}
		public bool CanFly { get; set; }
		public bool CanSing { get; set; }
		public bool HasBeak { get; set; }
		public int HasTwoLegs { get; set; }
	}
}

