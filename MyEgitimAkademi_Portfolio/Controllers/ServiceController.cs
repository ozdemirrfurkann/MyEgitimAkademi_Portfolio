using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ServiceController : Controller
    {
        MyPortfolioDBEntities db = new MyPortfolioDBEntities();

        [Authorize]
        public ActionResult Index()
        {
            var values=db.Service.ToList();
            return View(values);
        }
        public ActionResult AddService()
        {
            return View();
        }
    }
}