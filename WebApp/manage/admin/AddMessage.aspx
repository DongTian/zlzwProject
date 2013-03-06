<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="AddMessage.aspx.cs" Inherits="WebApp.manage.admin.AddMessage" %>

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
                    <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的liuyan 　" runat="server">
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
                            <ext:TextBox ID="txbPublishUserName" runat="server" Label="发布者姓名" EmptyText="留言发布者姓名" Required="true"
                                RequiredMessage="留言发布者姓名不能为空">
                            </ext:TextBox>
                            <ext:TextArea ID="txbPublishContent" runat="server" Label="留言内容" EmptyText="留言内容" Required="true" RequiredMessage="留言内容不能为空"></ext:TextArea>
                            <ext:DatePicker ID="txbPublishDate" runat="server" Label="发布日期" Required="true" RequiredMessage="发布日期不能为空"></ext:DatePicker>
                            <ext:DropDownList ID="drpReplyUserGUID" runat="server" Label="回复人"></ext:DropDownList>
                            <ext:DatePicker ID="txbReplyDate" runat="server" Label="回复日期" Required="true" RequiredMessage="回复日期不能为空"></ext:DatePicker>
                            <ext:CheckBox ID="ckbIsReply" runat="server" Label="页面中显示"></ext:CheckBox>
                            <ext:HtmlEditor ID="txbReplyContent" runat="server" Label="回复内容"></ext:HtmlEditor>
                        </Items>
                    </ext:SimpleForm>
                </Items>
            </ext:Panel>
        </Items>
    </ext:Panel>
    </form>
</body>
</html>
