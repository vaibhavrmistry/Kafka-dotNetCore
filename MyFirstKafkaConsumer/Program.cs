using System;

namespace MyFirstKafkaConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var myConsumer = new MyConsumer();
            myConsumer.Listen(Console.WriteLine);
        }
    }
}
