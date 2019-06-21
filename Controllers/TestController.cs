using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            List<string> myList = new List<string>();
            myList.Add("Ankita");
            myList.Add("Anisha");
            myList.Add("Bhagyashree");
            myList.Add("Bhaveshawari");

            ViewBag.NameList = myList;
            return View();
        }
	}
}