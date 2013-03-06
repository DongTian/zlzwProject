<%@ Page Language="C#" MasterPageFile="~/MasterPage/OnlineApplication.Master" AutoEventWireup="true" CodeBehind="OnlineApplicationInfo.aspx.cs" Inherits="WebApp.OnlineApplicationInfo" Title="校企英才官网-在线招聘" %>
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
                <b>招聘动态</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="OnlineApplication.aspx">招聘动态</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <a href="OnlineApplication.aspx" style="text-decoration:none;color:#fff;">
                            <dt class="expand1" style="color:#314777;">招聘动态</dt>
                        </a>
                    </dl>
                </div>
            </div>
            <div class="right1 xinwen_nei2" style="font-size:14px; line-height:25px;">
                <table style="width: 100%;">
                    <tr>
                        <td align="left">
                            企业名称：<asp:Label ID="labEnterpriseTitle" runat="server"></asp:Label>
                        </td>
                        <td>
                            发布日期：<asp:Label ID="labPublisDate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           &nbsp; 
                        </td>
                    </tr>
                    <tr>
                        <td>
                            工作地点：<asp:Label ID="labWorkAdd" runat="server"></asp:Label>
                        </td>
                        <td>
                            招聘人数：<asp:Label ID="labRecruitmentNumber" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            职位信息：<asp:Label ID="labPostInfo" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <p>岗位要求：</p><asp:Label ID="labPostDemand" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <p>待遇相关：</p><asp:Label ID="labTreatmentInfo" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            其他信息：<asp:Label ID="labOtherInfo" Visible="false" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
