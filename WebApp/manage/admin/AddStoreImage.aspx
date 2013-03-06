<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStoreImage.aspx.cs" Inherits="WebApp.manage.admin.AddStoreImage" %>

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
                    <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的店面展示图片　" runat="server">
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
                            <ext:DropDownList ID="drpStoreType" runat="server" Label="所属店面"></ext:DropDownList>
                            <ext:TextBox ID="txbStoreImageTitle" runat="server" Label="店面图片名称" EmptyText="店面展示图片名称" Required="true"
                            RequiredMessage="店面展示图片名称不能为空"></ext:TextBox>
                            <ext:TextArea ID="txbStoreImageDesc" runat="server" Label="店面图片介绍"></ext:TextArea>
                            <ext:FileUpload ID="btnStoreImageUpload" runat="server" Label="店面图片上传" EmptyText="请选择一张尺寸为166 * 55的企业Logo"></ext:FileUpload>
                            <ext:Image ID="imgUploadLogo" runat="server" Label="企业Logo" Visible="false"></ext:Image>
                        </Items>
                    </ext:SimpleForm>
                </Items>
            </ext:Panel>
        </Items>
    </ext:Panel>
    </form>
</body>
</html>
