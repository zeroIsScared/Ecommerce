

using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Property.Responses;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetPropertyById
    {
        public class Query : IRequest<PropertyDto>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, PropertyDto>
        {
            private readonly IRepository<Domain.Entities.Property> _repository;
            public Handler(IRepository<Domain.Entities.Property> repository)
            {
                _repository = repository;
            }
            public  async Task<PropertyDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _repository.GetById(request.Id).ToListAsync();

                var property =  new PropertyDto
                {                    
                    Title = result[0].Title,
                    Description = result[0].Description,
                    Price = result[0].Price
                };

                return  property;
            }
        }
    }
}
