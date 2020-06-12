<%@ Page Title="" Language="C#" MasterPageFile="~/adminmasterpage.master" AutoEventWireup="true" CodeFile="xyz-admin-page2-zxw.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        .textboxcssx{
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
    }
    </style>
        <div>
            <br />
            &nbsp;<asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <div style="position:relative">    
                <asp:ListBox ID="maviler" runat="server" Visible="False"></asp:ListBox>
                <asp:ListBox ID="siyahlar" runat="server" Visible="False"></asp:ListBox>
                <asp:ListBox ID="beyazlar" runat="server" Visible="False"></asp:ListBox>
                <asp:Panel ID="Panel1" runat="server">
                    
                    <asp:TextBox class="textboxcssx" ID="TextBox1" runat="server"></asp:TextBox>
                </asp:Panel></div>
               
            </div>
            <br />
            <asp:Button style="background-color:darkslategrey; font-size:medium;" class="btn-1"  ID="Button1" runat="server" OnClick="Button1_Click" Text="Soru Oluşturmayı Bitir." /><br />
            <br />
            <asp:Button style="background-color:lawngreen; font-size:medium;" class="btn-1"  ID="Button2" runat="server" OnClick="Button2_Click" Text="Yeni Soru Ekle." /><br />
            <br />
            <asp:Button style="background-color:olivedrab; font-size:medium;" class="btn-1" ID="Button3" runat="server" OnClick="Button3_Click" Text="Anasayfaya Git." />
</asp:Content>

