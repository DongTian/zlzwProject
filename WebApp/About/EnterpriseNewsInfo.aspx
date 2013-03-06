<%@ Page Language="C#" MasterPageFile="About.Master" AutoEventWireup="true"
    CodeBehind="EnterpriseNewsInfo.aspx.cs" Inherits="WebApp.About.EnterpriseNewsInfo"
    Title="校企英才官网-企业动态" %>

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
                <b>企业动态</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">企业动态</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a href="AboutKingStudy.aspx" style="text-decoration:none;"><dt class="original1">校企简介</dt></a>
                        <%--<dd>
                            <a href="AboutKingStudy.aspx">校企简介</a>
                        </dd>--%>
                        <a href="EnterpriseCulture.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">企业文化</dt></a>
                        <%--<dd>
                            <a href="EnterpriseCulture.aspx">企业文化</a>
                        </dd>--%>
                        <a href="EnterpriseNews.aspx" style="text-decoration:none;color:#fff;"><dt class="expand1" style="color:#314777;">企业动态</dt></a>
                        <%--<dd>
                            <a href="EnterpriseNews.aspx">企业动态</a>
                        </dd>--%>
                        <a href="PublicWelfare.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">公益事业</dt></a>
                        <%--<dd>
                            <a href="PublicWelfare.aspx">公益事业</a>
                        </dd>--%>
                        <a href="PartnerList.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">合作伙伴</dt></a>
                        <%--<dd>
                            <a href="PartnerList.aspx">合作伙伴</a>
                        </dd>--%>
                        <a href="Co-brand.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">品牌合作</dt></a>
                        <%--<dd>
                            <a href="Co-brand.aspx">品牌合作</a>
                        </dd>--%>
                        <dt class="original1">诚聘英才</dt>
                        <dd>
                            <a href="CareersList.aspx">诚聘英才</a>
                            <a href="http://ceping.zhilaizhiwang.net:82/" target="_blank">人才测评</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1 xinwen_nei2" style="font-size:14px; line-height:25px;">
                <table style="width: 100%;">
                    <tr>
                        <td colspan="2" align="center">
                            <h2>
                                <asp:Label ID="labNewsTitle" runat="server" CssClass="title4"></asp:Label>
                            </h2>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="title5">
                            <asp:Label ID="labPublisDate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="line-height: 30px;">
                            <asp:Label ID="labNewsContent" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
