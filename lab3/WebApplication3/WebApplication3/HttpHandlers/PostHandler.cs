using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.HttpHandlers
{
    public class PostHandler : IHttpHandler
    {
        bool IHttpHandler.IsReusable { get { return false; } }

        void IHttpHandler.ProcessRequest(HttpContext context)
        {
           
        }
    }
}