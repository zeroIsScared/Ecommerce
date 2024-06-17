
using Ecommerce.Application.Districts.Dtos;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Localities.Dtos
{
    public class GetLocalityDto
    {
        public long Id { get; set; }
        public required string Name { get; set; }        
        public long DistrictId { get; set; }      
    }
}
