using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap2.Models
{
    public class GiaiPhuongTrinh
    {
        public double GPT(double x, double y)
        {
            double GPT = 0;
            GPT = -y / x;
            return GPT;
        }
    }
}