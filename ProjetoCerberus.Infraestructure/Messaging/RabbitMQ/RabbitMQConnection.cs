using RabbitMQ.Client;

namespace ProjetoCerberus.Infrastructure.Messaging.RabbitMQ
{
    public class RabbitMqConnection
    {
        private readonly IConnection _connection;

        public RabbitMqConnection(string hostName, string userName, string password)
        {
            var factory = new ConnectionFactory
            {
                HostName = hostName,
                UserName = userName,
                Password = password
            };
            _connection = factory.CreateConnection();
        }

        public IModel CreateChannel()
        public RabbitMQ.Client.IModel CreateChannel()
        {
            if(_connection == null || !_connection.IsOpen)
            {
                throw new InvalidOperationException("RabbitMQ connection is not open.");
            }

            return _connection.CreateModel();
        }

    }
}
