using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mvcshubham.Models;


namespace Mvcshubham.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext DbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }
        public IActionResult Index()

        {
            List<Location> locations = DbContext.Locations.ToList();
            return View(locations);
        }
        public IActionResult CustmerList()

        {
            List<Customer> customers = DbContext.Customers.ToList();
            return View(customers);
        }
    }
}
