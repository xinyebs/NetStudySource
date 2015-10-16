using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 事件
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            server.started+=new ServerEventHander(server_started);

            server.stoped+=new ServerEventHander(server_stoped);

            Console.ReadKey();
        }

        static void server_started(object sender, ServerEventArgs e)
        {
            Console.WriteLine("Server Successfully Started is{0}",e.FireDateTime);
        }

        static void server_stoped(object sender, ServerEventArgs e)
        {
            Console.WriteLine("Server successfully Stoped is{0}",e.FireDateTime);
        }
    }
}
