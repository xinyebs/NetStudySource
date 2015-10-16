<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="jqueryEasyUI.test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="jquery-easyui-1.3.4/themes/default/easyui.css" rel="stylesheet" type="text/css" />
	<link rel="stylesheet" type="text/css" href="jquery-easyui-1.3.4/themes/icon.css">
	<%--<link rel="stylesheet" type="text/css" href="../demo.css">--%>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="jquery-easyui-1.3.4/jquery.easyui.min.js" type="text/javascript"></script>
     
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="easyui-datagrid" title="Basic DataGrid" style="width:700px;height:250px"
			data-options="pagination:true,pageSize:5,singleSelect:true,collapsible:true,url:'datagrid_data1.json',method:'get'">
		<thead>
			<tr>
            	<th data-options="field:'ck',width:80,checkbox:true"></th>
				<th data-options="field:'itemid',width:80">Item ID</th>
				<th data-options="field:'productid',width:100">Product</th>
				<th data-options="field:'listprice',width:80,align:'right'">List Price</th>
				<th data-options="field:'unitcost',width:80,align:'right'">Unit Cost</th>
				<th data-options="field:'attr1',width:250">Attribute</th>
				<th data-options="field:'status',width:60,align:'center'">Status</th>
			</tr>
		</thead>
	</table>
    </div>
    </form>
</body>
</html>
