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
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-D00EC5U\\SQLEXPRESS; Initial Catalog = tapaa; Integrated Security = True");
        baglanti.Open();
        string sorgu = "Select * from Pages where PageName = '" + Request.QueryString["sayfa"] + "'";

        SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
        DataTable ds = new DataTable();

        adap.Fill(ds);
        baglanti.Close();

        string sayfa_Ad = ds.Rows[0][1].ToString();

        string sayfa_Icerik = ds.Rows[0][2].ToString();
        Label1.Text = sayfa_Icerik;

    }
}