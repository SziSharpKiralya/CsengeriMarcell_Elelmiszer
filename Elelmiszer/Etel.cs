using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elelmiszer
{
	internal abstract class Etel
	{
		double caloriesPerDkg;
		double weight;
		string name;

		private bool isItDairyFree;

		protected Etel(double caloriesPerDkg, double weight, string name)
		{
			this.caloriesPerDkg = caloriesPerDkg;
			this.weight = weight;
			this.name = name;
			IsItDairyFree = false;
		}

		public double CaloriesPerDkg { get => caloriesPerDkg; }
		public double Weight { get => weight; }
		public string Name { get => name; }

		public bool IsItDairyFree { get => isItDairyFree; set => isItDairyFree = value; }

		public abstract double CountCalories();
	}
}
