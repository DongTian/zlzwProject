<%@ Page Language="C#" MasterPageFile="ContactUs.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="WebApp.About.ContactUs" Title="校企英才官网-联系我们" %>
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
                <b>联系我们</b><span>当前位置：<a href="../default.aspx">首页</a> > <a href="#">联系我们</a></span>
            </div>
            <div class="left1">
                <div class="wenti1">
                    <dl>
                        <dt class="expand1">联系我们</dt>
                        <dd style="display:block;">
                            <a href="ContactUs.aspx" class="h_hover2">联系我们</a>
                            <a href="Feedback.aspx">在线留言</a>
                        </dd>
                    </dl>
                </div>
            </div>
            <div class="right1" style="font-size:14px; line-height:25px;">
		<table style='width:100%;'>
			<tr>
				<td>
					<p style="margin-bottom:10px;margin-top:10px;">青岛校企英才人力资源开发有限公司</p>
					<p style="margin-bottom:10px;margin-top:10px;">地址：青岛市城阳区重庆北路59号(汽车北站南侧)</p>
					<p style="margin-bottom:10px;margin-top:10px;">服务电话：4008-118-678</p>
					<p style="margin-bottom:10px;margin-top:10px;">公司传真：0532-80971210</p>
					<p style="margin-bottom:10px;margin-top:10px;">企业邮箱：sales@zhilaizhiwang.net</p>
					<p style="margin-bottom:10px;margin-top:10px;">网址：www.zhilaizhiwang.net</p>
					<p style="margin-bottom:10px;margin-top:10px;">客户中心业务专线：0532-80971215</p>
					<p style="margin-bottom:10px;margin-top:10px;">人才市场业务专线：0532-89087588　89087688</p>
					<p style="margin-bottom:10px;margin-top:10px;">地址：1号馆汽车北站二楼大厅</p>
					<p style="margin-bottom:10px;margin-top:10px;margin-left:41px;">2号馆汽车北站南侧如家酒店一楼</p>
				</td>
				<td valign="top">
					<div id="map" style="width:300px;height:420px"></div>
				</td>
			</tr>
		</table>
                <!--<p style="margin-bottom:10px;margin-top:10px;">青岛校企英才人力资源开发有限公司</p>
                <p style="margin-bottom:10px;margin-top:10px;">地址：青岛市城阳区重庆北路59号(汽车北站南侧)</p>
                <p style="margin-bottom:10px;margin-top:10px;">服务电话：4008-118-678</p>
                <p style="margin-bottom:10px;margin-top:10px;">公司传真：0532-80971210</p>
                <p style="margin-bottom:10px;margin-top:10px;">企业邮箱：sales@zhilaizhiwang.net</p>
                <p style="margin-bottom:10px;margin-top:10px;">网址：www.zhilaizhiwang.net</p>
                <p style="margin-bottom:10px;margin-top:10px;">客户中心业务专线：0532-80971215</p>
		        <p style="margin-bottom:10px;margin-top:10px;">加盟连锁业务专线：0532-80981178</p>
                <p style="margin-bottom:10px;margin-top:10px;">人才市场业务专线：0532-89087588　89087688</p>
                <p style="margin-bottom:10px;margin-top:10px;">地址：1号馆汽车北站二楼大厅　2号馆汽车北站南侧如家酒店一楼</p>-->
            </div>
            
            <div class="clear">
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $().ready(function () {
            loadScript();
        });
			function initialize() 
			{
				  var mp = new BMap.Map('map');  
				  mp.centerAndZoom(new BMap.Point(120.400229, 36.247913), 11);
				  mp.addControl(new BMap.NavigationControl());  //添加默认缩放平移控件
				  mp.addControl(new BMap.NavigationControl({anchor: BMAP_ANCHOR_TOP_RIGHT, type: BMAP_NAVIGATION_CONTROL_SMALL}));  //右上角，仅包含平移和缩放按钮
				  mp.addControl(new BMap.NavigationControl({anchor: BMAP_ANCHOR_BOTTOM_LEFT, type: BMAP_NAVIGATION_CONTROL_PAN}));  //左下角，仅包含平移按钮
			          mp.addControl(new BMap.NavigationControl({anchor: BMAP_ANCHOR_BOTTOM_RIGHT, type: BMAP_NAVIGATION_CONTROL_ZOOM}));  //右下角，仅包含缩放按钮
				  
				  var point = new BMap.Point(120.400229, 36.247913);
				  mp.centerAndZoom(point, 15);
				  var marker = new BMap.Marker(point);  // 创建标注
				  mp.addOverlay(marker);              // 将标注添加到地图中
				  marker.setAnimation(BMAP_ANIMATION_BOUNCE); //跳动的动画
				  
				  var opts = {
				  	width : 180,     // 信息窗口宽度
				  	height: 70,     // 信息窗口高度
				  	title : "<strong>青岛校企英才人力资源开发公司</strong>"  // 信息窗口标题
				}
				var infoWindow = new BMap.InfoWindow("<hr/><p>地址：青岛市城阳区重庆北路59号</p>", opts);  // 创建信息窗口对象
				mp.openInfoWindow(infoWindow,point); //开启信息窗口
			}
			
			function loadScript() 
			{  
				var script = document.createElement("script");
				script.src = "http://api.map.baidu.com/api?v=1.4&callback=initialize";  
				document.body.appendChild(script);
			}
			
			window.onload = loadScript;
			
		</script>
</asp:Content>
