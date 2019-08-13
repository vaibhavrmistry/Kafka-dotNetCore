using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstKafkaConsumer
{
    public interface IMyConsumer
    {
        void Listen(Action<string> message);
    }
}
