<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJobCategoryList.aspx.cs" Inherits="WebApp.manage.admin.AddJobCategoryList" %>

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
                        <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的岗位类型　" runat="server">
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
                                <ext:TextBox ID="txbJobCategoryName" runat="server" Label="岗位类型名称" EmptyText="岗位类型名称" Required="true"
                                    RequiredMessage="岗位类型名称不能为空">
                                </ext:TextBox>
                                <ext:CheckBox ID="ckbIsHot" runat="server" Label="热门岗位"></ext:CheckBox>
                            </Items>
                        </ext:SimpleForm>
                    </Items>
                </ext:Panel>
            </Items>
        </ext:Panel>
    </form>
</body>
</html>
