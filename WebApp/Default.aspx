<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<%@ Register src="Resources/UserControls/byeguoguo.ascx" tagname="byeguoguo" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>校企英才官网欢迎您</title>
    <link href="Resources/css/style.css" rel="stylesheet" type="text/css" />
    <link href="Resources/css/common.css" rel="stylesheet" type="text/css" />
    <link href="Resources/css/public.css" rel="stylesheet" type="text/css" />
    <link href="Resources/css/byeGuoGuo.css" rel="stylesheet" type="text/css" />
    <link href="Resources/css/jquery.slider.css" rel="stylesheet" type="text/css" />
    <link href="Resources/css/ajaxloader.css" rel="stylesheet" type="text/css" />
    <!--[if IE 6]>
        <link rel="stylesheet" type="text/css" href="Resources/css/jquery.slider.ie6.css" />
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div class="top1">
            <div class="top1_965">
                <div class=" top1_wen m4">
                    服务热线：<span class="red">4008-118-678 </span>意见反馈</div>
                <div class="top1_wen2 m4">
                    <a href="#" class="honga" onclick="javascript:open_DataBaseUserLogin();return false;">企业登陆</a> / <a href="#" class="honga" onclick="javascript:open_DataBaseUserLogin();return false;">合作伙伴登陆</a> / <a href="#"
                        class="honga" onclick="javascript:open_DataBaseUserLogin();return false;">员工登陆</a></div>
            </div>
        </div>
        <div class="top2">
            <div class="logo">
                <img src="Resources/images/tu_03.gif" /></div>
            <div class="daohang">
                <div class="blue" style="margin-top: 15px;">
                    <div id="slatenav">
                        <ul>
                            <li><a id="menuItem01" name="navigateItem" href="default.aspx" class="current">首页</a></li>
                            <li><a id="menuItem02" name="navigateItem" href="About/AboutKingStudy.aspx">关于校企</a></li>
                            <li><a id="menuItem03" name="navigateItem" href="DispatchServices/EnterpriseServices.aspx">劳务合作</a></li>
                            <li><a id="menuItem04" name="navigateItem" href="Franchising/ProjectDescription.aspx">加盟连锁</a></li>
                            <li><a id="menuItem05" name="navigateItem" href="http://www.zhixingtianxia.net:86/" target="_blank">人才市场</a></li>
                            <li><a id="menuItem06" name="navigateItem" href="OnlineApplication.aspx">招聘动态</a></li>
                            <li><a id="A1" name="navigateItem" href="DispatchServices/OnlineJobHunting.aspx">个人求职</a></li>
                            <li><a id="menuItem07" name="navigateItem" href="ContactUs/ContactUs.aspx">联系我们</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class="banner">
            <table style="width: 100%;">
                <tr>
                    <td align="center">
                        <div id="index_main">
                            <div class="slider">
                            </div>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
        <div class="serach">
            <div class="serach_1">
                <div class="serach_2">
                    <div class="serach_2_1">
                        <img src="Resources/images/1.jpg" width="141" height="30" /></div>
                    <div class="serach_2_2">
                        <input name="txbSearchKey" runat="server" type="text" class="juxing border m6 le" id="txbSearchKey" value="输入职位关键词：如销售总监等" />
                        <div class="juxing2">
                            <%--<img src=" />--%>
                            <asp:ImageButton ID="btnSearch" ImageUrl="Resources/images/botton_gif_047.gif" runat="server" 
                                width="33" height="24" onclick="btnSearch_Click" OnClientClick="return validata_SearchValue();" />
                        </div>
                    </div>
                    <div class="serach_2_3">
                        100</div>
                </div>
                <div class="serach_3">
                    <ul>
                        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                            <ItemTemplate>
                                <li>
                                    <asp:Label ID="labHotPost" runat="server"></asp:Label></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
        <div class="xuanchuan m10">
            <asp:Label ID="labAdvertising" runat="server"></asp:Label>
            <%--<img src="Resources/images/tu_15.gif" width="960" height="80" />--%></div>
        <div class="neirong m10">
            <div class="kuaijie">
                <a href="DispatchServices/EnterpriseServices.aspx">
                    <img style="border: 0px" src="Resources/images/tu_23.gif" /></a><a href='Franchising/ProjectDescription.aspx'>
                    <img style="border: 0px;" src="Resources/images/tu_27.gif" width="231" height="73" /></a>
                <a href="http://www.zhixingtianxia.net:86/" target="_blank">
                    <img style="border: 0px;" src="Resources/images/tu_28.gif" /></a></div>
            <div class="xinwen">
                <div class="xinwen_biao">
                    <div style="width: 220px; float: left;">
                        <img src="Resources/images/tu_19.gif" width="220" height="33" /></div>
                    <div style="width: 500px; height: 25px; float: left; margin-left: 20px; margin-top: 15px;
                        font-size: 14px; font-family: 微软雅黑; color: #666666; display: inline;">
                        <span class="r"><a href="OnlineApplication.aspx" class="huia">更多</a></span><span id="labRegoin"></span></div>
                </div>
                <div class="xinwen_nei01">
                    <ul id="labPostList">
                    </ul>
                </div>
            </div>
        </div>
        <div class="jiameng">
            <div class="jiameng_biao">
                <img src="Resources/images/tu_30.gif" />
            <div id="hbMore"><a href="About/PartnerList.aspx">更多...</a></div>
            </div>
            <asp:Repeater ID="Repeater2" runat="server" OnItemDataBound="Repeater2_ItemDataBound">
                <ItemTemplate>
                    <div class="jiameng_gongsi">
                        <asp:Label ID="lablabImage" runat="server"></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="bottom">
        </div>
        <div class="bottom2">
            <a href="About/AboutKingStudy.aspx" class="huia">关于我们</a> | <a href="ContactUs/ContactUs.aspx" class="huia">联系我们</a> | <a href="About/CareersList.aspx" class="huia">诚聘英才</a> | <a href="#" class="huia" onclick="javascript:openMail();return false;">企业邮箱</a> | <a href="About/PartnerList.aspx" class="huia">合作伙伴</a> | <a href="../Links/Links.aspx" class="huia">友情链接</a></div>
        <div class="bottom3">
            劳务派遣：0532-80971215　加盟连锁：4008-118-678　人才市场：0532-89087588　传真：0532-80971210</div>
        <div class="bottom3">
            地址：山东省青岛市城阳区重庆北路59号 服务监督邮箱：sales@zhilaizhiwang.net</div>
        <div class="bottom3" style="margin-bottom: 30px;">
            校企英才版权所有1998-2012 未经同意，不得转载本网站之所有信息及作品 鲁ICP备000001</div>
        <div class="clear">
        </div>
    </div>
    <uc1:byeguoguo ID="byeguoguo1" runat="server" />
</form>

    <script type="text/javascript" src="http://lib.sinaapp.com/js/jquery/1.8.3/jquery.min.js"></script>
    <script src="Resources/js/jquery.easing-1.3.pack.js" type="text/javascript"></script>
    <script src="Resources/js/jquery.slider.min.js" type="text/javascript"></script>
    <script src="Resources/js/jquery.ajaxloader.1.4.min.js" type="text/javascript"></script>
    <script src="Resources/js/ByeGuoGuo.js" type="text/javascript"></script>
    <script src="Resources/js/artDialog.js" type="text/javascript"></script>

    <link href="Resources/skins/idialog.css" rel="stylesheet" type="text/css" />
    <script src="Resources/js/iframeTools.source.js" type="text/javascript"></script>
    <script src="Resources/js/default.js" type="text/javascript"></script>
</body>
</html>
