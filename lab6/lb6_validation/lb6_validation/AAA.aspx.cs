using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lb6_validation
{
    public partial class AAA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int n = int.Parse(args.Value);
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    args.IsValid = false;
                    break;
                }
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}