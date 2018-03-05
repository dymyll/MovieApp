using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/


        // 
        // GET: /HelloWorld/Welcome/ 
    /* 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    */
        public string MyRandom()
        {
            Random myrand = new Random();
            return "The Random Number is " + myrand.Next();
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }        
}