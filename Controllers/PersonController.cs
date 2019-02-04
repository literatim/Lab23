﻿using System.Linq;
using System.Web.Mvc;
using Lab21.DAL;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonContext _context = new PersonContext();
        // GET: Person

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Person newPerson)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMessage = "The information you entered is not valid.";
                return View();
            }

            _context.Person.Add(newPerson);
            _context.SaveChanges();
            return RedirectToAction("RegistrationSuccess");
        }

        public ActionResult RegistrationSuccess()
        {
            var user = _context.Person.Max(p => p.FirstName);
            ViewBag.Message = user;
            return View();
        }
    }
}