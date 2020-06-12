using System;
using System.Collections.Generic;
using System.Data;
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
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-D00EC5U\\SQLEXPRESS; Initial Catalog = tapaa; Integrated Security = True");
        
            string sil = "DELETE FROM Pages WHERE PageName =  '" + DropDownList1.SelectedItem.Text + "' ";

            SqlCommand komut = new SqlCommand(sil, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Response.Redirect("xyz-admin-page4-zxw.aspx");
        
        
    }
    string sayfa_id, sayfa_Ad, sayfa_Icerik;
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = new SqlConnection("Data Source =DESKTOP-D00EC5U\\SQLEXPRESS; Initial Catalog = tapaa; Integrated Security = True");
        baglanti.Open();
        string sorgu = "Select * from Pages where PageName = '" + DropDownList2.SelectedItem.Text + "'";

        SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
        DataTable ds = new DataTable();

        adap.Fill(ds);
        baglanti.Close();

        sayfa_id = ds.Rows[0][0].ToString();
        sayfa_Ad = ds.Rows[0][1].ToString();
        sayfa_Icerik = ds.Rows[0][2].ToString();
        Label7.Text = sayfa_id.ToString();
        TextBox1.Text = sayfa_Ad;
        FreeTextBox1.Text = sayfa_Icerik;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-D00EC5U\\SQLEXPRESS; Initial Catalog = tapaa; Integrated Security = True");

        baglanti.Open();
        string kayit = "update Pages set PageName= '" + TextBox1.Text + "',icerik= '" + FreeTextBox1.Text + "' where PageId= '" + Label7.Text + "'";
        //Müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
        SqlCommand komut = new SqlCommand(kayit, baglanti);
        //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
        komut.ExecuteNonQuery();
        //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
        baglanti.Close();
        Response.Write("<script>alert('::: Sayfa Güncelleme İşlemi Başarılı :::');</script>");

    }

}