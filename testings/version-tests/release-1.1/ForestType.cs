//  Copyright 2005 University of Wisconsin-Madison
//  Authors:  Jimm Domingo
//  License:  Available at  
//  http://landis.forest.wisc.edu/developers/LANDIS-IISourceCodeLicenseAgreement.pdf

namespace Landis.Output.Reclass
{
	/// <summary>
	/// A forest type.
	/// </summary>
	public class ForestType
		: IForestType
	{
		private string name;
		private int[] multipliers;

		//---------------------------------------------------------------------

		/// <summary>
		/// Name
		/// </summary>
		public string Name
		{
			get {
				return name;
			}
		}

		//---------------------------------------------------------------------

		/// <summary>
		/// Multiplier for a species
		/// </summary>
		public int this[int speciesIndex]
		{
			get {
				return multipliers[speciesIndex];
			}
		}

		//---------------------------------------------------------------------

		public ForestType(string name,
		                  int[]  multipliers)
		{
			this.name = name;
			this.multipliers = multipliers;
		}
	}
}
