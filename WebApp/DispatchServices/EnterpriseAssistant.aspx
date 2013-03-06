<%@ Page Language="C#" MasterPageFile="~/MasterPage/List.Master" AutoEventWireup="true" CodeBehind="EnterpriseAssistant.aspx.cs" Inherits="WebApp.EnterpriseAssistant" Title="校企英才官网-引企助教" %>
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
                <b>引企助教</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">引企助教</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <dt class="original1">企业服务</dt>
                        <dd>
                            <a href="EnterpriseServices.aspx">劳务派遣</a>
                            <a href="PersonnelAgency.aspx">人事代理</a>
                            <a href="RecruitmentAgents.aspx">代理招聘</a>
                            <a href="#">临时(短期)工</a>
                        </dd>
                        <dt class="expand1">院校合作</dt>
                        <dd style="display:block;">
                            <a href="CollegesUniversities.aspx">院校合作</a>
                             <a href="OrderCultivation.aspx">订单培养</a>
                              <a href="SchoolInvite.aspx">校园招聘</a>
                               <a href="EnterpriseAssistant.aspx" class="h_hover2">引企助教</a>
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
                    <strong>引企助教</strong></div>
                <p style="margin-bottom:10px;margin-top:10px;">■  校企英才会在全国范围内选取100家合作院校，由校企英才投入强大的资金，从共建实验室、提     
                    供模拟生产线及简易生产线、校企订单及冠名班等方面入手，增强与各院校的合作。</p>
                <p style="margin-bottom:10px;margin-top:10px;">■  校企英才免费为院校提供教学用模拟生产线，目前校企英才所提供的模拟生产线涉及汽车、电
                    子、机械三个大项，若干个专业。</p>	
                <p style="margin-bottom:10px;margin-top:10px;">■  企业订单培养、冠名培养，企业提供奖学金、实训设备、工作服等，让企业参与教学参与教材
                    的制定与更新，让学生从入校开始接受专属于企业特色的教学。</p> 
                <p style="margin-bottom:10px;margin-top:10px;">■  组织院校专业授课老师，深入企业实地参观学习交流，使老师的教学理论与实际结合得更紧
                    密，更加提高教学质量。</p>  
                <p style="margin-bottom:10px;margin-top:10px;">■  穿插带薪对口实习或社会实践。</p>
                <p style="margin-bottom:10px;margin-top:10px;">■  提供对口就业岗位信息，让学生学有所用。</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
