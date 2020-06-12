using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            baslangıc();
        }
        catch (Exception)
        {
            Response.Redirect("anasayfa.aspx");
            throw;
        }
    }
    
    private void baslangıc()
    {

        string sesionGelenString = Session["sayfa2"].ToString();

        string[] sesionGelenStringDizi = sesionGelenString.Split('*');
        string texkutu = sesionGelenStringDizi[2].ToString();

        string[] parcalitex = texkutu.Split(',');
        int[] sayilar = new int[parcalitex.Length];
        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = int.Parse(parcalitex[i]);
        }

        int sayac2 = 1;
        int diziuz = sayilar.Length;
        int sayac = 1;

        int X = int.Parse(sesionGelenStringDizi[0].ToString());
        int Y = int.Parse(sesionGelenStringDizi[1].ToString());

        string texaciklama = sesionGelenStringDizi[3].ToString();
        string[] parcalitexAciklama = texaciklama.Split('/');



        for (int i = 1; i <= Y; i++)
        {
            for (int j = 1; j <= X; j++)
            {

                if (sayilar[sayac2 - 1] == sayac)
                {
                    Label lbl = new Label();
                    for (int k = sayac2 - 1; k < sayac2; k++)
                    {
                        lbl.Text = lbl.Text + "" + parcalitexAciklama[k];
                    }

                    lbl.Height = 25;
                    lbl.Width = 25;

                    lbl.Attributes.CssStyle.Add("Position", "absolute");
                    lbl.Attributes.CssStyle.Add("Left", (60 + 35 * j) + "px");
                    lbl.Attributes.CssStyle.Add("Top", (80 + 35 * i) + "px");
                    Panel1.Controls.Add(lbl);
                    sayac++;
                    if (diziuz != sayac2)
                    {
                        sayac2++;
                    }

                }

                else
                {
                    Button btn = new Button();
                    btn.ID = sayac.ToString();

                    btn.Height = 35;
                    btn.Width = 35;
                    btn.Style["background-color"] = "White";

                    btn.Attributes.CssStyle.Add("Position", "absolute");
                    btn.Attributes.CssStyle.Add("Left", (60 + 35 * j) + "px");
                    btn.Attributes.CssStyle.Add("Top", (80 + 35 * i) + "px");



                    Panel1.Controls.Add(btn);
                    sayac++;

                    btn.Click += new EventHandler(dinamikMetod);
                }

            }

        }
        Timer1.Enabled = true;

    }



    protected void dinamikMetod(object sender, EventArgs e)
    {
        Button dinamikButon = (sender as Button);
        string sesionGelenString = Session["sayfa2"].ToString();
        string[] sesionGelenStringDizi = sesionGelenString.Split('*');
        int X = int.Parse(sesionGelenStringDizi[0].ToString());
        int Y = int.Parse(sesionGelenStringDizi[1].ToString());
        
        if (dinamikButon.BorderColor == Color.Black || dinamikButon.BorderColor == Color.Red || dinamikButon.BorderColor == Color.Lime)
        {
            dinamikButon.BorderColor = Color.White;
            dinamikButon.Style["background-color"] = "White";
            ListBox1.Items.Remove(dinamikButon.ID);
        }
        else
        {
            if (ListBox2.Items.Count == 0)
            {
                Label3.Visible = true;
            }
            else
            {
                Label3.Visible = false;
                dinamikButon.Style["background-color"] = "" + ListBox2.Items[0].ToString() + "";
                if (ListBox2.Items[0].ToString() == "#000000")
                { dinamikButon.BorderColor = Color.Black; }
                else if (ListBox2.Items[0].ToString() == "#00FF00")
                { dinamikButon.BorderColor = Color.Lime; }
                else
                { dinamikButon.BorderColor = Color.Red; }
                ListBox1.Items.Add(dinamikButon.ID);
            }
        }
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        Timer1.Enabled = false;


        ArrayList siyahlar = new ArrayList();

        foreach (object o in ListBox1.Items)
        {
            siyahlar.Add(int.Parse(o.ToString()));
        }
        siyahlar.Sort();
        ArrayList kontrolsiyah = new ArrayList();
        string sesionGelenString = Session["sayfa2"].ToString();
        string[] sesionGelenStringDizi = sesionGelenString.Split('*');
        string kontrolsiyahstring = sesionGelenStringDizi[5].ToString();
        string[] kontrolsiyahstring2 = kontrolsiyahstring.Split(',');

        foreach (var item in kontrolsiyahstring2)
        {
            kontrolsiyah.Add(int.Parse(item));
        }

        try
        {
            int kontsayac = 0;

            for (int i = 0; i < siyahlar.Count; i++)
            {
                if (Object.Equals(kontrolsiyah[i], siyahlar[i]))
                {
                    kontsayac++;

                }
            }
            if (kontsayac == kontrolsiyah.Count)
            {
                Response.Write("<script>alert('Çözüm Başarılı. Süreniz:: " + Label1.Text + "');</script>");

            }
            else
            {
                Response.Write("<script>alert('Çözüm Yanlış.  Süreniz::   " + Label1.Text + "');</script>");
                Timer1.Enabled = true;
            }
        }
        catch (Exception)
        {
            Response.Write("<script>alert('Çözüm Yanlış //// BEKLENMEYEN HATA SAYFAYI YENİLEYİN');</script>");
            ListBox1.Items.Clear();
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string renk = Button4.Text;
        ListBox2.Items.Clear();
        ListBox2.Items.Add(renk);
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        string renk = Button5.Text;
        ListBox2.Items.Clear();
        ListBox2.Items.Add(renk);
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        string renk = Button6.Text;
        ListBox2.Items.Clear();
        ListBox2.Items.Add(renk);
    }
    
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(Label1.Text);
        a = a + 1;
        Label1.Text = a.ToString();
        
    }
}