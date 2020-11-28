using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Kafka.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "192.168.40.133:9092",
                GroupId = "consumer1", //Consumer ID 
                AutoOffsetReset = AutoOffsetReset.Earliest,
                ClientId = Dns.GetHostName()
            };

            using (var consumer = new ConsumerBuilder<string, string>(config).Build())
            {
               
            }
        }
    }
}
