<%@ Page Language="C#" MasterPageFile="About.Master" AutoEventWireup="true"
    CodeBehind="AboutKingStudy.aspx.cs" Inherits="WebApp.About.AboutKingStudy" Title="校企英才官网-校企简介" %>

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
                <b>关于校企</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">校企简介</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a href="AboutKingStudy.aspx" style="text-decoration:none;"><dt class="expand1" style="color:#314777;">校企简介</dt></a>
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
                <div class="bar4" style="color:#F26200;">
                    <strong>校企简介</strong></div>
                <span style="margin:0 0 0 30px;">青岛校企英才人力资源开发有限公司，前身为黄河劳务，成立于2004年，是青岛最具竞争力和品牌价值的为客户提供专业化人力资源服务的规范化公司，拥有丰富的市场经验以及完备的服务资质。</span><br />
                <br />
                <span style="margin:0 0 0 30px;">公司通过劳务派遣、人事代理、代理招聘、人才市场等多项业务开展为企业提供灵活用工、劳动力解决方案及人力资源解决方案服务，现已经成为青岛企业首选的人力资源战略合作伙伴。</span><br />
                <br />
                <span style="margin:0 0 0 30px;">作为青岛人力资源服务行业的领跑者，校企英才人力资源服务体系依托信息技术中心、线上网络平台---www.zhilaizhiwang.net，线下渠道招聘、人才超市连锁店、青岛汽车北站人才市场，呼叫中心、客户服务中心、结算中心等多种方式，在企业人力资源服务及进城务工者服务等领域进行创新发展。</span><br />
                <br />
                <span style="margin:0 0 0 30px;">截止到2012上半年，累计为青岛3000多家内、外资企业提供了专业的人力资源服务，客户横跨各行各业；安置的求职者逾10万人；  同时与国内一百多所院校建立了长期深入的合作关系。</span><br />
                <br />
                <span style="margin:0 0 0 30px;">现校企英才已在高科园、开发区、四方长途站、河套、汽车北站、南万、转盘、李家女姑、赵戈庄、双埠开设连锁店，并计划三年内遍布青岛各大园区及交通要塞，为企业及求职者提供更便捷、更细致的人力资源服务。</span>
 
                <br />
                <br />
                <span style="margin:0 0 0 30px;">2012年7月，北站人才市场2号馆开馆，这是校企英才全方位发展的一个里程碑，更是业务发展的一个新起点。未来，校企英才将不断提升专业化服务能力，为推动青岛人力资源服务行业的规范化和专业化发展做出贡献。</span>
 
                <br />
                <br />
                <span style="margin:0 0 0 30px;">2012年12月，公司依托于丰富的学生资源做全国战略规划，立足青岛，放眼全国；将业务拓展至山东半岛地区、京津唐地区、长三角地区、珠三角地区等；</span>

            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
