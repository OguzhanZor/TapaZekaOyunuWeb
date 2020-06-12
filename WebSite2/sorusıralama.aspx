<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sorusıralama.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="Kolay" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Visible="False">
        <Columns>
            <asp:BoundField DataField="soru_id" HeaderText="soru_id" InsertVisible="False" ReadOnly="True" SortExpression="soru_id" />
            <asp:BoundField DataField="x" HeaderText="x" SortExpression="x" />
            <asp:BoundField DataField="y" HeaderText="y" SortExpression="y" />
            <asp:BoundField DataField="kutu_no" HeaderText="kutu_no" SortExpression="kutu_no" />
            <asp:BoundField DataField="kutu_aciklama" HeaderText="kutu_aciklama" SortExpression="kutu_aciklama" />
            <asp:BoundField DataField="bosluk_nolar" HeaderText="bosluk_nolar" SortExpression="bosluk_nolar" />
            <asp:BoundField DataField="karali_nolar" HeaderText="karali_nolar" SortExpression="karali_nolar" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tapaaConnectionString %>" SelectCommand="SELECT * FROM [kolay_tablosu]"></asp:SqlDataSource>
    <asp:GridView ID="Orta" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Visible="False">
        <Columns>
            <asp:BoundField DataField="soru_id" HeaderText="soru_id" InsertVisible="False" ReadOnly="True" SortExpression="soru_id" />
            <asp:BoundField DataField="x" HeaderText="x" SortExpression="x" />
            <asp:BoundField DataField="y" HeaderText="y" SortExpression="y" />
            <asp:BoundField DataField="kutu_no" HeaderText="kutu_no" SortExpression="kutu_no" />
            <asp:BoundField DataField="kutu_aciklama" HeaderText="kutu_aciklama" SortExpression="kutu_aciklama" />
            <asp:BoundField DataField="bosluk_nolar" HeaderText="bosluk_nolar" SortExpression="bosluk_nolar" />
            <asp:BoundField DataField="karali_nolar" HeaderText="karali_nolar" SortExpression="karali_nolar" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:tapaaConnectionString4 %>" SelectCommand="SELECT * FROM [orta_tablosu]"></asp:SqlDataSource>
    <asp:GridView ID="Zor" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" Visible="False">
        <Columns>
            <asp:BoundField DataField="soru_id" HeaderText="soru_id" InsertVisible="False" ReadOnly="True" SortExpression="soru_id" />
            <asp:BoundField DataField="x" HeaderText="x" SortExpression="x" />
            <asp:BoundField DataField="y" HeaderText="y" SortExpression="y" />
            <asp:BoundField DataField="kutu_no" HeaderText="kutu_no" SortExpression="kutu_no" />
            <asp:BoundField DataField="kutu_aciklama" HeaderText="kutu_aciklama" SortExpression="kutu_aciklama" />
            <asp:BoundField DataField="bosluk_nolar" HeaderText="bosluk_nolar" SortExpression="bosluk_nolar" />
            <asp:BoundField DataField="karali_nolar" HeaderText="karali_nolar" SortExpression="karali_nolar" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:tapaaConnectionString3 %>" SelectCommand="SELECT * FROM [zor_tablosu]" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
    <% string tabloIsmi = Session["sayfa1"].ToString();
            string[] tabloisimdizi = { "Kolay", "Orta", "Zor" };
            if (tabloIsmi == tabloisimdizi[0].ToString())
            {%>
              <div align='center'> <image  src='resim/kolay.png'></image></div>
          <%}
            else if (tabloIsmi == tabloisimdizi[1].ToString())
            {%>
              <div align='center'> <image src='resim/orta.png'></image></div>
          <%}
            else
            { %>
              <div align='center'> <image src='resim/zor.png'></image></div>
          <%}%>
    <asp:Panel  ID="Panel1" runat="server">

    </asp:Panel>
</asp:Content>

