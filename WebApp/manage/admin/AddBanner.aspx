<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBanner.aspx.cs" Inherits="WebApp.manage.admin.AddBanner" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" Theme="Gray" />
        <ext:Panel ID="Panel1" runat="server" Layout="Fit" ShowBorder="False" ShowHeader="false"
        BodyPadding="5px" EnableBackgroundColor="true" AutoHeight="true">
        <Toolbars>
            <ext:Toolbar ID="Toolbar1" runat="server">
                <Items>
                    <ext:Button ID="btnClose" EnablePostBack="false" Text="关闭" runat="server" Icon="BulletCross">
                    </ext:Button>
                    <ext:Button ID="btnSaveRefresh" Text="保存" ValidateForms="SimpleForm1" runat="server"
                        Icon="Accept" OnClick="btnSaveRefresh_Click">
                    </ext:Button>
                    <ext:ToolbarFill ID="ToolbarFill1" runat="server">
                    </ext:ToolbarFill>
                    <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的焦点图　" runat="server">
                    </ext:ToolbarText>
                </Items>
            </ext:Toolbar>
        </Toolbars>
        <Items>
            <ext:Panel ID="Panel2" Layout="Fit" runat="server" ShowBorder="false" ShowHeader="false" Height="450px">
                <Items>
                    <ext:SimpleForm ID="SimpleForm1" ShowBorder="true" ShowHeader="false" EnableLightBackgroundColor="true"
                        AutoScroll="true" BodyPadding="5px" runat="server" EnableCollapse="True">
                        <Items>
                            <ext:TextBox ID="txbBannerTitle" runat="server" Label="焦点图名称" EmptyText="焦点图名称" Required="false"></ext:TextBox>
                            <ext:TextBox ID="txbBannerContent" runat="server" Label="焦点图简介"  Required="false"></ext:TextBox>
                            <ext:FileUpload ID="btnBannerUpload" runat="server" Label="焦点图上传" EmptyText="焦点图宽度为1000px"></ext:FileUpload>
                            <ext:TextBox ID="txbBannerLinks" runat="server" Label="链接地址" Text="http://" Required="true" RegexMessage="链接地址不能为空" ></ext:TextBox>
                            <ext:CheckBox ID="ckbIsHot" runat="server" Label="热门焦点图"></ext:CheckBox>
                        </Items>
                    </ext:SimpleForm>
                </Items>
            </ext:Panel>
        </Items>
    </ext:Panel>
    </form>
</body>
</html>
