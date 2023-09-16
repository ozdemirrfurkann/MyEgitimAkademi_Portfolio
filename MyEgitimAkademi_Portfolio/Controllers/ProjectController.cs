using MyEgitimAkademi_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        MyPortfolioDBEntities db = new MyPortfolioDBEntities();
        // GET: Project
        public ActionResult Index()
        {
            var values = db.Project.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProject(Project project)
        {
            db.Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProject(int id)
        {
            var value = db.Project.Find(id);
            db.Project.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = db.Project.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProject(Project project)
        {
            var value = db.Project.Find(project.ProjectID);
            value.Title = project.Title;
            value.Description = project.Description;
            value.CompleteDay = project.CompleteDay;
            value.Price = project.Price;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}