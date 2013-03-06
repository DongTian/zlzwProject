<%@ Page Title="引企助教-引企" Language="C#" MasterPageFile="~/MasterPage/GuideEnterprises.Master" AutoEventWireup="true" CodeBehind="ImportEnterprise.aspx.cs" Inherits="WebApp.ImportEnterprise" %>

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
                            <a href="ImportEnterprise.aspx" class="h_hover2">引企</a>
                            <a href="AssistEducation.aspx">助教</a>
                            <a href="TrainingCase.aspx">案例</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size: 14px; line-height: 25px;">
                <div class="bar4" style="color: #F26200;">
                    <strong>引企</strong>
                </div>
                <p>
                    <div>
                        <p>
                            <p>校企英才在全国范围内选取100家合作院校，由校企英才投入强大的资金，加深与院校的合作。</p>
                            <p>合作方式包括：</p>
                            <p>1) 共建实训室；</p>
                            <p>2) 提供柔性生产线实训系统；</p>
                            <p>3)  提供企业简易生产线等；</p>
                            <p>只要院校有需求， 我们可以提供院校需要的各种品牌各种类型的职教装备。</p>
                            <p>目前青岛校企英才与国内外300多家大中型国企、外企、上市公司等有长期合作，如： 澳柯玛股份有</p>
                            <p>限公司；海信（山东）空调有限公司等。</p>
                            <p>青岛校企英才深入企业，及时获取企业最新工艺，通过提供企业模拟生产线，产品，工艺，工装，技</p><p>术给院校，更加利于院校培养真正符合企业要求的学生；</p>

                        </p>
                </p>
            </div>
            </p>
            </div>

            <div class="clear">
            </div>
        </div>
</asp:Content>
