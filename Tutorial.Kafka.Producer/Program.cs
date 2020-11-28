using Confluent.Kafka;
using System;
using System.Net;

namespace Tutorial.Kafka.Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "192.168.40.133:9092",
                ClientId = Dns.GetHostName(),
            };

            for (int i = 0; i < 100; i++)
            {
                using (var producer = new ProducerBuilder<string, string>(config).Build())
                {
                    producer.Produce("sample", new Message<string, string> {Key=i.ToString() , Value = DateTime.Now.ToString() });
                    producer.Flush(new TimeSpan(1000));
                }
            }
        }
    }
}
