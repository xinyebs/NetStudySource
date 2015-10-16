<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGrid.aspx.cs" Inherits="jqueryEasyUI.DataGrid" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Js/Easyui1.34/themes/bootstrap/easyui.css" rel="stylesheet" type="text/css" />
     <script src="../Js/Easyui1.34/jquery.easyui.min.js" type="text/javascript"></script>
    <script src="../Js/Easyui1.34/locale/easyui-lang-zh_CN.js" type="text/javascript"></script>
    <script src="../Js/common.js" type="text/javascript"></script>

  <script type="text/javascript">
      var me = {
          datagrid1: null,
          edit_form: null,
          edit_window: null,
          search_form: null,
          search_window: null,
          idFiled: 'trainsetNo',
          actionUrl: '/CarTableList.ashx',
          datagrid2: null,
          idFiled2: 'ID',
          ChangeWin: null,
          edit_fromWheelset: null
      };
      $(function () {
          function loadGrid() {
              me.datagrid1.datagrid({
                  //sortName: me.idFiled,
                  //idField: me.idFiled,
                  url: CarTableList.ashx,
                  loadMsg: '数据加载中，请稍后......',
                  rownumbers: true,
                  frozenColumns: [[
	                { field: 'ck', checkbox: true }
				]],
                  columns: [[
                  { field: 'trainsetNo', title: '车组', width: 100, sortable: true, align: 'center' },
                  { field: 'opt', title: '操作', width: 100, align: 'center', formatter: function (val, rec, index) {
                      var strReturn = '';
                      strReturn = '<a href="javascript:void(0)" class="l-btn-text" title="查看详情"    style="padding-left:20px;" >查看详情</a>';
                      return strReturn;
                  }
                  }
                ]],
//                  toolbar: ['-'
//                , { text: '新增', iconCls: 'icon-add', handler: function () { OpenWindow(); } }, '-'
//                , { text: '删除', iconCls: 'icon-remove', handler: function () { var ids = []; var rows = me.datagrid1.datagrid('getSelections'); if (rows.length == 0) { showError('请选择一条记录进行操作!'); } else { for (var i = 0; i < rows.length; i++) { ids.push(rows[i][me.idFiled]); } Delete(ids.join(',')); } } }, '-'
//                  //                 , { text: '查看', iconCls: 'icon-search', handler: function () { AddOrUpdate('view'); } }, '-'
//                 , { text: '查找', iconCls: 'icon-search', handler: function () { me.search_window.window('open'); } }, '-'
//                 , { text: '走行录入', iconCls: 'icon-add', handler: function () { OpenTravelWindow(); } }, '-'
//                 , { text: '备份到历史表', iconCls: 'icon-add', handler: function () { AddOrUpdate('bak'); } }, '-'
//                 , { text: '履历导入', iconCls: 'icon-add', handler: function () { OpenRecordWindow(); } }, '-'
//                ],
//                  onBeforeLoad: function (param) {
//                      me.search_form.find('input').each(function (index) { param[this.name] = $(this).val(); });
//                  }
              });
          }
       });
     
  </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
