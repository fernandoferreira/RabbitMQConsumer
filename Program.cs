using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;


namespace RabbitMQConsumer
{
    class Program
    {
        static void Main(string[] args)

        {
            var factory = new ConnectionFactory() { HostName = "localhost"};

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);

                Console.WriteLine(" [*] Waiting for messages.");

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, msg) =>
                {
                    var body = msg.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    System.Console.WriteLine($"Mensagem recebida: {message}");
                };

                channel.BasicConsume(queue: "hello", autoAck: true, consumer: consumer);

            }
        }
    }
}
