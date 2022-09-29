using System;

namespace APIModels.Entities
{
    public class Message : BaseEntity
    {
        public int MessageContentID { get; set; }
        public MessageContent MessageContent { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
