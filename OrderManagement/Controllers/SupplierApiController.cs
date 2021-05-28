using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Controllers
{
    [Route("api/[controller]")]
    public class SupplierApiController : Controller
    {
        public OrderContext dbContext = new OrderContext();
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            int count = (from row in dbContext.suppliers
                         select row).Count();
            return Ok(count);
        }

        [HttpGet]
        [Route("GetAllSupplier")]
        public IActionResult GetAllSupplier()
        {
            var results = (from row in dbContext.suppliers
                           select row);
            return Ok(results);
        }

        // GET: SupplierApiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SupplierApiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupplierApiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierApiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SupplierApiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierApiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupplierApiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
