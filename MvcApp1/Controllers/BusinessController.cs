using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp1.Controllers
{
    public class BusinessController : Controller
    {
        //
        // GET: /Business/

        public ActionResult Index()
        {
            return RedirectToAction("School"); 
        }

        // GET: /Business/Retail
        public ActionResult Retail()
        {
            ViewBag.Title = "Retail";
            ViewBag.Message = "This page is under construction"; 
            return View(); 
        }

        // GET: /Business/RealEstate
        public ActionResult RealEstate()
        {
            ViewBag.Title = "RealEstate";
            ViewBag.Message = "This page is under construction"; 
            return View();
        }

        // GET: /Business/Technology
        public ActionResult Technology()
        {
            ViewBag.Title = "Technology";
            ViewBag.Message = "This page is under construction"; 
            return View();
        }

        // GET: /Business/Personal
        public ActionResult Personal()
        {
            ViewBag.Title = "Personal";
            ViewBag.Message = "This page is under construction"; 
            return View();
        }

        // GET: /Business/Personal
        public ActionResult School()
        {
            ViewBag.Title = "Free School Website";
            ViewBag.Message = "This page is under construction";
            return View();
        }

    }
}
