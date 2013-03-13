<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddLinkList.aspx.cs" Inherits="WebApp.manage.admin.AddLinkList" %>

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
                        <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的友情链接　" runat="server">
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
                                <ext:DropDownList ID="drpLinkType" EnableAjax="true" runat="server" AutoPostBack="true" Label="友情链接类型" 
                                    OnSelectedIndexChanged="drpLinkType_SelectedIndexChanged">
                                    <ext:ListItem Text="图片" Value="0" />
                                    <ext:ListItem Text="文字" Value="1" />
                                </ext:DropDownList>
                                <ext:TextBox ID="txbLinkTitle" runat="server" Label="友情链接名称" EmptyText="友情链接名称" Required="true"
                                    RequiredMessage="友情链接名称不能为空">
                                </ext:TextBox>
                                <ext:TextBox ID="txbLinkTarget" runat="server" Label="链接地址" EmptyText="友情链接链接地址" Required="true" RequiredMessage="友情链接链接地址不能为空"></ext:TextBox>
                                <ext:FileUpload ID="btnImageUpload" runat="server" Label="图片Logo" EmptyText="友情链接图片尺寸为135*70"></ext:FileUpload>
                                <ext:Image ID="imgLinkImage" runat="server" Label="链接Logo" Visible="false"></ext:Image>
                                <ext:TextBox ID="txbSort" runat="server" Label="排序" EmptyText="排序字段" Required="true" RequiredMessage="排序字段不能为空" RegexPattern="ALPHA_NUMERIC" RegexMessage="排序字段只能为正整数"></ext:TextBox>
                                <ext:TextArea ID="txbLinkDesc" runat="server" Label="简介" EmptyText="链接简介" Required="false"></ext:TextArea>
                            </Items>
                        </ext:SimpleForm>
                    </Items>
                </ext:Panel>
            </Items>
        </ext:Panel>
    </form>
</body>
</html>
