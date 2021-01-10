using LogginSystem.Data;
using LogginSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogginSystem.Controllers
{
    public class ContactFormController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ContactFormController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
           
                IEnumerable<ContactForm> objList = _db.ContactForms;
                return View(objList);
            
        }
    }
}
