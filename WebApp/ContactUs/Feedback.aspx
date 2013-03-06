<%@ Page Language="C#" MasterPageFile="ContactUs.Master" AutoEventWireup="true"
    CodeBehind="Feedback.aspx.cs" Inherits="WebApp.Feedback" Title="校企英才官网-在线留言" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
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
                <b>在线留言</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">在线留言</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <dt class="expand1">联系我们</dt>
                        <dd style="display: block;">
                            <a href="ContactUs.aspx">联系我们</a> <a href="Feedback.aspx" class="h_hover2">在线留言</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size: 14px; line-height: 25px;">
                <h2 class="title6">
                    通过给校企英才留言，最快满足您的需求</h2>
                <p>
                    成功提交的留言将在12小时内给予回复</p>
                <div class="liuy">
                    <div class="c">
                        <div class="l">
                            用户姓名：</div>
                        <div class="r">
                            <input id="search" runat="server" style="height:20px;"/>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l">
                            留言内容：</div>
                        <div class="r">
                            <textarea runat="server" id="textarea" name="textarea" class="textarea"></textarea>
                        </div>
                    </div>
                    <div class="c">
                        <div class="clear">
                        </div>
                    </div>
                    <div style="text-align: center; padding: 10px 0">
                        <asp:Button ID="btnSubmit" runat="server" CssClass="btn1" onclick="btnSubmit_Click" OnClientClick="return btnSubmit_ClientClick();" />
                    </div>
                </div>
                <div class="hist">
                    <h2 class="title7">
                        历史留言</h2>
                    <asp:Repeater ID="Repeater1" runat="server" onitemdatabound="Repeater1_ItemDataBound">
                        <ItemTemplate>
                            <div class="list1">
                                <div class="list1_l">
                                    <img src="../Resources/images/icon10.jpg" width="23" height="26" /></div>
                                <div class="list1_r">
                                    <h3>
                                        <span style="color:#304877; font-size:16px;">咨询：</span><span class="time"><div style="float:right;"><asp:Label ID="labPublishDate" runat="server"></asp:Label></div></span></h3>
                                    <p style="margin-bottom:10px;margin-top:10px;">
                                        <asp:Label ID="labContent" runat="server" style="line-height:25px;"></asp:Label>
                                    </p>
                                </div>
                                <div class="clear">
                                </div>
                            </div>
                            <div class="list1">
                                <div class="list1_l">
                                    <img src="../Resources/images/icon11.jpg" width="23" height="26" /></div>
                                <div class="list1_r1">
                                    <div class="jiantou2">
                                    </div>
                                    <h3>
                                        <span style="color:#F26200; font-size:16px;">回复：</span><span class="time"><div style="float:right;"><asp:Label ID="labReplyPublish" runat="server"></asp:Label></div></span></h3>
                                    <p style="margin-bottom:10px;margin-top:10px;">
                                        <asp:Label ID="labReplyContent" runat="server" style="line-height:25px;"></asp:Label></p>
                                </div>
                                <div class="clear">
                                </div>
                            </div>
                        </ItemTemplate>
                        <SeparatorTemplate>
                            <div class="line">
                            </div>
                        </SeparatorTemplate>
                    </asp:Repeater>
                    <div class="more2">
                        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="5" OnPageChanged="AspNetPager1_PageChanged"
                            CssClass="paginator" CurrentPageButtonClass="cpb" FirstPageText="首页" LastPageText="尾页"
                            NextPageText="下一页" PrevPageText="上一页">
                        </webdiyer:AspNetPager>
                    </div>
                </div>
            </div>
            <div class="clear">
            </div>
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
