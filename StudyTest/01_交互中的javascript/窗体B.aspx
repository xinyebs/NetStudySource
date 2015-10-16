<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="窗体B.aspx.cs" Inherits="_01_交互中的javascript.窗体B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

<script type="text/javascript">
    //调用窗体A的变量，通过父窗体引用
    alert(parent.windowA.i);

</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
