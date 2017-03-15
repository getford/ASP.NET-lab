using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.HttpHandlers
{
    public class GetHandler : IHttpHandler
    {
        bool IHttpHandler.IsReusable { get { return false; } }

        void IHttpHandler.ProcessRequest(HttpContext context)
        {
            context.Response.Write("GET Handler: param1 = " +
                context.Request.QueryString.Get("param1") +
                ", param2 " + context.Request.QueryString.Get("param2"));
        }
    }
}