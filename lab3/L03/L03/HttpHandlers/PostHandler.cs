using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Text;

namespace L03.HttpHandlers
{
    public class PostHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.Path != "/sum.zvy")
            {
                context.Response.Write("PostHandler: param1=" + context.Request.Form.Get("param1") + ", param2=" + context.Request.Form.Get("param2") + "<br/>Result=" +
                            (Int32.Parse(context.Request.Form.Get("param1")) + Int32.Parse(context.Request.Form.Get("param2"))));
            }
            else if (context.Request.Path == "/sum.zvy")
            {
                StreamReader streamReader = new StreamReader(context.Request.GetBufferedInputStream());
                // Label3.Text = streamReader.ReadToEnd();
                //string responseXML = sr.ReadToEnd();
                string queryString = streamReader.ReadToEnd();
                context.Response.Write((Int32.Parse(HttpUtility.ParseQueryString(queryString).Get("param1")) + Int32.Parse(HttpUtility.ParseQueryString(queryString).Get("param2"))));
                context.Response.AppendHeader("Access-Control-Allow-Origin", "*");
                //context.Response.StatusCode = 200;

            }
        }
        public bool IsReusable
        {
            get { return false; }
        }
    }
}