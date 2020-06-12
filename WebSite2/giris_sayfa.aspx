<%@ Page Language="C#" AutoEventWireup="true" CodeFile="giris_sayfa.aspx.cs" Inherits="giris_sayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        .bodycolor{
            background-color:#e4e4e4;
        }
        .anadiv{
            position:absolute;
            width:100%;
            min-height:100%;
            display:table;
        }
        .icerik {
        display: table-cell;
        vertical-align: middle;
        text-align: center;
        }
        .btn-1 {
        padding: 1px 24px;
        cursor: pointer;
        outline: none;
        color: #fff;
        background-color: #4CAF50;
        border: none;
        border-radius: 15px;
        box-shadow: 0 4px #bbb;
        }
        .btn-1:hover {
        background-color: #4CAF50;
        }
        .btn-1:active {
        background-color: #4CAF50;
        box-shadow: 0 3px #444;
        transform: translateY(3px);
        }
        
        .labelsekil{
            font-family:'Comic Sans MS';
            text-transform:uppercase;
            text-shadow: 5px 1px 5px black;
            font-weight:bold;
            font-size:large;
        }
        .textboxcss{
        
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
        }
    </style>
</head>
<body class="bodycolor">
    <form id="form1" runat="server">
        <div class="anadiv">
            <div class="icerik">
                <image src="resim/tapaicon.png" width="250px">
                    <br/>
                    <asp:Label class="alert alert-warning labelsekil" ID="Label3" runat="server" Text="Kullanıcı Adı veya Şifre Yanlış." Visible="False"></asp:Label>
                    <br/>
                    <br/>
                <asp:Label class="labelsekil" ID="Label1" runat="server" Text="Kullanıcı Adı"></asp:Label>
                    <br/>
                <asp:TextBox class="textboxcss" placeholder="Kullanıcı Adınızı Giriniz..." ID="TextBox1" runat="server"></asp:TextBox>
                    <br/>
                <asp:Label class="labelsekil" ID="Label2" runat="server" Text="Şifre"></asp:Label>
                    <br/>
                <asp:TextBox class="textboxcss" placeholder="Şifrenizi Giriniz..." ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    <br/>
                    <br/>
                <asp:Button class="btn-1" style="font-size:large" ID="Button1" runat="server" Text="Giriş Yap" OnClick="Button1_Click" />
            </div> 
        </div>
    </form>
</body>
</html>
