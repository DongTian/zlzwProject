<%@ Page Language="C#" MasterPageFile="About.Master" AutoEventWireup="true"
    CodeBehind="CareersList.aspx.cs" Inherits="WebApp.About.CareersList" Title="校企英才官网-诚聘英才" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

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
                <b>诚聘英才</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">诚聘英才</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a href="AboutKingStudy.aspx" style="text-decoration:none;"><dt class="original1">校企简介</dt></a>
                        <%--<dd>
                            <a href="AboutKingStudy.aspx">校企简介</a>
                        </dd>--%>
                        <a href="EnterpriseCulture.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">企业文化</dt></a>
                        <%--<dd>
                            <a href="EnterpriseCulture.aspx">企业文化</a>
                        </dd>--%>
                        <a href="EnterpriseNews.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">企业动态</dt></a>
                        <%--<dd>
                            <a href="EnterpriseNews.aspx">企业动态</a>
                        </dd>--%>
                        <a href="PublicWelfare.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">公益事业</dt></a>
                        <%--<dd>
                            <a href="PublicWelfare.aspx">公益事业</a>
                        </dd>--%>
                        <a href="PartnerList.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">合作伙伴</dt></a>
                        <%--<dd>
                            <a href="PartnerList.aspx">合作伙伴</a>
                        </dd>--%>
                        <a href="Co-brand.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">品牌合作</dt></a>
                        <%--<dd>
                            <a href="Co-brand.aspx">品牌合作</a>
                        </dd>--%>
                        <dt class="expand1">诚聘英才</dt>
                        <dd style="display:block;">
                            <a href="CareersList.aspx" class="h_hover2">诚聘英才</a>
                            <a href="http://ceping.zhilaizhiwang.net:82/" target="_blank">人才测评</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
                <asp:Repeater ID="Repeater1" runat="server" 
                    onitemdatabound="Repeater1_ItemDataBound">
                    <ItemTemplate>
                        <table class="bor_gray1" align="center" style="font-size: 12px; font-family: 微软雅黑;"
                            border="0" cellpadding="5" cellspacing="0" width="100%">
                            <tbody>
                                <tr>
                                    <td colspan="2" bgcolor="#fdfcfc" height="24" style="font-weight:bold;">
                                        <asp:Label ID="labJobTitle" runat="server" style="padding-left:35px;color:#243B7F;"></asp:Label>
                                        <div style="float:right;color:#243B7F;"><asp:Label ID="labPublishDate" runat="server"></asp:Label>&nbsp;&nbsp;</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td bgcolor="#fdfcfc">
                                        &nbsp;
                                    </td>
                                    <td class="td_wz" bgcolor="#fdfcfc">
                                            <span style="font-weight:bold;">岗位职责</span>
                                        <asp:Label ID="labResponsibilities" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td bgcolor="FDFCFC" width="35">
                                        &nbsp;
                                    </td>
                                    <td class="td_wz" bgcolor="#fdfcfc">
                                            <span style="font-weight:bold;">任职资格：</span><br />
                                        <asp:Label ID="labQualifications" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="background-color:#fff;">
                                    <td bgcolor="FDFCFC" width="35">
                                        &nbsp;
                                    </td>
                                    <td class="td_wz" bgcolor="#fdfcfc" style="float:right;">
                                            <span style="font-weight:bold;"><asp:Label ID="labCheck" runat="server"></asp:Label>&nbsp;&nbsp;</span><br />
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </ItemTemplate>
                    <SeparatorTemplate>
                        <br />
                    </SeparatorTemplate>
                </asp:Repeater>
                <div class="qie">
                    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="5" 
                        onpagechanged="AspNetPager1_PageChanged" CssClass="paginator" CurrentPageButtonClass="cpb" FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" >
                    </webdiyer:AspNetPager>
                </div>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
