<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="anasayfa.aspx.cs" Inherits="Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-top: 65vh; font-size:50px;">
      &nbsp;<asp:Button style="background-color:rgb(215,174,8)" class="btn-1" ID="Button1" runat="server" Text="KOLAY" Visible="False" OnClick="Button1_Click" />
            <asp:Button  style="background-color:rgb(14,99,32)" class="btn-1" ID="Button2" runat="server" Text="ORTA" Visible="False" OnClick="Button2_Click" />
            <asp:Button  style="background-color:rgb(16,49,100)" class="btn-1" ID="Button3" runat="server" Text="BAŞLA" OnClick="Button3_Click" />
            <asp:Button  style="background-color:rgb(188,26,49)" class="btn-1" ID="Button4" runat="server" Text="ZOR" Visible="False" OnClick="Button4_Click" />
    </div>
</asp:Content>

