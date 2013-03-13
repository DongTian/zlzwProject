<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.manage.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>校企英才后台管理后台登陆</title>
    <link href="css/main.css" rel="stylesheet" type="text/css" />
    
</head>
<body>
    <form id="form1" runat="server">
    <ext:PageManager id="PageManager1" runat="server" Theme="Gray" />
    <ext:window id="Window1" runat="server" title="用户登录" ismodal="false" enableclose="false"
        windowposition="GoldenSection" width="350px">
        <Items>
            <ext:SimpleForm ID="SimpleForm1" runat="server" ShowBorder="false" BodyPadding="10px"
                LabelWidth="60px" EnableBackgroundColor="true" ShowHeader="false">
                <Items>
                    <ext:TextBox ID="txbUserName" Label="账号" Required="true" runat="server">
                    </ext:TextBox>
                    <ext:TextBox ID="txbPassword" Label="密码" TextMode="Password" Required="true" runat="server">
                    </ext:TextBox>
                    <ext:Image ID="imgCaptcha" runat="server" ShowEmptyLabel="true" ImageUrl="Captcha/captcha.ashx?w=231&h=30">
                    </ext:Image>
                    <ext:TextBox ID="txbCaptcha" Label="验证码" Required="true" runat="server">
                    </ext:TextBox>
                    <ext:Button ID="btnLogin" Text="登录" Type="Submit" ValidateForms="SimpleForm1" ValidateTarget="Top"
                        runat="server" OnClick="btnLogin_Click">
                    </ext:Button>
                </Items>
            </ext:SimpleForm>
        </Items>
    </ext:window>
    </form>
</body>
</html>
