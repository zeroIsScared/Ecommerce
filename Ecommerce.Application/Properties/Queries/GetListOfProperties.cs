
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Property.Responses;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetListOfProperties
    {
        public class Query : IRequest<List<PropertyDto>> { }

        public class Handler : IRequestHandler<Query, List<PropertyDto>>
        {
            private readonly IRepository<Domain.Entities.Property> _repository;

            public Handler(IRepository<Domain.Entities.Property> repository)
            {
                _repository = repository;
            }

            public async  Task<List<PropertyDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await  _repository.Read(false).Select(property => new PropertyDto
                {                    
                    Title = property.Title,
                    Description = property.Description,
                    Price = property.Price     

                }).ToListAsync();
            }
        }

    }
}
