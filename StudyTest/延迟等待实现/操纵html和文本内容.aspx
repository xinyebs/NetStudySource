<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="操纵html和文本内容.aspx.cs" Inherits="延迟等待实现.操纵html和文本内容" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
        

            $('input').click(
             function (e) {
                 e.preventDefault();
                 switch (this.id) {
                     case 'tmpGetHtml':
                         alert($(this).prev().html());
                         break;
                     case 'tmpGetText':
                         alert($(this).prev().text());
                         break;
                 }

             }
            );
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        Jquery's <b>html()</b> method can be used get Htmle content.
    </p>
    <input type="submit" id='tmpGetHtml' value='Get Html' />
    <p>
        Jquery's <b>text()</b> method can be used get Htmle content.
    </p>
    <input type="submit" id='tmpGetText' value='Get Text' />
    <p>
        The <b>Html()</b> methed can be also used by set Html content, which is done by
        passing html to its first argument
    </p>
    <input type="submit" id='tmpSetHtml' value='Set Html' />
    </form>
</body>
</html>
