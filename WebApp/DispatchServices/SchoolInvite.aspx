<%@ Page Language="C#" MasterPageFile="~/MasterPage/List.Master" AutoEventWireup="true" CodeBehind="SchoolInvite.aspx.cs" Inherits="WebApp.SchoolInvite" Title="校企英才官网-校园招聘" %>
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
                <b>校园招聘</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">校园招聘</a></span>
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
                            <a href="SchoolInvite.aspx" class="h_hover2">校园招聘</a>
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
                    <strong>校园招聘</strong></div>
                <table>
                    <tr>
                        <td>
                            <table style="width:100%;">
                                <tr>
                                    <td align="center">
                                        <img src="../Resources/images/SchoolInvite01.jpg" />
                                    </td>
                                    <td style="width:40px;"></td>
                                    <td align="center">
                                        <img src="../Resources/images/SchoolInvite02.jpg" width="288" height="188" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="padding-left:35px;">
                                        <p style="margin-bottom:10px;margin-top:10px;">代表企业或带领企业负责人到各院校参加校园双选会</p>
                                        <p style="margin-bottom:10px;margin-top:10px;">在各校区举办专场说明会或推介会</p>
                                        <p style="margin-bottom:10px;margin-top:10px;">在各校区举办现场面试或远程面试</p>
                                        <p style="margin-bottom:10px;margin-top:10px;">对录用人员促行进行全程跟踪服务</p> 
                                        <p style="color:#F26200; font-size:16px; font-weight:bold;">实习实训</p>
                                        <p style="margin-bottom:10px;margin-top:10px;">提供社会实践、对口实习、勤工俭学、顶岗实习岗位</p>
                                        <p style="margin-bottom:10px;margin-top:10px;">专人后勤服务或带队老师管理维护</p>
                                        <p style="margin-bottom:10px;margin-top:10px;">提供业余学习场所，穿插培训与学习</p>
                                        <p style="color:#F26200; font-size:16px; font-weight:bold;">第三方后勤维护</p>
                                        <p style="margin-bottom:10px;margin-top:10px;">代替外地学校及职业介绍机构定期考察青岛用工企业</p>
                                        <p style="margin-bottom:10px;margin-top:10px;">对已安置到青岛就业或实习人员进行定期回访，收集信息并反馈</p>
                                        <p style="margin-bottom:10px;margin-top:10px;">日常后勤维护及引导</p>
                                        <p style="margin-bottom:10px;margin-top:10px;">突发事件协调处理</p>
                                        <p style="margin-bottom:10px;margin-top:10px;"></p>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
