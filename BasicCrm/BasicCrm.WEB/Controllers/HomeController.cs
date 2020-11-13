using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BasicCrm.WEB.Models;
using BasicCrm.Business.Abstract;
using BasicCrm.Business.Concrete;
using BasicCrm.DataAccess.Concrete.EntityFramework;

namespace BasicCrm.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ICustomerService _customerService;
        IAdminService _adminService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _customerService = new CustomerManager(new EfCustomerDal());
            _adminService = new AdminManager(new EfAdminDal());
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
