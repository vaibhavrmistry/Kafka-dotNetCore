using System;
using System.Collections.Generic;
using System.Text;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;

namespace MyFirstKafkaConsumer
{
    public class MyConsumer : IMyConsumer
    {
        public void Listen(Action<string> message)
        {
            var config = new Dictionary<string, object>
           {
               {"group.id", "my_consumer" },
               {"bootstrap.servers", "localhost:9092" },
               {"enable.auto.commit", "false" }
           };

            using (var consumer = new Consumer<Null, string>(config, null, new StringDeserializer(Encoding.UTF8)))
            {
                consumer.Subscribe("my_first_topic");

                consumer.OnMessage += (_, msg) =>
                {
                    message("Consumer Says: "+ msg.Value);
                };


                while(true)
                {
                    consumer.Poll(100);
                }
            }
        }
    }
}
