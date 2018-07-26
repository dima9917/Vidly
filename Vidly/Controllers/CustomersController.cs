using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Movies

        IEnumerable<Customer> customers = new List<Customer>
            {
                new Customer {Name = "John Smith", Id = 1},
                new Customer {Name = "Mary Williams", Id = 2}
            };

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            return View(customers);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Details(int Id)
        {
            if (customers.Count(x => x.Id == Id) > 0)
            {
                return View(customers.Single(x => x.Id == Id));
            }
            else
                return HttpNotFound();
        }
    }
}