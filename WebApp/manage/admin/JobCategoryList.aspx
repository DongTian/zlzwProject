<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobCategoryList.aspx.cs" Inherits="WebApp.manage.admin.JobCategoryList" %>

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
                    <ext:Button ID="btnAdd" runat="server" Text="添加岗位分类" Icon="Add">
                    </ext:Button>
                    <ext:ToolbarSeparator ID="ToolbarSeparator1" runat="server"></ext:ToolbarSeparator>
                    <ext:Button ID="btnDel" runat="server" Text="删除岗位分类" Icon="BulletCross" OnClick="btnDel_Click"></ext:Button>
                </Items>
            </ext:Toolbar>
        </Toolbars>
        <Items>
            <ext:Grid ID="grid1" PageSize="15" ShowBorder="true" ShowHeader="false"
                AutoHeight="true" AllowPaging="true" runat="server" EnableCheckBoxSelect="True"
                Width="800px" DataKeyNames="JobCategoryGUID" OnPageIndexChange="Grid1_PageIndexChange"
                EnableRowNumber="True" IsDatabasePaging="true" 
                OnRowDataBound="Grid1_RowDataBound" ForceFitAllTime="true" AutoPostBack="False">
                <Columns>
                    <ext:BoundField Width="200px" DataField="JobCategoryName" HeaderText="岗位分类名称" TextAlign="Center" />
                    <ext:CheckBoxField Width="60px" RenderAsStaticField="true" DataField="IsHot" HeaderText="热门岗位分类" TextAlign="Center" />
                    <ext:BoundField Width="150px" DataField="PublishDate" HeaderText="发布日期" TextAlign="Center"  DataFormatString="{0:yyyy年MM月dd日}" />
                    <ext:TemplateField HeaderText="编辑操作" TextAlign="Center">
                        <ItemTemplate>
                            <a style="text-decoration:none;" href="<%# GetEditUrl(DataBinder.Eval(Container.DataItem, "[JobCategoryGUID]")) %>">编辑</a>
                        </ItemTemplate>
                    </ext:TemplateField>
                </Columns>
            </ext:Grid>
        </Items>
    </ext:Panel>
    <ext:Window ID="Window1" Title="Edit" Popup="false" EnableIFrame="true" runat="server"
        IFrameUrl="about:blank" Target="Self" IsModal="True" Width="550px" Height="250px">
    </ext:Window>
    </form>
</body>
</html>
