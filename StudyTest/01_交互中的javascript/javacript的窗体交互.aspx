<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="javacript的窗体交互.aspx.cs" Inherits="_01_交互中的javascript.javacript的窗体交互" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>


   <script type="text/javascript">
       window.onload = function () {

           var contwindow = document.getElementById("windowA").contentWindow; //返回iframe 的 window

           alert(contwindow.i);

           var ele = getElement();

           alert(ele);

       }


       function getElement() {

           var Elemetns = {};

           for (var i = 0; i <arguments.length ; i++) {
               var id = arguments[i];

               var elt = document.getElementById(id);

               if (elt==null)
               {
                   throw new Error("no element with");
               }

               Elemetns[id] = elt;
           }

           return Elemetns;
       }

       /////////////////////////

       window.onload = function () {

           var button = document.getElementById("addEvent");

           //给button注册事件 方式一
           button.onclick = function () {
               alert("我是注册事件方式一");
           };
           //我是注册事件方式二
           button.addEventListener("click", function () { alert("我是注册事件方式二"); }, false);



       }


       function addEvent(target,type,handler){
       
           //如果是ie9及以后的浏览器，都支持addEventListenter
           if (target.addEventListener) {
               target.addEventListener(type, handler, fals);
           } else {

               //如果是以前的浏览器

               target.attachEvent("on" + type, function (event) {

                   return handler.call(target,event);
               })

           }
       
       }
        





   </script>




</head>
<body>
    <form id="form1" runat="server">
  <!--iframe 之间传递值学习--->
    <div>
    <iframe src="窗体A.aspx" id="windowA"></iframe>
    <iframe src="窗体B.aspx" id="windowB"></iframe>
    </div>

     <br />

     <div>

       <button id="addEvent">我的按钮</button>

     </div>

    </form>
</body>
</html>
