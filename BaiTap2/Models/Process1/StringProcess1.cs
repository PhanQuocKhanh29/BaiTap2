using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace BaiTap2.Models.Process1
{
    public class StringProcess1
    {
        public string AutoGenerateKey(string id) 
        {
            //khai bao cac tham so de chua du lieu
            string numPart, strPart, newKey = "", newNumPart = "";
            int intNumber;
            //tham so dau vao la KH001
            //Buoc1: Tach phan so va phan chu => 2 phan: KH va 001
            //phan so: numPart = 001
            numPart = Regex.Match(id, @"\d+").Value;
            //Chuyen phan so sang dang so nguyen => Tang phan so len 1 don vi => gia tri = 2
            intNumber = Convert.ToInt32(numPart) + 1;
            //su dung vong lap de ghep bo sung cac so 0 => phan so moi = 002
            for (int i = 0; i < numPart.Length - intNumber.ToString().Length; i++)
            {
                newNumPart += "0";
            }
            newNumPart += intNumber;
            //phan chu: strPart = KH
            strPart = numPart = Regex.Match(id, @"\D+").Value;
            //ghep phan chu va phan so moi de duoc gia tri key moi => KH002
            newKey = strPart + newNumPart;
            //Tra ve gia tri key
            return newKey;

        }
    }
}