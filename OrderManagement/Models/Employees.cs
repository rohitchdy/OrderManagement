using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
	public class Employees
	{
		public int EmployeeID { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Title { get; set; }
		public string TitleOfCourtesy { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime HireDate { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string HomePhone { get; set; }
		public string Extension { get; set; }
		public byte[] Photo { get; set; }
		public string Notes { get; set; }
		public int ReportsTo { get; set; }
		public string PhotoPath { get; set; }

		public Employees(int EmployeeID, string LastName, string FirstName, string Title, string TitleOfCourtesy, DateTime BirthDate, DateTime HireDate, string Address, string City, string Region, string PostalCode, string Country, string HomePhone, string Extension, byte[] Photo, string Notes, int ReportsTo, string PhotoPath)
		{
			this.EmployeeID = EmployeeID;
			this.LastName = LastName;
			this.FirstName = FirstName;
			this.Title = Title;
			this.TitleOfCourtesy = TitleOfCourtesy;
			this.BirthDate = BirthDate;
			this.HireDate = HireDate;
			this.Address = Address;
			this.City = City;
			this.Region = Region;
			this.PostalCode = PostalCode;
			this.Country = Country;
			this.HomePhone = HomePhone;
			this.Extension = Extension;
			this.Photo = Photo;
			this.Notes = Notes;
			this.ReportsTo = ReportsTo;
			this.PhotoPath = PhotoPath;
		}
	}
}
