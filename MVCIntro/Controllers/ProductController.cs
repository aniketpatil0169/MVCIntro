using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
  
    [RoutePrefix("product")]
    public class ProductController : Controller
    {
        // http://localhost/product
        [Route("")]
        public string GetProducts()
        {
            //return "All list of products";
            return "<h2>All Product </h2>No Product Available";
        }

        public EmptyResult Index()
        { 
            //All code will go here

            return new EmptyResult();
        }

        public ContentResult Index1() 
        {
            return Content ("Hello");
        }
        public ContentResult Index2()
        {
            return Content("<h2>Index 2 Page</h2>","text/html");
        }

        public RedirectResult Index3() 
        {
            return Redirect("http://www.google.com");
        }

        public JsonResult Index4() 
        {
            string json = "{'Id' : 10, 'Name' : Aniket, 'City' : Satara'}";
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}