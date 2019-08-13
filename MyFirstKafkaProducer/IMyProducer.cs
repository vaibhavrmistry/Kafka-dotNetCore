using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstKafkaProducer
{
    public interface IMyProducer
    {
        void Produce(string message);
    }
}
