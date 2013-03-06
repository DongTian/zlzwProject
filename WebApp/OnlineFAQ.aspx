<%@ Page Language="C#" MasterPageFile="~/MasterPage/List.Master" AutoEventWireup="true"
    CodeBehind="OnlineFAQ.aspx.cs" Inherits="WebApp.OnlineFAQ" Title="校企英才官网-在线留言" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cidao">
        当前位置：<a href="../default.aspx" class="huia" title="返回关于校企">首页</a> > <span style="color: #486682;">在线留言</span></div>
    <div class="neirong2 m10">
        <div class="wenben3">
            <div class="wenben">
                <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                    <ItemTemplate>
                        <table class="bor_gray1" align="center" style="font-size: 12px; font-family: 微软雅黑;
                            width: 95%;" border="0" cellpadding="3" cellspacing="0">
                            <tr>
                                <td>
                                    　<span style="color: #243B7F; font-weight: bold;">提问人：<asp:Label ID="labPublishUserName"
                                        runat="server"></asp:Label></span>
                                    <div style="float: right;">
                                        　<asp:Label ID="labPublishDate" runat="server"></asp:Label></div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    　<asp:Label ID="labPublishContent" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="border-bottom: dotted 1px #6e6e6e;">
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    　<span style="color: #F26200; font-weight: bold;">解答人：<asp:Label ID="labReplyUser" runat="server"></asp:Label></span>
                                    　<div style="float: right;">
                                        <asp:Label ID="labReplyDate" runat="server"></asp:Label></div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    　<asp:Label ID="labReplyContent" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <br />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SeparatorTemplate>
                        <br />
                    </SeparatorTemplate>
                </asp:Repeater>
                <div style=" height:35px; text-align:center; margin-top:15px; float:left; width:100%;">
                    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="5" OnPageChanged="AspNetPager1_PageChanged"
                        CssClass="paginator" CurrentPageButtonClass="cpb" FirstPageText="首页" LastPageText="尾页"
                        NextPageText="下一页" PrevPageText="上一页">
                    </webdiyer:AspNetPager>
                </div>
                <div style="float:left; padding-left:25px;">
                   <table>
                       <thead>
                           <span style="font-size:20px; color:#243B7F; font-weight:bold;">用户留言</span>
                       </thead>
                       <tr>
                        <td style="height:10px;"></td>
                       </tr>
                       <tr>
                        <td>
                            <input name="search" runat="server" type="text" id="search" class="textfield" onfocus="if(this.value=='用户姓名') {this.value='';}this.style.color='#6e6e6e';" onblur="if(this.value=='') {this.value='用户姓名';this.style.color='#ccc';}" value="用户姓名" maxlength="20"/>
                        </td>
                    </tr>
                       <tr>
                        <td>
                            <textarea runat="server" id="textarea" name="textarea" class="textarea"></textarea>
                        </td>
                    </tr>
                       <tr>
                        <td align="center">
                            <div style="margin-top:20px;"><asp:Button ID="btnSubmit" runat="server" Text=" 提 问 →" onclick="btnSubmit_Click" OnClientClick="return btnSubmit_ClientClick();" /></div>
                        </td>
                    </tr>
                   </table>
                </div>
            </div>
        </div>
        <div class="clear">
        </div>
    </div>
    <script type="text/javascript">
        function btnSubmit_ClientClick()
        {
            if(document.getElementById('Hidden1').value == 1)
            {
                alert("您的留言已经提交，请不要重复提交");
                return false;
            }
            if(document.getElementById('ctl00_ContentPlaceHolder1_search').value == "用户姓名" || document.getElementById('ctl00_ContentPlaceHolder1_search').value == "")
            {
                alert("请填写用户姓名");
                return false;
            }
            if(document.getElementById('ctl00_ContentPlaceHolder1_textarea').value.length == 0)
            {                           
                alert("请填提问内容");
                return false;
            }
            document.getElementById('Hidden1').value = 1;        
            return true;
        }
    </script>

    <input id="Hidden1" type="hidden" value="0" />
</asp:Content>
