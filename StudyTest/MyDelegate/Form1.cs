using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace MyDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.myButton1.AddDelete(DGMyClick); 
            ///给委托添加多个事件
            this.myButton1.AddDelete(DGMyClick2);

            MyButtonEven butonEven = new MyButtonEven();
            butonEven.Location = new Point(100, 200);
            butonEven.Size = new Size(100, 100);
            butonEven.Text = "我是事件版的";
            this.Controls.Add(butonEven);

            butonEven.handel += new EventHandeTripClick(butonEven_handel);
        }

        void butonEven_handel(DateTime time)
        {
            MessageBox.Show(time.ToString());
        }
        void DGMyClick(DateTime clicTime)
        {
            MessageBox.Show("1点击我的时间是：" + clicTime.ToString());
        }
        void DGMyClick2(DateTime clicTime)
        {
            MessageBox.Show("2点击我的时间是：" + clicTime.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForeachList each = new ForeachList();

            ///声明一个委托
            ///each.ShowList是相匹配的参数
            DelegetFun delFun = new DelegetFun(each.ShowList);

            //初始化集合
            ArrayList list = new ArrayList();
            list.Add("老鸟");
            list.Add("大鸟");
            list.Add("小鸟");
            list.Add("菜鸟");

            ///调用each方法，传递 委托参数
            each.Each(list, delFun);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListGog listdog = new ListGog();
            List<DogEntity> list = listdog.GetListDog();
            DogSrot comparer = new DogSrot();
            list.Sort(comparer);  //接口实现排序

            foreach (var p in list)
            {
                Console.WriteLine(p.Age + ":" + p.Name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListGog listdog = new ListGog();
            List<DogEntity> list = listdog.GetListDog();
            ///使用委托排序 ，最后生成 list.Sort(new Comparison<DogEntity>(this.ComparisonDog));
            list.Sort(ComparisonDog); 

            foreach (var p in list)
            {
                Console.WriteLine(p.Age + ":" + p.Name);
            }
        }
        int ComparisonDog(DogEntity x, DogEntity y)
        {
            return x.Age - y.Age;
        }

        private void myButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
