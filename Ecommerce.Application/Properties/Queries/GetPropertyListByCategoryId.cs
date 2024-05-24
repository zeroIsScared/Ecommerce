

using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetPropertyListByCategoryId

    {
        public class Query : IRequest<List<GetPropertiesDto>>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<GetPropertiesDto>>
        {
            private readonly IRepository<Property> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<Property> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<List<GetPropertiesDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _repository.Read(false)                  
                  .Where(x => x.Category == (PropertyCategory)request.Id)
                  .Select(x => new GetPropertiesDto
                  {   Id = x.Id,
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
