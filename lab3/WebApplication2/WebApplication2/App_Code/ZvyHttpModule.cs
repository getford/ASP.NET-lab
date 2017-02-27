using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebApplication2.App_Code
{
    public class ZvyHttpModule : IHttpHandler
    {
        public void Init(HttpApplication context)
        {
            context.PreRequestHandlerExecute += HandlePreRequest;

        }

        private void HandlePreRequest(object sender, EventArgs e)
        {
            Page p = HttpContext.Current.CurrentHandler as Page;
            if (p != null)
            {
                p.Session["x11"] = "handlePreRequest";
            }
        }

        public void Dispose() { }

        public void ProcessRequest(HttpContext context)
        {
            throw new NotImplementedException();
        }
        public bool IsReusable
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}