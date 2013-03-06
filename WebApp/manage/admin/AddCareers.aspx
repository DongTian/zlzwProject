<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="AddCareers.aspx.cs" Inherits="WebApp.manage.admin.AddCareers" %>

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
                    <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的职位　" runat="server">
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
                            <ext:DropDownList ID="drpStoreType" runat="server" Label="所属门店"></ext:DropDownList>
                            <ext:TextBox ID="txbDepartmentName" runat="server" Label="招聘部门" EmptyText="招聘部门" Required="true" RequiredMessage="招聘部门不能为空"></ext:TextBox>
                            <ext:TextBox ID="txbCareersTitle" runat="server" Label="职位名称" EmptyText="职位名称" Required="true" RequiredMessage="职位名称不能为空"></ext:TextBox>
                            <ext:TextBox ID="txbCareersCount" runat="server" Label="招聘人数" EmptyText="招聘人数" Required="true" RequiredMessage="招聘人数不能为空" RegexPattern="NUMBER" RegexMessage="招聘人数格式错误"></ext:TextBox>
                            <ext:TextBox ID="txbWorkAdd" runat="server" Label="工作地址" EmptyText="工作所在地" Required="true" RequiredMessage="工作所在地不能为空"></ext:TextBox>
                            <ext:TextBox ID="txbEducational" runat="server" Label="学历要求" EmptyText="专科、本科、研究生" Required="true" RequiredMessage="学历要求不能为空" />
                            <ext:TextBox ID="txbSalary" runat="server" Label="月薪" EmptyText="月薪、面议" Required="true" RequiredMessage="月薪不能为空"></ext:TextBox>
                            <ext:TextBox ID="txbWorkExperience" runat="server" EmptyText="工作经验要求" Label="工作经验" Required="true" RequiredMessage="工作经验不能为空"></ext:TextBox>
                            <ext:TextBox ID="txbEmail" runat="server" Label="联系信箱" EmptyText="求职者联系的电子邮件地址" Required="true" RequiredMessage="联系信箱不能为空" RegexMessage="联系信箱格式错误" RegexPattern="EMAIL"></ext:TextBox>
                            <ext:TextBox ID="txbTel" runat="server" Label="联系电话" EmptyText="联系电话" Required="true" RequiredMessage="联系电话不能为空"></ext:TextBox>
                            <ext:TextBox ID="txbContactMan" runat="server" Label="联系人" EmptyText="联系人姓名" Required="true" RequiredMessage="联系人不能为空"></ext:TextBox>
                            <ext:CheckBox ID="ckbIsHot" runat="server" Label="热门职位"></ext:CheckBox>
                            <ext:HtmlEditor ID="txbResponsibilities" runat="server" Label="岗位职责" Height="150"></ext:HtmlEditor>
                            <ext:HtmlEditor ID="txbQualifications" runat="server" Label="任职资格" Height="150"></ext:HtmlEditor>
                        </Items>
                    </ext:SimpleForm>
                </Items>
            </ext:Panel>
        </Items>
    </ext:Panel>
    </form>
</body>
</html>
