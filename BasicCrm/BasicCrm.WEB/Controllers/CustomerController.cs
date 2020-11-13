using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCrm.Business.Abstract;
using BasicCrm.Business.Concrete;
using BasicCrm.Business.DependencyResolvers.NinjectDI;
using BasicCrm.DataAccess.Concrete.EntityFramework;
using BasicCrm.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BasicCrm.WEB.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        ICustomerService _customerService;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        public IActionResult Customers()
        {
            if (HttpContext.Session.GetString("AdminName") == null)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }

            var customers = _customerService.GetAll();
            return View(customers);
        }

        public IActionResult CustomerDetails(int id)
        {
            if (HttpContext.Session.GetString("AdminName") == null)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }

            var customer = _customerService.Get(id);
            return View(customer);
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            if (HttpContext.Session.GetString("AdminName") == null)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            if (HttpContext.Session.GetString("AdminName") == null)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }

            try
            {
                _customerService.Add(customer);
                TempData["Message"] = "Customer Added!";
            }
            catch (Exception exc)
            {
                string[] errorMessages = new string[] { "Customer Couldn't Add! - ", exc.Message.ToString() };
                TempData["ErrorMessages"] = errorMessages;
                return View();
            }

            return RedirectToAction("Customers", "Customer");
        }

        [HttpGet]
        public IActionResult EditCustomer(int id)
        {
            if (HttpContext.Session.GetString("AdminName") == null)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }

            var customer = _customerService.Get(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult EditCustomer(Customer customer)
        {
            if (HttpContext.Session.GetString("AdminName") == null)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }

            try
            {
                _customerService.Update(customer);
                TempData["Message"] = "Customer Edited!";
            }
            catch (Exception exc)
            {
                string[] errorMessages = new string[] { "Customer Couldn't Edit! - ", exc.Message.ToString() };
                TempData["ErrorMessages"] =  errorMessages;
                return View();
            }

            return RedirectToAction("Customers", "Customer");
        }

        public IActionResult DeleteCustomer(Customer customer)
        {
            if (HttpContext.Session.GetString("AdminName") == null)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }

            try
            {
                _customerService.Delete(customer);
                TempData["Message"] = "Customer Deleted!";
            }
            catch (Exception exc)
            {
                string[] errorMessages = new string[] { "Customer Couldn't Edit! - ", exc.Message.ToString() };
                TempData["ErrorMessages"] = errorMessages;
            }

            return RedirectToAction("Customers", "Customer");
        }
    }
}
