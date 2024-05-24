

using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetPropertyById
    {
        public class Query : IRequest<GetPropertyDto>
        {
            public long Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, GetPropertyDto>
        {
            private readonly IRepository<Property> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<Property> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }
            public async Task<GetPropertyDto> Handle(Query request, CancellationToken cancellationToken)
            {
                await _repository.ExistsOrThrowsAsync(request.Id, cancellationToken);
                var property = await _repository.Read()
                    /*.Include(x => x.Currency)
                    .Include(x => x.Details)
                    .Include(x => x.Utilities)
                        .ThenInclude(x => x.Utility)
                    .Include(x => x.User)
                    .Include(x => x.Photos)
                    .Include(x => x.Address)
                        .ThenInclude(x => x.Locality)
                           .ThenInclude(x => x.District)*/
                  .FirstAsync(x => x.Id == request.Id, cancellationToken);
/*
                var newProperty = new GetPropertyDto()
                {

                    Title = property.Title,
                    Currency = property.Currency.Symbol ?? property.Currency.Code,
                    Price = property.Price,
                    Address = property.Address,
                    Category = property.Category,
                    Description = property.Description,
                    Details = property.Details,
                    TransactionType = property.TransactionType,
                    User = _mapper.Map<UserDto>(property.User),
                    Photos = property.Photos
                };*/

                var result = _mapper.Map<GetPropertyDto>(property);                

                return result;
            }
        }
    }
}
