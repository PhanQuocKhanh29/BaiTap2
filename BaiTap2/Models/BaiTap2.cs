using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap2.Models
{
    public class BaiTap2
    {
        public double GPT(double a, double b)
        {
            double GPT = 0;
            GPT = -b / a;
            return GPT;
        }
    }
}