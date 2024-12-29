using RabbitMQ.Client;
using System.Text;

namespace ProjetoCerberus.Infrastructure.Messaging.RabbitMQ
{
    public class RabbitMqPublisher
    {
        private readonly RabbitMqConnection _connection;

        public RabbitMqPublisher(RabbitMqConnection connection)
        {
            _connection = connection;
        }

        public void Publish(string exchange, string routingKey, string message)
        {
            using var channel = _connection.CreateChannel();
            channel.ExchangeDeclare(exchange, ExchangeType.Direct);

            var body = Encoding.UTF8.GetBytes(message);
            channel.BasicPublish(exchange, routingKey, null, body);
        }
    }
}