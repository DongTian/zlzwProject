$().ready(function () {
    $('#ext-gen10').live('click', function () {
        if ($('#ctl00_ContentPlaceHolder1_txbUserName').val() == "") {
            alert("用户名不能为空");
            return;
        }
        if ($('#ctl00_ContentPlaceHolder1_txbBirthday').val() == "") {
            alert("出生日期不能为空");
            return;
        }
        if ($('#ctl00_ContentPlaceHolder1_txbUserCountry').val()) {
            alert("籍贯不能为空");
            return;
        }
        if ($('#ctl00_ContentPlaceHolder1_txbEmail').val()) {
            alert("电子邮件不能为空");
            return;
        }
        if ($('#ctl00_ContentPlaceHolder1_txbUserMobiNumber').val() == "") {
            alert("联系电话(手机)不能为空");
            return;
        }
        if ($('#ctl00_ContentPlaceHolder1_txbUserEducationalBackground').val()) {
            alert("教育背景不能为空");
            return;
        }
        if ($('#ctl00_ContentPlaceHolder1_txbWorkSkill').val() == "") {
            alert("工作技能不能为空");
            return;
        }
    });

    if (getQueryString("regStatus") == "true") {
        alert("注册成功");
        return;
    }
    else if (getQueryString("regStatus") == "false") {
        alert("注册失败");
        return;
    }
});

function getQueryString(name) {
        var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
        var r = window.location.search.substr(1).match(reg);
        if (r != null) return unescape(r[2]); return null;
    }

