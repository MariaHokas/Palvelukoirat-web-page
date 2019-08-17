using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Palvelukoira.Controllers
{
    public class PalvelukoiratController : Controller
    {
        // GET: Palvelukoirat
        public ActionResult Index()
        {
            return View();
        }
    }
}