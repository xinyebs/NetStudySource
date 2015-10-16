﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Text.aspx.cs" Inherits="extNet.Text" %>

<script runat="server">   
    protected void Button1_Click(object sender, DirectEventArgs e)
    { X.Msg.Notify(new NotificationConfig 
    { 
        Icon = Icon.Accept, Title = "Working", Html = this.TextArea1.Text 
    }).Show();
    }
     </script>
<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title>Ext.NET Example</title>
</head>
<body>
    <ext:ResourceManager ID="ResourceManager1" runat="server" Theme="Gray" />
    <form id="Form1" runat="server">
    <ext:Panel ID="Window1" runat="server" Title="Welcome to Ext.NET" Height="215" Width="350"
        Frame="true" Collapsible="true" Cls="box" BodyPadding="5" DefaultButton="0" Layout="AnchorLayout"
        DefaultAnchor="100%">
        <Items>
            <ext:TextArea ID="TextArea1" runat="server" EmptyText=">> Enter a Test Message Here <<"
                FieldLabel="Message" Height="85" />
        </Items>
        <Buttons>
            <ext:Button ID="Button1" runat="server" Text="Submit" Icon="Accept" OnDirectClick="Button1_Click" />
        </Buttons>
    </ext:Panel>

    <ext:Desktop runat=server Width=200>
    
    </ext:Desktop>
    </form>
</body>
</html>
