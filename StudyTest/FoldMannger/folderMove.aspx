<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="folderMove.aspx.cs" Inherits="FoldMannger.folderMove" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/common_css.css" rel="stylesheet" type="text/css" />
    <link href="css/file_select_css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div  class="file-select-list select-thumb">
        <ul style="height: 352px; mozuserselect: " id="js_file_list_ul" jquery17108084759769853851="15">
            <li rel="item" pick_code="fc8p64m72" area_id="1" is_share="0" file_type="0" cate_name="都非常高ftr"
                cate_id="31110135" index="0"><i style="cursor: pointer" class="file-thumb tb-folder"
                    title="都非常高ftr" cid="31110135" data-btn="open"></i><a style="color: #333333" class="file-name"
                        title="都非常高ftr" href="javascript:;" cid="31110135" data-btn="open">都非常高ftr</a></li>
            <li rel="item" pick_code="fe4f4vm97" area_id="1" is_share="0" file_type="0" cate_name="c#示例代码"
                cate_id="30862653" index="1"><i style="cursor: pointer" class="file-thumb tb-folder"
                    title="c#示例代码" cid="30862653" data-btn="open"></i><a style="color: #333333" class="file-name"
                        title="c#示例代码" href="javascript:;" cid="30862653" data-btn="open">c#示例代码</a></li>
            <li rel="item" pick_code="fe4sj9cal" area_id="1" is_share="0" file_type="0" cate_name="c#4.0"
                cate_id="30925910" index="2"><i style="cursor: pointer" class="file-thumb tb-folder"
                    title="c#4.0" cid="30925910" data-btn="open"></i><a style="color: #333333" class="file-name"
                        title="c#4.0" href="javascript:;" cid="30925910" data-btn="open">c#4.0</a></li>
            <li rel="item" pick_code="fc8m618yo" area_id="1" is_share="0" file_type="0" cate_name="asp.net插件"
                cate_id="30809029" index="3"><i style="cursor: pointer" class="file-thumb tb-folder"
                    title="asp.net插件" cid="30809029" data-btn="open"></i><a style="color: #333333" class="file-name"
                        title="asp.net插件" href="javascript:;" cid="30809029" data-btn="open">asp.net插件</a></li>
            <li rel="item" pick_code="fe4wxa3b3" area_id="1" is_share="0" file_type="0" cate_name="c#杨中科学习笔记"
                cate_id="30809010" index="4"><i style="cursor: pointer" class="file-thumb tb-folder"
                    title="c#杨中科学习笔记" cid="30809010" data-btn="open"></i><a style="color: #333333" class="file-name"
                        title="c#杨中科学习笔记" href="javascript:;" cid="30809010" data-btn="open">c#杨中科学习笔记</a></li>
            <li rel="item" pick_code="fb9svygvx" area_id="1" is_share="0" file_type="0" cate_name="开发软件"
                cate_id="30809009" index="5"><i style="cursor: pointer" class="file-thumb tb-folder"
                    title="开发软件" cid="30809009" data-btn="open"></i><a style="color: #333333" class="file-name"
                        title="开发软件" href="javascript:;" cid="30809009" data-btn="open">开发软件</a></li>
            <li rel="item" pick_code="fawfrv5kc" area_id="1" is_share="0" file_type="0" cate_name="我的文档"
                cate_id="30809008" index="6"><i style="cursor: pointer" class="file-thumb tb-folder"
                    title="我的文档" cid="30809008" data-btn="open"></i><a style="color: #333333" class="file-name"
                        title="我的文档" href="javascript:;" cid="30809008" data-btn="open">我的文档</a></li></ul>
        <div style="display: none" id="js_more_line" class="file-more" jquery17108084759769853851="12">
            <a href="javascript:;">显示更多文件</a></div>
        <div style="z-index: 99999; border-bottom: #072246 1px solid; position: absolute;
            filter: Alpha(Opacity=15); border-left: #072246 1px solid; width: 1px; display: none;
            background: #6bb0c9; height: 1px; overflow: hidden; border-top: #072246 1px solid;
            top: 236px; border-right: #072246 1px solid; left: 442px; opacity: 0.15" jquery17108084759769853851="17">
        </div>
    </div>
    </form>
</body>
</html>
