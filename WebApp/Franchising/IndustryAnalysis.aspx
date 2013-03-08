<%@ Page Language="C#" MasterPageFile="Franchising.Master" AutoEventWireup="true"
    CodeBehind="IndustryAnalysis.aspx.cs" Inherits="WebApp.Franchising.IndustryAnalysis"
    Title="校企英才官网-行业分析" %>

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
                <b>行业分析</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">行业分析</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a style='text-decoration:none;' href="ProjectDescription.aspx"><dt class="original1">项目介绍</dt></a>
                        <%--<dd>
                            <a href="ProjectDescription.aspx">项目介绍</a>
                        </dd>--%>
                        <dt class="expand1">投资分析</dt>
                        <dd style="display:block;">
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
                        <asp:Label ID="lab10" runat="server"></asp:Label>
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
                <div class="bar4" style="color:#F26200;">
                    <strong>行业分析</strong></div>
                <p style="margin-bottom:10px;margin-top:10px;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;每个产业行业的发展都有一定的阶段性和规律性，正如产品有寿命周期一样，产业也有自己的生命周期。</p>
                <p style="margin-bottom:10px;margin-top:10px;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;主要是通过识别产业的形态来进行投资分析，发现未来企业可能面对的机遇和威胁。大量的投资案例证明：选择比努力更重要！</p>
                <p style="margin-bottom:10px;margin-top:10px;">
                    <img src="../Resources/images/jiamengliansuoImages.JPG" alt="" /></p>
                <p style="margin-bottom:10px;margin-top:10px;"></p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
