<%@ Page Language="C#" MasterPageFile="~/MasterPage/List.Master" AutoEventWireup="true" CodeBehind="EnterpriseServices.aspx.cs" Inherits="WebApp.DispatchServices" Title="校企英才官网-劳务派遣" %>
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
                <b>劳务派遣</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">劳务派遣</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <dt class="expand1">企业服务</dt>
                        <dd style="display:block;">
                            <a href="EnterpriseServices.aspx" class="h_hover2">劳务派遣</a>
                            <a href="PersonnelAgency.aspx">人事代理</a>
                            <a href="RecruitmentAgents.aspx">代理招聘</a>
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
                    <strong>劳务派遣</strong></div>
                <p style="margin-bottom:10px;margin-top:10px;">全面满足客户招、留、用人需求、简化企业的用工程序、减少人员管理成本、降低用工风险，使客户从烦琐的人员招聘、培训、管理等工作中解脱出来，更好地关注在核心业务上。</p>
                <p style="color:#F26200; font-weight:bold;">服务内容</p>
                <p style="margin-bottom:10px;margin-top:10px;">涵盖员工的招聘、培训、考勤、绩效、在/离职管理、人员的补充、员工各类突发事件的处理等，是全方位一体式的员工管理服务。</p>
                <p style="color:#F26200; font-weight:bold;">我们的核心承诺：</p>
                <p style="margin-bottom:10px;margin-top:10px;"><span style="font-weight:bold;">对口招聘：</span>为企事业单位选送对口的专业人才；</p>
                <p style="margin-bottom:10px;margin-top:10px;"><span style="font-weight:bold;">简化流程：</span>避免重复操作节省大量工作时间；</p>
                <p style="margin-bottom:10px;margin-top:10px;"><span style="font-weight:bold;">降低风险：</span>实现人事工作的标准化和流程化；</p>
                <p style="margin-bottom:10px;margin-top:10px;"><span style="font-weight:bold;">人才再生：</span>提供后备人才供用人单位再选择。</p>
                <p style="color:#F26200; font-weight:bold;">我们的优势：</p>
                <p style="margin-bottom:10px;margin-top:10px;">专注劳务市场，熟悉行业规范，良好的政府关系；</p>
                <p style="margin-bottom:10px;margin-top:10px;">丰富的招工网络，确保劳动力供应；</p>
                <p style="margin-bottom:10px;margin-top:10px;">适用灵活的社会保险缴费项目，降低用工成本；</p>
                <p style="margin-bottom:10px;margin-top:10px;">2000平方米人才市场测评及培训，筛除问题员工，降低流失率，提高匹配度；</p>
                <p style="margin-bottom:10px;margin-top:10px;">专业化的工作团队、规范的工作流程、完善的后勤保障，突发事件处理能力强；</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
