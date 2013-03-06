<%@ Page Language="C#" MasterPageFile="Franchising.Master" AutoEventWireup="true" CodeBehind="StoreStatisticsList.aspx.cs" Inherits="WebApp.Franchising.StoreStatisticsList" Title="校企英才官网-店面评比" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Resources/css/DefaultStyle.css" rel="stylesheet" type="text/css" />
    <link href="../Resources/css/TableStyle.css" rel="stylesheet" type="text/css" />
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
    <ext:PageManager ID="PageManager1" runat="server" EnableAjax="false" EnablePageLoading="true" AutoSizePanelID="Panel1" Theme="Gray" />
    <div class="content">
        <div class="main">
            <div class="banner2">
                <a href="../guideenterprises.aspx" target="_blank"><img style="border:0px;" src="../Resources/images/banner1.jpg" width="1000" height="100" /></a>
            </div>
            <div class="bar">
                <b>店面评比</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">店面评比</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a style='text-decoration:none;' href="ProjectDescription.aspx"><dt class="original1">项目介绍</dt></a>
                        <%--<dd>
                            <a href="ProjectDescription.aspx">项目介绍</a>
                        </dd>--%>
                        <dt class="original1">投资分析</dt>
                        <dd>
                            <a href="InvestmentAnalysis.aspx">投资分析</a>
                            <a href="IndustryAnalysis.aspx" class="h_hover2">行业分析</a>
                        </dd>
                        <dt class="original1">加盟流程</dt>
                        <dd>
                            <a href="JoiningProcess.aspx">加盟流程</a>
                            <a href="JoinConditions.aspx">加盟条件</a>
                            <a href="RightsAndObligations.aspx">权利和义务</a>
                        </dd>
                        <a style='text-decoration:none;' href="VentureStarList.aspx"><dt class="original1">创业明星</dt></a>
                        <%--<dd>
                            <a href="VentureStarList.aspx">创业明星</a>
                        </dd>--%>
                        <a style='text-decoration:none;' href="StorefrontEleganceList.aspx"><dt class="original1">店面风采</dt></a>
                        <%--<dd>
                            <a href="StorefrontEleganceList.aspx">店面风采</a>
                        </dd>--%>
                        <a style='text-decoration:none;' href="StoreStatisticsList.aspx"><dt class="expand1" style="color:#314777;">店面评比</dt></a>
                        <dd style="display:block;">
                            <asp:Label ID="labMenuList" runat="server"></asp:Label>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right11" style="font-size:14px; line-height:25px;">
                <table style="width:70%; padding-left:25px;">
                    <tr>
                        <td align="right">
                            　日期查询：
                        </td>
                        <td align="left">
                            <ext:DatePicker ID="txbDate" runat="server" Width="250px"></ext:DatePicker>
                        </td>
                        <td align="left">
                            <ext:Button ID="btnUpdte" runat="server" Text="查询" Icon="zoom" 
                                onclick="btnUpdte_Click"></ext:Button>
                        </td>
                    </tr>
                </table>
                <asp:Repeater ID="Repeater1" runat="server" 
                    onitemdatabound="Repeater1_ItemDataBound">
                    <HeaderTemplate>
                        <table id="hor-zebra" summary="Employee Pay Sheet" style="width:100%; font-size:14px;padding-left:10px;">
                            <thead>
    	                        <tr class="odd">
    	                            <th scope="col" style="width:25%; font-weight:bold;">评比指标</th>
        	                        <th scope="col" style="width:25%; font-weight:bold;">排名</th>
                                    <th scope="col" style="width:25%; font-weight:bold;">店面名称</th>
                                    <th scope="col" style="width:25%; font-weight:bold;">评比日期</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                                <asp:Label ID="labPingBi" runat="server"></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                            </tbody>
                        </table>
                    </FooterTemplate>
                    <SeparatorTemplate>
                    </SeparatorTemplate>
                </asp:Repeater>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
