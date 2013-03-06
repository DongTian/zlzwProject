<%@ Page Language="C#" MasterPageFile="About.Master" AutoEventWireup="true"
    CodeBehind="CareersInfo.aspx.cs" Inherits="WebApp.About.CareersInfo" Title="校企英才官网-诚聘英才" %>

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
                <b style="color:#E57117;">诚聘英才</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="CareersList.aspx">诚聘英才</a></span>
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
                <%--<div class="bar4" style="color:#E97014;">
                    <strong>诚聘英才</strong></div>--%>
                <table style="width: 100%; padding-left:25px;">
                    <tr>
                        <td>
                            <p>职位名称：<asp:Label ID="labJobTitle" runat="server"></asp:Label></p>
                        </td>
                   </tr>
                   <tr>
                        <td>
                            <p>发布日期：<asp:Label ID="labPublishDate" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>招聘部门：<asp:Label ID="labDeptName" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>招聘人数：<asp:Label ID="labCareersCount" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>学历要求：<asp:Label ID="labEducational" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>工作经验：<asp:Label ID="labWorkExperience" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>岗位职责：<br /><asp:Label ID="labResponsibilities" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>任职资格：<br /><asp:Label ID="labQualifications" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>工作地址：<asp:Label ID="labWorkAdd" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>联系电话：<asp:Label ID="labTel" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>联系邮箱：<asp:Label ID="labMail" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>联系人：<asp:Label ID="labContactMan" runat="server"></asp:Label></p>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:15px;"></td>
                    </tr>
                </table>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
