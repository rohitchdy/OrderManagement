using Microsoft.AspNetCore.Mvc;
using OrderManagement.DataAccess;
using OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Controllers
{
    public class CustomerController : Controller
        
    {
       public OrderContext dbContext = new OrderContext();

        public IActionResult Question1()
        {
            var results = from c in dbContext.customers
                          let allProducts = from p in dbContext.products.Where(p => p.UnitPrice < 5) select p.ProductID
                          where !allProducts.Except(from o in dbContext.orders from d in dbContext.orderDetails select d.ProductID).Any()
                          select c.CompanyName;
            return Ok(results);
        }

        public IActionResult Question2()
        {
            var results = from p in dbContext.products
                          let allEmployees = from e in dbContext.employees select e.EmployeeID
                          where !allEmployees.Except(
                          from od in dbContext.orderDetails
                          join o in dbContext.orders on od.OrderID equals o.OrderID
                          join e in dbContext.employees on o.EmployeeID equals e.EmployeeID
                          select e.EmployeeID).Any()
                          select p.ProductName;
            return Ok(results);
        }

        public IActionResult Question3()
        {
            var results = from p in dbContext.products
                          group p by p.CategoryID into g
                          select new { g.Key, AveragePrice = g.Average(c => c.UnitPrice) };
            return Ok(results);
        }

        public IActionResult Question4()
        {
            var results = from e in dbContext.employees
                          where e.HireDate < (from e1 in dbContext.employees.Where(e1 => e1.City == "London")
                                              select e1.HireDate).Min()
                          select new { e.FirstName, e.LastName };
            return Ok(results);
        }

        public IActionResult Question5()
        {
            var results = (from e in dbContext.employees.Where(e => e.City == "London")
                           from o in dbContext.orders
                           from od in dbContext.orderDetails
                           join p in dbContext.products on od.ProductID equals p.ProductID
                           select new { p.ProductName }).Union((from c in dbContext.customers.Where(c => c.City == "London")
                                                                from o in dbContext.orders
                                                                from od in dbContext.orderDetails
                                                                join p in dbContext.products on od.ProductID equals p.ProductID
                                                                select new { p.ProductName }).Distinct());
            return Ok(results);
        }
    }
}
