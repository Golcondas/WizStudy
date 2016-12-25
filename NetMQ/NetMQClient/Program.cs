using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace NetMQ.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NetMQContext context = NetMQContext.Create())
            {
                Client(context);
            }
        }

        public static void Client(NetMQContext context) 
        {
            using (NetMQSocket clientSocket = context.CreateRequestSocket())
            {
                clientSocket.Connect("tcp://127.0.0.1:5555");
                JavaScriptSerializer seriallizer = null;
                while (true)
                {
                    seriallizer = new JavaScriptSerializer();
                    Console.WriteLine("Please enter your message:");
                    
        
                    string msg = Console.ReadLine();
                    NetMQMessage message = new NetMQMessage();
                    var msgBytes = Common.ByteConvertHelp.Object2Bytes(msg);
                    clientSocket.Send(msgBytes);

                    string answer = clientSocket.ReceiveString();

                    Console.WriteLine("Answer from server: {0}", answer);

                    if (msg == "exit")
                    {
                        break;
                    }
                }
            }
        }
    }
}
