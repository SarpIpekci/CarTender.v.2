using RabbitMQ.Client;

namespace MailService
{
    public class RabbitMqEngine
    {
        private IConnection _connection;
        private IModel _channel;

        public RabbitMqEngine()
        {
            kanalOlustur();
        }

        ~RabbitMqEngine()
        {
            _channel.Dispose();
            _connection.Dispose();
        }

        public static RabbitMqEngine YeniObjeOlustur() => new RabbitMqEngine();
        public void KuyruktanMesajIslemeBaslat()
        {
            MessageProcessor mesajIsleyen = new MessageProcessor(_channel);
            _channel.BasicConsume("Register", false, mesajIsleyen);
        }
        private void kanalOlustur()
        {
            _connection = baglantiBilgileriGetir().CreateConnection();
            _channel = _connection.CreateModel();
            _channel.BasicQos(0, 1, false);
        }
        private ConnectionFactory baglantiBilgileriGetir()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory
            {

                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };

            return connectionFactory;
        }
    }
}
