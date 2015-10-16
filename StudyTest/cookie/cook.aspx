<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cook.aspx.cs" Inherits="cookie.cook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>


    <script type="text/javascript">


        ///设置cookie，默认参数 daysToLive
        function setCookie(name,value,daysToLive) {

            var cookie = name + "=" + encodeURIComponent(value);

            if (typeof daysToLive=="number") {

                cookie += "; max-age="+encodeURIComponent(daysToLive*60*60*24);
            }

            document.cookie = cookie;

        }


        function getCookie() {

            var cookie = {};

            var all = document.cookie;

            if (all==="") {
                return cookie;
            }

            var list = all.split(";");

            for (var i = 0; i < list.length; i++) {

                var cookie = list[i];

                var p = cookie.indexOf("=");

                var name = cookie.substring(0, p);

                var value = cookie.substring(p + 1);
                
                value = decodeURIComponent(value);

                cookie[name] = value;


            }

            return cookie;

        }


    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
