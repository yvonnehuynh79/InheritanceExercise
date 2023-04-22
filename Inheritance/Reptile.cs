using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
			Age = 1;
			LegCount = 0;
			CanWalk = true;
			EatsFood = "insects";
		}
		public bool LaysEggs { get; set; }
		public bool IsColdBlooded { get; set; }
		public bool HasScales { get; set; }
		public bool HasMouth { get; set; }
	}
}

