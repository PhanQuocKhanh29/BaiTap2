using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaiTap2.Models;
using BaiTap2.Models.Process1;

namespace BaiTap2.Controllers
{
    public class KhachHangs1Controller : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();
        private StringProcess1 strPro = new StringProcess1();

        // GET: KhachHangs1
        public ActionResult Index()
        {
            return View(db.KhachHangs.ToList());
        }

        // GET: KhachHangs1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = db.KhachHangs.Find(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // GET: KhachHangs1/Create
        public ActionResult Create()
        {
            var model = db.KhachHangs.ToList();
            //kiem tra xem doi tuong da co du lieu chua
            //neu chua co thi tra ve 1 ma mac dinh ban dau
            if (model.Count == 0)
            {
                ViewBag.MaKH = "KH001";
            }
            //neu co roi thi goi toi phuong thuc sinh ma tu dong
            else 
            {
                //lay ra ma khach hang moi nhat
                var idKH = model.OrderByDescending(m => m.MaKH).FirstOrDefault().MaKH;
                var newKey = strPro.AutoGenerateKey(idKH);
                ViewBag.MaKH = newKey;
            }
            //tra ma tu dong ve view
            return View();
        }

        // POST: KhachHangs1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TenKH,MaKH,Diachi")] KhachHang khachHang)
        {
            //dua cac cau lenh co the gay ra loi vao phan try
            try
            {
                if (ModelState.IsValid)
                {
                    db.KhachHangs.Add(khachHang);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            //xu ly cac loi co the phat sinh
            catch (Exception)
            {
                ModelState.AddModelError("", "Khoa chinh bi trung, vui long nhap lai.");
                return View(khachHang);
            }
           

            return View(khachHang);
        }

        // GET: KhachHangs1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = db.KhachHangs.Find(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHangs1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TenKH,MaKH,Diachi")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khachHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khachHang);
        }

        // GET: KhachHangs1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = db.KhachHangs.Find(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHangs1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KhachHang khachHang = db.KhachHangs.Find(id);
            db.KhachHangs.Remove(khachHang);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
