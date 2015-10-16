<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FoldMannger.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="upLold">上传文件：<asp:FileUpload ID="fileUP" runat="server" />
        <asp:Button ID="btnUP" Text="上传" runat="server" onclick="btnUP_Click" /></div>
    <div id="repFolddiv">
    <asp:Repeater ID="repFold" runat="server">
    </asp:Repeater>
    </div>
    <div id="repfileDiv">
    <asp:Repeater ID="repfile" runat="server" >
    </asp:Repeater>
    </div>
      <div id="empty" runat="server" visible="false" >
      文件为空，请点击上传
      </div>
    </div>
    </form>
</body>
</html>
