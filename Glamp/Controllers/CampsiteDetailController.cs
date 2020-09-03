using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Glamp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Glamp.Controllers
{
    public class CampsiteDetailController : Controller
    {
        public ActionResult Index(string campId, string contractID)
        {

            var client = new HttpClient();
            var quote = new CampsiteDetailRepository(client);

            CampsiteDetail campsites = quote.GetCamperDetail(campId, contractID);

            return View(campsites);
        }
    }
}
