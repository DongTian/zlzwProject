<%@ Page Language="C#" MasterPageFile="Franchising.Master" AutoEventWireup="true" CodeBehind="RightsAndObligations.aspx.cs" Inherits="WebApp.Franchising.RightsAndObligations" Title="校企英才官网-权利和义务" %>
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
                <b>权利和义务</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">权利和义务</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a style='text-decoration:none;' href="ProjectDescription.aspx"><dt class="original1">项目介绍</dt></a>
                        <%--<dd>
                            <a href="ProjectDescription.aspx">项目介绍</a>
                        </dd>--%>
                        <dt class="original1">投资分析</dt>
                        <dd>
                            <a href="InvestmentAnalysis.aspx">投资分析</a>
                            <a href="IndustryAnalysis.aspx">行业分析</a>
                        </dd>
                        <dt class="expand1">加盟流程</dt>
                        <dd style="display:block;">
                            <a href="JoiningProcess.aspx">加盟流程</a>
                            <a href="JoinConditions.aspx">加盟条件</a>
                            <a href="RightsAndObligations.aspx" class="h_hover2">权利和义务</a>
                        </dd>
                        <a style='text-decoration:none;' href="VentureStarList.aspx"><dt class="original1">创业明星</dt></a>
                        <%--<dd>
                            <a href="VentureStarList.aspx">创业明星</a>
                        </dd>--%>
                        <a style='text-decoration:none;' href="StorefrontEleganceList.aspx"><dt class="original1">店面风采</dt></a>
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
                    <strong>权利和义务</strong></div>
                    <p style="margin-bottom:10px;margin-top:10px;">(一)加盟商权利</p>
                    <p style="margin-bottom:10px;margin-top:10px;">1、创业资质支持：公司协助办理营业证件，加盟商可选择使用公司的资质开展业务。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">2、品牌形象支持：可使用统一的CI形象策划。完整、诚信的企业形象，为加盟商奠定了良好的品牌和形象基础。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">3、店面管理支持：公司提供统一的店面管理流程，包括：收费标准及规范、服务规范、店内布置、简章张贴，人员面试、入职办理流程等。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">4、经营管理支持：公司提供人员安置服务、企业回款服务、客户开发服务、工伤处理服务、企业关系维护等。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">5、客户资源支持：公司内部所有岗位信息全部共享，加盟者也可独立开发客户（公司可提供相应的客户开发培训或协助开发客户），享受公司的奖励。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">6、渠道招聘支持：公司渠道开发团队具有较强的批量招聘能力，亦可联合其他连锁店共同满足较大客户的招聘需求。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">7、职来职往人才市场支持：公司除在北站开设人才市场以外，将会陆续在各区战略位置开设人才市场，为各连锁店积累品牌优势及客户资源，同时仅限向加盟者及企业客户提供人才市场摊位（人才市场不对其它劳务公司开放，而对加盟者优惠开放甚至免费开放）。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">8、财税支持：公司具有完善的结算数据系统及财务系统，便于各类数据信息查询，合理纳税避税。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">(二)加盟商的义务</p>
                    <p style="margin-bottom:10px;margin-top:10px;">1、加盟商对外开展业务需接受公司的监督和指导，须维护公司形象、名誉及经济利益。</p>
                    <p style="margin-bottom:10px;margin-top:10px;">2、加盟商在协议有效期内不得无故停止经营，如遇特殊情况需要停止经营必须提前三个月以书面的形式上报公司</p>。
                    <p style="margin-bottom:10px;margin-top:10px;">3、加盟商在经营过程中资金来源须正当合法，须遵守法纪，不得恶意竞争并严格遵守《人才超市连锁店管理制度》及相关流程。</p>

                    <p style="margin-bottom:10px;margin-top:10px;"></p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
