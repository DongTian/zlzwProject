<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddVentureStar.aspx.cs" Inherits="WebApp.manage.admin.AddVentureStar" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

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
                    <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的创业明星　" runat="server">
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
                            <ext:TextBox ID="txbVentureStarName" runat="server" Label="姓名" EmptyText="创业明星的姓名" Required="true"
                            RequiredMessage="姓名不能为空"></ext:TextBox>
                            <ext:FileUpload ID="btnImageUpload" runat="server" Label="创业明星图片" EmptyText="请选择一张尺寸为166 * 55的创业明星图片"></ext:FileUpload>
                            <ext:ContentPanel ID="ContentPanel1" runat="server" Width="695px" Height="280px" BodyPadding="1px"
                                EnableBackgroundColor="true" ShowBorder="true" ShowHeader="true" Title="介绍">
                                <FCKeditorV2:FCKeditor ID="FCKeditor1" BasePath="../fckeditor/" runat="server" Height="400px">
                                </FCKeditorV2:FCKeditor>
                            </ext:ContentPanel>
                        </Items>
                    </ext:SimpleForm>
                </Items>
            </ext:Panel>
        </Items>
    </ext:Panel>
    </form>
</body>
</html>
