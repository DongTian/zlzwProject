<%@ Page Title="引企助教-背景" Language="C#" MasterPageFile="~/MasterPage/GuideEnterprises.Master" AutoEventWireup="true" CodeBehind="GuideEnterprises.aspx.cs" Inherits="WebApp.GuideEnterprises" %>

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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="main">
            <div class="banner2">
                <a href="../guideenterprises.aspx" target="_blank"><img style="border:0px;" src="../Resources/images/banner1.jpg" width="1000" height="100" /></a>
            </div>
            <div class="bar">
                <b>引企助教</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">引企助教</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <dt class="expand1">引企助教</dt>
                        <dd style="display:block;">
                            <a href="GuideEnterprises.aspx" class="h_hover2">背景</a>
                            <a href="ImportEnterprise.aspx">引企</a>
                            <a href="AssistEducation.aspx">助教</a>
                            <a href="TrainingCase.aspx">案例</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size: 14px; line-height: 25px;">
                <div class="bar4" style="color: #F26200;">
                    <strong>背景</strong>
                </div>
                <p>
                    <p>政府支持：</p>
                    <div>
                        <p>
                            <p style="margin:0 0 0 30px;">教育部部长袁贵仁先生在2010年度全国职业教育与成人教育工作会议时， 强调：“继续加强职业</p><p>教育， 以就业为目标，整合教育资源，改进教学方式， 着力培养学生的就业创业能力，增强学生适</p><p>应企业能力。”
  《国家中长期教育改革和发展规划纲要》中提出“要制定和实施校企合作的法规，建立</p><p>健全政府主导、行业指导、企业参与的办学机制，并纳入国家教育体制重大改革的试点范围”。</p>
                        </p>
                    </div>
                </p>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
