using System;
using System.Text;
using APIModels.Mail;
using MailService.Model;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace MailService
{
    public class MessageProcessor : DefaultBasicConsumer
    {
        private readonly IModel _channel;

        public MessageProcessor(IModel channel)
        {
            _channel = channel;
        }

        public override void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, IBasicProperties properties, byte[] body)
        {
            string message = Encoding.UTF8.GetString(body);
            Console.Write("Mail gönderiliyor----\t");

            MailEngine mailMotoru = new MailEngine();

            MailInfo mailBilgi = JsonConvert.DeserializeObject<MailInfo>(message);

            MailSendResult mailGonderimSonuc = mailMotoru.MailGonder(mailBilgi);

            if (mailGonderimSonuc.Success)
                Console.WriteLine("----Mail gönderildi.");
            else
                Console.WriteLine("----Mail gönderimi başarısız.");

            _channel.BasicAck(deliveryTag, false);
        }
    }
}
