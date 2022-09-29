﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class UserCar
    {
        [Key, Column(Order = 0)]
        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [Key, Column(Order = 1)]
        public int CarID { get; set; }

        [ForeignKey("CarID")]
        public Car Car { get; set; }

        public bool IsActive { get; set; } = true;

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
