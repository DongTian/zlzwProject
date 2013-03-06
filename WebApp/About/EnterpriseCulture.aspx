<%@ Page Language="C#" MasterPageFile="About.Master" AutoEventWireup="true"
    CodeBehind="EnterpriseCulture.aspx.cs" Inherits="WebApp.About.EnterpriseCulture"
    Title="校企英才官网-企业文化" %>

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
                <b>企业文化</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">企业文化</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a href="AboutKingStudy.aspx" style="text-decoration:none;"><dt class="original1">校企简介</dt></a>
                        <%--<dd>
                            <a href="AboutKingStudy.aspx">校企简介</a>
                        </dd>--%>
                        <a href="EnterpriseCulture.aspx" style="text-decoration:none;color:#fff;"><dt class="expand1" style="color:#314777;">企业文化</dt></a>
                        <%--<dd>
                            <a href="EnterpriseCulture.aspx">企业文化</a>
                        </dd>--%>
                        <a href="EnterpriseNews.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">企业动态</dt></a>
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
            <div class="right1" style="font-size:14px; line-height:25px;">
                <p style="color: #F26200; font-weight: bold; margin-bottom:10px;margin-top:10px;">
                    我们的愿景： <span style="color: #6e6e6e; font-weight: normal">成为本土最具实力的受人尊敬的人力资源公司！</span></p>
                <p style="color: #F26200; font-weight: bold; margin-bottom:10px;margin-top:10px;">
                    我们的使命： <span style="color: #6e6e6e; font-weight: normal">助求职者有业、乐业！</span></p>
                <p style="color: #F26200; font-weight: bold; margin-bottom:10px;margin-top:10px;">
                    我们的核心价值观： <span style="color: #6e6e6e; font-weight: normal">诚信、专业、责任、创新</span></p>
                <p style="color: #F26200; font-weight: bold; margin-bottom:10px;margin-top:10px;">
                    诚信 Honest</p>
                <p style="margin-bottom:10px;margin-top:10px;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;对我，尊重自己，树立个人品牌 对企业，我们将如实告知我们的业务能力和能和合作进展的实际情况； 对求职者，我们将如实告知合作企业的详细信息及可能会遇到的风险； 对合作伙伴，我们将如实告知我们的客户信息和合作方式。</p>
                <p style="color: #F26200; font-weight: bold; margin-bottom:10px;margin-top:10px;">
                    专业 Ability & Profession</p>
                <p style="margin-bottom:10px;margin-top:10px;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;对我，注重细节，不断学习，成为相关岗位的专家； 对企业，我们能提供可行的最佳服务方案及最高的服务效能； 对求职者，我们能根据准确的、详尽的企业信息提供最适合本人的就业指导；
                    对合作伙伴，我们能提供匹配的客户信息及便捷的对接流程。</p>
                <p style="color: #F26200; font-weight: bold; margin-bottom:10px;margin-top:10px;">责任 Responsibility</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;对我，相信团队，努力担当； 对企业，我们应努力达成客户对我们的期望； 对求职者，我们应全力维护他们的权利并提供保护； 对合作伙伴，我们应全力提升服务质量，消除其后顾之忧，合作共赢；</p>
                <p style="color: #F26200; font-weight: bold; margin-bottom:10px;margin-top:10px;">创新 Innovation</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;对我，脚踏实地，勇于变革； 对企业，我们将不断改进，竭力满足企业需求； 对求职者，我们将不断创造使他们进步的机会，帮助其发展；
                对合作伙伴，我们将通过业务模式改进，努力形成多渠道共赢。</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
