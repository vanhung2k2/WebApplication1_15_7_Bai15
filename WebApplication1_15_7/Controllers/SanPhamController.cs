using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_15_7.Models;

namespace WebApplication1_15_7.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SanPham/Create
        [HttpPost]
        public ActionResult Create(SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                SanPhamStore.AddSanPham(sanPham);
                return RedirectToAction("Index"); // Chuyển hướng về trang danh sách sản phẩm
            }
            return View(sanPham);
        }

        // GET: SanPham/Edit/5
        public ActionResult Edit(int id)
        {
            var sanPham = SanPhamStore.GetSanPhams().FirstOrDefault(s => s.Id == id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // POST: SanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                SanPhamStore.UpdateSanPham(sanPham);
                return RedirectToAction("Index");
            }
            return View(sanPham);
        }

        // GET: SanPham/Delete/5
        public ActionResult Delete(int id)
        {
            var sanPham = SanPhamStore.GetSanPhams().FirstOrDefault(s => s.Id == id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // POST: SanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SanPhamStore.RemoveSanPham(id);
            return RedirectToAction("Index");
        }

        // GET: SanPham/Search
        public ActionResult Search(string keyword)
        {
            var sanPhams = SanPhamStore.GetSanPhams()
                                       .Where(s => s.Ten.Contains(keyword) || s.MoTa.Contains(keyword))
                                       .ToList();
            return View("Index", sanPhams);
        }

        // GET: SanPham/Index
        public ActionResult Index()
        {
            var sanPhams = SanPhamStore.GetSanPhams();
            return View(sanPhams);
        }
    }
}