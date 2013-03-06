$().ready(function() {
    $.ajax({
        type: 'POST',
        url: 'Resources/Services/GetBannerList.asmx/Get_BannerList',
        contentType: 'application/json',
        data: '', 
        success: function(data) {
            if(data.d != "")
            {
                $('.slider').append(data.d);
                $(".slider").slideshow({
                    width      : 1000,
                    height     : 452,
                    selector   : false,
                    timer      : false,
                    transition : 'slipbottom'
                });
                return;
            }
        }
    });
    $.ajax({
        type: 'POST',
        url: 'Resources/Services/GetRegionList.asmx/Get_PostList',
        contentType: 'application/json',
        data: '{strID:14}', 
        success: function (data) {
            if(data.d != "-1")
            {
                $('#labPostList').empty();
                document.getElementById('labPostList').innerHTML  = data.d;
                $('.xinwen').ajaxloader('hide');
                return;
            }
            else if(data.d == "0")
            {
                $('#labPostList').empty();
                $('#labPostList').append("暂无相关职位");
                $('.xinwen').ajaxloader('hide');
                return;
            }
        }
    });
    $(".xinwen").ajaxStart(function(){
       $('.xinwen').ajaxloader();
    })
    //加载地区类型
    $.ajax({
        type: 'POST',
        url: 'Resources/Services/GetRegionList.asmx/Get_RegionList',
        contentType: 'application/json',
        data: '', 
        success: function(data) {
            if(data.d != "-1")
            {
                $('#labRegoin').html(data.d);
                $('a[name=RegionType]').bind('click',function(){
                    $('a[name=RegionType]').attr('style','cursor:pointer;color: #6e6e6e;font-size:14px;');
                    $('#'+this.id).attr('style','cursor:pointer;color:#F87A00;font-weight:bolder;font-size:16px;');
                    //加载地区所属职位
                    $.ajax({
                        type: 'POST',
                        url: 'Resources/Services/GetRegionList.asmx/Get_PostList',
                        contentType: 'application/json',
                        data: '{"strID":"'+ this.id +'"}', 
                        success: function (data) {
                            if(data.d.length > 0)
                            {
                                $('#labPostList').empty();
                                document.getElementById('labPostList').innerHTML  = data.d;
                                $('.xinwen').ajaxloader('hide');
                            }
                            else if(data.d.length == 0)
                            {
                                $('#labPostList').empty();
                                $('#labPostList').append("暂无相关职位");
                                $('.xinwen').ajaxloader('hide');
                            }
                        }
                    });
                });
            }
        }
    }); 
    
    $('#txbSearchKey').bind('focus',function(){
        $('#txbSearchKey').val('');
    });
    $('#txbSearchKey').bind('blur',function(){
        if($('#txbSearchKey').val() == '')
        $('#txbSearchKey').val('输入职位关键词：如销售总监等');
    });
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
});

function validata_SearchValue()
{
    var strSearchKey = document.getElementById('txbSearchKey').value;
    if(strSearchKey.length == 0 || strSearchKey == '' || strSearchKey == '输入职位关键词：如销售总监等')
    {
        alert("请输入待查询的职位关键字或词");
        return false;
    }
    return true;
}

function openMail()
{
    art.dialog.open("EMailTemplate.html", {width: 477, height: 271});
}

function open_DataBaseUserLogin() {
    art.dialog.open("DataBaseUserLogin.html", { width: 477, height: 271 });
}