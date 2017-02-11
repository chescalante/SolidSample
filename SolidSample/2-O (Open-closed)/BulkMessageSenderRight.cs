using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidSample._2_O
{
    public class BulkMessageSenderRight
    {
        public void Send(List<IMessage> messages)
        {
            foreach (var message in messages)
            {
                message.Send();
            }
        }
    }

    public interface IMessage
    {
        MessageMethod Method { get; }
        void Send();
    }

    public class EmailMessage : IMessage
    {
        public MessageMethod Method => MessageMethod.Email;

        public void Send()
        {
            // send message by email
        }
    }

    public class PushMessage : IMessage
    {
        public MessageMethod Method => MessageMethod.Push;

        public void Send()
        {
            // send message by push notification
        }
    }
}
