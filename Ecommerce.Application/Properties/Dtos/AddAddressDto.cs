

namespace Ecommerce.Application.Properties.Dtos
{
    public class AddAddressDto
    {       public long? Id { get; set; }
            public string? Street { get; set; }
            public string? HouseNumber { get; set; }
            public long LocalityId { get; set; }     
       
    }
}
