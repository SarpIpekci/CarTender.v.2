using System;

namespace MailService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RabbitMqEngine.YeniObjeOlustur().KuyruktanMesajIslemeBaslat();
            Console.WriteLine("Kuyruktan mesaj işleme başlatıldı.");
            Console.WriteLine("Durdurmak için bir tuşa basın.");
            Console.ReadLine();
        }
    }
}
