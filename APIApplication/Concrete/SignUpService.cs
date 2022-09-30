using APIApplication.Abstract;
using APIDataAccess;
using APIModels.DTOS.SignUp;
using APIModels.Entities;
using APIModels.Mail;
using APIRabbitMq;
using AutoMapper;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIApplication.Concrete
{
    public class SignUpService : ISignUpService
    {
        private readonly IMapper _mapper;
        private readonly CarTenderDataContext _context;
        private readonly IQueueService _queueService;
        public SignUpService(IMapper mapper,CarTenderDataContext context,IQueueService queueService)
        {
            _mapper = mapper;
            _context = context;
            _queueService = queueService;
        }
        public bool AddUser(RegisterDTO dto)
        {
            var user = _mapper.Map<User>(dto);
            _context.User.Add(user);
            var result = _context.SaveChanges();
            if(result == 0)
            {
                return false;
            }
            else
            {
                List<string> eposta = new List<string>();
                eposta.Add(user.Email);
                MailInfo mailInfo = new MailInfo()
                {
                    Topic = "Email Doğrulama",
                    ReceiveMails = eposta,
                    Content = "",//todo : İçerik girilecek
                };
                ConnectionFactory connectionFactory = new ConnectionFactory()
                {
                    HostName = "localhost",
                    Password = "guest",
                    UserName = "guest",
                };
                var queue = "Register";
                var exchange = "RegisterExchange";
                var routingKey = "RegisterMail";
                _queueService.CreateQueue(connectionFactory, queue);
                _queueService.CreateExchange(connectionFactory, exchange);
                _queueService.CreateBinding(connectionFactory, queue, exchange, routingKey);
                _queueService.Publish(connectionFactory,mailInfo,exchange, routingKey);
            }
            return true;
        }
    }
}
