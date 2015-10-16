using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDelegate
{
    /// <summary>
    /// 自定义单击委托
    /// </summary>
    /// <param name="time">当前的时间</param>
    public delegate void DGMyClick(DateTime time);

    public class MyButton : System.Windows.Forms.Button
    {
        /// <summary>
        /// 定义私有委托变量，用来存放用户定义的方法
        /// </summary>
        private DGMyClick dgMyclick;

       /// <summary>
       /// 用户如果要添加事件，调用此方法，不能直接暴露委托变量dgMyclick
       /// 这样子如果用户直接dgMyclick=null,导致，以前用户添加的事件都被注释掉
       /// </summary>
       /// <param name="dg"></param>
        public void AddDelete(DGMyClick dg)
        {
            dgMyclick += dg;
        }
        /// <summary>
        /// 用户想取消事件，调用次方法，调用的时候传递一个委托方法，如果不知道委托方法名称，则取消不了
        /// </summary>
        /// <param name="dg"></param>
        public void RemoveDelete(DGMyClick dg)
        {
            dgMyclick -= dg;
        }
        public MyButton()
        {
            ///初始化控件的时候，调用父类的单击事件注册一个方法
            base.Click += new EventHandler(MyButton_Click);
        }
        public void MyButton_Click(object sender, EventArgs e)
        {
            ///如果实例化了委托，就调用
            ///在调用委托之前一定要判断是否实例化了
            if (dgMyclick != null)
                dgMyclick(DateTime.Now);  ///调用自定义委托的方法
        }
    }
}
