using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap2.Models;

namespace BaiTap2.Controllers
{
    public class DemoBT2Controller : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: DemoBT2
        public ActionResult GPT()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPT(string soA, string soB)
        {
            //nhan 2 gia tri gui len tu client
            //chuyen oi sang kieu doubl
            //2 giatri nay làm tham so dau vao ho phon thuc gii phuong trinh
            double so1 = Convert.ToDouble(soA);
            double so2 = Convert.ToDouble(soB);
            //Khai bao bien x
            // ke thua phuong thuc giai pt
            double ketqua = gpt.GPT(so1, so2);
            ViewBag.Giaipt = ketqua;
            return View();
        }
    }
}