using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Select_input.Items.Add("");
            }

            HtmlTable table = new HtmlTable
            {
                Border = 1,
                CellPadding = 3,
                CellSpacing = 3,
                Align = "center",
                BorderColor = "red"
            };

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            cell.InnerHtml = "Html Control";
            row.Cells.Add(cell);


        }

        protected void Reset_OnServerClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}