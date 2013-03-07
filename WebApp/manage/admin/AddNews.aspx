<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="AddNews.aspx.cs" Inherits="WebApp.manage.admin.AddNews" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
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
                    <ext:ToolbarText ID="ToolbarText2" Text="添加新闻　" runat="server">
                    </ext:ToolbarText>
                </Items>
            </ext:Toolbar>
        </Toolbars>
        <Items>
            <ext:Panel ID="Panel2" Layout="Fit" runat="server" ShowBorder="false" ShowHeader="false"
                Height="450px">
                <Items>
                    <ext:SimpleForm ID="SimpleForm1" ShowBorder="true" ShowHeader="false" EnableLightBackgroundColor="true"
                        AutoScroll="true" BodyPadding="5px" runat="server" EnableCollapse="True">
                        <Items>
                            <ext:Label ID="labPublishID" runat="server" Label="发布人"></ext:Label>
                            <ext:TextBox ID="txbNewsTitle" runat="server" Label="新闻标题" EmptyText="新闻标题" Required="true"
                                RequiredMessage="新闻标题不能为空">
                            </ext:TextBox>
                            <ext:DropDownList ID="drpNewsType" runat="server" Label="新闻类型"></ext:DropDownList>
                            <ext:TextArea ID="txbNewsSummary" runat="server" Label="新闻简介" Required="true" RegexMessage="新闻简介不能为空"></ext:TextArea>
                            <ext:CheckBox ID="ckbIsHot" runat="server" Label="热门新闻"></ext:CheckBox>
                            <ext:ContentPanel ID="ContentPanel1" runat="server" Width="610px" BodyPadding="1px"
                                EnableBackgroundColor="true" ShowBorder="true" ShowHeader="true" Title="新闻正文">
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
