<%@ Page Title="" Language="C#" MasterPageFile="~/adminmasterpage.master" AutoEventWireup="true" CodeFile="xyz-admin-page-zxw.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <div id="container" >
            <asp:Label ID="Label1" runat="server" Text="Eklenecek Sorunun Satır Sayısı:"></asp:Label>
            <asp:TextBox class="textboxcss" ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Eklenecek Sorunun Sütun Sayısı:"></asp:Label>
            <asp:TextBox class="textboxcss" ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Zorluk Derecesi::"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="kolay_tablosu">Kolay</asp:ListItem>
                <asp:ListItem Value="orta_tablosu">Orta</asp:ListItem>
                <asp:ListItem Value="zor_tablosu">Zor</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:Button style="background-color:rgb(215,174,8); font-size:large;" class="btn-1" ID="Button1" runat="server" OnClick="Button1_Click"  OnClientClick="return confirm('Oluşturacağınız Sorudan Emin Misiniz?');" Text="Oluştur" />
            <br />
            <br />
        </div>
</asp:Content>

