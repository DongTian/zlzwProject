<%@ Page Language="C#" MasterPageFile="Franchising.Master" AutoEventWireup="true"
    CodeBehind="InvestmentAnalysis.aspx.cs" Inherits="WebApp.Franchising.InvestmentAnalysis"
    Title="校企英才官网-投资分析" %>

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
                <b>投资分析</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">投资分析</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a style='text-decoration:none;' href="ProjectDescription.aspx"><dt class="original1">项目介绍</dt></a>
                        <%--<dd>
                            <a href="ProjectDescription.aspx">项目介绍</a>
                        </dd>--%>
                        <dt class="expand1">投资分析</dt>
                        <dd style="display:block;">
                            <a href="InvestmentAnalysis.aspx" class="h_hover2">投资分析</a>
                            <a href="IndustryAnalysis.aspx">行业分析</a>
                        </dd>
                        <dt class="original1">加盟流程</dt>
                        <dd>
                            <a href="JoiningProcess.aspx">加盟流程</a>
                            <a href="JoinConditions.aspx">加盟条件</a>
                            <a href="RightsAndObligations.aspx">权利和义务</a>
                        </dd>
                        <a style='text-decoration:none;' href="VentureStarList.aspx"><dt class="original1">创业明星</dt></a>
                        <%--<dd>
                            <a href="VentureStarList.aspx">创业明星</a>
                        </dd>--%>
                        <asp:Label ID="lab10" runat="server"></asp:Label>
                        <%--<dd>
                            <a href="StorefrontEleganceList.aspx">店面风采</a>
                        </dd>--%>
                        <dt class="original1">店面评比</dt>
                        <dd>
                            <asp:Label ID="labMenuList" runat="server"></asp:Label>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
                <div class="bar4" style="color:#F26200;">
                    <strong>投资分析</strong></div>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2002年开始出现民营的劳务派遣公司，到2008年劳动合同法开始引爆劳务派遣业务的迅速发展，到目前相当比例的企业采用劳务派遣形式用工，需求达到井喷，预测：</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;形成期：2002-2008</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;成长期：2009-2015</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;成熟期：2016-2022</p>
                    <p style="font-weight:bold;">2、人事代理</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;80年代开始到现在一直由央企及政府就业中心控制垄断，目前属于投入期。</p>
                    <p style="font-weight:bold;">3、代理招聘</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2005年开始出现企业付费，由劳务公司（职业介绍）代理招聘，但一直未出现高速发展，而是慢慢转向劳务派遣，因此判断处于投入期或是已经历成长期到了成熟期。</p>
                    <p style="font-weight:bold;">4、职业介绍连锁加盟</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;职业中介服务机构是人力资源市场的载体，职业中介服务对促进劳动力供求均衡、减少劳动力市场摩擦、降低劳动力交易成本方面、促进劳动力合理流动等方面具有重要作用。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;其中的公共就业服务更能起到提高人力资源市场的透明度、保持人力资源市场的公平、帮助就业困难群体避免陷入不利地位的特殊作用。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;综观世界各国，职业中介服务在促进劳动者就业中发挥了重要的作用。</p>
 　　               <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;中国在改革开放和建立市场经济体制过程中，职业中介服务逐步建立和发展完善。经过三十多年的努力，职业中介得到了迅速发展。中国职业中介机构的迅速发展得益于中国政府提供的法律和政策环境。</p>
 　　               <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2002年以来，在中国政府出台的一系列积极的就业政策中，发展和规范劳动力市场是其中一项重要内容。</p>
 　　               <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;一方面，鼓励各类职业中介机构发展，提供就业服务；另一方面，加强劳动力市场的清理整顿，严厉打击非法职业中介行为和职业中介机构侵犯求职者权益的行为。</p>
 　　               <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;各地劳动保障部门将民办职业中介机构作为促进就业的重要力量，鼓励其发展，组织其参与对下岗失业人员和农民工的就业服务工作，并给予政策支持。</p>
 　　               <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;中国通过职业中介服务实现就业的人数在整个就业市场中所占比重较高，基本上占50%左右，有的地方更高。</p>
 　　               <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;这说明，中国职业中介在促进劳动者就业中发挥着重要作用。今后中国政府仍将大力鼓励发展私营职业中介机构，这是促进和保障劳动力市场的灵活性和提高市场效率的重要方面。</p>
 　　               <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1990年深圳出现全国第一家职业介绍所，利润来源于向求职者收取的中介费，到2005年开始出现企业付费，再到2008年遍布街巷的职介所，利润来源发生了根本变化，主要来自企业付费及劳务派遣公司返利，</p>
 　　               <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;甚至很多转向劳务派遣业务，而近两年出现的连锁加盟更多是劳务公司整合资源的手段，主要收入来源大多依附于派遣管理费，</p>
 　　               <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;因此职业介绍连锁加盟是暂时依存于具有丰富企业客户资源的劳务派遣公司而进入快速成长期，但其长远发展仍将回归简单的职业介绍。 预测：</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;形成期：1990-2005</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;成长期：2006-2021</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;成熟期：2022-2037</p>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;综上，人力资源行业正处于高速成长期，发展潜力无限，适宜投资。</p>
                <p style="margin-bottom:10px;margin-top:10px;"></p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
