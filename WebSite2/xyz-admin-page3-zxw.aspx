<%@ Page Title="" Language="C#" MasterPageFile="~/adminmasterpage.master" AutoEventWireup="true" CodeFile="xyz-admin-page3-zxw.aspx.cs" Inherits="_Default" validateRequest="false"  %>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="eklemeekrancss" >  
    <br /> 
    <asp:Label ID="Label1" runat="server" Text="Sayfa İsmi"></asp:Label> 
    <asp:TextBox  class="textboxcss" ID="TextBox1" runat="server"></asp:TextBox> 
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="İçerik"></asp:Label>    
    <br />
    <FTB:FreeTextBox ID="FreeTextBox1" runat="server"></FTB:FreeTextBox>
        <br />    <br />
&nbsp;<asp:Button  style="background-color:rgb(76, 255, 0); font-size:large;" class="btn-1" ID="Button1" runat="server" Text="OLUŞTUR" OnClick="Button1_Click" /> <br />    <br /> <br />
        </div>
      
</asp:Content>

