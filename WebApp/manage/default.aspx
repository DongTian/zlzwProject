<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApp.manage._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后台管理</title>
    <link href="css/default.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <ext:PageManager ID="PageManager1" Theme="Gray" AutoSizePanelID="RegionPanel1" runat="server">
    </ext:PageManager>
    <ext:RegionPanel ID="RegionPanel1" ShowBorder="false" runat="server">
        <Regions>
            <ext:Region ID="Region1" Margins="0 0 0 0" Height="62px" ShowBorder="false" ShowHeader="false"
                Position="Top" Layout="Fit" runat="server">
                <Toolbars>
                    <ext:Toolbar ID="Toolbar1" Position="Bottom" runat="server">
                        <Items>
                            <ext:Button ID="btnExpandAll" IconUrl="images/expand-all.gif" Text="展开全部" EnablePostBack="false"
                                runat="server">
                            </ext:Button>
                            <ext:Button ID="btnCollapseAll" IconUrl="images/collapse-all.gif" Text="折叠全部" EnablePostBack="false"
                                runat="server">
                            </ext:Button>
                            <ext:ToolbarFill ID="ToolbarFill1" runat="server">
                            </ext:ToolbarFill>
                        </Items>
                    </ext:Toolbar>
                </Toolbars>
                <Items>
                    <ext:ContentPanel ShowBorder="false" CssClass="header" ShowHeader="false" BodyStyle="background-color:#1C3E7E;"
                        ID="ContentPanel1" runat="server">
                        <div class="title">
                            <a href="./default.aspx" style="color:#fff;">后台管理模板</a>
                        </div>
						<div class="version">
                            <a href="#" target="_blank" style="color:#fff;">版本1.0</a>
                        </div>
                    </ext:ContentPanel>
                </Items>
            </ext:Region>
            <ext:Region ID="Region2" Split="true" EnableSplitTip="true" CollapseMode="Mini" Width="200px"
                Margins="0 0 0 0" ShowHeader="true" Title="菜单管理" EnableLargeHeader="false" Icon="Outline"
                EnableCollapse="true" Layout="Fit" Position="Left" runat="server">
            </ext:Region>
            <ext:Region ID="mainRegion" ShowHeader="false" Layout="Fit" Margins="0 0 0 0" Position="Center"
                runat="server">
                <Items>
                    <ext:TabStrip ID="mainTabStrip" EnableTabCloseMenu="true" ShowBorder="false" runat="server">
                        <Tabs>
                            <%--<ext:Tab Title="用户管理" Layout="Fit" Icon="UserHome" runat="server">
                                <Toolbars>
                                    <ext:Toolbar runat="server">
                                        <Items>
                                            <ext:Button ID="btnAdd" runat="server" Text="添加管理员" Icon="Add"></ext:Button>
                                        </Items>
                                    </ext:Toolbar>
                                </Toolbars>
                                <Items>
                                    <ext:Grid ID="grid1" Title="表格" PageSize="4" ShowBorder="true" ShowHeader="true"
                                        AutoHeight="true" AllowPaging="true" runat="server" EnableCheckBoxSelect="True"
                                        Width="800px" DataKeyNames="AdminID" OnPageIndexChange="Grid1_PageIndexChange"
                                        EnableRowNumber="True" IsDatabasePaging="false" PageIndex="0" AutoPostBack="True">
                                        <Columns>
                                            <ext:BoundField Width="100px" DataField="adminname" HeaderText="账号" />
                                            <ext:BoundField Width="150px" DataField="adminpassword" HeaderText="密码" />
                                            <ext:CheckBoxField Width="60px" RenderAsStaticField="true" DataField="isenable" HeaderText="是否可用" />
                                            <ext:BoundField Width="100px" DataField="publishdate" HeaderText="发布日期" />
                                        </Columns>
                                    </ext:Grid>
                                </Items>
                            </ext:Tab>--%>
                        </Tabs>
                    </ext:TabStrip>
                </Items>
            </ext:Region>
        </Regions>
    </ext:RegionPanel>
    <ext:Window ID="windowSourceCode" Icon="PageWhiteCode" Title="源代码" Popup="false"
        EnableIFrame="true" runat="server" IsModal="true" Width="900px" Height="550px"
        EnableClose="true" EnableMaximize="true" EnableResize="true">
    </ext:Window>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="menu.xml"></asp:XmlDataSource>
    </form>
    <img src="images/logo/zlzwlogo.png" alt="职来职往" id="logo" />

    <script src="js/default.js" type="text/javascript"></script>
</body>
</html>
