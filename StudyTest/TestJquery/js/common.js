$.extend($.fn.datagrid.defaults, {
    fit: true,
    nowrap: false,
    striped: true,
    rownumbers: true,
    singleSelect: true,
    pagination: true,
    pageSize: 5,
    sortOrder: 'desc',
    border: false,
    pageList: [10, 20, 30, 40, 50, 100],
    onLoadSuccess: function (data) {
        $(this).datagrid('clearSelections');
        $(this).datagrid('selectRow', 0);
    },
    onLoadError: function (data) {
        showError(data.Length);
        showError('加载数据错误！');
    }
});

$.extend($.fn.datagrid.methods, {
    editCell: function (jq, param) {
        return jq.each(function () {
            var opts = $(this).datagrid('options');
            var fields = $(this).datagrid('getColumnFields', true).concat($(this).datagrid('getColumnFields'));
            for (var i = 0; i < fields.length; i++) {
                var col = $(this).datagrid('getColumnOption', fields[i]);
                col.editor1 = col.editor;
                if (fields[i] != param.field) {
                    col.editor = null;
                }
            }
            $(this).datagrid('beginEdit', param.index);
            for (var i = 0; i < fields.length; i++) {
                var col = $(this).datagrid('getColumnOption', fields[i]);
                col.editor = col.editor1;
            }
        });
    }
});

$.extend($.fn.window.defaults, {
    modal: true,
    //closed: true,
    shadow: false,
    collapsible: false,
    minimizable: false,
    maximizable: false
});

$.extend($.fn.tree.defaults, {
    onLoadError: function(XMLHttpRequest, textStatus, errorThrown) {
        if (errorThrown) {
            showError('加载数据错误！' + errorThrown);
        } else {
            showError('加载数据错误！');
        }
    }
});
$.ajaxSetup({
    global: false,
    type: "POST",
    dataType: 'json',
    error: function(XMLHttpRequest, textStatus, errorThrown) {
        if (errorThrown) {
            showError('加载数据错误！' + errorThrown);
        } else {
            showError('加载数据错误！');
        }
    }
});

function showError(message) {
    $.messager.alert('错误信息', message, 'error');
}
function showInfo(message) {
    $.messager.alert("提示信息", message, "info");
}

String.prototype.format = function() {
    var args = arguments;
    return this.replace(/\{(\d+)\}/g,
         function(m, i) {
             return args[i];
         });
}
String.format = function() {
    if (arguments.length == 0)
        return null;

    var str = arguments[0];
    for (var i = 1; i < arguments.length; i++) {
        var re = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
        str = str.replace(re, arguments[i]);
    }
    return str;
}
/*===============================================================*/

/*===================EasyUI通用验证扩展开始===================*/
$.extend($.fn.validatebox.defaults.rules, {
    CHS: {
        validator: function(value, param) {
            return /^[\u0391-\uFFE5]+$/.test(value);
        },
        message: '请输入汉字'
    },
    ZIP: {
        validator: function(value, param) {
            return /^[1-9]\d{5}$/.test(value);
        },
        message: '邮政编码不存在'
    },
    QQ: {
        validator: function(value, param) {
            return /^[1-9]\d{4,10}$/.test(value);
        },
        message: 'QQ号码不正确'
    },
    mobile: {
        validator: function(value, param) {
            return /^((\(\d{2,3}\))|(\d{3}\-))?13\d{9}$/.test(value);
        },
        message: '手机号码不正确'
    },
    loginName: {
        validator: function(value, param) {
            return /^[\u0391-\uFFE5\w]+$/.test(value);
        },
        message: '登录名称只允许汉字、英文字母、数字及下划线。'
    },
    safepass: {
        validator: function(value, param) {
            return safePassword(value);
        },
        message: '密码由字母和数字组成，至少6位'
    },
    equalTo: {
        validator: function(value, param) {
            return value == $(param[0]).val();
        },
        message: '两次输入的字符不一至'
    },
    number: {
        validator: function(value, param) {
            return /^\d+$/.test(value);
        },
        message: '请输入数字'
    },
    idcard: {
        validator: function(value, param) {
            return idCard(value);
        },
        message: '请输入正确的身份证号码'
    },
    safePassword: {
        validator: function(value, param) {
            return !(/^(([A-Z]*|[a-z]*|\d*|[-_\~!@#\$%\^&\*\.\(\)\[\]\{\}<>\?\\\/\'\"]*)|.{0,5})$|\s/.test(value));
        },
        message: '密码由字母和数字组成，至少6位'
    },
    idcard2: {
        validator: function(idcard, param) {
            var idcard = value;
            var Errors = new Array(
"验证通过!",
"身份证号码位数不对!",
"身份证号码出生日期超出范围或含有非法字符!",
"身份证号码校验错误!",
"身份证地区非法!"
);
            var area = { 11: "北京", 12: "天津", 13: "河北", 14: "山西", 15: "内蒙古", 21: "辽宁", 22: "吉林", 23: "黑龙江", 31: "上海", 32: "江苏", 33: "浙江", 34: "安徽", 35: "福建", 36: "江西", 37: "山东", 41: "河南", 42: "湖北", 43: "湖南", 44: "广东", 45: "广西", 46: "海南", 50: "重庆", 51: "四川", 52: "贵州", 53: "云南", 54: "西藏", 61: "陕西", 62: "甘肃", 63: "青海", 64: "宁夏", 65: "新疆", 71: "台湾", 81: "香港", 82: "澳门", 91: "国外" }

            var idcard, Y, JYM;
            var S, M;
            var idcard_array = new Array();
            idcard_array = idcard.split("");
            //地区检验
            if (area[parseInt(idcard.substr(0, 2))] == null) {
                alert(Errors[4]);
                return false;
            }
            //身份号码位数及格式检验
            switch (idcard.length) {
                case 15:
                    if ((parseInt(idcard.substr(6, 2)) + 1900) % 4 == 0 || ((parseInt(idcard.substr(6, 2)) + 1900) % 100 == 0 && (parseInt(idcard.substr(6, 2)) + 1900) % 4 == 0)) {
                        ereg = /^[1-9][0-9]{5}[0-9]{2}((01|03|05|07|08|10|12)(0[1-9]|[1-2][0-9]|3[0-1])|(04|06|09|11)(0[1-9]|[1-2][0-9]|30)|02(0[1-9]|[1-2][0-9]))[0-9]{3}$/; //测试出生日期的合法性
                    } else {
                        ereg = /^[1-9][0-9]{5}[0-9]{2}((01|03|05|07|08|10|12)(0[1-9]|[1-2][0-9]|3[0-1])|(04|06|09|11)(0[1-9]|[1-2][0-9]|30)|02(0[1-9]|1[0-9]|2[0-8]))[0-9]{3}$/; //测试出生日期的合法性
                    }
                    if (ereg.test(idcard)) return true;
                    else {
                        alert(Errors[2]);
                        return false;
                    }
                    break;
                case 18:
                    //18位身份号码检测
                    //出生日期的合法性检查 
                    //闰年月日:((01|03|05|07|08|10|12)(0[1-9]|[1-2][0-9]|3[0-1])|(04|06|09|11)(0[1-9]|[1-2][0-9]|30)|02(0[1-9]|[1-2][0-9]))
                    //平年月日:((01|03|05|07|08|10|12)(0[1-9]|[1-2][0-9]|3[0-1])|(04|06|09|11)(0[1-9]|[1-2][0-9]|30)|02(0[1-9]|1[0-9]|2[0-8]))
                    if (parseInt(idcard.substr(6, 4)) % 4 == 0 || (parseInt(idcard.substr(6, 4)) % 100 == 0 && parseInt(idcard.substr(6, 4)) % 4 == 0)) {
                        ereg = /^[1-9][0-9]{5}(19|20)[0-9]{2}((01|03|05|07|08|10|12)(0[1-9]|[1-2][0-9]|3[0-1])|(04|06|09|11)(0[1-9]|[1-2][0-9]|30)|02(0[1-9]|[1-2][0-9]))[0-9]{3}[0-9Xx]$/; //闰年出生日期的合法性正则表达式
                    } else {
                        ereg = /^[1-9][0-9]{5}(19|20)[0-9]{2}((01|03|05|07|08|10|12)(0[1-9]|[1-2][0-9]|3[0-1])|(04|06|09|11)(0[1-9]|[1-2][0-9]|30)|02(0[1-9]|1[0-9]|2[0-8]))[0-9]{3}[0-9Xx]$/; //平年出生日期的合法性正则表达式
                    }
                    if (ereg.test(idcard)) {//测试出生日期的合法性
                        //计算校验位
                        S = (parseInt(idcard_array[0]) + parseInt(idcard_array[10])) * 7
+ (parseInt(idcard_array[1]) + parseInt(idcard_array[11])) * 9
+ (parseInt(idcard_array[2]) + parseInt(idcard_array[12])) * 10
+ (parseInt(idcard_array[3]) + parseInt(idcard_array[13])) * 5
+ (parseInt(idcard_array[4]) + parseInt(idcard_array[14])) * 8
+ (parseInt(idcard_array[5]) + parseInt(idcard_array[15])) * 4
+ (parseInt(idcard_array[6]) + parseInt(idcard_array[16])) * 2
+ parseInt(idcard_array[7]) * 1
+ parseInt(idcard_array[8]) * 6
+ parseInt(idcard_array[9]) * 3;
                        Y = S % 11;
                        M = "F";
                        JYM = "10X98765432";
                        M = JYM.substr(Y, 1); //判断校验位
                        if (M == idcard_array[17]) return true; //检测ID的校验位
                        else {
                            alert(Errors[3]);
                            return false;
                        }
                    }
                    else {
                        alert(Errors[2]);
                        return false;
                    }
                    break;
                default:
                    alert(Errors[1]);
                    return false;
                    break;
            }
        },
        message: '身份证号非法'
    },
    idCard: {
        validator: function(value, param) {
            if (value.length == 18 && 18 != value.length) return false;
            var number = value.toLowerCase();
            var d, sum = 0, v = '10x98765432', w = [7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2], a = '11,12,13,14,15,21,22,23,31,32,33,34,35,36,37,41,42,43,44,45,46,50,51,52,53,54,61,62,63,64,65,71,81,82,91';
            var re = number.match(/^(\d{2})\d{4}(((\d{2})(\d{2})(\d{2})(\d{3}))|((\d{4})(\d{2})(\d{2})(\d{3}[x\d])))$/);
            if (re == null || a.indexOf(re[1]) < 0) return false;
            if (re[2].length == 9) {
                number = number.substr(0, 6) + '19' + number.substr(6);
                d = ['19' + re[4], re[5], re[6]].join('-');
            } else d = [re[9], re[10], re[11]].join('-');
            if (!isDateTime.call(d, 'yyyy-MM-dd')) return false;
            for (var i = 0; i < 17; i++) sum += number.charAt(i) * w[i];
            return (re[2].length == 9 || number.charAt(17) == v.charAt(sum % 11));
        },
        message: '身份证号非法'
    },
    isDateTime:
    {
        validator: function(value, param) {
            format = param[0] || 'yyyy-MM-dd';
            var input = this, o = {}, d = new Date();
            var f1 = format.split(/[^a-z]+/gi), f2 = input.split(/\D+/g), f3 = format.split(/[a-z]+/gi), f4 = input.split(/\d+/g);
            var len = f1.length, len1 = f3.length;
            if (len != f2.length || len1 != f4.length) return false;
            for (var i = 0; i < len1; i++) if (f3[i] != f4[i]) return false;
            for (var i = 0; i < len; i++) o[f1[i]] = f2[i];
            o.yyyy = s(o.yyyy, o.yy, d.getFullYear(), 9999, 4);
            o.MM = s(o.MM, o.M, d.getMonth() + 1, 12);
            o.dd = s(o.dd, o.d, d.getDate(), 31);
            o.hh = s(o.hh, o.h, d.getHours(), 24);
            o.mm = s(o.mm, o.m, d.getMinutes());
            o.ss = s(o.ss, o.s, d.getSeconds());
            o.ms = s(o.ms, o.ms, d.getMilliseconds(), 999, 3);
            if (o.yyyy + o.MM + o.dd + o.hh + o.mm + o.ss + o.ms < 0) return false;
            if (o.yyyy < 100) o.yyyy += (o.yyyy > 30 ? 1900 : 2000);
            d = new Date(o.yyyy, o.MM - 1, o.dd, o.hh, o.mm, o.ss, o.ms);
            var reVal = d.getFullYear() == o.yyyy && d.getMonth() + 1 == o.MM && d.getDate() == o.dd && d.getHours() == o.hh && d.getMinutes() == o.mm && d.getSeconds() == o.ss && d.getMilliseconds() == o.ms;
            return reVal && reObj ? d : reVal;
            function s(s1, s2, s3, s4, s5) {
                s4 = s4 || 60, s5 = s5 || 2;
                var reVal = s3;
                if (s1 != undefined && s1 != '' || !isNaN(s1)) reVal = s1 * 1;
                if (s2 != undefined && s2 != '' && !isNaN(s2)) reVal = s2 * 1;
                return (reVal == s1 && s1.length != s5 || reVal > s4) ? -10000 : reVal;
            }
        },
        message: '身份证号非法'
    }

});
/*===================EasyUI通用验证扩展结束===================*/


// 判断闰年

Date.prototype.isLeapYear = function() {

    return (0 == this.getYear() % 4 && ((this.getYear() % 100 != 0) || (this.getYear() % 400 == 0)));

}


// 日期格式化

// 格式 YYYY/yyyy/YY/yy 表示年份

// MM/M 月份

// W/w 星期

// dd/DD/d/D 日期

// hh/HH/h/H 时间

// mm/m 分钟

// ss/SS/s/S 秒
Date.prototype.Format = function(formatStr) {

    var str = formatStr;

    var Week = ['日', '一', '二', '三', '四', '五', '六'];

    str = str.replace(/yyyy|YYYY/, this.getFullYear());

    str = str.replace(/yy|YY/, (this.getYear() % 100) > 9 ? (this.getYear() % 100).toString() : '0' + (this.getYear() % 100));

    str = str.replace(/MM/, this.getMonth() > 9 ? this.getMonth().toString() : '0' + this.getMonth());

    str = str.replace(/M/g, this.getMonth());

    str = str.replace(/w|W/g, Week[this.getDay()]);

    str = str.replace(/dd|DD/, this.getDate() > 9 ? this.getDate().toString() : '0' + this.getDate());

    str = str.replace(/d|D/g, this.getDate());

    str = str.replace(/hh|HH/, this.getHours() > 9 ? this.getHours().toString() : '0' + this.getHours());

    str = str.replace(/h|H/g, this.getHours());

    str = str.replace(/mm/, this.getMinutes() > 9 ? this.getMinutes().toString() : '0' + this.getMinutes());

    str = str.replace(/m/g, this.getMinutes());

    str = str.replace(/ss|SS/, this.getSeconds() > 9 ? this.getSeconds().toString() : '0' + this.getSeconds());

    str = str.replace(/s|S/g, this.getSeconds());

    return str;

}

//+---------------------------------------------------

//| 求两个时间的天数差 日期格式为 YYYY-MM-dd

//+---------------------------------------------------

function daysBetween(DateOne, DateTwo) {

    var OneMonth = DateOne.substring(5, DateOne.lastIndexOf('-'));

    var OneDay = DateOne.substring(DateOne.length, DateOne.lastIndexOf('-') + 1);

    var OneYear = DateOne.substring(0, DateOne.indexOf('-'));

    var TwoMonth = DateTwo.substring(5, DateTwo.lastIndexOf('-'));

    var TwoDay = DateTwo.substring(DateTwo.length, DateTwo.lastIndexOf('-') + 1);

    var TwoYear = DateTwo.substring(0, DateTwo.indexOf('-'));

    var cha = ((Date.parse(OneMonth + '/' + OneDay + '/' + OneYear) - Date.parse(TwoMonth + '/' + TwoDay + '/' + TwoYear)) / 86400000);

    return Math.abs(cha);

}

//+---------------------------------------------------

//| 日期计算

//+---------------------------------------------------

Date.prototype.DateAdd = function(strInterval, Number) {

    var dtTmp = this;

    switch (strInterval) {

        case 's': return new Date(Date.parse(dtTmp) + (1000 * Number));

        case 'n': return new Date(Date.parse(dtTmp) + (60000 * Number));

        case 'h': return new Date(Date.parse(dtTmp) + (3600000 * Number));

        case 'd': return new Date(Date.parse(dtTmp) + (86400000 * Number));

        case 'w': return new Date(Date.parse(dtTmp) + ((86400000 * 7) * Number));

        case 'q': return new Date(dtTmp.getFullYear(), (dtTmp.getMonth()) + Number * 3, dtTmp.getDate(), dtTmp.getHours(), dtTmp.getMinutes(), dtTmp.getSeconds());

        case 'm': return new Date(dtTmp.getFullYear(), (dtTmp.getMonth()) + Number, dtTmp.getDate(), dtTmp.getHours(), dtTmp.getMinutes(), dtTmp.getSeconds());

        case 'y': return new Date((dtTmp.getFullYear() + Number), dtTmp.getMonth(), dtTmp.getDate(), dtTmp.getHours(), dtTmp.getMinutes(), dtTmp.getSeconds());

    }

}

//+---------------------------------------------------

//| 比较日期差 dtEnd 格式为日期型或者 有效日期格式字符串

//+---------------------------------------------------

Date.prototype.DateDiff = function(strInterval, dtEnd) {

    var dtStart = this;

    if (typeof dtEnd == 'string')//如果是字符串转换为日期型
    {

        dtEnd = StringToDate(dtEnd);

    }

    switch (strInterval) {

        case 's': return parseInt((dtEnd - dtStart) / 1000);

        case 'n': return parseInt((dtEnd - dtStart) / 60000);

        case 'h': return parseInt((dtEnd - dtStart) / 3600000);

        case 'd': return parseInt((dtEnd - dtStart) / 86400000);

        case 'w': return parseInt((dtEnd - dtStart) / (86400000 * 7));

        case 'm': return (dtEnd.getMonth() + 1) + ((dtEnd.getFullYear() - dtStart.getFullYear()) * 12) - (dtStart.getMonth() + 1);

        case 'y': return dtEnd.getFullYear() - dtStart.getFullYear();

    }

}

//+---------------------------------------------------

//| 日期输出字符串，重载了系统的toString方法

//+---------------------------------------------------

Date.prototype.toString = function(showWeek) {

    var myDate = this;

    var str = myDate.toLocaleDateString();

    if (showWeek) {

        var Week = ['日', '一', '二', '三', '四', '五', '六'];

        str += ' 星期' + Week[myDate.getDay()];

    }

    //+---------------------------------------------------

    //| 字符串转成日期类型

    //| 格式 MM/dd/YYYY MM-dd-YYYY YYYY/MM/dd YYYY-MM-dd

    //+---------------------------------------------------

    function StringToDate(DateStr) {

        var converted = Date.parse(DateStr);

        var myDate = new Date(converted);

        if (isNaN(myDate)) {

            //var delimCahar = DateStr.indexOf('/')!=-1?'/':'-';

            var arys = DateStr.split('-');

            myDate = new Date(arys[0], --arys[1], arys[2]);

        }

        return myDate;
    }
}