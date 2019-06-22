using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(){
                ID = 1, Name = "Ankita", Department ="IT"});
            new Employee(){
                 ID = 2, Name = "Anisha", Department ="IT"};
            new Employee(){
                 ID = 3, Name = "Bhagyashree", Department ="IT"};
            new Employee(){
                 ID = 4, Name = "Bhaveshawari", Department ="IT"};

            ViewBag.Message = empList;

            ViewData["Message"] = empList;

            TempData["Message"] = "Hello world";
            TempData.Keep();
            return View();
            }
            

        public ActionResult SecondPage()
        {
            return View();
        }

            //List<string> myList = new List<string>();
            //myList.Add("Ankita");
            //myList.Add("Anisha");
            //myList.Add("Bhagyashree");
            //myList.Add("Bhaveshawari");

            //ViewBag.NameList = myList;
            
        }
	}
