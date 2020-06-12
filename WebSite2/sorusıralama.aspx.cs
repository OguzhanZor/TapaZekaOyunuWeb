using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        try
        {
            string tabloIsmi = Session["sayfa1"].ToString();

            string[] tabloisimdizi = { "Kolay", "Orta", "Zor" };
  
            if (tabloIsmi == tabloisimdizi[0].ToString())
            {
                for (int i = 1; i < Kolay.Rows.Count + 1; i++)
                {
                    Button sorubtn = new Button();
                    sorubtn.Attributes.Add("class", "btn-1");
                    sorubtn.Style["height"] = "75px";
                    sorubtn.Style["margin-right"] = "25px";


                    sorubtn.ID = i.ToString();
                    sorubtn.Text = i.ToString();
                    sorubtn.Width = 80;
                    sorubtn.Height = 50;
                    Panel1.Controls.Add(sorubtn); 


                    sorubtn.Click += new EventHandler(sorudinamikMetod); // dinamik olarak oluşturulan butonu kontrol etmek için her oluşturulan butonun clik olayına atıyoruz.
                                                                         //        
                }
            }
            else if (tabloIsmi == tabloisimdizi[1].ToString())
            {
                for (int i = 1; i < Orta.Rows.Count + 1; i++)
                {


                    Button sorubtn = new Button();
                    sorubtn.Attributes.Add("class", "btn-1");
                    sorubtn.Style["height"] = "75px";
                    sorubtn.Style["margin-right"] = "25px";
                    sorubtn.ID = i.ToString();
                    sorubtn.Text = i.ToString();
                    sorubtn.Width = 80;
                    sorubtn.Height = 50;
                    Panel1.Controls.Add(sorubtn);


                    sorubtn.Click += new EventHandler(sorudinamikMetod); // dinamik olarak oluşturulan butonu kontrol etmek için her oluşturulan butonun clik olayına atıyoruz.
                }
            }
            else
            {
                for (int i = 1; i < Zor.Rows.Count + 1; i++)
                {

                    Button sorubtn = new Button();
                    sorubtn.Attributes.Add("class", "btn-1");
                    sorubtn.Style["height"] = "75px";
                    sorubtn.Style["margin-right"] = "25px";
                    sorubtn.ID = i.ToString();
                    sorubtn.Text = i.ToString();
                    sorubtn.Width = 80;
                    sorubtn.Height = 50;
                    Panel1.Controls.Add(sorubtn);


                    sorubtn.Click += new EventHandler(sorudinamikMetod); // dinamik olarak oluşturulan butonu kontrol etmek için her oluşturulan butonun clik olayına atıyoruz.
                }
            }
        }
        catch (Exception)
        {
            Response.Redirect("anasayfa.aspx");
            throw;
        }
        

    }
    protected void sorudinamikMetod(object sender, EventArgs e)
    {

        Button sorudinamikButon = (sender as Button);

        string tabloIsmi = Session["sayfa1"].ToString();


        if (tabloIsmi == "Kolay")
        {

            Session["sayfa2"] = Kolay.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[1].Text.ToString() + "*" +
                Kolay.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[2].Text.ToString() + "*" +
                Kolay.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[3].Text.ToString() + "*" +
                Kolay.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[4].Text.ToString() + "*" +
                Kolay.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[5].Text.ToString() + "*" +
                Kolay.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[6].Text.ToString();
        }
        else if (tabloIsmi == "Orta")
        {

            Session["sayfa2"] = Orta.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[1].Text.ToString() + "*" +
                Orta.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[2].Text.ToString() + "*" +
                Orta.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[3].Text.ToString() + "*" +
                Orta.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[4].Text.ToString() + "*" +
                Orta.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[5].Text.ToString() + "*" +
                Orta.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[6].Text.ToString();

        }
        else
        {
            Session["sayfa2"] = Zor.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[1].Text.ToString() + "*" +
                Zor.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[2].Text.ToString() + "*" +
                Zor.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[3].Text.ToString() + "*" +
                Zor.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[4].Text.ToString() + "*" +
                Zor.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[5].Text.ToString() + "*" +
                Zor.Rows[int.Parse(sorudinamikButon.ID) - 1].Cells[6].Text.ToString();

        }
        Session["rastgele"] = "ugrandi";
        Response.Redirect("oyun_basla.aspx");
    }
}