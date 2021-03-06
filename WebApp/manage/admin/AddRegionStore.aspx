﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRegionStore.aspx.cs" Inherits="WebApp.manage.admin.AddRegionStore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
                        <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的区域　" runat="server">
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
                                <ext:TextBox ID="txbNewsTypeName" runat="server" Label="所属区域" EmptyText="门店所属地区名称" Required="true"
                                    RequiredMessage="门店所属区域名称不能为空">
                                </ext:TextBox>
                                <ext:TextBox ID="txbNewsTypeIndex" runat="server" Label="区域索引" EmptyText="建议使用门店名称的中文全拼" Required="true" RequiredMessage="所属区域索引不能为空"></ext:TextBox>
                                <ext:TextBox ID="txbOrderNumber" runat="server" Label="排序" EmptyText="排序名次" Text="0"></ext:TextBox>
                                <ext:TextArea ID="txbDictionaryDesc" runat="server" Label="简介" EmptyText="区域简介" Required="false"></ext:TextArea>
                            </Items>
                        </ext:SimpleForm>
                    </Items>
                </ext:Panel>
            </Items>
        </ext:Panel>
    </form>
</body>
</html>
