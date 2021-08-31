using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2.Controllers
{
    public class DemoBT2Controller : Controller
    {
        // GET: DemoBT2
        public ActionResult GPT()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPT(string soX, string soY)
        {
            double soa = Convert.ToDouble(soX);
            double sob = Convert.ToDouble(soY);
            double ketqua = -sob / soa;
            ViewBag.Giaipt = ketqua;
            return View();
        }
    }
}