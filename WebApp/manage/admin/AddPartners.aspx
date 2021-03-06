﻿<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="AddPartners.aspx.cs" Inherits="WebApp.manage.admin.AddPartners" %>

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
                    <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的合作伙伴　" runat="server">
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
                            <ext:TextBox ID="txbPartnersName" runat="server" Label="合作伙伴名称" EmptyText="合作伙伴名称" Required="true"
                            RequiredMessage="合作伙伴名称不能为空"></ext:TextBox>
                            <ext:FileUpload ID="btnImageUpload" runat="server" Label="企业Logo上传" EmptyText="请选择一张尺寸为135*70的企业Logo"></ext:FileUpload>
                            <ext:FileUpload ID="btnBannerUpload" runat="server" Label="企业Banner上传" EmptyText="请选择一张宽度为1024px的企业Banner"></ext:FileUpload>
                            <ext:CheckBox ID="ckbIsHot" runat="server" Label="热门企业" Checked="false"></ext:CheckBox>
                            <ext:TextBox ID="txbJobContactAdd" runat="server" Label="公司地址" EmptyText="职位联系方式-公司地址" Required="true" RequiredMessage="公司联系地址不能为空"></ext:TextBox>
                            <ext:TextBox ID="txbJobContactPhone" runat="server" Label="联系电话" EmptyText="职位联系方式-联系电话" Required="true" RequiredMessage="联系电话不能为空"></ext:TextBox>
                            <ext:TextBox ID="txbJobContactName" runat="server" Label="联系人" EmptyText="职位联系方式-联系人" Required="true" RequiredMessage="联系人不能为空"></ext:TextBox>
                            <ext:HtmlEditor ID="txbPartner" Label="合作伙伴介绍" runat="server" Height="250px"></ext:HtmlEditor>
                            <ext:Image ID="imgUploadLogo" runat="server" Label="企业Logo" Visible="false"></ext:Image>
                            <ext:Image ID="imgUploadBanner" runat="server" Label="企业Banner" Visible="false"></ext:Image>
                        </Items>
                    </ext:SimpleForm>
                </Items>
            </ext:Panel>
        </Items>
    </ext:Panel>
    </form>
</body>
</html>