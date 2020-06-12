using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;   

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult print(int a,int b, int c)
        {
            var Disc = new Discriminant() { a = a, b = b, c = c };

            ViewBag.gang = "gang";

            if(Disc.answer == 2)
            {
                ViewBag.Warning= "am gantolebas aqvs 2 amonaxsni";
            }
            else if(Disc.answer == 1)
            {
                ViewBag.Warning = "am gantolebas aqvs 1 amonaxsni";
            }
            else if(Disc.answer == 0)
            {
                ViewBag.Warning = "am gantolebas aqvs 0 amonaxsni";
            }

            return View(Disc);
        }

        
    }
   
  
}
