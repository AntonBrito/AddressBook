using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AddressBook.Controllers
{
    public class AddressController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //return View();
            string todaysDate = DateTime.Now.ToShortDateString();
            return Ok(todaysDate);
        }
    }
}
