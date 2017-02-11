using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidSample._2_O
{
    public class BulkMessageSenderWrong
    {
        public void Send(List<Message> messages)
        {
            foreach (var message in messages)
            {
                switch (message.Method)
                {
                    case MessageMethod.Email:
                        // send message by email
                        break;
                    case MessageMethod.Push:
                        // send message by push notification
                        break;
                }
            }
        }
    }

    public enum MessageMethod
    {
        Email,
        Push
    }

    public class Message
    {
        public MessageMethod Method { get; set; }
    }
}
