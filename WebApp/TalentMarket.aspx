<%@ Page Language="C#" MasterPageFile="~/MasterPage/TalentMarket.Master" AutoEventWireup="true" CodeBehind="TalentMarket.aspx.cs" Inherits="WebApp.TalentMarket" Title="校企英才官网-人才市场" %>
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
                <b>人才市场</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">市场简介</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a href="TalentMarket.aspx" style="text-decoration:none;"><dt class="expand1" style="color:#314777;">人才市场</dt></a>
                        <%--<dd>
                            <a href="AboutKingStudy.aspx">人才市场</a>
                        </dd>--%>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
                <div class="bar4" style="color:#F26200;">
                    <strong>市场简介</strong></div>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;青岛职来职往  汽车北站人才市场，是校企英才旗下项目。现拥有两个招聘展馆：</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;①号馆位于青岛汽车北站二楼大厅</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;②号馆位于汽车北站南侧如家酒店下方，共设置标准摊位100余个。</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;凭借对入场企业质量的严格控制和良好的招聘效果， 自2012年春节后运营以来，获得广大求职者和用人单位及社会各界一致的好评，为企业与求职者搭建了一个信息通畅的平台，在促进人力资源合理化配置及提升社会就业率方面发挥了重大的作用。</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;青岛电视台、山东卫视、青岛新闻网、齐鲁晚报、半岛都市报、早报、晚报、城阳电视台、人民广播电台、中国青年报等众多媒体对市场给予了多次报道。</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;校企英才将根据客户需求陆续在市区、开发区、胶州、即墨等区域开设人才市场，满足更多区域更多客户需求。</p>
                 <p style="color:#F26200; font-size:16px; font-weight:bold;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;一、招聘会举办周期和行业设置每周二、四、六    9:00-12:00    ①②号馆同时开放</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;周二：服务行业专场招聘会：涵盖：酒店、餐饮、商超、贸易、房地产、建筑、勘探、物流、交通、汽车、航空、电信、软件、金融、教育、医疗、娱乐、计算机、软件、环保、互联网等行业。</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;周四：制造行业专场招聘会：涵盖：机械、汽配、模具、电器、电子、仪表、五金、服装纺织、食品、化工、塑料、制药、家具、建材、印刷、工艺品、材料、新能源、橡胶、制鞋、设备等行业。</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;周六：大型综合性招聘会：暨城阳区高校毕业生招聘大会。涵盖各行业管理、销售、行政、文职、技术、一线等岗位的求职人群。单位涵盖：外资、合资、民营、国企、事业单位等。</p>
                 <p style="color:#F26200; font-size:16px; font-weight:bold;">二、业务范围</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;现场招聘会：综合性、行业专场、大企业专场、校园招聘会。</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;A4广告栏、报纸招聘、简章招聘、网络招聘、短工供应、代理招聘、人事代理、劳务派遣、百伯人才网。</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;其它：场地租赁、商务合作、HR俱乐部、企业员工相亲会、行业聚会、广告置换、工厂产品展销会等。</p>
                 <p style="color:#F26200; font-size:16px; font-weight:bold;">三、活动预告：</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1、活动预告：“青岛新市民相亲大会——你知道你的另一半在这等你吗？”
                 时间：每月第二个周日13:30-16:30    地点：职来职往青岛汽车北站人才市场②号馆</p>
                 <p style="margin-bottom:10px;margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2、活动预告：青岛HR俱乐部*联谊会 ----给个人成长凝聚充沛的外部人脉资源。
                 时间：每月第三个周六14:00-17:00     地点：职来职往青岛汽车北站人才市场②号馆</p>
                <p>&nbsp;</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>   
</asp:Content>
