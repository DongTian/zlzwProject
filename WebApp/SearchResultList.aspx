<%@ Page Language="C#" MasterPageFile="~/MasterPage/OnlineApplication.Master" AutoEventWireup="true" CodeBehind="SearchResultList.aspx.cs" Inherits="WebApp.SearchResultList" Title="校企英才官网-职位查询" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Resources/css/DefaultStyle.css" rel="stylesheet" type="text/css" />
    <script src="http://lib.sinaapp.com/js/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
    <script src="../Resources/js/tab.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function(){
            $('dt').hover(function(){
	            if($(this).hasClass('expand1')) return;
	            $(this).attr('class','focus1');
            },function(){
	            if($(this).hasClass('expand1')) return;
	            $(this).attr('class','original1');}
            );

            $('dt').click(function(){
	            if($(this).hasClass('expand1')){
		            $(this).next().hide();
		            $(this).attr('class','original1');;
		            return;
	            }
	            $('dd').hide();
	            $('dt').attr('class','original1');
	            $(this).attr('class','expand1');
	            $(this).next().show();
            });

        })
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="main">
            <div class="banner2">
                <a href="../guideenterprises.aspx" target="_blank"><img style="border:0px;" src="../Resources/images/banner1.jpg" width="1000" height="100" /></a>
            </div>
            <div class="bar">
                <b>职位查询</b>
                <span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">职位查询</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a href="OnlineApplication.aspx" style="text-decoration:none;color:#fff;">
                            <dt class="expand1" style="color:#314777;">招聘动态</dt>
                        </a>
                    </dl>
                </div>
            </div>
            <%--<div class="right1" >--%>
                <div class="right1 xinwen_nei2" style="font-size:14px; line-height:25px;">
                <ul>
                    <li style="vertical-align:top; display:none;">
                        <table style="width:100%;">
                            <tr>
                                <td style="width:20%;" align="center">
                                    城市选择：
                                </td>
                                <td style="width:45%;" align="left">
                                    <asp:DropDownList ID="drpSelectCity" style="width:150px;" runat="server" AutoPostBack="true" 
                                        onselectedindexchanged="drpSelectCity_SelectedIndexChanged1"></asp:DropDownList>
                                </td>
                                <td align="right" style="width:15%;">
                                    当前城市：
                                </td>
                                <td align="left" style="width:20%;color:#314777;font-size:16px; font-weight:bold;">
                                    <asp:Label ID="labCurrentCity" runat="server" Text="青岛"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </li>
                    <asp:Repeater ID="Repeater1" runat="server" onitemdatabound="Repeater1_ItemDataBound">
                        <ItemTemplate>
                            <li>
                                <div style="float:right;width:150px;"><asp:Label ID="labPublishDate" runat="server" CssClass="r hui" style="text-align:right;"></asp:Label></div>
                                <asp:Label ID="labJobTitle" runat="server" style="font-size:14px;"></asp:Label>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                    <table style="width:100%;">
                        <tr>
                            <td align="center">
                                <p>
                                    <asp:Label ID="labEmptyInfo" runat="server" Visible="false"  style="text-align:center;"><span style="font-size:16px; color:#314777;">暂无相关职位信息</span></asp:Label>
                                </p>
                            </td>
                        </tr>
                    </table>
                </ul>
                <div class="qie">
                    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="10" 
                        onpagechanged="AspNetPager1_PageChanged" CssClass="paginator" CurrentPageButtonClass="cpb" FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" >
                    </webdiyer:AspNetPager>
                </div>
            </div>
            <%--</div>--%>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
