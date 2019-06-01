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
        public List<Customer> customers = new List<Customer>()
        {
            new Customer(){Id = 1, Name = "Alfred"},
            new Customer(){Id = 2, Name = "Steven"},
            new Customer(){Id=3,Name="Becky"}
        };

        // GET: Customers
        public ActionResult Index()
        {

            var viewModel = new CustomersViewModel()
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (customers.Find(x => x.Id == id) != null)
            {
                var customer = customers.Find(x => x.Id == id);

                return View(customer);
            }

            return HttpNotFound();
        }
    }
}