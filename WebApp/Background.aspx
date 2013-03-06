<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/GuideEnterprises.Master" AutoEventWireup="true" CodeBehind="Background.aspx.cs" Inherits="WebApp.Background" %>
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
                        <a href="guideenterprises.aspx" style="text-decoration: none;">
                            <dt class="expand1" style="color: #314777;">引企助教</dt>
                        </a>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size: 14px; line-height: 25px;">
                <div class="bar4" style="color: #F26200;">
                    <strong>引企助教——开启校企合作新纪元</strong>
                </div>
                <p style="text-align: center">
                    <img src="Resources/images/yqzj01.jpg" alt="" />
                </p>
                <p style="text-align: center">
                    <img src="Resources/images/yqzj02.jpg" alt="" />
                </p>
                <p style="text-align: center">
                    <img src="Resources/images/yqzj03.jpg" alt="" />
                </p>
                <p>
                    尊敬的学院（校）领导：您好！
                    <p>　　　教育部党总书记、部长袁贵仁先生在出席2010年度全国职业教育与成人教育工作会议时强</p>
                    <p>
                        调：“继续加强职业教育，以就业为目标，整合教育资源，改进教学方式，着力培养学生的就业创业
                    </p>
                    <p>
                        能力，增强学生适应企业的能力”；同时在《国家中长期教育改革和发展规划纲要》（2010-2020）
                    </p>
                    <p>
                        文本中也提出，“要制订和实施校企合作的法规，建立健全政府主导、行业指导、企业参与的办学机
                    </p>
                    <p>
                        制，并纳入国家教育体制重大改革的试点范围，探索中国特色社会主义职业教育发展的道路”；上述
                    </p>
                    <p>
                        足可以明确校企合作在未来职业教育中的地位，“培养符合企业需求的人员，增强学生适应企业生产
                    </p>
                    <p>
                        的能力”应是未来职业教育发展的方向。那究竟怎样才能培养符合企业需求的人员呢？在这里我公司
                    </p>
                    <p>
                        青岛校企英才人力资源开发有限公司提出“引企助教”的概念，希望通过这一理念开拓校企合作的新纪
                    </p>
                    <p>元，具体方案如下：</p>
                    <p>一、引企：</p>
                    <p>1，校企英才会在全国范围内选取100家合作院校，由校企英才投入强大的资金，从共建实验室、提供模拟生产线及简易生产线、校企订单及冠名班等方面入手，增强与各院校的合作。</p>
                    <p>2，利用校企英才自身业务的优势（目前与国内外300多家大中型企业有长期合作），深入企业，及时获取最新工艺导向，及时反馈与各院(校），更利于院校培养符合要求的学生。</p>
                    <p>3，整合人才市场、行业协会及社会培训机构为实习或已经就业的学生提供海量的岗位信息及针对学生自身发展的职业培训。</p>
                    <p>4，校企英才是行业内的知名品牌，业务运作极为规范，利用丰富的客户服务经验代为院校跟踪管理实习就业学生。</p>
                    <p>二、助教：</p>
                    <p>1，校企英才免费为院校提供教学用模拟生产线，目前校企英才所提供的模拟生产线涉及汽车、电子、机械三个大项，若干个专业。</p>
                    <p>2，企业订单培养、冠名培养，企业提供奖学金、实训设备、工作服等，让企业参与教学参与教材的制定与更新，让学生从入校开始接受专属于企业特色的教学。</p>
                    <p>3，组织院校专业授课老师，深入企业实地参观学习交流，使老师的教学理论与实际结合得更紧密，更加提高教学质量。</p>
                    <p>4，穿插带薪对口实习或社会实践。</p>
                    <p>5，提供对口就业岗位信息，让学生学有所用。</p>
                    <p>目前影响各个大中专院校生存的是生源之争，但没有好的特色教学、没有好的就业质量是无法打赢这场生源争夺战的！校企英才希望通过“引企助教”这个理念，协助各个院校打赢这场战争，达到各院校、企业、学生、学生家长等五方共赢!</p>
                </p>
                <div class="bar4" style="color: #F26200;">
                    <strong>部分合作企业名录</strong>
                </div>
                <div class="EnterpriseList">
                    <ul>
                        <li>海尔集团</li>
                        <li>海信集团</li>
                        <li>青岛啤酒集团</li>
                        <li>澳柯玛股份</li>
                        <li>大润发商业有限公司</li>
                        <li>金王集团</li>
                        <li>双星集团</li>
                        <li>富士康集团</li>
                        <li>马士基集团</li>
                        <li>TE电子</li>
                        <li>和记黄埔有限公司</li>
                        <li>本田汽车</li>
                        <li>松下</li>  
                        <li>宝马</li>
                        <li>雀巢公司</li>
                        <li>港中旅</li>
                        <li>中国电信</li>
                        <li>索尼（SONY） </li> 
                        <li>联想集团</li>
                        <li>家乐福</li>
                        <li>沃尔玛</li>
                        <li>三一重工</li>
                        <li>玲珑轮胎</li>
                        <li>华硕电脑</li>
                        <li>歌尔电子</li>
                        <li>中国远洋运输总公司</li>
                        <li>太平洋恩利国际</li>
                        <li>中国人寿</li>
                        <li>旺旺集团</li>
                        <li>惠普</li>
                        <li>比亚迪</li>
                        <li>上汽通用五菱</li>
                        <li>伊利集团</li>
                        <li>青特集团</li>
                        <li>英维思集团</li>
                        <li>中国工商银行</li>
                        <li>中国移动</li>
                        <li>中化集团</li>
                        <li>宝钢集团</li>
                        <li>龙湖地产</li>
                        <li>华世洁</li>
                        <li>毅昌集团</li>
                        <li>黄海制药</li>
                        <li>汇源果汁</li>
                        <li>魏桥实业</li>
                        <li>万科集团</li>
                        <li>百度公司</li>
                        <li>平安保险</li>
                        <li>赛轮股份</li>
                        <li>中国南车</li>
                        <li>金晶集团</li>
                        <li>中国重汽</li>
                        <li>可口可乐</li>
                        <li>特瑞堡工程</li>
                        <li>海南航空</li>
                        <li>（以上企业排名不分先后）</li>
                    </ul>
                </div>
            </div>

            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
