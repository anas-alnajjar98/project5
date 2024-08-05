using Newtonsoft.Json;
using Project_5_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_5_.Controllers
{

    public class AdminController : Controller
    {
        private electionEntities DB = new electionEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddDate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDate([Bind(Include = "startDateNominate,EndDateNominate,startDateOfElection,EndDateOfElection")] DATE date)
        {
            if (ModelState.IsValid)
            {
                DB.DATES.Add(date);
                DB.SaveChanges();

            }
            return View();

        }
        public ActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginAdmin(string Email, string Password)
        {
            var user = DB.Admins.FirstOrDefault(u => u.Email == Email);
            if (user != null)
            {
                if (user.PasswordHash == Password)
                {
                    TempData["LoggedUser"] = JsonConvert.SerializeObject(user);
                    return RedirectToAction("AddDate", new { id = user.AdminID });
                }
            }

            ViewBag.Message = "Invalid login attempt.";
            return View();
        }
    }
}