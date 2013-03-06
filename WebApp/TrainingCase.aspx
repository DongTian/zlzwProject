<%@ Page Title="引企助教-案例" Language="C#" MasterPageFile="~/MasterPage/GuideEnterprises.Master" AutoEventWireup="true" CodeBehind="TrainingCase.aspx.cs" Inherits="WebApp.TrainingCase" %>

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
                <a href="../guideenterprises.aspx" target="_blank">
                    <img style="border: 0px;" src="../Resources/images/banner1.jpg" width="1000" height="100" /></a>
            </div>
            <div class="bar">
                <b>引企助教</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">引企助教</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <dt class="expand1">引企助教</dt>
                        <dd style="display: block;">
                            <a href="GuideEnterprises.aspx">背景</a>
                            <a href="ImportEnterprise.aspx">引企</a>
                            <a href="AssistEducation.aspx">助教</a>
                            <a href="TrainingCase.aspx" class="h_hover2">案例</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size: 14px; line-height: 25px;">
                <div class="bar4" style="color: #F26200;">
                    <strong>案例</strong>
                </div>
                <p>
                    <p>青岛校企英才提供完备的服务：</p>
                    <p>1. 为学生在实习期间缴纳保险；</p>
                    <p>2. 遵照国家法律，同工同酬；</p>
                    <p>3. 免费培训， 讲座。</p>
                    <p>4. 讲师是外聘的企业讲师团成员， 有世界500强公司的企业实际工作经验和技术；</p>
                </p>
                <br />
                <p>
                    <div class="bar4" style="color: #F26200;">
                        <strong>订单班</strong>
                    </div>
                </p>
                <p style="text-align: center;">
                    <img src="Resources/images/case02.jpg" alt="" /></p>
                <p style="text-align: center;">企业冠名培养，在学校设立订单班</p>
                <br />
                <p>
                    <p style="text-align: center;">
                        <img src="Resources/images/case01.jpg" alt="" /></p>
                    <p style="text-align: center;">为在青岛澳柯玛股份有限公司实习的学生提供免费讲座</p>
            </div>
        </div>

        <div class="clear">
        </div>
    </div>
</asp:Content>
