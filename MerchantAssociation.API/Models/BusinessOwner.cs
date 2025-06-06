using System;

namespace MerchantAssociation.API.Models
{
    public class BusinessOwner
    {
        public int BusinessId { get; set; }
        public int OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Business Business { get; set; }
        public virtual Owner Owner { get; set; }
    }
}