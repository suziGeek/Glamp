using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Glamp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Glamp.Controllers
{
    public class CampgroundsController : Controller
    {
        public IActionResult Index(string selectState, string selectActivity)
        {
            var client = new HttpClient();
            var quote = new CampgroundsRepository(client);    
            var campground = quote.GetCampgrounds(selectState, selectActivity);

            return View(campground);
        }

    }
}
