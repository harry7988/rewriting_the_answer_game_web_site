using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AQWithWebAPI.Models;

namespace AQWithWebAPI.Controllers
{
    public class ADController : Controller
    {
        Model1 db = new Model1();
        // GET: AD
        public ActionResult Index()
        {
            @ViewBag.activetab = "1-1";
            return View();
        }

    }
}