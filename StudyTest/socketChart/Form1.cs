using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace socketChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //服务端全局连接socket
        public Socket serviceSocket = null;
        //监听线程
        public Thread ListenThread = null;

        Dictionary<string, Socket> clientList = new Dictionary<string, Socket>();

        /// <summary>
        /// 开始监听端口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListen_Click(object sender, EventArgs e)
        {
            string ip = txtIP.Text.Trim();
            string point = txtPoint.Text.Trim();

            //创建监听套接字 使用 ip4协议，流式传输，TCP连接
            serviceSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endpoit = new IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(point));


            //绑定端口
            serviceSocket.Bind(endpoit);
            //设置监听队列
            serviceSocket.Listen(10);
            //等待客户端连接，此方法会阻断当前线程，直到有 其它程序 连接过来，才执行完毕,所以要用一个线程（监听线程）
            //serviceSocket.Accept();
            ListenThread = new Thread(ListenConnection);
            ListenThread.IsBackground = true;
            ListenThread.Start();
        }

      
        //定义一个委托 用来向ui控件添加文本
        public delegate void DelegateAddMsg(string msg);
        //定义委托变量
        private DelegateAddMsg deleAddMsg;
        public void ListenConnection()
        {
            //开始监听,有客户端连接成功后，返回一个新的socket,（通信socket）
            //注意：每一个socket 都会创建一个新的socket,一个socket一次只能连接一个主机
            Socket connectSocket = serviceSocket.Accept();
            string remotIp = connectSocket.RemoteEndPoint.ToString();

            //把请求的客户端保存起来
            clientList.Add(remotIp, connectSocket);


            //实例化委托变量
            deleAddMsg = new DelegateAddMsg(Msg);
            //让委托添加到主线程
            listClient.Invoke(deleAddMsg, remotIp);


            //创建一个接受消息线程，并把当前通信socket 传递
            Thread threadResive = new Thread(resiveMsg);
            threadResive.IsBackground = true;
            threadResive.Start(connectSocket);

           
           
        }


        
        public void Msg(string removtIp) {
            //显示连接的ip+端口
            listClient.Items.Add(removtIp);

        }



        public void resiveMsg(object obj) {

            //接受消息
            
            Socket client = obj as Socket;

            //定义1M的缓冲区
            byte[] buffer=new byte[1024*1024*1];
            
            //开启循环接受
            while(true)
            {
                 //接收客户端的消息 并存入 缓存区,注意：Receive方法也会阻断当前的线程
            client.Receive(buffer);
            //byte -> string
            string resiveMsg = Encoding.UTF8.GetString(buffer);

            DelegateAddMsg delegateshowMsg = new DelegateAddMsg(showMsg);

            this.txtResive.Invoke(delegateshowMsg, resiveMsg);

            }
        }
        public void showMsg(string msg)
        {
            //接受用户发送的消息

            string old = this.txtResive.Text;

            string newmsg = old + "\r\n" + msg;

            this.txtResive.Text = newmsg;

        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = txtmsg.Text.Trim();

            byte[] sendMsg = Encoding.UTF8.GetBytes(msg);

            for (int i = 0; i < listClient.Items.Count;i++ ) {

                Socket client = clientList[listClient.Items[i].ToString()];

                client.Send(sendMsg);

            }

        }

    }
}
