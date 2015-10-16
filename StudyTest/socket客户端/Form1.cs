using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace socket客户端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //客户端socket
        Socket clientSocket = null;

        //定义显示消息委托
        private delegate void DelegateShowMsg(string msg);


        private void btnListen_Click(object sender, EventArgs e)
        {
            //======连接到socket服务器=====//

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint endpont = new IPEndPoint(IPAddress.Parse(txtIP.Text), Convert.ToInt32(txtPoint.Text));
            
            //客户端发起连接
            clientSocket.Connect(endpont);


            Thread DeshowMsg = new Thread(showMsg);

            DeshowMsg.IsBackground = true;

            DeshowMsg.Start();

        }

        public void showMsg()
        {
            //定义缓冲区
            DelegateShowMsg deleget = new DelegateShowMsg(addMsgToText);

            byte[] byteMsg = new byte[1024 * 1024 * 1];
            while(true)
            {
                clientSocket.Receive(byteMsg);

               this.txtmsg.Invoke(deleget,Encoding.UTF8.GetString(byteMsg));
            }
            
        }

        public void addMsgToText(string msg) {

            this.txtmsg.Text += "\r\n" + msg;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = txtmsg.Text.Trim();

            byte[] sendbyte = Encoding.UTF8.GetBytes(msg);

            clientSocket.Send(sendbyte);
        }
    }
}
