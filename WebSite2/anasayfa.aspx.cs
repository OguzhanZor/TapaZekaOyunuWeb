using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Button1.Visible = true;
        Button2.Visible = true;
        Button4.Visible = true;
        Button3.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //kolay button

        Session["sayfa1"] = "Kolay";
        Response.Redirect("sorusıralama.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //orta button
        Session["sayfa1"] = "Orta";
        Response.Redirect("sorusıralama.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        //zor button


        Session["sayfa1"] = "Zor";
        Response.Redirect("sorusıralama.aspx");
    }
}