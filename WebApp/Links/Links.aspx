﻿<%@ Page Language="C#" MasterPageFile="~/Links/Links.Master" AutoEventWireup="true" CodeBehind="Links.aspx.cs" Inherits="WebApp.Links.Links1" Title="校企英才官网=友情链接" %>
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
                <b>友情链接</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">友情链接</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <dt class="expand1">友情链接</dt>
                        <dd style="display:block;">
                            <a href="Links.aspx" class="h_hover2">友情链接</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" onitemdatabound="DataList1_ItemDataBound">
                    <ItemTemplate>
                        <table style="margin-left:28px; margin-top:10px;">
                        <tr>
                            <td align="center">
                                <div class="jiameng_gongsi01">
                                    <asp:Label ID="labLinkImage" runat="server" style="margin-top:10px;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:Label ID="labLinkTitle" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    </ItemTemplate>
                    <SeparatorTemplate>
                        <table>
                            <tr>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                            </tr>
                        </table>
                    </SeparatorTemplate>
                </asp:DataList>
                <p>&nbsp;</p>
            <asp:DataList ID="DataList2" runat="server" RepeatColumns="3" 
                RepeatDirection="Horizontal" onitemdatabound="DataList2_ItemDataBound">
                <ItemTemplate>
                    <table style="margin-left:28px; margin-top:10px;">
                        <tr>
                            <td>
                                <asp:Label ID="labLinksText" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
