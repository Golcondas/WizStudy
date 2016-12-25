using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace NetMQ.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using(NetMQContext context=NetMQ.NetMQContext.Create())
            {
                Server(context);
            }
        }

        public static void Server(NetMQContext context)
        { 
            using(NetMQSocket serverSocket=context.CreateResponseSocket())
            {
                JavaScriptSerializer seriallizer=null;
                serverSocket.Bind("tcp://127.0.0.1:5555");
                while(true)
                {
                    seriallizer = new JavaScriptSerializer();
                    var msg = serverSocket.ReceiveFrameBytes();
                    
    
                    Console.WriteLine("Receive message {0}", Common.ByteConvertHelp.Bytes2Object(msg));
                    serverSocket.Send("Send Hello world");
                    if (Common.ByteConvertHelp.Bytes2Object(msg) == "exit")
                    {
                        break;
                    }
                }
            }
        }
    }
}
