<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TestJquery.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/Site.css" rel="stylesheet" type="text/css" />
    <link href="css/Menu.css" rel="stylesheet" type="text/css" />
    <link href="css/default.css" rel="stylesheet" type="text/css" />
    <link href="jquery-easyui-1.3.4/themes/default/easyui.css" rel="stylesheet" type="text/css" />
    <link href="jquery-easyui-1.3.4/themes/icon.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-1.4.1.js" type="text/javascript"></script>
    <script src="js/common.js" type="text/javascript"></script>
    <script src="jquery-easyui-1.3.4/locale/easyui-lang-zh_CN.js" type="text/javascript"></script>
    <script src="jquery-easyui-1.3.4/jquery.easyui.min.js" type="text/javascript"></script>
    <script src="js/index.js" type="text/javascript"></script>
    <title></title>
    <script type="text/javascript">
        $('#loginOut').click(function () {
            $.messager.confirm("", function (isOk) {
                if (isOk) {
                    $.ajax({
                     url:'Handle/LoginOut.ashx',
                     data:{},
                     success:function(json){
                       json=eval(json);
                       switch(json.isOk){
                       case 1:
                         location.href = 'Login.aspx';
                       break;
                       case 0:
                       showError(json.message);
                       break;
                       };
                     },

                    });
                }
            });

        });
    </script>
</head>
<body class="easyui-layout" style="overflow-y: hidden" scroll="no">
    <noscript>
        <div style="position: absolute; z-index: 100000; height: 2046px; top: 0px; left: 0px;
            width: 100%; background: white; text-align: center;">
            <img src="../images/noscript.gif" alt='抱歉，请开启脚本支持！' />
        </div>
    </noscript>
    <div region="north" split="true" border="false" style="overflow: hidden; height: 100px;
        background: url(images/layout-browser-hd-bg.gif) #7f99be repeat-x center 50%;
        line-height: 20px; color: #fff; font-family: Verdana, 微软雅黑,黑体">
        <div id="Header">
            <div id="HeaderLogo">
            </div>
            <div id="weather">
            </div>
        </div>
        <div id="Headerbotton">
            <div id="left_title">
                <img src="Images/clock_32.png" alt="" width="20" height="20" style="vertical-align: middle;
                    padding-bottom: 1px;" />
                <span id="datetime"></span>
            </div>
            <div id="conten_title">
                <div style="float: left">
                    <img src="Images/networking.png" alt="" width="20" height="20" style="vertical-align: middle;
                        padding-bottom: 1px;" />
                </div>
                <div id="toolbar" style="text-align: right; padding-right: 3px;">
                    &nbsp;&nbsp;&nbsp;
                    <img src="../Images/Max_arrow_left.png" title="后退" alt="" onclick="Loading(true);javascript:history.go(-1)"
                        width="20" height="20" style="padding-bottom: 1px; cursor: pointer; vertical-align: middle;" />
                    &nbsp;&nbsp;&nbsp;<img src="../Images/refresh.png" title="刷新业务窗口" alt="" onclick="Loading(true);main.window.location.reload();return false;"
                        width="20" height="20" style="padding-top: 1px; cursor: pointer; vertical-align: middle;" />
                    &nbsp;&nbsp;&nbsp;<img src="../Images/4963_home.png" title="返回首页" alt="" onclick="rePage()"
                        width="20" height="20" style="padding-top: 1px; cursor: pointer; vertical-align: middle;" />
                    &nbsp; &nbsp;<img src="../Images/button-white-stop.png" title="安全退出" alt="" id="loginOut"
                        width="20" height="20" style="padding-top: 1px; cursor: pointer; vertical-align: middle;" />
                </div>
            </div>
        </div>
    </div>
    <div region="south" split="true" style="height: 35px; background: #D2E0F2;">
        <div class="footer">
            <div id="botton_toolbar">
                <div style="width: 33%; float: left; text-align: left;">
                    当前版本 V1.0
                </div>
                <div style="width: 34%; float: left; text-align: center;">
                    成都东动车所</div>
                <div style="width: 33%; float: left; text-align: right">
                    (<%=userInfo %>)你好，欢迎使用本系统
                </div>
            </div>
        </div>
    </div>
    <div region="west" hide="true" split="true" title="导航菜单" style="width: 180px;" id="west">
        <div id="nav" class="easyui-accordion" fit="true" border="false" title="导航内容">
        </div>
    </div>
    <div id="mainPanle" region="center" style="background: #eee; overflow-y: hidden">
        <div id="tabs" class="easyui-tabs" fit="true" border="false">
            <div title="欢迎使用" style="padding: 20px; overflow: hidden; color: red; display: block;">
                <div class="box">
                    <div class="box-title">
                        <img src="../Images/sun_2.png" alt="" width="20" height="20" />
                        <label id="BeautifulGreetings">
                        </label>
                        (<%=userInfo %>)你好，欢迎使用本系统
                    </div>
                    <div class="box-content">
                        <div onclick="ClickShortcut('/RMBase/SysPersonal/CurrentUserManager.aspx','个人信息','Iframe')"
                            class="shortcuticons">
                            <img src="../Images/32/99.png" alt="" /><br />
                            个人信息</div>
                        <div onclick="ClickShortcut('/RMBase/SysPersonal/Login_List.aspx','登录信息','Iframe')"
                            class="shortcuticons">
                            <img src="../Images/32/316.png" alt="" /><br />
                            登录信息</div>
                        <br />
                        <br />
                        <br />
                        <br />
                    </div>
                </div>
                <div class="blank10">
                </div>
                <div class="box">
                    <div class="box-title">
                        <img src="../Images/milestone.png" alt="" width="20" height="20" />当前登录情况</div>
                    <div class="box-content">
                        本月登录总数：6 次
                        <br />
                        本次登录IP：127.0.0.1<br />
                        本次登录时间：2013-06-03 9:54:46<br />
                        上次登录IP：127.0.0.1<br />
                        上次登录时间：2013-06-03 9:54:19<br />
                        <br />
                        <img src="../Images/exclamation_octagon_fram.png" style="vertical-align: middle;
                            margin-bottom: 3px;" width="16" height="16" alt="tip" />
                        提示：为了账号的安全，如果上面的登录情况不正常，建议您马上 <a href="javascript:void(0)" id="editpass">修改密码</a>
                    </div>
                </div>
                <div class="blank10">
                </div>
            </div>
        </div>
    </div>
    <div id="loading" onclick="Loading(false);">
        正在处理，请稍待。。。
    </div>
</body>
</html>
