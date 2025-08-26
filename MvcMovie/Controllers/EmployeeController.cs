using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee ep)
        {
            string strOutput = "Xin chào" + ep.EmployeeId + "-" + ep.Age;
            ViewBag.InfoPerson = strOutput;
            return View();
        }
    }
}