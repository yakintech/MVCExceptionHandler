using MVCExceptionHandler.Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptionHandler.Models.Attributes.ExceptionAttributes
{
    public class MyErrorHandle : HandleErrorAttribute, IExceptionFilter
    {


        
        public override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;

            var exMessage = filterContext.Exception.Message;
            var controllerName = filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];
            var message = String.Format("Message:{0} controller:{1} action:{2}", exMessage, controllerName, actionName);



            filterContext.ExceptionHandled = true;


            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Error/Index.cshtml"
            };
        }
    }
}