<%@ Page Language="C#" MasterPageFile="About.Master" AutoEventWireup="true" CodeBehind="Co-brand.aspx.cs" Inherits="WebApp.About.Co_brand" Title="校企英才官网-品牌合作" %>
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
                <b>品牌合作</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">品牌合作</a></span>
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
                        <a href="PublicWelfare.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">公益事业</dt></a>
                        <%--<dd>
                            <a href="PublicWelfare.aspx">公益事业</a>
                        </dd>--%>
                        <a href="PartnerList.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">合作伙伴</dt></a>
                        <%--<dd>
                            <a href="PartnerList.aspx">合作伙伴</a>
                        </dd>--%>
                        <a href="Co-brand.aspx" style="text-decoration:none;color:#314777;"><dt class="expand1" style="color:#314777;">品牌合作</dt></a>
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
                <p style="margin-bottom:30px;margin-top:10px; text-align:center;"><a href="http://www.baijob.com/" target="_blank" title="百伯网"><img style="border:0px;" src="../Resources/images/BaiBoLogog.jpg" alt="百伯网" /></a></p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;百伯网是由百度投资创立，是国内首家致力于中文招聘领域垂直搜索服务的网站。</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;经过近两年的发展，百伯网现已经成为国内最大的招聘平台。</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2011年1月，百度在原百度人才频道的基础之上，将原‘百度人才频道’产品独立成一家公司进行运营，并将‘百度人才’正式改名为‘百伯网’。</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;其主要产品是针对于招聘网站进行职位信息和公司招聘信息检索的垂直搜索引擎。</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2012年6月，在原职位搜索功能的基础上，百伯网又推出新产品“职位推荐引擎 ”，通过将求职者简历与企业职位信息的分析匹配，为求职者推荐合适职位，让求职者和企业都能更加精准地找到对方，真正实现了人尽其才、才尽其用、人事相宜，对员工稳定性和企业长期发展具有重大意义。</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2012年11月，百度又将运营了多年的“招聘类开放平台”【俗称“招聘阿拉丁”】正式交于百伯网进行运营。</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;至此，百伯网拥有两大搜索引擎和基于百度巨大招聘流量的招聘阿拉丁，具备了中国第一大招聘行业垂直搜索引擎的技术能力和无可比拟的流量基础。</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;借助于百度“招聘阿拉丁”的运营，百伯网立志要推动中国招聘行业产业链的变革，致力打造全新的能够满足现阶段互联网时代需求的中国网络招聘生态圈。</p>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;百伯网通过上述主营产品和专业技术向用户提供企业人员的招聘管理、面向各大招聘网站提供百度招聘阿拉丁的数据免费接入服务以及基于百伯网的精准广告投放服务。</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
