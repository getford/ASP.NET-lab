using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L03.HttpHandlers
{
    public class PutHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("PutHandler: param1=" + context.Request.Form.Get("param1") + ", param2=" + context.Request.Form.Get("param2"));
            
        }
        public bool IsReusable
        {
            get { return false; }
        }
    }
}