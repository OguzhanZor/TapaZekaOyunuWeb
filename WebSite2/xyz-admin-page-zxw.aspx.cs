using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["rol"].ToString() != "A")
        {
            Response.Redirect("giris_sayfa.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string X = TextBox1.Text;
        string Y = TextBox2.Text;

        Session["sayfa4"] = X + "," + Y + "," + RadioButtonList1.SelectedValue;

        Response.Redirect("xyz-admin-page2-zxw.aspx");
    }

}