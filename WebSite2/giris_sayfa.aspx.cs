using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class giris_sayfa : System.Web.UI.Page
{
    SqlConnection baglantii = new SqlConnection("Data Source = DESKTOP-D00EC5U\\SQLEXPRESS; Initial Catalog = tapaa; Integrated Security = True");

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        baglantii.Open();
        SqlCommand uyecekomut = new SqlCommand("SELECT kullanici_adi,kullanici_sifre,kullanici_rol FROM kullanicilar_tablosu WHERE kullanici_adi = '"+TextBox1.Text+"'",baglantii);
        SqlDataAdapter da = new SqlDataAdapter(uyecekomut);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count == 0 || TextBox1.Text != ds.Tables[0].Rows[0][0].ToString() || TextBox2.Text != ds.Tables[0].Rows[0][1].ToString())
        {
            Label3.Visible=true;
        }
        else
        {
            if (TextBox2.Text==ds.Tables[0].Rows[0][1].ToString())
            {
                if (ds.Tables[0].Rows[0][2].ToString() == " ")
                {
                    Response.Redirect("anasayfa.aspx");
                }
                else
                {
                    Session["rol"] = ds.Tables[0].Rows[0][2].ToString();
                    Response.Redirect("xyz-admin-page-zxw.aspx");
                }
            }
        }

    }
}