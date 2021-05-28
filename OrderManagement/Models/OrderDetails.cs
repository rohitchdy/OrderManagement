using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
	public class OrderDetails
	{
		public int OrderID { get; set; }
		public int ProductID { get; set; }
		public decimal UnitPrice { get; set; }
		public short Quantity { get; set; }
		public Single Discount { get; set; }

		public OrderDetails(int OrderID, int ProductID, decimal UnitPrice, short Quantity, Single Discount)
		{
			this.OrderID = OrderID;
			this.ProductID = ProductID;
			this.UnitPrice = UnitPrice;
			this.Quantity = Quantity;
			this.Discount = Discount;
		}
	}
}
