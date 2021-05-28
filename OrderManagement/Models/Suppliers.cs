using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
	public class Suppliers
	{
		public int SupplierID { get; set; }
		public string CompanyName { get; set; }
		public string ContactName { get; set; }
		public string ContactTitle { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string HomePage { get; set; }

		public Suppliers(int SupplierID, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax, string HomePage)
		{
			this.SupplierID = SupplierID;
			this.CompanyName = CompanyName;
			this.ContactName = ContactName;
			this.ContactTitle = ContactTitle;
			this.Address = Address;
			this.City = City;
			this.Region = Region;
			this.PostalCode = PostalCode;
			this.Country = Country;
			this.Phone = Phone;
			this.Fax = Fax;
			this.HomePage = HomePage;
		}
	}
}
