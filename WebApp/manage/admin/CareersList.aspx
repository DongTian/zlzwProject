<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CareersList.aspx.cs" Inherits="WebApp.manage.admin.CareersList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <ext:PageManager ID="PageManager1" Theme="Gray" AutoSizePanelID="Panel1" runat="server">
    </ext:PageManager>
    <ext:Panel ID="Panel1" runat="server" Layout="Fit" ShowBorder="False" ShowHeader="false"
        BodyPadding="5px" EnableBackgroundColor="true">
        <Toolbars>
            <ext:Toolbar ID="Toolbar2" runat="server">
                <Items>
                    <ext:Button ID="btnAdd" runat="server" Text="添加诚聘英才" Icon="Add">
                    </ext:Button>
                    <ext:ToolbarSeparator ID="ToolbarSeparator1" runat="server"></ext:ToolbarSeparator>
                    <ext:Button ID="btnDel" runat="server" Text="删除诚聘英才" Icon="BulletCross" OnClick="btnDel_Click"></ext:Button>
                </Items>
            </ext:Toolbar>
        </Toolbars>
        <Items>
            <ext:Grid ID="grid1" PageSize="15" ShowBorder="true" ShowHeader="false"
                AutoHeight="true" AllowPaging="true" runat="server" EnableCheckBoxSelect="True"
                Width="800px" DataKeyNames="CareersGUID" OnPageIndexChange="Grid1_PageIndexChange"
                EnableRowNumber="True" IsDatabasePaging="true" 
                OnRowDataBound="Grid1_RowDataBound" ForceFitAllTime="true">
                <Columns>
                    <ext:BoundField Width="100px" DataField="DictionaryKey" HeaderText="所属门店" TextAlign="Center" />
                    <ext:BoundField Width="100px" DataField="DepartmentName" HeaderText="招聘部门" TextAlign="Center" />
                    <ext:BoundField Width="150px" DataField="CareersTitle" HeaderText="职位名称" TextAlign="Center" />
                    <ext:BoundField Width="50px" DataField="CareersCount" HeaderText="招聘人数" TextAlign="Center" />
                    <ext:BoundField Width="50px" DataField="Salary" HeaderText="月薪" TextAlign="Center" />
                    <ext:CheckBoxField Width="60px" RenderAsStaticField="true" DataField="IsHot" HeaderText="热门职位" TextAlign="Center" />
                    <ext:BoundField Width="150px" DataField="publishdate" HeaderText="发布日期" TextAlign="Center" DataFormatString="{0:yyyy年MM月dd日}" />
                    <ext:TemplateField HeaderText="编辑操作" TextAlign="Center">
                        <ItemTemplate>
                            <a style="text-decoration:none;" href="<%# GetEditUrl(DataBinder.Eval(Container.DataItem, "[CareersGUID]")) %>">编辑</a>
                        </ItemTemplate>
                    </ext:TemplateField>
                </Columns>
            </ext:Grid>
        </Items>
    </ext:Panel>
    <ext:Window ID="Window1" Title="Edit" Popup="false" EnableIFrame="true" runat="server"
        IFrameUrl="about:blank" Target="Self" IsModal="True" Width="750px" Height="520px">
    </ext:Window>
    </form>
</body>
</html>
