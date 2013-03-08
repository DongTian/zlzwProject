<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStorefrontElegance.aspx.cs" Inherits="WebApp.manage.admin.AddStoreStatistics" %>

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
                    <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的店面风彩　" runat="server">
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
                            <ext:DropDownList ID="drpRegionList" runat="server" Label="所属区域" OnSelectedIndexChanged="drpRegionList_SelectedIndexChanged" EnableAjax="true" AutoPostBack="true"></ext:DropDownList>
                            <ext:DropDownList ID="drpStorefrontEleganceType" runat="server" Label="所属店面" OnSelectedIndexChanged="drpStorefrontEleganceType_SelectedIndexChanged" EnableAjax="true" AutoPostBack="true"></ext:DropDownList>
                            <ext:TextBox ID="txbStorefrontEleganceTitle" runat="server" Label="店面名称" EmptyText="店面名称" Required="true"
                            RequiredMessage="店面名称不能为空"></ext:TextBox>
                            <ext:TextArea ID="txbStorefrontEleganceDescription" runat="server" Label="店面简介介绍" Required="true" RequiredMessage="店面简介不能为空"></ext:TextArea>
                            <ext:TextBox ID="txbPushJobs" runat="server" Label="主推岗位" Required="true" EmptyText="店面主推岗位" RequiredMessage="主推岗位不能为空"></ext:TextBox>
                            <ext:FileUpload ID="btnStorefrontEleganceHeadImage" runat="server" Label="店面介绍图片" EmptyText="请选择一张尺寸为166 * 55的图片"></ext:FileUpload>
                        </Items>
                    </ext:SimpleForm>
                </Items>
            </ext:Panel>
        </Items>
    </ext:Panel>
    </form>
</body>
</html>
