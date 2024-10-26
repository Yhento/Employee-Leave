using System.Net.Http.Headers;
using EmployeeLeaveManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeLeaveManagement.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {   
            var data = new TestViewModel 
            {
                Name = "Student",
                DateOfBirth = new DateTime(1991,10,27)
            };
            return View(data);
        }

    }
}
