<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WEBSericesTest.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
    <asp:Button runat="server" ID="btn" Text="点击调用" onclick="btn_Click" />
    <asp:Button runat="server" ID="btnTrafic" Text="点击查询" onclick="btnTrafic_Click"  />
    <asp:Label ID="labShow" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
