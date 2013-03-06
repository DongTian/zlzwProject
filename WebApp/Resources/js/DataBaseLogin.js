$().ready(function () {
    $('#btnLogin').bind('click', function () {
        var strUserName = $('#uin').val();
        var strUserPassword = $('#pwd').val();
        if (strUserName.length == 0) {
            alert("账号不能为空");
            return;
        }
        if (strUserPassword.length == 0) {
            alert("密码不能为空");
            return;
        }
        $.ajax({
            type: 'POST',
            url: 'Resources/Services/Get_DataBaseUserList.asmx/Get_Database_UserLogin',
            contentType: 'application/json',
            data: '{strUserName:"' + strUserName + '" ,strUserPassword:"' + strUserPassword + '"}',
            success: function (data) {
                if (data.d == "-1") {
                    alert("用户名或密码错误");
                    return;
                }
                else {
                    window.parent.location.href = data.d;
                }
            }
        });
    });
});