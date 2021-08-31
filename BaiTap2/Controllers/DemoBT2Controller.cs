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
        public ActionResult GPT(string soA, string soB)
        {
            double so1 = Convert.ToDouble(soA);
            double so2 = Convert.ToDouble(soB);
            double ketqua = -so2 / so1;
            ViewBag.Giaipt = ketqua;
            return View();
        }
    }
}