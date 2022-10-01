using System;

namespace APIModels.Entities
{
    public class Message : BaseEntity
    {
        public Guid MessageContentID { get; set; }
        public MessageContent MessageContent { get; set; }

        public Guid UserID { get; set; }
        public User User { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
