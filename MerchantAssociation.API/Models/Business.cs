using System;
using System.Collections.Generic;

namespace MerchantAssociation.API.Models
{
    public class Business(
        string name,
        string description,
        string address,
        string phoneNumber,
        string email
    )
    {
        public int Id { get; set; }
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public string Address { get; set; } = address;
        public string PhoneNumber { get; set; } = phoneNumber;
        public string Email { get; set; } = email;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<BusinessOwner> BusinessOwners { get; set; }
    }
}