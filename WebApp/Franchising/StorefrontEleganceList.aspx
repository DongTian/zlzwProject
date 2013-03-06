<%@ Page Language="C#" MasterPageFile="Franchising.Master" AutoEventWireup="true" CodeBehind="StorefrontEleganceList.aspx.cs" Inherits="WebApp.Franchising.StorefrontEleganceList" Title="校企英才官网-店面风采" %>
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
                <b>店面风采</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">店面风采</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <asp:Repeater ID="Repeater1" runat="server" onitemdatabound="Repeater1_ItemDataBound">
                            <ItemTemplate>
                                <dl>
                                    <asp:Label ID="labMenuContent" runat="server"></asp:Label>
                                </dl>
                            </ItemTemplate>
                        </asp:Repeater>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
                <div class="bar4" style="color:#F26200;">
                    <strong>店面风采</strong></div>
                    <table>
                    <tr>
                        <td valign="top">
                            <asp:Label ID="labStoreImage" runat="server"></asp:Label>
                        </td>
                        <td style="width:15px;">
                           
                        </td>
                        <td valign="top">
                            <table>
                                <tr>
                                    <td valign="top" class='bar6'>
                                        <asp:Label ID="labStoreDesc" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="labPostJob" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <asp:DataList ID="DataList1" runat="server"  RepeatColumns="2" RepeatDirection="Horizontal" onitemdatabound="DataList1_ItemDataBound">
                            <ItemTemplate>
                                <table style="margin-left:50px; margin-top:30px;">
                                <tr>
                                    <td>
                                        <asp:Label ID="labImageList" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="labImageName" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            </ItemTemplate>
                            <SeparatorTemplate>
                                
                            </SeparatorTemplate>
                        </asp:DataList>
                    </tr>
                    <tr>
                        <td><p style="margin-bottom:10px;margin-top:10px;"></p></td>
                    </tr>
                </table>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
