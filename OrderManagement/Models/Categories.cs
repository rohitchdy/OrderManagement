using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
	public class Categories
	{
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
		public byte[] Picture { get; set; }

		public Categories(int CategoryID, string CategoryName, string Description, byte[] Picture)
		{
			this.CategoryID = CategoryID;
			this.CategoryName = CategoryName;
			this.Description = Description;
			this.Picture = Picture;
		}
	}
}
