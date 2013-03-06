<%@ Page Language="C#" MasterPageFile="~/MasterPage/List.Master" AutoEventWireup="true" CodeBehind="PersonnelAgency.aspx.cs" Inherits="WebApp.PersonnelAgency" Title="校企英才官网-人事代理" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Resources/css/DefaultStyle.css" rel="stylesheet" type="text/css" />
    <script src="http://lib.sinaapp.com/js/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
    <script src="../Resources/js/tab.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('dt').hover(function () {
                if ($(this).hasClass('expand1')) return;
                $(this).attr('class', 'focus1');
            }, function () {
                if ($(this).hasClass('expand1')) return;
                $(this).attr('class', 'original1');
            }
            );

            $('dt').click(function () {
                if ($(this).hasClass('expand1')) {
                    $(this).next().hide();
                    $(this).attr('class', 'original1');;
                    return;
                }
                $('dd').hide();
                $('dt').attr('class', 'original1');
                $(this).attr('class', 'expand1');
                $(this).next().show();
            });

        })
    </script>
    <style type="text/css">
        #divContent p {
            line-height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="main">
            <div class="banner2">
                <a href="../guideenterprises.aspx" target="_blank">
                    <img style="border: 0px;" src="../Resources/images/banner1.jpg" width="1000" height="100" /></a>
            </div>
            <div class="bar">
                <b>人事代理</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">人事代理</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <dt class="expand1">企业服务</dt>
                        <dd style="display: block;">
                            <a href="EnterpriseServices.aspx">劳务派遣</a>
                            <a href="PersonnelAgency.aspx" class="h_hover2">人事代理</a>
                            <a href="RecruitmentAgents.aspx">代理招聘</a>
                            <a href="#">临时(短期)工</a>
                        </dd>
                        <dt class="original1">院校合作</dt>
                        <dd>
                            <a href="CollegesUniversities.aspx">院校合作</a>
                            <a href="OrderCultivation.aspx">订单培养</a>
                            <a href="SchoolInvite.aspx">校园招聘</a>
                            <a href="EnterpriseAssistant.aspx">引企助教</a>
                        </dd>
                        <a style='text-decoration: none;' href="../About/PartnerList.aspx">
                            <dt class="original1">合作伙伴</dt>
                        </a>
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
            <div id="divContent" class="right1" style="font-size: 14px; line-height: 25px;">
                <div class="bar4" style="color: #F26200;">
                    <strong>人事代理</strong>
                </div>
                <p style="margin-left: 30px;">为客户配备专业的HR客服人员，提供一站式的全程人事服务。开展以薪酬、档案管理和社会保</p>
                <p>
                    险为核心内容的各项委托代理服务，帮助客户简化人事工作的流程，轻松解决员工从入职到离职的
                </p>
                <p>一切事务性工作，为客户降低人力资源管理成本，提高人力资源管理效率。</p>
                <p style="margin-left: 30px;">人事代理是指用人单位根据工作实际需要通过派遣机构为所聘用人员办理用工、发放薪酬以及代</p><p>办社
                    保、档案托管等。</p>
                <p style="color: #F26200; font-weight: bold;">
                    服务内容：
                </p>
                <p style="margin-bottom: 10px; margin-top: 10px;">
                    (1)、转移派遣：由用人单位自行招牌、选拔、培训人员，再由我公司与员工签订《劳动合同》，并
                </p>
                <p>由我公司负责员工的薪酬、福利、保险、处理劳动纠纷等事务。</p>
                <p style="margin-bottom: 10px; margin-top: 10px;">
                    (2)、减员派遣：指用人单位对自行招聘或者已雇佣的员工，将其雇主身份转移至我公司。由我公司
                </p>
                <p>代付有关费用，包括工资、奖金、福利、各项社会保险金，用人单位支付相应管理费用。其目的是减</p>
                <p>少用人单位固定员工编制，增强用人单位面对风险时候的组织应变能力和人才资源弹性。</p>
                <p style="margin-bottom: 10px; margin-top: 10px;">
                    (3)、试用派遣：用人单位在试用期间将新员工合同及保险关系转至我公司，先以派遣形式试用，使
                </p>
                <p>
                    用人单位在准确选才方面更具保障，免去选拔误差风险，有效降低用人成本。
                </p>
                <p style="color: #F26200; font-weight: bold;">
                    享受专业、高效、用人机制灵活的人事服务的同时，降低成本，规避风险、减少人事（劳动）纠纷
                </p>
                <p style="margin-bottom: 10px; margin-top: 10px;">&nbsp;</p>
            </div>

            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
