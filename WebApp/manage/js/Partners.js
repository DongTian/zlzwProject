$(document).ready(function () {       
        var x1 = 0;
        var y1 = 0;
        var x2 = 0;
        var y2 = 0;
        $('#imgSrcImage').imgAreaSelect({
            handles: true,
            
            minWidth: 160,
            minHeight: 55,
            resizable:false,
            onSelectEnd: someFunction,
            onSelectChange: imagePreview
        });

        function imagePreview(img, selection) {
            var scaleX = 100 / (selection.width || 1);
            var scaleY = 100 / (selection.height || 1);
          
            $('#imgPreview').css({
                width: Math.round(scaleX * img.width) + 'px',
                height: Math.round(scaleY * img.height) + 'px',
                marginLeft: '-' + Math.round(scaleX * selection.x1) + 'px',
                marginTop: '-' + Math.round(scaleY * selection.y1) + 'px'
             });
        }
        
        function someFunction(img,c)
        {
            x1 = c.x1;
            y1 = c.y1;
            x2 = c.x2;
            y2 = c.y2;
        }
        
        $('#btnUploadPhoto').bind('click',function(){
            
            if(x1 != 0 && y1 != 0 && x2 != 0 && x2 != 0)
            {
                $.ajax({
                    type: 'POST',
                    url: 'webServices/UserPhotoUpload.asmx/Set_UserPhoto',
                    contentType: 'application/json',
                    data: '{"srcImage":"../images/shu.jpg","destImage":"../UsrerPhoto/newuserPhoto.jpg","x":"'+ x1 +'","y":"'+ y1 +'","width":"'+ x2 +'","height":"'+ y2 +'"}', 
                    success: function(data) {
                       alert("头像上传成功"); 
                    }
                });
            }
            else
            {
                alert("请选择一个图片区域");
            }
        });

        $("#filePhoto").uploadify({

        'uploader': '../../uploadify.swf',
        'script': '../Services/UploadPartnersLogo.ashx',
        'cancelImg': '../images/uploadify-cancel.png',
        'fileExt': '*.gif;*.jpg;*.jpeg;*.png;*.bmp' ,
        'folder': '../../PartnersLogo',
        'auto': true,
        'multi': false,
        'fileDesc' : '图片文件',
        'buttonText':'Upload',
        'onProgress':function(event,queueId,fileObj,data)
                    {
//                        $('#userImgLayout').ajaxloader();
                    },
        'onComplete':function(event, queueID, fileObj, response, data)
                     {
                        if(response == "0")
                        {
                            alert("头像上传失败");
                            return;
                        }
                        else
                        {
                            $('#imgSrcImage').attr('src',"../../"+response);
//                            $('#imgPreview').attr('src',"../../"+response);
                            test01();
                        }
                     }
        });
        
    });
    
    
    $.extend({
    includePath: '',
    include: function (file) {
        var files = typeof file == "string" ? [file] : file;
        for (var i = 0; i < files.length; i++) {
            var name = files[i].replace(/^\s|\s$/g, "");
            var att = name.split('.');
            var ext = att[att.length - 1].toLowerCase();
            var isCSS = ext == "css";
            var tag = isCSS ? "link" : "script";
            var attr = isCSS ? " type='text/css' rel='stylesheet' " : " language='javascript' type='text/javascript' ";
            var link = (isCSS ? "href" : "src") + "='" + $.includePath + name + "'";
            if ($(tag + "[" + link + "]").length == 0) document.write("<" + tag + attr + link + "></" + tag + ">");
        }
    }
});