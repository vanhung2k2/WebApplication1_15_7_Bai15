using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_15_7.Models;

namespace WebApplication1_15_7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var lst = new List<SanPham>();
            lst.Add(new SanPham(1,"Điện Thoại", "Đời mới", 1000000, "Nghe gọi"));
            lst.Add(new SanPham(2,"Máy Tính", "Xịn xò", 2000000, "Lướt web"));
            lst.Add(new SanPham(3,"Tai Nghe", "Âm tốt", 1500000, "Nghe nhạc"));
            lst.Add(new SanPham(4,"Bàn Phím", "Nhạy", 2500000, "Gõ lạch cạch"));
            ViewBag.Message = "Hello, world!";
            return View(lst);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}