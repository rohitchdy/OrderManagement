using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
	public class Region
	{
		public int RegionID { get; set; }
		public string RegionDescription { get; set; }

		public Region(int RegionID, string RegionDescription)
		{
			this.RegionID = RegionID;
			this.RegionDescription = RegionDescription;
		}
	}
}
