using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCApplication.Data;
using TestMVCApplication.Entities;
using TestMVCApplication.Models;

namespace TestMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerRepository _repository;        
        public HomeController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var customers = _repository.GetCustomers();
            return View(customers);
        }

        public ActionResult ViewOrders(string CustomerID)
        {
            ViewBag.Message = "Orders";

            var orders = _repository.GetCustomerOrders(CustomerID);

            return View(orders);
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Create New Customer.";

            return View();
        }

        [HttpPost]
        public ActionResult Create( CustomerViewModel model)
        {
            var custID = model.CustomerID;
            if (custID.Length != 5)
            {
                ModelState.AddModelError("CustomerID", "Customer ID should be of exactly five characters");
            }

            if (ModelState.IsValid)
            {
                //check if customer already exists
                var customerAlreadyExists = _repository.GetCustomerByCustomerID(custID);
                if (customerAlreadyExists == null)
                {
                    _repository.CreateCustomer(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("CustomerID", "Customer ID already exists.");
                }
            }           

            return View();
        }

        public ActionResult Angular()
        {
            return View();
        }
    }
}