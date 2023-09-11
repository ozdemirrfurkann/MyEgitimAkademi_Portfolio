using MyEgitimAkademi_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class UyarıBtnController : Controller
    {
        MyPortfolioDBEntities db = new MyPortfolioDBEntities();
        public ActionResult Index()
        {
            return View();
        }
        
       
    }
}