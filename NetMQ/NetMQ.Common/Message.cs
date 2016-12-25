using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMQ.Common
{
    [Serializable]
    public class Message
    {
        public int Id { set; get; }

        public string FunName { set; get; }

        public Dictionary<string, object> Params { set; get; }

        public string Result { set; get; }  
    }
}
