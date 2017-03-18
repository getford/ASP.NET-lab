using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace L03.HttpHandlers
{
    public class GetHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("GetHandler: param1=" + 
                context.Request.QueryString.Get("param1") + 
                ", param2=" + context.Request.QueryString.Get("param2"));
        }
        public bool IsReusable
        {
            get { return false; }
        }
    }
}