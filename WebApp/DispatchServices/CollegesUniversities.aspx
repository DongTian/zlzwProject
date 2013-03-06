<%@ Page Language="C#" MasterPageFile="~/MasterPage/List.Master" AutoEventWireup="true" CodeBehind="CollegesUniversities.aspx.cs" Inherits="WebApp.CollegesUniversities" Title="校企英才官网-院校合作" %>
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
                <b>院校合作</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">院校合作</a></span>
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
                            <a href="CollegesUniversities.aspx" class="h_hover2">院校合作</a>
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
                    <strong>院校合作</strong></div>
                <%--<p>全面满足客户招、留、用人需求、简化企业的用工程序、减少人员管理成本、降低用工风险，使客户从烦琐的人员招聘、培训、管理等工作中解脱出来，更好地关注在核心业务上。</p>
                <p style="color:#F26200; font-weight:bold;">服务内容</p>
                <p>涵盖员工的招聘、培训、考勤、绩效、在/离职管理、人员的补充、员工各类突发事件的处理等，是全方位一体式的员工管理服务，其中包括：</p>
                <p>1)招聘服务</p>  
                <p>2)面试组织服务</p>
                <p>3)员工录用及相关手续办理服务</p> 
                <p>4)员工培训</p>   
                <p>5)工资发放及即时查询服务</p>
                <p>6)保险缴纳及理赔服务</p>        
                <p>7)工伤处理服务</p>       
                <p>8)驻场管理服务</p>      
                <p>9)关爱与福利提供服务</p> 
                <p>10)危机干预服务</p>     
                <p>11)咨询支持服务</p>
                <p style="color:#F26200; font-weight:bold;">我们的核心承诺：</p>
                <p>对口招聘：为企事业单位选送对口的专业人才；</p>
                <p>简化流程：避免重复操作节省大量工作时间；</p>
                <p>降低风险：实现人事工作的标准化和流程化；</p>
                <p>人才再生：提供后备人才供用人单位再选择。</p>--%>
                <p>&nbsp;</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
