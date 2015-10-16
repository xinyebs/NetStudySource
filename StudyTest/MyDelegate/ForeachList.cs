using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace MyDelegate
{
    public delegate void DelegetFun(int index, object obj);
    public class ForeachList
    {
        public void ShowList(int index, object obj)
        {
            MessageBox.Show("遍历的是索引为:" + index + "值为" + obj.ToString());
        }
        /// <summary>
        /// 遍历一个集合，委托当作参数来用
        /// </summary>
        /// <param name="list"></param>
        /// <param name="del"></param>
        public void Each(ArrayList list, DelegetFun del)
        {
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    del(i, list[i]); //委托调用方法
                }
            }
        }
    }
}
