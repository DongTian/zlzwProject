<%@ Page Language="C#" MasterPageFile="Franchising.Master" AutoEventWireup="true" CodeBehind="ProjectDescription.aspx.cs" Inherits="WebApp.Franchising.ProjectDescription" Title="校企英才官网-项目介绍" %>
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
                <b>项目介绍</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">项目介绍</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a style='text-decoration:none;' href="ProjectDescription.aspx"><dt class="expand1" style="color:#314777;">项目介绍</dt></a>
                        <%--<dd>
                            <a href="ProjectDescription.aspx">项目介绍</a>
                        </dd>--%>
                        <dt class="original1">投资分析</dt>
                        <dd>
                            <a href="InvestmentAnalysis.aspx">投资分析</a>
                            <a href="IndustryAnalysis.aspx">行业分析</a>
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
                    <strong>项目介绍</strong></div>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;“人才超市”加盟创业项目是由青岛校企英才人力资源开发有限公司发起，统一组织、运营并发展推广的新型人力资源服务项目。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;连锁店主要功能是通过连锁店终端的布点、网络与实体结合的方式，实现资源共享，建立丰富的人才库，为个人求职和中、小企业招聘打造诚信、专业、高效的服务平台。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;项目加盟者主要依托“校企英才”的行业实践经验和广泛的客户资源支持，建立便捷、高效、专业的个人求职和中、小企业招聘服务连锁店，通过健全的连锁经营服务系统，实现专业化、统一化、规模化的市场合力，实现梦想，达到共赢，共同打造青岛人资资源行业的第一品牌。</p>
                    <p style="margin-bottom:10px;margin-top:10px;"></p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
