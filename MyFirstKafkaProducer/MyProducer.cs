using System;
using System.Collections.Generic;
using System.Text;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;

namespace MyFirstKafkaProducer
{
    public class MyProducer : IMyProducer
    {
        public void Produce(string message)
        {
            var config = new Dictionary<string, object>
            {
                {"bootstrap.servers", "localhost:9092"}
            };

            using (var producer = new Producer<Null, string>(config, null, new StringSerializer(Encoding.UTF8)))
            {
                producer.ProduceAsync("my_first_topic", null, message).GetAwaiter().GetResult();
                producer.Flush(10);
            }
        }
    }
}
