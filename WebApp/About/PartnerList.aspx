<%@ Page Language="C#" MasterPageFile="About.Master" AutoEventWireup="true" CodeBehind="PartnerList.aspx.cs" Inherits="WebApp.About.PartnerList" Title="校企英才官网-合作伙伴" %>
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
                <b>合作伙伴</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">合作伙伴</a></span>
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
                        <a href="PartnerList.aspx" style="text-decoration:none;color:#fff;"><dt class="expand1" style="color:#314777;">合作伙伴</dt></a>
                        <%--<dd>
                            <a href="PartnerList.aspx">合作伙伴</a>
                        </dd>--%>
                        <a href="Co-brand.aspx" style="text-decoration:none;color:#fff;"><dt class="original1">品牌合作</dt></a>
                        <%--<dd>
                            <a href="Co-brand.aspx">品牌合作</a>
                        </dd>--%>
                        <dt class="original1">诚聘英才</dt>
                        <dd>
                            <a href="CareersList.aspx">诚聘英才</a>
                            <a href="http://ceping.zhilaizhiwang.net:82/" target="_blank">人才测评</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
                <table style="width:100%; padding-left:20px;">
                    <asp:Repeater ID="Repeater1" runat="server" 
                        onitemdatabound="Repeater1_ItemDataBound">
                        <ItemTemplate>
                            <tr style="border:1px; border-style:solid; ">
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:Label ID="labLogoImage" runat="server"></asp:Label> 
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" style="font-weight:bold;">
                                                <asp:Label ID="labEnterpriseName" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>   
                                </td>
                                <td style="width:15px;"></td>
                                <td>
                                    <asp:Label ID="labEnterpriseContent" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="title5" colspan="3"></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                    <tr>
                        <td colspan="3" align="center">
                            <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="10" 
                                onpagechanged="AspNetPager1_PageChanged" CssClass="paginator" CurrentPageButtonClass="cpb" FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" >
                            </webdiyer:AspNetPager>
                        </td>
                    </tr>
                </table>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
