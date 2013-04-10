<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApp.PartnerTemplates._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id="txbTitle" runat="server"></title>
    <link href="css/styles.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://lib.sinaapp.com/js/jquery/1.8.3/jquery.min.js"></script>
    <script src="../Resources/js/artDialog.js" type="text/javascript"></script>
    <link href="../Resources/skins/idialog.css" rel="stylesheet" type="text/css" />
    <script src="../Resources/js/iframeTools.source.js" type="text/javascript"></script>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" border="0" cellpadding="0" cellspacing="0" width="1024">
            <tbody>
                <tr>
                    <td colspan="4" width="1024" style="background-image: url('images/index_01.jpg');">
                        <asp:Label ID="labEnterpriseLogo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" valign="top">
                        <asp:Label ID="labBanner" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" bgcolor="#FFFFFF" height="20">
                        <img src="images/index_03.jpg" height="70" width="1024">
                    </td>
                </tr>
                <tr>
                    <td colspan="4" background="images/index_04.jpg" bgcolor="#FFFFFF" height="20">
                        <table align="center" border="0" cellpadding="0" cellspacing="0" width="91%">
                            <tbody>
                                <tr>
                                    <td>
                                        <asp:Label ID="labEnterpriseContent" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" bgcolor="#FFFFFF" height="20">
                        <img src="images/index_06.jpg" height="84" width="1024">
                    </td>
                </tr>
                <tr>
                    <td colspan="4" background="images/index_07.jpg" bgcolor="#FFFFFF" height="20">
                        <table align="center" border="0" cellpadding="0" cellspacing="0" width="90%">
                            <tbody>
                                <tr>
                                    <td>
                                        <table align="center" border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" OnItemDataBound="DataList1_ItemDataBound" Width="893px">
                                                            <HeaderTemplate>
                                                                
                                                            </HeaderTemplate>
                                                            <ItemTemplate>
                                                                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td height="26" width="33.3%">
                                                                                <li>
                                                                                    <asp:Label ID="labJobTitle" runat="server"></asp:Label>
                                                                                </li>
                                                                            </td>
                                                                        </tr>
                                                                        </tbody>
                                                                </table>
                                                            </ItemTemplate>
                                                            <FooterTemplate>
                                                                    
                                                            </FooterTemplate>
                                                        </asp:DataList>
                                                        
                                                                <%--<tr>
                                                                    <td height="26" width="33%">
                                                                        <li><a href="http://search.51job.com/job/53314370,c.html" target="_blank">手机销售顾问</a>
                                                                            ( 沈阳 )</li>
                                                                    </td>
                                                                    <td>
                                                                        <li><a href="http://search.51job.com/job/53314369,c.html" target="_blank">手机销售顾问</a>
                                                                            ( 成都 )</li>
                                                                    </td>
                                                                    <td width="34%">
                                                                        <li><a href="http://search.51job.com/job/53314368,c.html" target="_blank">手机销售顾问</a>
                                                                            ( 上海 )</li>
                                                                    </td>
                                                                </tr>--%>
                                                            
                                                        <table class="9t" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                        </table>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <hr>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <strong>职位联系方式</strong>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tbody>
                                                                <tr>
                                                                    <td align="right" nowrap="nowrap" valign="top">公司地址：
                                                                    </td>
                                                                    <td align="left" valign="top"><asp:Label ID="labJobContactAdd" runat="server"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" nowrap="nowrap" valign="top">联系电话：
                                                                    </td>
                                                                    <td align="left" valign="top"><asp:Label ID="labJobContactPhone" runat="server"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" nowrap="nowrap" valign="top">联系人员：
                                                                    </td>
                                                                    <td align="left" valign="top"><asp:Label ID="labJobContactName" runat="server"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" background="images/index_09.jpg" bgcolor="#FFFFFF" height="70">
                        <table align="center" border="0" cellpadding="0" cellspacing="0" width="90%">
                            <tbody>
                                <tr>
                                    <td>
                                        <div align="center">
                                            未经 校企英才 同意，不得转载本网站之所有招聘信息及作品；校企英才版权所有&#169;1999-
                                        <%--<script>document.write((new Date()).getYear()+(navigator.userAgent.indexOf("Firefox")==-1?0:1900))</script>--%>
                                        2012 &nbsp;
                                        </div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                </tr>
            </tbody>
        </table>
    </form>
</body>
</html>
