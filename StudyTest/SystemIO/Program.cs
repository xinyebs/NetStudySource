using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string watchPath = @"F:\c#杨中科";

            FileSystemWatcher watch = new FileSystemWatcher(watchPath);
            //创建目录时触发事件
            watch.Created +=new FileSystemEventHandler(watch_Created);
            //删除指定目录及目录文件时触发
            watch.Deleted+=new FileSystemEventHandler(watch_Deleted);
            //中的文件和目录时发生。
            watch.Changed+=new FileSystemEventHandler(watch_Changed);
            //当内部缓冲区溢出时发生。
            watch.Error+=new ErrorEventHandler(watch_Error);

            watch.EnableRaisingEvents = true;

            Thread.Sleep(1000 * 60);

            Console.ReadKey();
           
        }

        static void watch_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("错误：" + e.ToString()); 
        }

        static void  watch_Deleted(object sender, FileSystemEventArgs e)
        {

        }
        static void watch_Changed(object sender, FileSystemEventArgs e)
        {

        }
        static void watch_Error(object sender, ErrorEventArgs e)
        {

        }

    }
}
