
using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetListOfProperties
    {
        public class Query : IRequest<List<GetPropertiesDto>> { }

        public class Handler : IRequestHandler<Query, List<GetPropertiesDto>>
        {
            private readonly IRepository<Property> _repository;            

            public Handler(IRepository<Property> repository)
            {
                _repository = repository;               
            }

            public async Task<List<GetPropertiesDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _repository.Read(false)
                    .Include(x => x.Currency)
                    .Include(x => x.Photos)
                    .Select(x => new GetPropertiesDto 
                    {  
                        Id = x.Id,
                        Title = x.Title,
                        Currency = x.Currency.Symbol ?? x.Currency.Code,
                        Price = x.Price,
                        PhotoURL = x.Photos.First().URL
                    })
                    .ToListAsync(cancellationToken);   

                return result;
            }
        }

    }
}
