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
        HtmlTable table = new HtmlTable();
        HtmlTableRow r;
        HtmlTableCell c;

        protected void Page_Load(object sender, EventArgs e)
        {
            table.Border = 1;
            table.CellPadding = 3;
            table.CellSpacing = 3;
            table.Align = "center";
            table.BorderColor = "red";

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "html Control"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "onserverclick"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "onserverchange"; r.Cells.Add(c);
            table.Rows.Add(r);
            Controls.Add(table);
        }
        protected void Reset_ButtonClick(object sender, System.EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputReset"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
        protected void ButtonClick(object sender, System.EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputButton"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
        protected void Submit_ButtonClick(object sender, System.EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputSubmit"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            table.Rows.Add(r);

        }
        protected void File_ButtonClick(object sender, System.EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputFile"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
        protected void File_onserverchange(object sender, System.EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputFile"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            table.Rows.Add(r);

        }
        protected void InputTextClick(object sender, System.EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputText"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
        protected void InputText_onserverchange(object sender, System.EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputText"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
        protected void Password_onserverchange(object sender, System.EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputPassword"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
        protected void CheckBox_onserverchange(object sender, System.EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputCheckBox"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
        protected void textArea_onserverchange(object sender, System.EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputTextArea"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
        protected void Select1_ServerChange(object sender, EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputSelect"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
        protected void radio1_onserverchange(object sender, EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputRadioButton 1"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
        protected void radio2_onserverchange(object sender, EventArgs e)
        {
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "HtmlInputRadioButton 2"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "-"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "+"; r.Cells.Add(c);
            table.Rows.Add(r);
        }
    }
}