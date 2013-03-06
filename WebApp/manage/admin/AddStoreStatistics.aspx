<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStoreStatistics.aspx.cs" Inherits="WebApp.manage.admin.AddStoreStatistics1" %>

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
                    <ext:ToolbarText ID="ToolbarText2" Text="添加一个新的评比指标　" runat="server">
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
                            <ext:DropDownList ID="drpStoreDictionaryKey" runat="server" Label="所属门店"></ext:DropDownList>
                            <ext:DropDownList ID="drpDictionaryKey" runat="server" Label="所属指标"></ext:DropDownList>
                            <ext:DatePicker ID="txbStoreStatisticsDate" runat="server" Label="评比日期"></ext:DatePicker>
                            <ext:TextBox ID="txbIndexValue" runat="server" Label="指标数值" Required="true" RequiredMessage="指标数值不能为空"></ext:TextBox>
                            <ext:TextBox ID="txbStoreStatisticsOrder" runat="server" Label="排名" Required="true" RequiredMessage="排名不能为空" RegexPattern="NUMBER" RegexMessage="排名必须为正整数"></ext:TextBox>                            
                        </Items>
                    </ext:SimpleForm>
                </Items>
            </ext:Panel>
        </Items>
    </ext:Panel>
    </form>
</body>
</html>
