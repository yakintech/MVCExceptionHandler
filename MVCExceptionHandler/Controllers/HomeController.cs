using MVCExceptionHandler.Models.Attributes.ExceptionAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptionHandler.Controllers
{

    public class HomeController : Controller
    {

        //[HandleError(ExceptionType = typeof(IndexOutOfRangeException), View = "DatabaseError")]
       // [MyErrorHandle]
        public ActionResult Index()
        {
           // throw new Exception();
            
            return View();
        }

        public ActionResult DatabaseError()
        {
            return View();
        }
    }
}