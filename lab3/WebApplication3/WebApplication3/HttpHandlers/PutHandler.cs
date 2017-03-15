using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.HttpHandlers
{
    public class PutHandler : IHttpHandler
    {
        public bool IsReusable { get { return false; } }

    public void ProcessRequest(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}