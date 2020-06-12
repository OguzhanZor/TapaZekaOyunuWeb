<%@ Page Title="" Language="C#" MasterPageFile="~/adminmasterpage.master" AutoEventWireup="true" CodeFile="xyz-admin-page4-zxw.aspx.cs" Inherits="_Default" validateRequest="false"%>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="guncelekrancss">
    <asp:Label ID="Label1" runat="server" Text="SAYFA SİLME"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Silmek İçin Sayfa Şeç::: "></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="PageName" DataValueField="PageName"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tapaaConnectionString7 %>" SelectCommand="SELECT [PageName] FROM [Pages]"></asp:SqlDataSource><br />
    <asp:Button  style="background-color:rgb(76, 255, 0); font-size:large;" class="btn-1" ID="Button1" runat="server" Text="SAYFAYI SİL" OnClick="Button1_Click"  OnClientClick="return confirm('Sayfayı Silmek İstedğinizden Emin Misiniz?');" />
    <br /> <br /><br />
    <asp:Label ID="Label3" runat="server" Text="SAYFA GÜNCELLEME"></asp:Label><br />
    <asp:Label ID="Label4" runat="server" Text="Güncellemek İçin Sayfa şeçin::: "></asp:Label>  <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="PageName" DataValueField="PageName"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:tapaaConnectionString8 %>" SelectCommand="SELECT [PageName] FROM [Pages]"></asp:SqlDataSource>
    <br /><asp:Button  style="background-color:rgb(76, 255, 0); font-size:large;" class="btn-1" ID="Button2" runat="server" Text="SAYFAYI GETİR" OnClick="Button2_Click" />
      <br /> <br /><br />
    <asp:Label ID="Label5" runat="server" Text="Sayfa İsmi"></asp:Label><br />
        <asp:TextBox class="textboxcss" ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Sayfa No'su :::" Visible="False"></asp:Label>
    <asp:Label ID="Label7" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
    
    <asp:Label ID="Label6" runat="server" Text="İçerik"></asp:Label><br />
    <FTB:FreeTextBox ID="FreeTextBox1" runat="server"></FTB:FreeTextBox>
      <br /><br />
    <asp:Button  style="background-color:rgb(76, 255, 0); font-size:large;" class="btn-1" ID="Button3" runat="server" Text="SAYFAYI GÜNCELLE" OnClick="Button3_Click" />
       <br /><br /><br />
    </div>
</asp:Content>

