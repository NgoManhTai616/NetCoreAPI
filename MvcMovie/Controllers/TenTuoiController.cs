using MvcMovie.Models;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

    public class TenTuoiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Nhan du lieu";
            return View();
        }
        [HttpPost]
        public IActionResult Index(TenTuoi p)
        {
            int age = DateTime.Now.Year - p.Age;
            ViewBag.Message = $"Họ tên: {p.FullName}, Tuổi: {age}";
            return View();
        }

    }