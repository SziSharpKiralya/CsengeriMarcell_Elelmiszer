namespace Elelmiszer
{
	internal class Program
	{

		static List<Etel> etterem = new List<Etel>();
		static List<Etel> dairyFreeList = new List<Etel>();

		static void Main(string[] args)
		{

			etterem.Add(new Kenyerfelek(78, 200, "tószt-kenyér"));
			etterem.Add(new Kenyerfelek(34, 400, "bagett"));
			etterem.Add(new Kenyerfelek(66, 420, "csömöri-kenyér"));
			etterem.Add(new Levesek(78, 200, "gulyás-leves"));
			etterem.Add(new Levesek(34, 400, "paradicsom-leves"));
			etterem.Add(new Levesek(66, 420, "hús-leves"));
			etterem.Add(new SultHusok(78, 200, "jó-hús"));
			etterem.Add(new SultHusok(34, 400, "rossz-hús"));
			etterem.Add(new SultHusok(66, 420, "zsíros-hús"));

			etterem[3].IsItDairyFree = true;
			etterem[6].IsItDairyFree = true;
			etterem[1].IsItDairyFree = true;

			Console.WriteLine(SumCalories());
            foreach (var etel in DairyFree())
            {
				Console.WriteLine(etel.Name);
			}
            
        }

		static List<Etel> DairyFree()
		{
            foreach (var etel in etterem)
            {
                if (etel.IsItDairyFree)
				{
					dairyFreeList.Add(etel);
				}
            }
			return dairyFreeList;
		}


		static double SumCalories()
		{
			double sum = 0;
            foreach (var etel in etterem)
            {
                sum += etel.CountCalories();	
            }
			return sum;
        }
	}
}
