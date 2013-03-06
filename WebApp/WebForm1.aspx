<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="Resources/css/DefaultStyle.css" rel="stylesheet" type="text/css" />

    <script src="http://lib.sinaapp.com/js/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>

    <script src="Resources/js/tab.js" type="text/javascript"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div class="content">
        <div class="main">
            <%--<div class="banner2">
                <img src="img/banner2.jpg" width="1000" height="100" />
            </div>--%>
            <div class="bar">
                <b>用户中心</b><span>当前位置：<a href="http://www.865171.cn/">首页 ></a><a href="http://www.865171.cn/">用户中心</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">

                    <script>
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

                    <dl>
                        <dt class="original1">我的通讯录</dt>
                        <dd>
                            <a href="http://www.865171.cn/" class="h_hover2">联系人列表</a> <a href="http://www.865171.cn/">
                                历史备份记录</a></dd>
                        <dt class="original1">个人信息</dt>
                        <dd>
                            <a href="http://www.865171.cn/" class="h_hover">基本信息</a> <a href="http://www.865171.cn/">
                                修改密码</a> <a href="http://www.865171.cn/">密码保护</a></dd>
                        <dt class="original1">帐号管理</dt>
                        <dd>
                            <a href="http://www.865171.cn/">近期活动</a> <a href="http://www.865171.cn/">往期活动</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1">
                <div class="bar4">
                    密码保护</div>
                <p>
                    密码保护功能可以使你帐号更安全，当密码遗忘或被盗时，通过回答您所设置的问题，系统自动把密码重设外国投资发到您所设置的<a href="http://www.865171.cn/"
                        style="color: #751c00">邮箱</a>。</p>
                <div class="sezhi">
                    <p>
                        1、设置密码保护问题</p>
                    <div class="c">
                        <div class="l1">
                            问题：</div>
                        <div class="r1">
                            <select class="select2">
                                <option>我的小学名字是什么？</option>
                            </select></div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="c">
                        <div class="l1">
                            答案：</div>
                        <div class="r1">
                            <input type="text" class="text1" />(最长30个字)</div>
                        <div class="clear">
                        </div>
                    </div>
                    <p>
                        2、设置密码保护邮箱</p>
                    <div class="c">
                        <div class="l1">
                            邮箱：</div>
                        <div class="r1">
                            <input type="password" class="text1" />(密码重置链接将发送到邮箱)</div>
                        <div class="clear">
                        </div>
                    </div>
                </div>
                <div style="border-top: 1px dashed #cacaca; text-align: center; padding: 20px 0">
                    <a href="http://www.865171.cn/">
                        <img src="img/reset.jpg" width="133" height="36" /></a></div>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
<%--    <div class="foot">
        <div class="foot_nav">
            <a href="http://www.865171.cn/">帮助中心</a>|<a href="http://www.865171.cn/">隐私条款</a>|<a
                href="http://www.865171.cn/">关于我们</a></div>
        <div class="foot_bar">
            <img src="img/logo2.jpg" width="114" height="42" align="left" />&copy;2009.INBAI
            Technology Co.Ltd<br />
            粤ICP备09104593</div>
        <div class="clear">
        </div>
    </div>--%>
    </form>
</body>
</html>
