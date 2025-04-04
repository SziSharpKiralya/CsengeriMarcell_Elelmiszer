using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elelmiszer
{
	internal class Kenyerfelek : Etel
	{
		public Kenyerfelek(double caloriesPerDkg, double weight, string name) : base(caloriesPerDkg, weight, name)
		{
		}

		public override double CountCalories()
		{
			return (CaloriesPerDkg * Weight) / 100;
		}
	}
}
