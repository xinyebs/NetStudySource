using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MyDelegate
{
    public class MyButtonEven : System.Windows.Forms.Button
    {
        Timer timer = new Timer();
        public event EventHandeTripClick handel;
        private int times = 0;//及时器，三击事件
        public MyButtonEven()
        {
            ///调用父类的单击事件
            base.Click += new EventHandler(MyButtonEven_Click);
            timer.Interval = 1000;// 获取或设置在相对于上一次发生的 System.Windows.Forms.Timer.Tick 事件
            timer.Tick += new EventHandler(timer_Tick);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //当指定的计时器间隔已过去而且计时器处于启用状态时发生。
            times = 0;
        }


        void MyButtonEven_Click(object sender, EventArgs e)
        {
            ///调用父类的单击事件，就会调用次方法，在这里实现自己的三击事件
            ///
            if (times < 2)
            {
                if (times == 0)
                {///单击第一次的时候启动计时器
                    timer.Start();
                }
                times++;
            }
            else
            {
                handel(DateTime.Now);
            }

        }
    }
}
