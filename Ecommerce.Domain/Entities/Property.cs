﻿

using Ecommerce.Domain.Enums;

namespace Ecommerce.Domain.Entities
{
    public class Property : BaseEntity
    {
        public Property(string title, string? description, decimal? price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

        public string Title { get; set; }       
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public PropertyCategory Category { get; set; }
        public TransactionType TransactionType { get; set; }
        public long CurrencyId { get; set; }
        public Currency Currency { get; set; } = default!;
        public long UserId { get; set; }
        public User User { get; set; } = default!;     
        public PropertyDetail Details { get; set; } = default!; 
        public long AddressId {  get; set; }
        public Address Address { get; set; } = default!;
        public ICollection<PropertyUtility> Utilities { get; set; } = default!;
        public ICollection<UserFavorite> Favorites { get; set; } = default!;
        public ICollection<PropertyPhoto> Photos { get; set; } = default!;
        
    }
}