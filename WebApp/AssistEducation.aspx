<%@ Page Title="引企助教-助教" Language="C#" MasterPageFile="~/MasterPage/GuideEnterprises.Master" AutoEventWireup="true" CodeBehind="AssistEducation.aspx.cs" Inherits="WebApp.AssistEducation" %>

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
                            <a href="AssistEducation.aspx" class="h_hover2">助教</a>
                            <a href="TrainingCase.aspx">案例</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size: 14px; line-height: 25px;">
                <div class="bar4" style="color: #F26200;">
                    <strong>助教</strong>
                </div>
                <p>
                    <p>1. 校企英才免费为院校提供教学用柔性生产线等职教装备，目前涉及机电、物流，汽车行业等。</p>
                    <p>2. 为学校提供订单培养、冠名等校企合作模式。</p>
                    <p>由青岛校企英才或者企业提供奖学金、实训设备、工作服等，并参与教学与教材的制定及更新，让学</p>
                    <p>生从入学开始即接受带有企业特色的教学模式；</p>
                    <p>3. 组织院校专业老师，深入企业，实地参观学习交流，使老师的教学理论与企业实际结合的更加紧</p><p>密，真正有利于提高教学质量；</p>
                    <p>4. 为学生提供对口实习、见习、工学交替、就业岗位，让学生真正学有所用，实现理论与</p><p>实践的结合；</p>

                </p>
            </div>
        </div>

        <div class="clear">
        </div>
    </div>
</asp:Content>
