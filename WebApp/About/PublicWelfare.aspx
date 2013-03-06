<%@ Page Language="C#" MasterPageFile="About.Master" AutoEventWireup="true" CodeBehind="PublicWelfare.aspx.cs" Inherits="WebApp.About.PublicWelfare" Title="校企英才官网=公益事业" %>
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
                <b>公益事业</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">公益事业</a></span>
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
                        <a href="EnterpriseNews.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">企业动态</dt></a>
                        <%--<dd>
                            <a href="EnterpriseNews.aspx">企业动态</a>
                        </dd>--%>
                        <a href="PublicWelfare.aspx" style="text-decoration:none;color:#fff;"><dt class="expand1" style="color:#314777;">公益事业</dt></a>
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
            <div class="right1" style="font-size:14px; line-height:25px;">
                <p style="margin-bottom:10px;margin-top:10px;">参与建立新市民阳光社区</p>
                <p style="margin-bottom:10px;margin-top:10px;">定期向新市民紧急救助基金捐款</p>
                <p style="margin-bottom:10px;margin-top:10px;">为新市民阳光社区会员免费提供专业服务</p>
                <p style="margin-bottom:10px;margin-top:10px;">全体员工加入阳光大使行列成为新市民阳光社区的“义工后援团”</p>
                <p style="margin-bottom:10px;margin-top:10px;">为进城务工者的城市融入事业出钱、出心、出力</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
