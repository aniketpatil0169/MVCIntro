using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        public string Welcome()
        {
            return "My First MVC Application";
        }

        public string GetResult(int id)
        {
            return $"You have passed {id} input value";
        }

        public string GetEmployeeData(int id, string name)
        {
            return $"Employee Id : {id} Name : {name}";
        }

        [Route("vhaash/home/{id}/{studentName}")]
        public string GetStudentData(int id, string studentName)
        {
            return $"Employee Id : {id} Name : {studentName}";
        }
    }
}