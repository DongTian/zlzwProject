<%@ Page Language="C#" MasterPageFile="Franchising.Master" AutoEventWireup="true" CodeBehind="JoinConditions.aspx.cs" Inherits="WebApp.Franchising.JoinConditions" Title="校企英才官网-加盟条件" %>
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
                <b>加盟条件</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">加盟条件</a></span>
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
                            <a href="IndustryAnalysis.aspx">行业分析</a>
                        </dd>
                        <dt class="expand1">加盟流程</dt>
                        <dd style="display:block;">
                            <a href="JoiningProcess.aspx">加盟流程</a>
                            <a href="JoinConditions.aspx" class="h_hover2">加盟条件</a>
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
                    <strong>加盟条件</strong></div>
                <p style="margin-bottom:10px;margin-top:10px;">1、申请人对人力资源服务行业认可并有浓厚的兴趣，原意将劳务派遣、代理招聘、职业介绍等人力资源服务业务作为自己的一项事业来发展；</p>
                <p style="margin-bottom:10px;margin-top:10px;">2、申请人有强烈的创业愿望及良好的创业心态，具备良好的语言表达能力和沟通能力；</p>
                <p style="margin-bottom:10px;margin-top:10px;">3、申请人的个人支持系统中有人力资源服务行业客户两端（企业客户与求职者）的潜在资源；</p>
                <p style="margin-bottom:10px;margin-top:10px;">4、认同青岛校企英才人力资源开发有限公司“诚信、专业、责任、创新”的核心价值理念及“助求职者有业、乐业”的企业使命；并承诺规范、诚信经营；</p>
                <p style="margin-bottom:10px;margin-top:10px;">5、申请人有固定的、面积不小于20平方米的经营场所；</p>
                <p style="margin-bottom:10px;margin-top:10px;">6、接受项目的加盟条件与方式，接受公司的运营指导和管理模式。</p>
                <p style="margin-bottom:10px;margin-top:10px;"></p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>