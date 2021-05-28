using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
	public class Products
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public int SupplierID { get; set; }
		public int CategoryID { get; set; }
		public string QuantityPerUnit { get; set; }
		public decimal UnitPrice { get; set; }
		public short UnitsInStock { get; set; }
		public short UnitsOnOrder { get; set; }
		public short ReorderLevel { get; set; }
		public bool Discontinued { get; set; }

		public Products(int ProductID, string ProductName, int SupplierID, int CategoryID, string QuantityPerUnit, decimal UnitPrice, short UnitsInStock, short UnitsOnOrder, short ReorderLevel, bool Discontinued)
		{
			this.ProductID = ProductID;
			this.ProductName = ProductName;
			this.SupplierID = SupplierID;
			this.CategoryID = CategoryID;
			this.QuantityPerUnit = QuantityPerUnit;
			this.UnitPrice = UnitPrice;
			this.UnitsInStock = UnitsInStock;
			this.UnitsOnOrder = UnitsOnOrder;
			this.ReorderLevel = ReorderLevel;
			this.Discontinued = Discontinued;
		}
	}
}
