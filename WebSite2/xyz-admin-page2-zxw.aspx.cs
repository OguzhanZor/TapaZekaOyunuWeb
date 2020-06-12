using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
       
    SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-D00EC5U\\SQLEXPRESS; Initial Catalog = tapaa; Integrated Security = True");
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string tabloIsmi = Session["sayfa4"].ToString();
        string[] tablo_Dizi = tabloIsmi.Split(',');
        int sayac = 1;

        for (int i = 0; i < int.Parse(tablo_Dizi[0]); i++)
        {
            for (int j = 0; j < int.Parse(tablo_Dizi[1]); j++)
            {
                Button btn = new Button();
                btn.ID = sayac.ToString();
                btn.Height = 35;
                btn.Width = 35;
                btn.Style["background-color"] = "White";
                btn.Attributes.CssStyle.Add("Position", "absolute");
                btn.Attributes.CssStyle.Add("Left", (60 + 35 * j) + "px");
                btn.Attributes.CssStyle.Add("Top", (200 + 35 * i) + "px");
                
                Panel1.Controls.Add(btn);
                sayac++;
                btn.Click += new EventHandler(dinamikMetod);
            }
        }
    }
    protected void dinamikMetod(object sender, EventArgs e)
    {
        
        Button dinamikButon = (sender as Button);
        
        if (dinamikButon.BorderColor == Color.Black)
        {
            dinamikButon.Text = TextBox1.Text;
            dinamikButon.BorderColor = Color.Blue;
            dinamikButon.Style["background-color"] = "Blue";
            maviler.Items.Add(dinamikButon.ID + "&" + dinamikButon.Text);
            siyahlar.Items.Remove(dinamikButon.ID);
            beyazlar.Items.Remove(dinamikButon.ID);
            
            TextBox1.Text = "";
        }
        else if (dinamikButon.BorderColor == Color.Blue)
        {

            dinamikButon.BorderColor = Color.White;
            dinamikButon.Style["background-color"] = "White";
            maviler.Items.Remove(dinamikButon.ID + "&" + dinamikButon.Text);
            siyahlar.Items.Remove(dinamikButon.ID);
            beyazlar.Items.Add(dinamikButon.ID);
            
        }
        else
        {

            dinamikButon.Style["background-color"] = "Black";
            dinamikButon.BorderColor = Color.Black;
            siyahlar.Items.Add(dinamikButon.ID);
            maviler.Items.Remove(dinamikButon.ID + "&" + dinamikButon.Text);
            beyazlar.Items.Remove(dinamikButon.ID);
            Label2.Text = dinamikButon.ID + ".ci Karenin İçeriği::";
            
        }

    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        string mavilerKutuNo = "";
        string mavilerKutuAciklama = "";
        string karalıNolar = "";
        
        //  mavilerin sıralanması ve başta yada sonda olan vilgüllerin giderilmesi
        for (int i = 0; i < maviler.Items.Count; i++)
        {
            string[] mavilerAyirma = maviler.Items[i].Text.Split('&');
            if (maviler.Items.Count - 1 != i)
            {
                mavilerKutuNo = mavilerKutuNo + mavilerAyirma[0] + ",";
                mavilerKutuAciklama = mavilerKutuAciklama + mavilerAyirma[1] + "/";

            }
            else
            {
                mavilerKutuNo = mavilerKutuNo + mavilerAyirma[0];
                mavilerKutuAciklama = mavilerKutuAciklama + mavilerAyirma[1];

            }

        }
        
        ArrayList SiyahArray = new ArrayList();

        foreach (var item in siyahlar.Items)
        {
            SiyahArray.Add(int.Parse(item.ToString()));
        }
        SiyahArray.Sort();

        for (int i = 0; i < SiyahArray.Count; i++)
        {
            if (SiyahArray.Count - 1 != i)
            {
                karalıNolar = karalıNolar + SiyahArray[i].ToString() + ",";

            }
            else
            {
                karalıNolar = karalıNolar + SiyahArray[i].ToString();

            }
        }
        
        string tabloIsmi = Session["sayfa4"].ToString();
        string[] tablo_Dizi = tabloIsmi.Split(',');
        
        baglanti.Open();
        SqlCommand komut = new SqlCommand("insert into " + tablo_Dizi[2].ToString() + " (X,Y,kutu_no,kutu_aciklama,karali_nolar) values('" + tablo_Dizi[0].ToString() + "','" + tablo_Dizi[1].ToString() + "','" + mavilerKutuNo + "','" + mavilerKutuAciklama + "','" + karalıNolar + "')", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        Response.Write("<script>alert('::: Soru Olusturulması Başarılı :::');</script>");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("xyz-admin-page-zxw.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("anasayfa.aspx");
    }
   
    
}