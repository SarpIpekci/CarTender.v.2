using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class BidOfferDetail
    {
        [Key, Column(Order = 0)]
        public Guid BidCarID { get; set; }

        [Key, Column(Order = 1)]
        public Guid BidUserOfferID { get; set; }

        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        [Timestamp]
        public byte[] Version { get; set; }

        [ForeignKey("BidCarID")]
        public BidCar BidCar { get; set; }

        [ForeignKey("BidUserOfferID")]
        public BidUserOffer BidUserOffer { get; set; }


    }
}
