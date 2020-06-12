using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["rastgele"].ToString() == " ")
        {
            Response.Redirect("anasayfa.aspx");
        }
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            Response.Redirect("tapa_ekran.aspx");
       
    }
}