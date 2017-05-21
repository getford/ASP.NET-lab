using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace L10
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://vsm.org/ws/")]
    //[WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        int x = 999999999;
        int y = 99999999;

        [WebMethod(EnableSession = true)]
        public void CheckSessionSetX(int x)
        {
            Session["x"] = x;
        }

        [WebMethod(EnableSession = true)]
        public int GetX()
        {
            int ret = x;
            if (Session["x"] != null) ret = (int)Session["x"];
            return ret;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        [WebMethod(Description = "Сумма", EnableSession = true)]
        public int Add(int x, int y)
        {
            return x + y;
        }
        [WebMethod(Description = "Разность")]
        public int Sub(int x, int y)
        {
            return x - y;
        }
        [WebMethod(Description = "Произведение")]
        public int Mul(int x, int y)
        {
            return x * y;
        }
    }
}
