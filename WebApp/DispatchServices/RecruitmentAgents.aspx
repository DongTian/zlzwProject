<%@ Page Language="C#" MasterPageFile="~/MasterPage/List.Master" AutoEventWireup="true" CodeBehind="RecruitmentAgents.aspx.cs" Inherits="WebApp.RecruitmentAgents" Title="校企英才官网-代理招聘" %>
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
                <b>代理招聘</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">代理招聘</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <dt class="expand1">企业服务</dt>
                        <dd style="display:block;">
                            <a href="EnterpriseServices.aspx">劳务派遣</a>
                            <a href="PersonnelAgency.aspx">人事代理</a>
                            <a href="RecruitmentAgents.aspx" class="h_hover2">代理招聘</a>
                            <a href="#">临时(短期)工</a>
                        </dd>
                        <dt class="original1">院校合作</dt>
                        <dd>
                            <a href="CollegesUniversities.aspx">院校合作</a>
                             <a href="OrderCultivation.aspx">订单培养</a>
                              <a href="SchoolInvite.aspx">校园招聘</a>
                               <a href="EnterpriseAssistant.aspx">引企助教</a>
                        </dd>
                        <a style='text-decoration:none;' href="../About/PartnerList.aspx"><dt class="original1">合作伙伴</dt></a>
                        <%--<dd>
                            <a href="../About/PartnerList.aspx">合作伙伴</a>
                        </dd>--%>
                        <%--<a style='text-decoration:none;' href="OnlineJobHunting.aspx"><dt class="original1">个人求职</dt></a>--%>
                        <%--<dd>
                            <a href="OnlineJobHunting.aspx">在线求职</a>
                        </dd>--%>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
                <div class="bar4" style="color:#F26200;">
                    <strong>代理招聘</strong></div>
                <p style="margin-bottom:10px;margin-top:10px;">帮助客户进行人员招聘，流程简易、快捷；</p>
                <p style="margin-bottom:10px;margin-top:10px;">帮助客户节省繁杂的筛选、面试环节，减少人员的投入，避免重复操作，节省大量工作时间；
                <p style="margin-bottom:10px;margin-top:10px;">帮助客户节省招聘宣传成本，电话沟通成本，面试成本，人员投入成本，时间成本等等
                <p style="margin-bottom:10px;margin-top:10px;">帮助客户降低招聘风险，帮助企业实现人事工作的标准化和流程化，提高工作效率。
                <p style="color:#F26200; font-weight:bold;">我们的服务优势</p>
                <p style="color:#F26200; font-weight:bold;">专业优势：</p>
                <p style="margin-bottom:10px;margin-top:10px;">1.我们的招聘团队拥有多年、多行业、多类职位的实战操作经验；</p>
                <p style="margin-bottom:10px;margin-top:10px;">2.我们拥有专业资深的行业招聘顾问及客服人员，对于各行业的岗位分布、岗位基本要求、薪酬福利等情况有着深厚且明确的知悉度，既可提供专业的代理招聘服务，也可提供包括招聘在内的全方位咨询服务。</p>
                <p style="color:#F26200; font-weight:bold;">渠道优势：</p>
                <p style="color:#F26200; font-weight:bold;">五大渠道帮助客户筛选、提供符合招聘需求的人员：</p>
                <p style="margin-bottom:10px;margin-top:10px;">1、人才市场专设摊位招聘</p>         
                <p style="margin-bottom:10px;margin-top:10px;">2、人才超市连锁店店内招聘</p>    
                <p style="margin-bottom:10px;margin-top:10px;">3、呼叫中心定向呼叫到达</p>
                <p style="margin-bottom:10px;margin-top:10px;">4、广泛分布的人才输出机构合作招聘/渠道招聘</p> 
                <p style="margin-bottom:10px;margin-top:10px;">5、机动高效的社会招聘</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
