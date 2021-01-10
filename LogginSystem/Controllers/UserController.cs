using LogginSystem.Data;
using LogginSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogginSystem.Controllers
{
    public class UserController: Controller
    {

        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            
            return View();
        }

        /// <summary>
        /// Post-create
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        /// <summary>
        /// Post-Loggin
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Loggin(User obj)
        {
            IEnumerable<User> objList = _db.Users;
            bool Correct = false;
            foreach (var item in objList)
            {
                if (item.Email == obj.Email && item.Password == obj.Password)
                {
                    Correct = true;
                    break;
                }

            }
            if (Correct)
            {
                return RedirectToAction("UserProfile");
            }
            else 
            {
                return RedirectToAction("Index");
            }
            

        }
        public IActionResult UserProfile()
        {
            IEnumerable<ContactForm> objList = _db.ContactForms;
            return View(objList);

        }

       
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ContactForms.Find(id);
            
            _db.ContactForms.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("UserProfile");

        }

    }
}
