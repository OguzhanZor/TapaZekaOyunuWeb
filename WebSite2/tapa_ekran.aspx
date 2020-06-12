<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="tapa_ekran.aspx.cs" Inherits="Default7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"/>     
        <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
            <ContentTemplate>
                <div class="row">
                    <div class="col-md-4" style="display:table; height:80px;">
                        <div class="icerik">
                                <p style="font-family:'Comic Sans MS'; font-size:18px; font-weight:bold;">Oynamak İstediğiniz Rengi Seçiniz.</p>
                                <asp:Button style="background-color:rgb(0, 0, 0); color:rgb(0, 0, 0);" class="btn-1" ID="Button4" runat="server" OnClick="Button4_Click" Text="#000000"/>
                                <asp:Button style="background-color:rgb(0, 255, 00); color:rgb(0, 255, 0);" class="btn-1" ID="Button5" runat="server" OnClick="Button5_Click" Text="#00FF00"/>
                                <asp:Button style="background-color:rgb(255, 0, 0); color:rgb(255, 0, 0);" class="btn-1" ID="Button6" runat="server"  OnClick="Button6_Click" Text="#FF0000"/>
                        </div>
                    </div>
                    <div class="col-md-6" style="display:table; height:80px;">
                        <div class="icerik">
                               <asp:Label ID="Label3" style="font-family:'Comic Sans MS'; font-size:18px; font-weight:bold;" runat="server" Text="Oyuna Başlamak İçin Önce Renk Seçimi Yapmalısınız.Lütfen Oynamak İstediğiniz Rengi Seçip Oyuna Öyle Başlayınız." Visible="False"></asp:Label>
                        </div>
                    </div>
                    <div class="col-md-2 timerdiv" style="height:80px;">
                        <div class="icerik">
                               <asp:Label class="timerlabel" ID="Label2" runat="server" Text="Süre"></asp:Label><br />
                               <asp:Label class="timerlabel" ID="Label1" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
                <asp:ListBox ID="ListBox2" runat="server" Height="27px" Visible="False"></asp:ListBox>
                <asp:ListBox ID="ListBox3" runat="server" Width="74px" Visible="False"></asp:ListBox>
                <div style="position:relative">
                    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
                <div>
                    <asp:Button style="background-color:rgb(0, 255, 33); font-size:20px;" class="btn-1" ID="Button1" runat="server" OnClick="Button1_Click" Text=" Sonucu Kontrol Et" />
                </div>
                    <asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox>
</asp:Content>

