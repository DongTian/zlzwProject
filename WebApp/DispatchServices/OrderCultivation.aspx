<%@ Page Language="C#" MasterPageFile="~/MasterPage/List.Master" AutoEventWireup="true" CodeBehind="OrderCultivation.aspx.cs" Inherits="WebApp.OrderCultivation" Title="校企英才官网-订单培养" %>
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
                <b>订单培养</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">订单培养</a></span>
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
                             <a href="OrderCultivation.aspx" class="h_hover2">订单培养</a>
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
                    <strong>订单培养</strong></div>
                    <p style="margin-bottom:10px;margin-top:10px;">
                        <table style="width:100%;">
                            <tr>
                                <td align="center">
                                    <img src="../Resources/images/IMG_9908.jpg" alt="" />
                                </td>
                                <td align="center">
                                    <img src="../Resources/images/IMG_9912.jpg" alt="" />
                                </td>
                            </tr>
                        </table>
                    </p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;校企英才广泛开展与各行业协会、专业机构及规模以上企业的合作，联合各大中高职院校进行订单培养。</p>

                    <p style="margin-bottom:10px;margin-top:10px;">对订单岗位的要求：</p>
                    <p style="margin-bottom:10px;margin-top:10px;">■  岗位需求量达到一定规模；</p>
                    <p style="margin-bottom:10px;margin-top:10px;">■  岗位薪水在当地具有竞争力；</p>
                    <p style="margin-bottom:10px;margin-top:10px;">■  岗位具有一定技术含量并有上升空间；</p>
                    <p style="margin-bottom:10px;margin-top:10px;">■  正式上岗前的培养期可提供带薪实习机会；</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
