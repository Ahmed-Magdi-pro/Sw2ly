using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fast_Market.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult cart()
        {
            return View();
        }

        public IActionResult details()
        {
            return View();
        }

        public IActionResult slideBar()
        {
            return View();
        }
        public IActionResult wishList()
        {
            return View();
        }
    }
}
