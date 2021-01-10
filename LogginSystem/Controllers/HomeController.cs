using LogginSystem.Data;
using LogginSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LogginSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
    
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
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
        /// <summary>
        /// Post-create
        /// </summary>
        /// <returns></returns>
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ContactForm obj)
        {
                if (ModelState.IsValid)
                {
                    _db.ContactForms.Add(obj);
                    _db.SaveChanges();

                }
                return RedirectToAction("Index");
            
           
        }
    }
}
