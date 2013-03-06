<%@ Page Language="C#" MasterPageFile="~/Franchising/Franchising.Master" AutoEventWireup="true" CodeBehind="VentureStarList.aspx.cs" Inherits="WebApp.Franchising.VentureStarList1" Title="校企英才官网-创业明星" %>
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
                <b>创业明星</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">创业明星</a></span>
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
                        <a style='text-decoration:none;' href="VentureStarList.aspx"><dt class="expand1" style="color:#314777;">创业明星</dt></a>
                        <%--<dd>
                            <a href="VentureStarList.aspx">创业明星</a>
                        </dd>--%>
                        <a style='text-decoration:none;' href="StorefrontEleganceList.aspx"><dt class="original1">店面风采</dt></a>
                        <%--<dd>
                            <a href="StorefrontEleganceList.aspx">店面风采</a>
                        </dd>--%>
                        <dt class="original1">店面评比</dt>
                        <dd>
                            <asp:Label ID="labMenuList" runat="server"></asp:Label>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
                <asp:Repeater ID="Repeater1" runat="server" 
                    onitemdatabound="Repeater1_ItemDataBound">
                    <ItemTemplate>
                        <table class="bor_gray1" align="center" style="font-size: 14px; font-family: 微软雅黑;" border="0" cellpadding="5" cellspacing="0">
                            <tr>
                                <td>
                                    <asp:Label ID="labImage" runat="server"></asp:Label>
                                </td>
                                <td width="25"></td>
                                <td valign="top">
                                    <asp:Label ID="labContent" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SeparatorTemplate>
                        <p>&nbsp;</p>
                    </SeparatorTemplate>
                </asp:Repeater>
                <p>&nbsp;</p>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
