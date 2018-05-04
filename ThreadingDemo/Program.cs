using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteUsingNewThread);
            thread.Name = "worker thread";
            thread.Start();

            // the main program and the thread program will run simultaneously, both will be interspersed.
            // this process is deferred to the operating system, cannot be controlled by developer like this.
            Thread.CurrentThread.Name = "main thread";
            for (var i = 0; i < 1000; i++)
            {
                Console.Write(" A" + i + " ");
            }
            
        }

        private static void WriteUsingNewThread()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.Write(" Z" + i + " ");
            }
        }
    }
}
