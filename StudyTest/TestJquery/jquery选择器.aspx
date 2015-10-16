<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jquery选择器.aspx.cs" Inherits="TestJquery.jquery选择器" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/jquery-1.4.1.min.js" type="text/javascript"></script>
    <style type="text/css">
        table
        {
            width: 100%;
            border: 1px red solid;
            border-collapse: collapse;
        }
        table td
        {
            border-collapse: collapse;
            border: 1px red solid;
        }
        
        div, span, p
        {
            width: 140;
            background-color: #aaa;
            border: #000 1px solid;
            height: 140;
            float: left;
            margin: 5px;
            font-size: 14px;
        }
        
        div.mini
        {
            width: 50px;
            height: 50px;
            font-size: 10px;
            background-color: #aaa;
        }
        
        div.hide
        {
            display: none;
        }
    </style>
</head>
<body>
    <table id="tds">
        <tbody>
            <tr>
                <td>
                    第一行数据
                </td>
                <td>
                    第一行数据
                </td>
            </tr>
            <tr>
                <td>
                    第二行数据
                </td>
                <td>
                    第二数据
                </td>
            </tr>
            <tr>
                <td>
                    第三行数据
                </td>
                <td>
                    第三数据
                </td>
            </tr>
            <tr>
                <td>
                    第四行数据
                </td>
                <td>
                    第四数据
                </td>
            </tr>
            <tr>
                <td>
                    第五行数据
                </td>
                <td>
                    第五数据
                </td>
            </tr>
        </tbody>
    </table>
    <div class="one" id="one">
        id为one class 为one的div
    </div>
    <div class="one" id="two" title="test">
        id为two class 为one的div
        <div class="mini" title="other">
            class="mini" title="other"</div>
        <div class="mini" title="Tett">
            class="mini" title="Tett"</div>
    </div>
    <div class="one">
        <div class="mini">
            class="mini"</div>
        <div class="mini">
            class="mini"</div>
        <div class="mini">
            class="mini"</div>
        <div class="mini">
        </div>
    </div>
    <div class="one">
        <div class="mini">
            class="mini"</div>
        <div class="mini">
            class="mini"</div>
        <div class="mini">
            class="mini"</div>
        <div class="mini" title="tesst">
            class="mini" title="tesst"</div>
    </div>
    <div class="none" style="display: none">
        class="none" style="display:none"</div>
    <div class="hide">
        class="hide"</div>
    <div>
        fgfgfgfg
        <input type="hidden" size="8" />
    </div>
    <span id="mover">正在执行动画的span </span>
    <h1>
        dfdfdfdfd</h1>
        <br  style="clear:both" />
       <form id="form1" action="#">
         可用元素：<input name="add" value="可用文本框" />  
          不可用元素：<input name="emil"  disabled="disabled" value="不可用文本框" />  <br />
          
           可用元素：<input name="che" value="可用文本框" />  
          不可用元素：<input name="name"  disabled="disabled" value="不可用文本框" />  
          
          <br />
          
          多选框<br />
          
          <input type="checkbox" name="newsletter" checked="checked" value="test1" /> test1
          <input type="checkbox" name="newsletter"   value="tess2"/> test2
          <input type="checkbox" name="newsletter"   value="test3"/> test3
          <input type="checkbox" name="newsletter" checked="checked"  value="test4"/> test4 
          <input type="checkbox" name="newsletter"   value="test5"/> test5   
          
          <br />
          <br />
          
          下拉列表<br />

          <select name="test1" multiple="multiple"  style="height:100px;" >
          <option>浙江</option>
          <option selected="selected">湖南</option>
          <option>北京</option>
          <option selected="selected">天津</option>
          <option>广州</option>
          <option>湖北</option>
          </select>
             
             <br />
             下拉列表2
             <br />

             <select name="test2" >
          <option>浙江</option>
          <option >湖南</option>
          <option selected="selected">北京</option>
          <option >天津</option>
          <option>广州</option>
          <option>湖北</option>
             </select>

       </form>
</body>
</html>
<script type="text/javascript">
    $(document).ready(function () {

        //        $("#tds tbody tr:even").css("background", "#888");

        //        $(".one").next("div").css("background", "red");
        //        //过滤选择器
        //       $("div:first").css("background", "red");  //选取div集合中第一个元素

        //       $("div:last").css("background", "red");  //选取div集合中最后一个元素

        //        $("div:not(.one)").css("background", "red"); //改变class 不为one的div的背景

        //        $("div:even").css("background", "red");  //改变索引值为偶数的div的背景，索引从0开始

        //        $("div:odd").css("background", "red"); //改变索引值为奇数的div的背景，索引从0开始

        //        $("div:eq(3)").css("background", "red"); //改变索引等于3的div的背景，索引从0开始

        //        $("div:gt(3)").css("background", "red"); //改变索引值大于3的div的背景，索引从0开始

        //        $("div:lt(3)").css("background", "red"); //改变索引值小于3的div的背景，索引从0开始

        //        $(":header").css("background", "red"); //改变所有的标题元素，如h1,h2。。。。这些元素

        //        $(":animated").css("background", "red"); //改变当前正在执行动画的元素的背景


        //        $("div:contains(d)").css("background", "red");  //改变含有文本"d"的<div>的背景。

        //        $("div:empty").css("background", "red");  //改变不包含子元素的div的背景色

        //        $("div:has(input)").css("background", "red"); //选择 div中含有input标签的元素。

        //        $("div:parent").css("background","red");  //改变包含子元素的div的背景色

        /////////////属性选择器

        //        $("div[title]").css("background", "red"); //获取含有属性title的div

        //        $("div[title=test]").css("background", "red"); //获取含有属性tilte,且title=test的的div

        //        $("div[title!=test]").css("background", "red"); //获取含有属性tilte,且title!=test的的div

        //        $("div[title^=te]").css("background", "red");   //获取属性title以te开头的div

        //        $("div[title$=st]").css("background", "red");   //获取属性title以st结尾的div

        //        $("div[title*=te]").css("background", "red");   //获取属性title含有te的div

        //        $("div[id][title^=te]").css("background", "red");   //获取属性title以te开头,并且有id属性的div
        //////////////////////子元素过滤选择器

//         $("div.one :nth-child(2)").css("background", "red");  //选取每个 class=one的div 的 父元素下，第二个子元素，改变背景

//         $("div.one :first-child").css("background", "red");  //选取每个class=one的div的第一个儿子元素

//        $("div.one :last-child").css("background", "red");  //选取class=one的div的最后一个子元素，注意，div.one :last-child,之间有空格


//        $("div.one only-child").css("background","red");   //选取class=one,并且只有一个子元素的div



    });
</script>

<script type="text/javascript">
    $(function () {
        //        $("#form1 input:enabled").val("修改可用元素的值")


        //        $("#form1 input:disabled").val("修改不可用元素的值")

        //        $("#form1 input:checked").length;  // 获取id=form1下所有 复选框中选中的个数

        //        $("#from1 input:selected").text(); //获取下拉列表中选中的值

       // alert($("#form1 :input").length);

    });
</script>