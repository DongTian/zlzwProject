$().ready(function(){
    $('.caidan a').bind('click',function(){
        $('.caidan img').attr('src','../Resources/images/youjiantou.gif');
        $('.caidan a').attr('style','color:#F26200;');
        $('.caidan div').hide();
        $(this).prev().attr('src',"../Resources/images/downjiantou.gif")
        $(this).attr('style','color:#243B7F');
        $(this).next().attr('style','display:block;');
        
    });
});