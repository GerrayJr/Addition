using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Sum2
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Addition : System.Web.Services.WebService
    {
        [WebMethod]
        // Add three numbers
        public int Sum(int Num1 , int Num2, int Num3)
        {
            return Num1 + Num2 + Num3;
        }
        [WebMethod]
        //Subtract three numbers
        public int Subtract(int Num1, int Num2, int Num3)
        {
            return Num1 - Num2 - Num3;
        }
        [WebMethod]
        //Divide two numbers
        public int Divide(int Num1, int Num2)
        {
            return Num1/Num2;
        }
        [WebMethod]
        //Multiply three numbers
        public int Multiply(int Num1, int Num2, int Num3)
        {
            return Num1 * Num2 * Num3;
        }

     }
}
