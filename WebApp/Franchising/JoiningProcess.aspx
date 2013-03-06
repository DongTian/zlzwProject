<%@ Page Language="C#" MasterPageFile="Franchising.Master" AutoEventWireup="true" CodeBehind="JoiningProcess.aspx.cs" Inherits="WebApp.Franchising.JoiningProcess" Title="校企英才官网-加盟流程" %>
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
                <b>加盟流程</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">加盟流程</a></span>
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
                            <a href="JoiningProcess.aspx" class="h_hover2">加盟流程</a>
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
                        <dt class="original1">店面评比</dt>
                        <dd>
                            <asp:Label ID="labMenuList" runat="server"></asp:Label>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
                <div class="bar4" style="color:#F26200;">
                    <strong>加盟流程</strong></div>
                <p style="margin-bottom:10px;margin-top:10px;">1、获取信息：通过面谈获取《加盟手册》。</p>
                <p style="margin-bottom:10px;margin-top:10px;">2、考察洽谈：通过申请，到现有“人才超市”连锁店进行现场参观考察，交流详细事宜，确定加盟合作意向。</p>
                <p style="margin-bottom:10px;margin-top:10px;">3、提交申请：认真调查、思考，提出加盟申请。</p>
                <p style="margin-bottom:10px;margin-top:10px;">4、资格审定：公司收到申请信息后，招商部负责人将及时与意向加盟者联系，提供相关资讯，审定加盟资格。</p>
                <p style="margin-bottom:10px;margin-top:10px;">5、签订合同：提供合法性证明材料，交纳相关费用，签署《加盟合同》。</p>
                <p style="margin-bottom:10px;margin-top:10px;">6、协助选址及装修：公司结合市场有利信息协助加盟商选定经营场所，并提供装修设计指导（加盟店门头及背景墙等需按照公司提供的施工效果图进行装修）。</p>
                <p style="margin-bottom:10px;margin-top:10px;">7、营业前培训：</p>
                <p style="margin-bottom:10px;margin-top:10px;">　(1)为期3天的行业信息、产品介绍、业务流程、经营理论、管理知识培训</p>
                <p style="margin-bottom:10px;margin-top:10px;">　(2)为期一周的金牌“人才超市”连锁店实地培训；</p>
                <p style="margin-bottom:10px;margin-top:10px;">　(3)为期3天的客户开发实训； </p>
                <p style="margin-bottom:10px;margin-top:10px;">　(4)公司客户资源分享、解读。</p>
                <p style="margin-bottom:10px;margin-top:10px;">8、试营业：开张后一个月内，公司派“店面运营指导师”协助试营业。</p>
                <p style="margin-bottom:10px;margin-top:10px;">9、持续经营支持、督导：根据店面遇到的问题，结合实际情况，及时解决、规避经营风险。</p>
                <p style="margin-bottom:10px;margin-top:10px;"></p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>