using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lb6_validation
{
    public partial class BBB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CompareValidatorDate.ValueToCompare = DateTime.Now.ToShortDateString();
        }

        protected void CustomValidatorPass_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string pass = args.Value as string;
            HashSet<char> passHash = new HashSet<char>(pass);
            if (passHash.Count() != pass.Count())
                args.IsValid = false;
        }
    }
}