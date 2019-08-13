using System;

namespace MyFirstKafkaProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your message. Enter q to quit");
            var message = default(string);
            while((message = Console.ReadLine()) != "q")
            {
                var producer = new MyProducer();
                producer.Produce(message);
            }
        }
    }
}
