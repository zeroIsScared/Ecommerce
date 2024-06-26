﻿using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;

namespace Ecommerce.Application.Properties.Dtos
{
    public class GetPropertyDto
    {
        public long Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public PropertyCategory Category { get; set; }
        public TransactionType TransactionType { get; set; }
        public CurrencyDto Currency { get; set; } = default!;
        public UserDto User { get; set; } = default!;
        public PropertyDetailsDto Details { get; set; } = default!;       
        public GetAddressDto Address { get; set; } = default!;
        public ICollection<PropertyUtilityDto> Utilities { get; set; } = default!;      
        public ICollection<PhotoDto> Photos { get; set; } = default!;
    }
}
