using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        SqlConnection baglanti = new SqlConnection("Data Source =DESKTOP-D00EC5U\\SQLEXPRESS; Initial Catalog = tapaa; Integrated Security = True");
        if (TextBox1.Text != "")
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Pages (PageName,icerik) values('" + TextBox1.Text + "','" + FreeTextBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Response.Write("<script>alert('::: Sayfa Olusturulması Başarılı :::');</script>");

        }
        else
        {
            Response.Write("<script>alert('::: Sayfa Oluşturulamadı. Sayfa oluşturulması için bir sayfa isim giriniz. :::');</script>");
        }
    }

}