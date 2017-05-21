using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace L08
{
    public class Student
    {
        public string Family { get; set; }
        public string Name { get; set; }
        public string Patro { get; set; }
        public string Date { get; set; }
        public string Sex { get; set; }
        public string Faculty { get; set; }
        public int Year { get; set; }
        public int Group { get; set; }
    }
    public partial class StudentControl : System.Web.UI.UserControl, ICallbackEventHandler
    {
        public string name { get; set; }
        public string family { get; set; }
        public string patron { get; set; }
        public DateTime date { get; set; }
        public string sex { get; set; }
        public string faculty { get; set; }
        public int group { get; set; }
        public int year { get; set; }
        public string buttonEnterText { get; set; }
        public string buttonCancelText { get; set; }
        protected string returnValue;

        protected void Page_Load(object sender, EventArgs e)
        {
            CompareValidator1.ValueToCompare = DateTime.Now.ToShortDateString();
            if (buttonEnterText != null)
                ButtonEnter.Text = buttonEnterText;
            if (buttonCancelText != null)
                ButtonCancel.Text = buttonCancelText;

            String cbReference = Page.ClientScript.GetCallbackEventReference(this, "arg", "ReceiveServerData", "context");
            String callbackScript = "function CallServer(arg, context)" + "{ " + cbReference + ";}";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "CallServer", callbackScript, true);

        }

        public void RaiseCallbackEvent(string eventArgument)
        {
            try
            {
                Student student = JsonConvert.DeserializeObject<Student>(eventArgument);
                if (student != null)
                    returnValue = "OK";
            }
            catch (Exception ex)
            {
                returnValue = ex.Message;
            }
        }

        public string GetCallbackResult()
        {
            return returnValue;
        }
    }
}
