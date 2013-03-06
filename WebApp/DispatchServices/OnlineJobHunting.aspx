<%@ Page Language="C#" MasterPageFile="~/MasterPage/List01.Master" AutoEventWireup="true" CodeBehind="OnlineJobHunting.aspx.cs" Inherits="WebApp.OnlineJobHunting" Title="校企英才官网-在线求职" %>
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
    <script type="text/javascript" src="../Resources/js/OnlineJobHunting.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ext:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" Theme="Gray" />
    <div class="content">
        <div class="main">
            <div class="banner2">
                <a href="../guideenterprises.aspx" target="_blank"><img style="border:0px;" src="../Resources/images/banner1.jpg" width="1000" height="100" /></a>
            </div>
            <div class="bar">
                <b>在线求职</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">在线求职</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <%--<dt class="original1">企业服务</dt>
                        <dd>
                            <a href="EnterpriseServices.aspx">劳务派遣</a>
                            <a href="PersonnelAgency.aspx">人事代理</a>
                            <a href="RecruitmentAgents.aspx">代理招聘</a>
                            <a href="#">临时(短期)工</a>
                        </dd>
                        <dt class="original1">院校合作</dt>
                        <dd>
                            <a href="CollegesUniversities.aspx">院校合作</a>
                            <a href="OrderCultivation.aspx">订单培养</a>
                            <a href="SchoolInvite.aspx">校园招聘</a>
                            <a href="EnterpriseAssistant.aspx">引企助教</a>
                        </dd>
                        <a style='text-decoration:none;' href="../About/PartnerList.aspx"><dt class="original1">合作伙伴</dt></a>--%>
                        <%--<dd>
                            <a href="../About/PartnerList.aspx">合作伙伴</a>
                        </dd>--%>
                        <a style='text-decoration:none;' href="OnlineJobHunting.aspx"><dt class="expand1" style="color:#314777;">个人求职</dt></a>
                        <%--<dd>
                            <a href="OnlineJobHunting.aspx">在线求职</a>
                        </dd>--%>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
                <h2 class="title6">
                    您的个人资料将会保存在校企英才的人才库中</h2>
                <p>
                    请保证填写信息的完整性及真实性，便于我们及时的联系到您!</p>
                <div class="liuy">
                    <div class="c">
                        <div class="l">
                            用户姓名(中文)：</div>
                        <div class="r">
                            <ext:TextBox ID="txbUserName" runat="server" Width="300px" EmptyText="您的真实姓名" Required="true" RequiredMessage="用户名不能为空"></ext:TextBox>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l">
                            用户性别：</div>
                        <div class="r">
                            <ext:DropDownList ID="drpSex" runat="server" Width="300px">
                                <ext:ListItem Text="男" Value="1" />
                                <ext:ListItem Text="女" Value="0"/>
                            </ext:DropDownList>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l">
                            出生日期：</div>
                        <div class="r">
                            <ext:DatePicker ID="txbBirthday" runat="server" Width="300px" EmptyText="用户出生日期" Required="true" RequiredMessage="出生日期不能为空"></ext:DatePicker>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l">
                            用户籍贯：</div>
                        <div class="r">
                            <ext:TextBox ID="txbUserCountry" runat="server" Width="300px" EmptyText="用户籍贯" Required="true" RequiredMessage="用户籍贯不能为空"></ext:TextBox>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l">
                            电子邮件：</div>
                        <div class="r">
                            <ext:TextBox ID="txbEmail" runat="server" Width="300px" EmptyText="常用的电子邮件地址" RegexPattern="EMAIL" RegexMessage="电子邮件格式错误" Required="true" RequiredMessage="电子邮件不能为空"></ext:TextBox>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l">
                            联系电话(手机)：</div>
                        <div class="r">
                            <ext:TextBox ID="txbUserMobiNumber" runat="server" Width="300px" EmptyText="常用的手机号码" RegexPattern="NUMBER" RegexMessage="手机号码格式错误" Required="true" RequiredMessage="手机号码不能为空"></ext:TextBox>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l">
                            家庭电话(座机)：</div>
                        <div class="r">
                            <ext:TextBox ID="txbHomeTelephone" runat="server" Width="300px" EmptyText="座机电话号码" Required="false"></ext:TextBox>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l">
                            期望薪资：</div>
                        <div class="r">
                            <ext:TextBox ID="txbHopeWorkSalary" runat="server" EmptyText="您的期望薪资" Width="300px"></ext:TextBox>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l">
                            教育背景：</div>
                        <div class="r">
                            <ext:TextArea ID="txbUserEducationalBackground" runat="server" Height="150px" EmptyText="您的教育背景" Width="300px" Required="true" RequiredMessage="教育背景不能为空"></ext:TextArea>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l">
                            工作技能：</div>
                        <div class="r">
                            <ext:TextArea ID="txbWorkSkill" runat="server" EmptyText="您的工作技能" Height="150px" Width="300px" Required="true" RequiredMessage="工作技能不能为空"></ext:TextArea>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <p style="margin-bottom:10px;margin-top:10px;">&nbsp;</p>
                    <div style="padding-left:35%;">
                       <%--<ext:Button ID="btnSubmit" runat="server" Text="提　交" EnablePostBack="false" EnableAjax="false" Icon="Add"></ext:Button>--%>
                        <%--<input type="button" value="提 交" id="btnSubmit" />--%>
                        <ext:HiddenField ID="txbPostBackURL" runat="server"></ext:HiddenField>
                        <input type="submit" value="提交" />
                    </div>
                </div>
                <p style="margin-bottom:10px;margin-top:10px;">&nbsp;</p>
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>

</asp:Content>
