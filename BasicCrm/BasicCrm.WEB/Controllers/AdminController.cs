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
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        IAdminService _adminService;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
            _adminService = InstanceFactory.GetInstance<IAdminService>();
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(Admin _admin)
        {
            var admin = _adminService.Get(_admin.AdminName, _admin.AdminPassword);
            if (admin != null)
            {
                HttpContext.Session.SetString("AdminName", admin.AdminName);
                return RedirectToAction("Customers", "Customer");
            }
            else
            {
                ViewBag.errorMessage = "AdminName or AdminPassword is wrong!";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminName");
            return RedirectToAction("AdminLogin", "Admin");
        }
    }
}
