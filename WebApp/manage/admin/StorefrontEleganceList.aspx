<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StorefrontEleganceList.aspx.cs" Inherits="WebApp.manage.admin.StoreStatisticsList" %>

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
                    <ext:Button ID="btnAdd" runat="server" Text="添加店面风采" Icon="Add">
                    </ext:Button>
                    <ext:ToolbarSeparator ID="ToolbarSeparator1" runat="server"></ext:ToolbarSeparator>
                    <ext:Button ID="btnDel" runat="server" Text="删除店面风采" Icon="BulletCross" OnClick="btnDel_Click"></ext:Button>
                </Items>
            </ext:Toolbar>
        </Toolbars>
        <Items>
            <ext:Grid ID="grid1" PageSize="15" ShowBorder="true" ShowHeader="false"
                AutoHeight="true" AllowPaging="true" runat="server" EnableCheckBoxSelect="True"
                Width="800px" DataKeyNames="StorefrontEleganceGUID" OnPageIndexChange="Grid1_PageIndexChange"
                EnableRowNumber="True" IsDatabasePaging="true" 
                OnRowDataBound="Grid1_RowDataBound" ForceFitAllTime="true">
                <Columns>
                    <ext:BoundField Width="150px" DataField="DictionaryKey" HeaderText="所属店面" TextAlign="Center"/>
                    <ext:BoundField Width="150px" DataField="StorefrontEleganceTitle" HeaderText="店面名称" TextAlign="Center" DataToolTipField="StorefrontEleganceTitle" />
                    <ext:BoundField Width="200px" DataField="StorefrontEleganceDescription" HeaderText="店面简介" TextAlign="Center" DataToolTipField="StorefrontEleganceDescription" />
                    <ext:BoundField Width="150px" DataField="PushJobs" HeaderText="主推岗位" TextAlign="Center" DataToolTipField="PushJobs" />
                    <ext:BoundField Width="150px" DataField="publishdate" HeaderText="发布日期" TextAlign="Center" DataFormatString="{0:yyyy年MM月dd日}" />
                    <ext:TemplateField HeaderText="编辑操作" TextAlign="Center">
                        <ItemTemplate>
                            <a style="text-decoration:none;" href="<%# GetEditUrl(DataBinder.Eval(Container.DataItem, "[StorefrontEleganceGUID]")) %>">编辑</a>
                        </ItemTemplate>
                    </ext:TemplateField>
                </Columns>
            </ext:Grid>
        </Items>
    </ext:Panel>
    <ext:Window ID="Window1" Title="Edit" Popup="false" EnableIFrame="true" runat="server"
        IFrameUrl="about:blank" Target="Self" IsModal="True" Width="750px" Height="450px">
    </ext:Window>
    </form>
</body>
</html>
