using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzureIntegrator.Models;

namespace AzureIntegrator.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        public ActionResult Login()
        {
            var login = new Account() ;
            return View("~/Views/Account/Login/Login.cshtml");
        }
    }
}